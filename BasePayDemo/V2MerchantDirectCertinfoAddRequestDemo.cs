using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 证书登记 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectCertinfoAddRequestDemo
    {

        public static void V2MerchantDirectCertinfoAddRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantDirectCertinfoAddRequest request = new V2MerchantDirectCertinfoAddRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 渠道商汇付Id
            request.setUpperHuifuId("6666000103509367");
            // 开通类型
            request.setPayWay("W");
            // 开发者的应用ID
            request.setAppId("20220818198665087");
            // 文件列表
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
            // 商户号
            extendInfoMap.Add("mch_id", "360634064");
            // 证书序列号
            extendInfoMap.Add("cert_sn", "20220818883326714");
            // 服务商密钥
            extendInfoMap.Add("secret_key", "RERE202208182319");
            // 证书类型标记
            extendInfoMap.Add("cert_flag", "");
            return extendInfoMap;
        }

        private static string getFileList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            obj.Add("file_type", "F53");
            // 文件jfileID
            obj.Add("file_id", "9aec5b9e-816f-3ebf-8fe8-4146348ce2b0");
            // 文件名称
            obj.Add("file_name", "证书1202208189390.crt");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
