using System;

using Newtonsoft.Json;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace BasePaySdk
{
    /// <summary>
    /// 网络通信类
    /// </summary> 
    public class NetUtils
    {

        public const string POST = "post";
        public const string GET = "get";

        /// <summary>
        /// 发送报文请求
        /// </summary>
        ///
        /// <param name="postParams">报文参数集合</param>
        /// <param name="filePath">上传文件路径</param>
        /// <param name="fileParam">上传文件参数名</param>
        /// <param name="funcCode">接口功能编码</param>
        /// <param name="method">http请求方法</param>
        /// <param name="merConfig">商户配置信息</param>
        ///
        /// <returns>返回报文</returns>
        ///
        public static Dictionary<string, Object> requestBasePayWithFuncCode(Dictionary<string, object> postParams, string filePath, string fileParam, string funcCode, string method, MerConfig merConfig)
        {

            if (null == merConfig || merConfig.RsaPrivateKey == null)
            {
                throw new Exception("privateKey 不能为空");
            }

            string requireUrl = fetchRequestUrl(funcCode);


            HttpWebRequest request = null;


            if (method.Equals(GET))
            {
                request = CreateGetRequest(postParams, requireUrl, merConfig);
            }
            else if (null != filePath)
            {
                request = CreateUploadRequest(postParams, filePath,fileParam, requireUrl, merConfig);
            }
            else
            {
                request = CreatePostRequest(postParams, requireUrl, merConfig);
            }


            Dictionary<string, Object> responseJson = null;
            string responseText = null;
            object responseSign = null;
            String rsaPublicKey = merConfig.RsaPublicKey;
            if(string.IsNullOrEmpty( rsaPublicKey )) {
                rsaPublicKey = BasePay.HUIFU_DEFAULT_PUBLIC_KEY;
            }
            try
            {
                HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
                {
                    responseText = streamReader.ReadToEnd();
                    CoreUtils.Log("response:" + responseText);
                    if (responseText != null && responseText.Contains("html")) {

                        // 页面版本支付，需要将页面直接返回给
                        responseJson = new Dictionary<string, object>();
                        responseJson.Add("data", responseText);
                        return responseJson;
                    }
                    Dictionary<string, object> response = (Dictionary<string, object>)JsonConvert.DeserializeObject<Dictionary<string, object>>(responseText);
                    Dictionary<string, object> data = (Dictionary<string, object>)JsonConvert.DeserializeObject<Dictionary<string, object>>(response["data"].ToString());
                
                    object respCode = null;
                    data.TryGetValue("resp_code", out respCode);
                    object respDesc = null;
                    data.TryGetValue("resp_desc", out respDesc);
                    string strRespCode = (string) respCode;
                    string strRespDesc = (string) respDesc;
                    // 判断接口调用是否成功
                    //if (!"10000".Equals(strRespCode)) {
                    //    CoreUtils.Log("接口调用失败，失败原因：" + strRespDesc);
                    //    throw new Exception("接口调用失败，失败原因：" + strRespDesc);
                    //}
     
                    CoreUtils.Log("response data....." + data);
                    responseSign = null;
                    response.TryGetValue("sign", out responseSign);
                    string strData = JsonConvert.SerializeObject(response["data"]);
                    string strSign = (string) responseSign;
                    if (!string.IsNullOrEmpty(strSign)) 
                    {
                        if (!RsaUtils.verfySign(rsaPublicKey, strSign, strData))
                        {
                            throw new Exception("public key veryfy singnature failed");
                        }
                    }

                    responseJson = data;
                }
            }
            catch (WebException e)
            {
                responseJson = new Dictionary<string, object>();
                responseJson.Add("resp_code","99999999");
                responseJson.Add("resp_desc", e.Message);
 
            }

            return responseJson;
        }

        /// <summary>
        /// 发送上传文件请求
        /// </summary>
        ///
        /// <param name="postParams">报文参数集合</param>
        /// <param name="filePath">上传文件路径</param>
        /// <param name="fileParam">上传文件参数名</param>
        /// <param name="funcCode">接口功能编码</param>
        /// <param name="method">http请求方法</param>
        /// <param name="merConfig">商户配置信息</param>
        ///
        /// <returns>返回报文</returns>
        ///
        public static Dictionary<string, Object> requestBasePayForFileUpload(Dictionary<string, object> postParams, string filePath, string fileParam, string funcCode, string method, MerConfig merConfig)
        {
            return requestBasePayWithFuncCode(postParams, filePath, fileParam, funcCode, method, merConfig);
            
        }

        /// <summary>
        /// 发送报文请求
        /// </summary>
        ///
        /// <param name="postParams">报文参数集合</param>
        /// <param name="funcCode">接口功能编码</param>
        /// <param name="method">http请求方法</param>
        /// <param name="merConfig">商户配置信息</param>
        ///
        /// <returns>返回报文</returns>
        ///
        public static Dictionary<string, Object> requestBasePay(Dictionary<string, object> postParams, string funcCode, string method, MerConfig merConfig)
        {
            return requestBasePayWithFuncCode(postParams, null, null, funcCode, method, merConfig);

        }

        /// <summary>
        /// 跟据功能编码获取实际请求地址
        /// </summary>
        ///
        /// <param name="funcCode">接口功能编码</param>
        ///
        /// <returns>返回接口实际请求地址</returns>
        ///
        private static String fetchRequestUrl(String funcCode) {
            String baseUrl = BasePay.BASE_URL;
            if (!BasePay.prodMode) {
                baseUrl = BasePay.BASE_URL_MOCK;
            }
            if (!baseUrl.EndsWith("/")) {
                baseUrl = baseUrl + "/";
            }
            String interfaceUrl = funcCode.Replace(".", "/");
            String requestUrl = baseUrl + interfaceUrl;
            return requestUrl;
        }


        //设置get请求参数
        // get post 以及post 上传文件的接口，url地址以及签名方式有差别
        private static HttpWebRequest CreateGetRequest(Dictionary<string, object> postParams,  string requireUrl, MerConfig merConfig)
        {

            
            string json_params = CoreUtils.getOrignalString(postParams);
            string json_string = requireUrl + json_params;
            
            //参数中会有中文,签名前需url encode
            json_string = Uri.UnescapeDataString(json_string);

            string signStr = RsaUtils.sign(merConfig.RsaPrivateKey, json_string);

            requireUrl = requireUrl + "?" + json_params;
            CoreUtils.Log("requireUrl:" + requireUrl);

            HttpWebRequest request  = (HttpWebRequest)WebRequest.Create(requireUrl);
            ServicePoint currentServicePoint = request.ServicePoint;
            currentServicePoint.ConnectionLimit = 1000;

            WebHeaderCollection header = request.Headers;
            header.Set("sdk_version", "C#SDK_"+BasePay.sdk_version);
            header.Set("format", "JSON");
            header.Set("charset", "UTF-8");
            header.Set("version", "1.0.0");
            header.Set("product_id", merConfig.ProductId);

            request.Method = "get";
            request.ContentType = "text/html;charset=UTF-8";

            return request;

        }

        //设置不带文件的post请求参数
        private static HttpWebRequest CreatePostRequest(Dictionary<string, object> postParams,  string requireUrl,  MerConfig merConfig)
        {

            string json_params = JsonConvert.SerializeObject(postParams, Formatting.None);
            JObject jo = (JObject)JsonConvert.DeserializeObject(json_params);
            Dictionary<string, object> body = new Dictionary<string, object>();
            body.Add("sys_id", merConfig.SysId);
            //body.Add("sign_type", "RSA2");
            body.Add("data", jo);
            body.Add("product_id",merConfig.ProductId);

            String sortedData = JsonUtils.sort4JsonString(json_params);
            string signStr = RsaUtils.sign(merConfig.RsaPrivateKey, sortedData);
            body.Add("sign", signStr);

            String jsonBody = JsonConvert.SerializeObject(body, Formatting.None);
            CoreUtils.Log("request data:" + json_params);
            CoreUtils.Log("request sign:" + signStr);
            CoreUtils.Log("request body:" + jsonBody);

            //参数中会有中文,签名前需url encode
            // json_string = Uri.UnescapeDataString(json_string);

            HttpWebRequest request = request = (HttpWebRequest)WebRequest.Create(requireUrl);

            ServicePoint currentServicePoint = request.ServicePoint;
            currentServicePoint.ConnectionLimit = 1000;
            WebHeaderCollection header = request.Headers;
            header.Set("sdk_version", "C#SDK_" + BasePay.sdk_version);
            header.Set("format", "JSON");
            header.Set("charset", "UTF-8");
            header.Set("version", "1.0.0");
           // header.Set("product_id", merConfig.ProductId);

            request.Method = "post";
            request.ContentType = "application/json";
            byte[] byteData = Encoding.UTF8.GetBytes(jsonBody);
            int length = byteData.Length;
            request.ContentLength = length;
            Stream writer = request.GetRequestStream();
            writer.Write(byteData, 0, length);
            writer.Close();

            return request;
            
        }

        //设置文件上传request
        private static HttpWebRequest CreateUploadRequest(Dictionary<string, object> postParams, string filePath, string fileParam, string requireUrl, MerConfig merConfig)
        {

            HttpWebRequest request = request = (HttpWebRequest)WebRequest.Create(requireUrl);
            ServicePoint currentServicePoint = request.ServicePoint;
            currentServicePoint.ConnectionLimit = 1000;

            string json_params = JsonConvert.SerializeObject(postParams, Formatting.None);
            string signStr = RsaUtils.sign(merConfig.RsaPrivateKey, json_params);

            Dictionary<string, object> body = new Dictionary<string, object>();
            body.Add("sys_id", merConfig.SysId);
            body.Add("sign_type", "RSA2");
            body.Add("data", json_params);
            body.Add("sign", signStr);

            WebHeaderCollection header = request.Headers;
            header.Set("sdk_version", "C#SDK_" + BasePay.sdk_version);
            header.Set("format", "JSON");
            header.Set("charset", "UTF-8");
            header.Set("version", "1.0.0");
            header.Set("product_id", merConfig.ProductId);

            request.Method = "post";
            //文件信息
            byte[] UpdateFile = CoreUtils.File2Bytes(filePath);//转换为二进制
            if (UpdateFile.Length == 0)
            {
                throw new Exception("file content cannot be null");
            }

            string Boundary = "--WebKitFormBoundary39B5a5e2FWoGbphs";
            //构造POST请求体
            StringBuilder PostContent = new StringBuilder("");
            //组成普通参数信息
            foreach (KeyValuePair<string, object> item in body)
            {
                PostContent.Append("--" + Boundary + "\r\n")
                        .Append("Content-Disposition: form-data; name=\"" + item.Key + "\"" + "\r\n\r\n" + (string)item.Value + "\r\n");
            }

            byte[] PostContentByte = Encoding.UTF8.GetBytes(PostContent.ToString());

            //文件信息
            
            StringBuilder FileContent = new StringBuilder();
            FileContent.Append("--" + Boundary + "\r\n")
                    .Append("Content-Disposition:form-data; name=\""+ fileParam + "\";filename=\""+ Path.GetFileName(filePath) +"\"" + "\r\n\r\n");

            byte[] FileContentByte = Encoding.UTF8.GetBytes(FileContent.ToString());

            request.ContentType = "multipart/form-data;boundary=" + Boundary;

            byte[] ContentEnd = Encoding.UTF8.GetBytes("\r\n--" + Boundary + "--\r\n");//请求体末尾，后面会用到

            //定义请求流
            Stream myRequestStream = request.GetRequestStream();
            myRequestStream.Write(PostContentByte, 0, PostContentByte.Length);//写入参数
            myRequestStream.Write(FileContentByte, 0, FileContentByte.Length);//写入文件信息
            myRequestStream.Write(UpdateFile, 0, UpdateFile.Length);//文件写入请求流中
            myRequestStream.Write(ContentEnd, 0, ContentEnd.Length);//写入结尾   

            myRequestStream.Close();

            return request;

        }
    }
}