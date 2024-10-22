using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 分期交易退款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayafteruseInstallmentRefundRequestDemo
    {

        public static void V2TradePayafteruseInstallmentRefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePayafteruseInstallmentRefundRequest request = new V2TradePayafteruseInstallmentRefundRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000108281250");
            // 申请退款金额
            request.setOrdAmt("0.01");

            // 设置非必填字段
            Dictionary<string, object> extendInfoMap = getExtendInfos();
            request.setExtendInfo(extendInfoMap);

            try
            {
                // 3. 发起API调用
                // 调用接口,使用默认商户配置时可省略配置key
                Dictionary<string, Object> result = null;
                result = BasePayClient.postRequest(request, null);
                // 使用指定配置调用接口
                // result = BasePayClient.postRequest(request,null,"merchantKey2");
                Console.WriteLine(JsonConvert.SerializeObject(result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /**
         * 非必填字段
         * @return
         */
        private static Dictionary<string, object> getExtendInfos()
        {
            // 设置非必填字段
            Dictionary<string, object> extendInfoMap = new Dictionary<string, object>();
            // 分账串
            // extendInfoMap.Add("acct_split_bunch", getAcctSplitBunch());
            // 原请求流水号
            extendInfoMap.Add("org_req_seq_id", "20241010test10000111qccrr");
            // 原请求日期
            extendInfoMap.Add("org_req_date", "20241010");
            // 原全局流水号
            // extendInfoMap.Add("org_hf_seq_id", "");
            // 交易备注
            // extendInfoMap.Add("remark", "");
            // 异步通知地址
            // extendInfoMap.Add("notify_url", "");
            return extendInfoMap;
        }

        private static object getAcctInfos()
        {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            // obj.Add("div_amt", "test");
            // 分账接收方商户号
            // obj.Add("huifu_id", "test");
            // 分账接收方账户号
            // obj.Add("acct_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object getAcctSplitBunch()
        {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");
            // 分账明细
            // obj.Add("acct_infos", getAcctInfos());

            return obj;
        }
    }
}
