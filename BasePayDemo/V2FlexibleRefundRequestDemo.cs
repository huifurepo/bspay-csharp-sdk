using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 灵工支付退款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleRefundRequestDemo
    {

        public static void V2FlexibleRefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2FlexibleRefundRequest request = new V2FlexibleRefundRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 原请求日期
            request.setOrgReqDate("20250617");
            // 原灵工支付交易流水号&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665231&lt;/font&gt;
            request.setOrgReqSeqId("20250618710431811test001");
            // 原灵工支付汇付全局流水号与原灵工支付交易流水号必选其一&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665001&lt;/font&gt;
            request.setOrgHfSeqId("");
            // 发起方商户号
            request.setHuifuId("6666000108903745");
            // 支付金额
            request.setOrdAmt("10");

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
            // 备注
            extendInfoMap.Add("remark", "备注11111");
            return extendInfoMap;
        }

    }
}
