using BasePaySdk.Request;
using System;
using System.Collections.Generic;

namespace BasePaySdk 
{
    public class BasePayClient
    {
        /// <summary>
        /// 发送报文请求
        /// </summary>
        ///
        /// <param name="funcCode">功能编码</param>
        /// <param name="requestParams">请求报文</param>
        /// <param name="merchantKey">商户配置key</param>
        ///
        /// <returns>返回报文</returns>
        ///
        public static Dictionary<string, Object> postRequest(string funcCode, Dictionary<string, object> requestParams, string merchantKey = "default") {
            MerConfig config = BasePay.fetchConfig(merchantKey);
            return NetUtils.requestBasePay(requestParams, funcCode, NetUtils.POST, config);
        }

        /// <summary>
        /// 上传文件请求
        /// </summary>
        ///
        /// <param name="funcCode">功能编码</param>
        /// <param name="requestParams">请求报文</param>
        /// <param name="filePath">上传文件路径</param>
        /// <param name="merchantKey">商户配置key</param>
        ///
        /// <returns>返回报文</returns>
        ///
        public static Dictionary<string, Object> postRequestFile(string funcCode, Dictionary<string, object> requestParams, string filePath, string merchantKey = "default")
        {
            MerConfig config = BasePay.fetchConfig(merchantKey);
            return NetUtils.requestBasePayForFileUpload(requestParams, filePath, "file", funcCode, NetUtils.POST, config);
        }

        /// <summary>
        /// 发送报文请求
        /// </summary>
        ///
        /// <param name="request">请求类</param>
        /// <param name="merchantKey">商户配置key</param>
        /// <param name="isFile">是否文件类</param>
        /// <returns>返回报文</returns>
        ///
        public static Dictionary<string, Object> postRequest(BaseRequest request,string filePath,string merchantKey = "default")
        {
            MerConfig config = BasePay.fetchConfig(merchantKey);

            //1.把requset转为map，适应requestParams<string,Object>
            Dictionary<string, Object> requestParams = CoreUtils.ObjToMap(request);

            //2.把reqest.extendInfos 里的键值，覆盖已有的
            if (request.getExtendInfos() != null && request.getExtendInfos().Count > 0)
            {
                foreach (KeyValuePair<string, Object> item in request.getExtendInfos())

                {
                    if (requestParams.ContainsKey(item.Key) ){ 
                        requestParams.Remove(item.Key);
                    }
                    requestParams.Add(item.Key, item.Value);
                }
            
            }
            if (!string.IsNullOrEmpty(filePath))
            {
                return  postRequestFile(request.getFunctionCode(), requestParams, filePath);
            }
            else 
            {
                return NetUtils.requestBasePay(requestParams, request.getFunctionCode(), NetUtils.POST, config);
            }
        
        }


    }
}