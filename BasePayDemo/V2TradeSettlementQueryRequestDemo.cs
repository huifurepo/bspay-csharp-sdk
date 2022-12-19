using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 出金交易查询接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettlementQueryRequestDemo
    {

        public static void V2TradeSettlementQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeSettlementQueryRequest request = new V2TradeSettlementQueryRequest();
            // 汇付客户Id
            request.setHuifuId("6666000021290000");
            // 原交易请求日期
            request.setOrgReqDate("20210916");
            // 原交易返回的全局流水号原交易返回的全局流水号、原交易请求流水号二选一必填；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00470topo1A211015160805P090ac132fef00000&lt;/font&gt;
            // request.setOrgHfSeqId("test");
            // 原交易请求流水号原交易返回的全局流水号、原交易请求流水号二选一必填；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：202109167745558220003&lt;/font&gt;
            request.setOrgReqSeqId("202109160899013231200005");

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
