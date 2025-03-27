using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 交易确认 - 示例
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
            request.setHuifuId("6666000109133323");
            // 交易类型**原交易为快捷支付必填：QUICK_PAY**；&lt;br/&gt;**原交易为余额支付必填：ACCT_PAYMENT**；&lt;br/&gt;原交易为全域资金必填：REMITTANCE_PAY；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：ACCT_PAYMENT&lt;/font&gt;
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
            extendInfoMap.Add("org_req_date", "20220512");
            // 原交易请求流水号
            extendInfoMap.Add("org_req_seq_id", "20220512195832E06521");
            // 原交易商户订单号
            // extendInfoMap.Add("org_mer_ord_id", "");
            // 原交易全局流水号
            extendInfoMap.Add("org_hf_seq_id", "");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getA7256caaCe6b490680ba86babafe4967());
            // 安全信息
            extendInfoMap.Add("risk_check_data", get5dc1f4fb2ca7478382dc4811aa4903f8());
            // 备注
            extendInfoMap.Add("remark", "remark123");
            // 灵活用工标志
            // extendInfoMap.Add("hyc_flag", "");
            // 灵活用工平台
            // extendInfoMap.Add("lg_platform_type", "");
            // 代发模式
            // extendInfoMap.Add("salary_modle_type", "");
            // 落地公司商户号
            // extendInfoMap.Add("bmember_id", "");
            // 乐接活请求参数集合
            // extendInfoMap.Add("ljh_data", get4da1733e10a041c7Aa241338ac87fac0());
            // 异步通知地址
            // extendInfoMap.Add("notify_url", "");
            return extendInfoMap;
        }

        private static object getF77aaa99F28d44d5820628512e341eac() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额(元)单位元，需保留小数点后两位，最低传入0.01 ，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt; ，percentage_flag非Y时必填；&lt;br/&gt;percentage_flag&#x3D;Y时div_amt不填，div_amt&#x3D;total_div_amt*percentage_div
            obj.Add("div_amt", "0.01");
            // 分账接收方ID
            obj.Add("huifu_id", "6666000109133323");
            // 分账百分比%
            // obj.Add("percentage_div", "");
            // 分账接收方账户号
            // obj.Add("acct_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getA7256caaCe6b490680ba86babafe4967() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账总金额（元）本次交易确认总额。需保留小数点后两位&lt;br/&gt;percentage_flag&#x3D;Y时必填。该金额与分账百分比用来计算分账金额。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：10.00&lt;/font&gt;；
            // obj.Add("total_div_amt", "test");
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 分账明细
            obj.Add("acct_infos", getF77aaa99F28d44d5820628512e341eac());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get5dc1f4fb2ca7478382dc4811aa4903f8() {
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
        private static string get4da1733e10a041c7Aa241338ac87fac0() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 税源地ID
            // obj.Add("tax_area_id", "");
            // 任务模板ID
            // obj.Add("template_id", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
