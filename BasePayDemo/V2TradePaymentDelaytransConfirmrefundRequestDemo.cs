using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 交易确认退款接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentDelaytransConfirmrefundRequestDemo
    {

        public static void V2TradePaymentDelaytransConfirmrefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePaymentDelaytransConfirmrefundRequest request = new V2TradePaymentDelaytransConfirmrefundRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000103423237");
            // 原交易请求日期
            request.setOrgReqDate("20221108");
            // 原交易请求流水号
            request.setOrgReqSeqId("20221108349713659620211667908395");

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
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getAcctSplitBunch());
            // 是否垫资退款
            // extendInfoMap.Add("loan_flag", "");
            // 垫资承担者
            // extendInfoMap.Add("loan_undertaker", "");
            // 垫资账户类型
            // extendInfoMap.Add("loan_acct_type", "");
            return extendInfoMap;
        }

        private static string getAcctSplitBunch() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", getAcctInfos());

            return JsonConvert.SerializeObject(obj);
        }
        private static object getAcctInfos() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 被分账方ID
            obj.Add("huifu_id", "6666000003109208");
            // 分账金额
            obj.Add("div_amt", "0.01");
            // 垫资金额
            // obj.Add("part_loan_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
    }
}
