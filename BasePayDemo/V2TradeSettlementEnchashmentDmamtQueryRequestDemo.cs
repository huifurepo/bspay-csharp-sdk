using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * DM取现额度查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettlementEnchashmentDmamtQueryRequestDemo
    {

        public static void V2TradeSettlementEnchashmentDmamtQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeSettlementEnchashmentDmamtQueryRequest request = new V2TradeSettlementEnchashmentDmamtQueryRequest();
            // 商户号
            request.setHuifuId("6666000021291985");

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
            // 账户号
            extendInfoMap.Add("acct_id", "F00598600");
            return extendInfoMap;
        }

    }
}
