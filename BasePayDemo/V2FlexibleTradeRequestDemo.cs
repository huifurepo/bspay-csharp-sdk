using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 灵工支付 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleTradeRequestDemo
    {

        public static void V2FlexibleTradeRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2FlexibleTradeRequest request = new V2FlexibleTradeRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 出款方商户号
            request.setOutHuifuId("6666000108903745");
            // 出款方账户号
            request.setOutAcctId("C03117654");
            // 交易阶段操作类型
            request.setStageOperationType("FIRST_STAGE");
            // 前段交易流水号** 当交易阶段操作类型为02时，该字段必填。填写的是交易阶段操作类型为01时交易已完成的交易全局流水号。 &lt;font color&#x3D;&quot;green&quot;&gt;示例值：20250620112533115566896&lt;/font&gt;
            request.setPhaseHfSeqId("");
            // 支付金额
            request.setOrdAmt("20");

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
            extendInfoMap.Add("remark", "");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getD5cc6c3fD3854f9fB3eeF736df9fbbf8());
            return extendInfoMap;
        }

        private static object get3fc17817Caf445dc8f13A2c315f6d1e8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "20.00");
            // 分账接收方ID
            obj.Add("huifu_id", "6666000108898793");
            // 账户号
            obj.Add("acct_id", "C03113649");

            return obj;
        }
        private static object getD5cc6c3fD3854f9fB3eeF736df9fbbf8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_info", get3fc17817Caf445dc8f13A2c315f6d1e8());

            return obj;
        }
    }
}
