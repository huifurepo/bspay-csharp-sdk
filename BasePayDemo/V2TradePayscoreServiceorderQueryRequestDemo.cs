using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 查询支付分订单 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscoreServiceorderQueryRequestDemo
    {

        public static void V2TradePayscoreServiceorderQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePayscoreServiceorderQueryRequest request = new V2TradePayscoreServiceorderQueryRequest();
            // 汇付商户号
            request.setHuifuId("6666000108854952");

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
            // 汇付服务订单号
            extendInfoMap.Add("out_order_no", "1234323JKHDFE1243252");
            // 汇付全局流水号
            // extendInfoMap.Add("org_hf_seq_id", "");
            // 请求流水号
            // extendInfoMap.Add("org_req_seq_id", "");
            return extendInfoMap;
        }

    }
}
