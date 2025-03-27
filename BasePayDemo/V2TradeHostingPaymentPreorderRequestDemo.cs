using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 支付宝小程序预下单接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentPreorderRequestDemo
    {

        public static void V2TradeHostingPaymentPreorderRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeHostingPaymentPreorderRequest request = new V2TradeHostingPaymentPreorderRequest();
            // 商户号
            request.setHuifuId("6666000109133323");
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 预下单类型
            request.setPreOrderType("2");
            // 交易金额
            request.setTransAmt("0.10");
            // 商品描述
            request.setGoodsDesc("app跳支付宝消费");
            // app扩展参数集合
            request.setAppData(get3929b82cFd8a47008ecb589e2c69dcf7());

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
            // 收款汇付账户号
            // extendInfoMap.Add("acct_id", "");
            // 收银台样式
            // extendInfoMap.Add("style_id", "");
            // 是否延迟交易
            extendInfoMap.Add("delay_acct_flag", "N");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getD7e2c888B0514b8fBf315dc4c03edce3());
            // 交易失效时间
            // extendInfoMap.Add("time_expire", "");
            // 业务信息
            // extendInfoMap.Add("biz_info", getAd8a5bcc31b14817A48c1bf5c51ca53a());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "https://callback.service.com/xx");
            // 支付宝参数集合
            // extendInfoMap.Add("alipay_data", getBc1ce5960e7549a28341A27a488826af());
            // 设备信息
            // extendInfoMap.Add("terminal_device_data", getF2e9a7f30aca42a08f236cd825a7398a());
            return extendInfoMap;
        }

        private static object getA05acc30794c41e38154471472af99b5() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "0.08");
            // 分账接收方ID
            obj.Add("huifu_id", "6666000109133323");
            // 收款汇付账户号
            // obj.Add("acct_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getD7e2c888B0514b8fBf315dc4c03edce3() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", getA05acc30794c41e38154471472af99b5());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get3929b82cFd8a47008ecb589e2c69dcf7() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 小程序返回码
            obj.Add("app_schema", "app跳转链接");
            // 私有信息
            // obj.Add("private_info", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get3459e01890374013B480D391e23fb4cd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否提供校验身份信息
            // obj.Add("need_check_info", "");
            // 允许的最小买家年龄
            // obj.Add("min_age", "");
            // 是否强制校验付款人身份信息
            // obj.Add("fix_buyer", "");

            return obj;
        }
        private static object get4b7a8d8dB702492dB8aaB7b2fed9b305() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 姓名
            // obj.Add("name", "");
            // 证件类型
            // obj.Add("cert_type", "");
            // 证件号
            // obj.Add("cert_no", "");
            // 手机号
            // obj.Add("mobile", "");

            return obj;
        }
        private static string getAd8a5bcc31b14817A48c1bf5c51ca53a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 付款人验证（支付宝）
            // obj.Add("payer_check_ali", get3459e01890374013B480D391e23fb4cd());
            // 个人付款人信息
            // obj.Add("person_payer", get4b7a8d8dB702492dB8aaB7b2fed9b305());

            return JsonConvert.SerializeObject(obj);
        }
        private static object get44bb8f8aCc3247b3Abdb5603398c94cb() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡类型
            // obj.Add("card_type", "");
            // 支付宝点餐场景类型
            // obj.Add("food_order_type", "");
            // 花呗分期数
            // obj.Add("hb_fq_num", "");
            // 花呗卖家手续费百分比
            // obj.Add("hb_fq_seller_percent", "");
            // 行业数据回流信息
            // obj.Add("industry_reflux_info", "");
            // 信用卡分期资产方式
            // obj.Add("fq_channels", "");
            // 停车场id
            // obj.Add("parking_id", "");
            // 系统商编号
            // obj.Add("sys_service_provider_id", "");

            return obj;
        }
        private static object getFade890b54bd4a619dcfE68d9aeb4fd3() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品的编号
            // obj.Add("goods_id", "test");
            // 商品名称
            // obj.Add("goods_name", "test");
            // 商品单价(元)
            // obj.Add("price", "test");
            // 商品数量
            // obj.Add("quantity", "test");
            // 商品描述信息
            // obj.Add("body", "");
            // 商品类目树
            // obj.Add("categories_tree", "");
            // 商品类目
            // obj.Add("goods_category", "");
            // 商品的展示地址
            // obj.Add("show_url", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getBc1ce5960e7549a28341A27a488826af() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付宝的店铺编号
            // obj.Add("alipay_store_id", "");
            // 业务扩展参数
            // obj.Add("extend_params", get44bb8f8aCc3247b3Abdb5603398c94cb());
            // 订单包含的商品列表信息
            // obj.Add("goods_detail", getFade890b54bd4a619dcfE68d9aeb4fd3());
            // 商户原始订单号
            // obj.Add("merchant_order_no", "");
            // 商户操作员编号
            // obj.Add("operator_id", "");
            // 销售产品码
            // obj.Add("product_code", "");
            // 卖家支付宝用户号
            // obj.Add("seller_id", "");
            // 商户门店编号
            // obj.Add("store_id", "");
            // 订单标题
            // obj.Add("subject", "");
            // 商家门店名称
            // obj.Add("store_name", "");
            // 商户业务信息
            // obj.Add("ali_business_params", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getF2e9a7f30aca42a08f236cd825a7398a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 汇付机具号
            // obj.Add("devs_id", "test");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
