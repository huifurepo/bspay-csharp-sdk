using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * H5、PC预下单接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentPreorderH5RequestDemo
    {

        public static void V2TradeHostingPaymentPreorderH5RequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeHostingPaymentPreorderH5Request request = new V2TradeHostingPaymentPreorderH5Request();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000109133323");
            // 交易金额
            request.setTransAmt("0.10");
            // 商品描述
            request.setGoodsDesc("支付托管消费");
            // 预下单类型
            request.setPreOrderType("1");
            // 半支付托管扩展参数集合
            request.setHostingData(getHostingData());

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
            extendInfoMap.Add("delay_acct_flag", "N");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getAcctSplitBunch());
            // 交易失效时间
            // extendInfoMap.Add("time_expire", "");
            // 业务信息
            extendInfoMap.Add("biz_info", getBizInfo());
            // 交易异步通知地址
            extendInfoMap.Add("notify_url", "https://callback.service.com/xx");
            // 使用类型
            // extendInfoMap.Add("usage_type", "");
            // 交易类型
            // extendInfoMap.Add("trans_type", "");
            return extendInfoMap;
        }

        private static object getAcctInfosRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "0.08");
            // 分账接收方ID
            obj.Add("huifu_id", "6666000111546360");

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
        private static string getHostingData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 项目标题
            obj.Add("project_title", "收银台标题");
            // 半支付托管项目号
            obj.Add("project_id", "PROJECTID2023101225142567");
            // 请求类型P:PC页面版，默认：P；M:H5页面版；指定交易类型时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：M&lt;/font&gt;
            // obj.Add("request_type", "test");
            // 商户私有信息
            obj.Add("private_info", "商户私有信息test");
            // 回调地址
            obj.Add("callback_url", "https://paas.huifu.com");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getPayerCheckAli() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否提供校验身份信息
            obj.Add("need_check_info", "T");
            // 允许的最小买家年龄
            obj.Add("min_age", "12");
            // 是否强制校验付款人身份信息
            obj.Add("fix_buyer", "F");

            return obj;
        }
        private static object getPayerCheckWx() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 指定支付者
            obj.Add("limit_payer", "ADULT");
            // 微信实名验证
            obj.Add("real_name_flag", "Y");

            return obj;
        }
        private static object getPersonPayer() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 姓名
            obj.Add("name", "张三");
            // 证件类型
            obj.Add("cert_type", "IDENTITY_CARD");
            // 证件号
            obj.Add("cert_no", "OLOxrl809XmVIMmPRTIyIpJHxi4HFMJNmxGz1nhZAtps9xPEVDysU3UZPBZfsNFLFcXEMENPsJ+tymbYt42dNQ+76hyEtx+qz0BQhU8SKV8H5itrI4kaXpaJf+sV8OewrJkhDidPdz01vqMEDQRhaMnNwl8snHZxDdpu7HVUz5JwsLYfBbZP2Q4CZpVWS3NunQahZ8zHQ+8EhvYVH1vE7f/M6nJt1/4GoHz9C/UnuYudV0S2uBhlywbX+YkRGNMl/oz5+UNeMDA2jqhtTreSD4+w7S82L53rqKsAbosodOPo4OAMZk4/0QOH5LDbqFByVM97mzHfw7z+Tx/dsXJ8QQ==");
            // 手机号
            obj.Add("mobile", "15012345678");

            return obj;
        }
        private static string getBizInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 付款人验证（支付宝）
            obj.Add("payer_check_ali", getPayerCheckAli());
            // 付款人验证（微信）
            obj.Add("payer_check_wx", getPayerCheckWx());
            // 个人付款人信息
            obj.Add("person_payer", getPersonPayer());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
