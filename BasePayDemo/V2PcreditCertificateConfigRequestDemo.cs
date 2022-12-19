using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 分期证书配置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2PcreditCertificateConfigRequestDemo
    {

        public static void V2PcreditCertificateConfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2PcreditCertificateConfigRequest request = new V2PcreditCertificateConfigRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 开发者的应用ID
            request.setAppId("2019090666961966");
            // 证书文件列表
            request.setFileList(getFileList());

            // 设置非必填字段
            Dictionary<string, object> extendInfoMap = getExtendInfos();
            request.setExtendInfo(extendInfoMap);

            try {
                // 3. 发起API调用
                // 调用接口,使用默认商户配置时可省略配置key
                Dictionary<string, Object> result = null;
                result = BasePayClient.postRequest(request,null);
                // 使用指定配置调用接口
                // result = BasePayClient.postRequest(request,null,"merchantKey2");
                Console.WriteLine(JsonConvert.SerializeObject(result));
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        /**
         * 非必填字段
         * @return
         */
        private static Dictionary<string, object> getExtendInfos() {
            // 设置非必填字段
            Dictionary<string, object> extendInfoMap = new Dictionary<string, object>();
            return extendInfoMap;
        }

        private static string getFileList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            obj.Add("file_type", "F120");
            // 文件jfileID
            obj.Add("file_id", "57cc7f00-600a-33ab-b614-6221bbf2e529");
            // 文件名称
            obj.Add("file_name", "test420.jpg");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
