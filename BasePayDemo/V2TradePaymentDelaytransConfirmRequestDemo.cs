using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 交易确认接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentDelaytransConfirmRequestDemo
    {

        public static void V2TradePaymentDelaytransConfirmRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePaymentDelaytransConfirmRequest request = new V2TradePaymentDelaytransConfirmRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000103423237");
            // 交易类型**原交易为快捷支付必填：QUICK_PAY**，&lt;br/&gt;**原交易为余额支付必填：ACCT_PAYMENT**；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：ACCT_PAYMENT&lt;/font&gt;
            // request.setPayType("test");

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
            // 原交易请求日期
            extendInfoMap.Add("org_req_date", "20221108");
            // 原交易请求流水号
            extendInfoMap.Add("org_req_seq_id", "2022072724398620211667900766");
            // 原交易商户订单号
            // extendInfoMap.Add("org_mer_ord_id", "");
            // 原交易全局流水号
            extendInfoMap.Add("org_hf_seq_id", "");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getAcctSplitBunch());
            // 安全信息
            extendInfoMap.Add("risk_check_data", getRiskCheckData());
            // 备注
            extendInfoMap.Add("remark", "remark123");
            // 灵活用工标志
            // extendInfoMap.Add("hyc_flag", "");
            // 代发模式
            // extendInfoMap.Add("salary_modle_type", "");
            // 落地公司商户号
            // extendInfoMap.Add("bmember_id", "");
            // 灵活用工代发批次号
            // extendInfoMap.Add("hyc_attach_id", "");
            // 异步通知地址
            // extendInfoMap.Add("notify_url", "");
            return extendInfoMap;
        }

        private static object getAcctInfosRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "0.01");
            // 分账接收方ID
            obj.Add("huifu_id", "6666000103423237");
            // 分账接收方账户号
            obj.Add("acct_id", "C01400109");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getAcctSplitBunch() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", getAcctInfosRucan());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getRiskCheckData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // ip地址
            // obj.Add("ip_addr", "");
            // 基站地址
            obj.Add("base_station", "3");
            // 纬度
            obj.Add("latitude", "2");
            // 经度
            obj.Add("longitude", "1");
            // 产品子类
            // obj.Add("sub_product", "");
            // 转账原因
            // obj.Add("transfer_type", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
