using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 交易退款查询接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentScanpayRefundqueryRequestDemo
    {

        public static void V2TradePaymentScanpayRefundqueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePaymentScanpayRefundqueryRequest request = new V2TradePaymentScanpayRefundqueryRequest();
            // 商户号
            request.setHuifuId("6666000108854952");
            // 退款请求日期
            request.setOrgReqDate("20221110");
            // 退款全局流水号退款请求流水号,退款全局流水号,终端订单号三选一不能都为空；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0030default220825182711P099ac1f343f00000&lt;/font&gt;
            request.setOrgHfSeqId("003100TOP2B221110093241P139ac139c0c00000");
            // 退款请求流水号退款请求流水号,退款全局流水号,终端订单号三选一不能都为空；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：202110210012100005&lt;/font&gt;
            request.setOrgReqSeqId("");
            // 终端订单号退款请求流水号,退款全局流水号,终端订单号三选一不能都为空；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：16672670833524393&lt;/font&gt;
            request.setMerOrdId("");

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
