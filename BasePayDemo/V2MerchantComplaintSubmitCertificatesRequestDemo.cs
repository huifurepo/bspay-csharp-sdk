using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 支付宝申诉提交凭证 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintSubmitCertificatesRequestDemo
    {

        public static void V2MerchantComplaintSubmitCertificatesRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantComplaintSubmitCertificatesRequest request = new V2MerchantComplaintSubmitCertificatesRequest();
            // 请求汇付流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求汇付时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 支付宝推送流水号
            request.setRiskBizId("b1e11c97badf1ba025399ee0332d8fb1-ISV");
            // 申诉解限的唯一ID
            request.setRelievingId("653739ab36362810b7203b304d6f3883");
            // 解限风险类型
            request.setRelieveRiskType("SMID_MERCHANT");
            // 提交的凭证数据
            request.setRelieveCertDataList(getRelieveCertDataList());

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

        private static string getRelieveCertDataList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 凭证的唯一ID
            obj.Add("request_id", "1efc8c73afd64fc1b1fc50a834a54be0");
            // 凭证类型
            obj.Add("type", "IMAGE");
            // 凭证code
            obj.Add("code", "904");
            // 凭证的内容
            obj.Add("info_data", "edd2d893-d3c2-342b-9ded-993913effce9");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
