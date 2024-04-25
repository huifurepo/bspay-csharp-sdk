using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信小程序预下单接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentPreorderWxRequestDemo
    {

        public static void V2TradeHostingPaymentPreorderWxRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeHostingPaymentPreorderWxRequest request = new V2TradeHostingPaymentPreorderWxRequest();
            // 预下单类型
            request.setPreOrderType("3");
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000003100616");
            // 交易金额
            request.setTransAmt("0.13");
            // 商品描述
            request.setGoodsDesc("app跳微信消费");
            // 微信小程序扩展参数集合
            request.setMiniappData(getMiniappDataRucan());

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
            // 收银台样式
            // extendInfoMap.Add("style_id", "");
            // 是否延迟交易
            extendInfoMap.Add("delay_acct_flag", "Y");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getAcctSplitBunchRucan());
            // 交易失效时间
            extendInfoMap.Add("time_expire", "20231127233423");
            // 业务信息
            // extendInfoMap.Add("biz_info", getBizInfo());
            // 交易异步通知地址
            extendInfoMap.Add("notify_url", "https://callback.service.com/xx");
            return extendInfoMap;
        }

        private static object getAcctInfosRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "0.01");
            // 分账接收方ID
            obj.Add("huifu_id", "6666000003100616");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getAcctSplitBunchRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", getAcctInfosRucan());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getMiniappDataRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否生成scheme_code
            obj.Add("need_scheme", "Y");
            // 应用ID
            obj.Add("seq_id", "APP_2022033147154783");
            // 私有信息
            obj.Add("private_info", "oppsHosting://");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getPayCheckWx() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 指定支付者
            // obj.Add("limit_payer", "");
            // 微信实名验证
            // obj.Add("real_name_flag", "");

            return obj;
        }
        private static object getPersonPayer() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 姓名
            // obj.Add("name", "");
            // 证件类型
            // obj.Add("cert_type", "");
            // 证件号
            // obj.Add("cert_no", "");

            return obj;
        }
        private static string getBizInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 付款人验证（微信）
            // obj.Add("payer_check_wx", getPayCheckWx());
            // 个人付款人信息
            // obj.Add("person_payer", getPersonPayer());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
