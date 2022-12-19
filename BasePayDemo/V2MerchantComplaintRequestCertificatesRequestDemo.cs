using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 支付宝申诉请求凭证 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintRequestCertificatesRequestDemo
    {

        public static void V2MerchantComplaintRequestCertificatesRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantComplaintRequestCertificatesRequest request = new V2MerchantComplaintRequestCertificatesRequest();
            // 请求汇付流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求汇付时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 支付宝推送流水号
            request.setRiskBizId("04a3d978689542ed6ba0295fbc2dc137-BANK");
            // 商户类型
            request.setMerchantType("个体工商户");
            // 商户经营模式
            request.setOperationType("线上");
            // 收款应用场景
            request.setPaymentScene("通过小程序收款");

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

    }
}
