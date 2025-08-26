using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 托管交易查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentQueryorderinfoRequestDemo
    {

        public static void V2TradeHostingPaymentQueryorderinfoRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeHostingPaymentQueryorderinfoRequest request = new V2TradeHostingPaymentQueryorderinfoRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号开户自动生成；商户号不填时必填party_order_id；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
            request.setHuifuId("6666000109133323");
            // 原交易请求日期请求格式：yyyyMMdd；该字段不填时必填party_order_id；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20221023&lt;/font&gt;
            request.setOrgReqDate("20231020");
            // 原交易请求流水号该字段不填时必填party_order_id；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：rQ2021121311173944&lt;/font&gt;
            request.setOrgReqSeqId("202310201652361987182512");
            // 用户账单上的商户订单号该字段不填时，商户号、原交易请求日期、原交易请求流水号必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：03232109190255105603561&lt;/font&gt;
            // request.setPartyOrderId("test");

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
