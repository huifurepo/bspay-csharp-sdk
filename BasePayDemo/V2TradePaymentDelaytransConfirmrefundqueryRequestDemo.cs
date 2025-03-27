using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 交易确认退款查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentDelaytransConfirmrefundqueryRequestDemo
    {

        public static void V2TradePaymentDelaytransConfirmrefundqueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePaymentDelaytransConfirmrefundqueryRequest request = new V2TradePaymentDelaytransConfirmrefundqueryRequest();
            // 商户号
            request.setHuifuId("6666000109133323");
            // 原交易请求日期
            request.setOrgReqDate("20240426");
            // 原交易请求流水号指交易确认请求流水号，org_req_seq_id和org_hf_seq_id二选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665002&lt;/font&gt;
            request.setOrgReqSeqId("20211714122436");
            // 原退款全局流水号原交易确认退款全局流水号。org_req_seq_id和org_hf_seq_id二选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：003500TOP2B211021163242P447ac132fd200000&lt;/font&gt;
            request.setOrgHfSeqId("003100TOP1A240513112100P256ac139cc000000");

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
