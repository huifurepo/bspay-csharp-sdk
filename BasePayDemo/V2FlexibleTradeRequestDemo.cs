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
            // 交易阶段操作类型
            request.setStageOperationType("FIRST_STAGE");
            // 前段交易流水号** 当交易阶段操作类型为02时，该字段必填。填写的是交易阶段操作类型为01时交易已完成的交易全局流水号。 &lt;font color&#x3D;&quot;green&quot;&gt;示例值：20250620112533115566896&lt;/font&gt;
            request.setPhaseHfSeqId("");
            // 支付金额
            request.setOrdAmt("20");
            // 分账对象
            request.setAcctSplitBunch(get5ff7863bFba14fd185823535ee0a9e52());

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
            // 出款方账户号
            extendInfoMap.Add("out_acct_id", "C03117654");
            // 备注
            extendInfoMap.Add("remark", "");
            return extendInfoMap;
        }

        private static object get875acdbcEff4424dBa4551dffa06d840() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "20.00");
            // 分账接收方ID
            obj.Add("huifu_id", "6666000108898793");
            // 账户号
            obj.Add("acct_id", "C03113649");

            return obj;
        }
        private static string get5ff7863bFba14fd185823535ee0a9e52() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_info", get875acdbcEff4424dBa4551dffa06d840());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
