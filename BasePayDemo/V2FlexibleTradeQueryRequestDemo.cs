using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 灵工支付查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleTradeQueryRequestDemo
    {

        public static void V2FlexibleTradeQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2FlexibleTradeQueryRequest request = new V2FlexibleTradeQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 原请求流水号原请求流水号与原请求全局流水号二选一必填，示例值：2021091708126665001
            request.setOrgReqSeqId("2025060916130548005test001");
            // 原请求日期原请求流水号必填则原请求日期必填，格式：yyyyMMdd；示例值：20210917
            request.setOrgReqDate("20250609");
            // 汇付商户号
            request.setHuifuId("6666000107740841");
            // 原交易全局流水号原请求流水号与原请求全局流水号二选一必填，  &lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值： 003100TOP1A230816150903P990ac139c0600000&lt;/font&gt;
            request.setOrgHfSeqId("2025060900000000000078864005");

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
