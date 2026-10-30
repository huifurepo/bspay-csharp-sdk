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
    public class V2TradeHostingPaymentPreorderAliRequestDemo
    {

        public static void V2TradeHostingPaymentPreorderAliRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeHostingPaymentPreorderAliRequest request = new V2TradeHostingPaymentPreorderAliRequest();
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
            request.setAppData(get071c7f8fCe5341708f20F1cf750b3308());

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
            // 是否延迟交易
            extendInfoMap.Add("delay_acct_flag", "N");
            // 是否合单支付
            // extendInfoMap.Add("merge_pay_flag", "");
            // 子单信息列表
            // extendInfoMap.Add("sub_orders_request", getE35bb59f055046438dfa5e2f822c68c1());
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getB030a02bA5c8472c9cff00ed4cacb3a7());
            // 统一收银台扩展参数集合
            // extendInfoMap.Add("hosting_data", get7e0c32a9Cea440a1B8839321e39ed0fc());
            // 交易失效时间
            // extendInfoMap.Add("time_expire", "");
            // 业务信息
            // extendInfoMap.Add("biz_info", get7398d9ecC6114d4eA0977142e0c11757());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "https://callback.service.com/xx");
            // 支付宝参数集合
            // extendInfoMap.Add("alipay_data", get948f4498D5bb46b7979cA19d0f6c16df());
            // 设备信息
            // extendInfoMap.Add("terminal_device_data", getBf7b33fb979847f9890eCe3044270146());
            // 手续费场景标识
            // extendInfoMap.Add("fee_sign", "");
            // 是否交易手续费分摊
            // extendInfoMap.Add("fee_split_flag", "");
            // 手续费扣款标志
            // extendInfoMap.Add("fee_flag", "");
            // 渠道号
            // extendInfoMap.Add("channel_no", "");
            // 场景类型
            // extendInfoMap.Add("pay_scene", "");
            return extendInfoMap;
        }

        private static string getE35bb59f055046438dfa5e2f822c68c1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 子单请求流水号
            // obj.Add("sub_req_seq_id", "test");
            // 子单商户号
            // obj.Add("sub_huifu_id", "test");
            // 子单交易金额
            // obj.Add("sub_trans_amt", "test");
            // 子单账户号
            // obj.Add("sub_acct_id", "");
            // 是否延迟交易
            // obj.Add("delay_acct_flag", "");
            // 子单备注
            // obj.Add("sub_remark", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object get26f8c4beCab64ba1834fDd7fa82cf1a7() {
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
        private static string getB030a02bA5c8472c9cff00ed4cacb3a7() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", get26f8c4beCab64ba1834fDd7fa82cf1a7());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get7e0c32a9Cea440a1B8839321e39ed0fc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 项目号
            // obj.Add("project_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get071c7f8fCe5341708f20F1cf750b3308() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 小程序返回码
            obj.Add("app_schema", "app跳转链接");
            // 支付宝小程序ID
            // obj.Add("appid", "");
            // 私有信息
            // obj.Add("private_info", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get91f6489b0f5446d19da30042b5e26453() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否提供校验身份信息
            // obj.Add("need_check_info", "");
            // 允许的最小买家年龄
            // obj.Add("min_age", "");
            // 是否强制校验付款人身份信息
            // obj.Add("fix_buyer", "");

            return obj;
        }
        private static object get2effa40bA18e472dB4cc13ac8f232ff4() {
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
        private static string get7398d9ecC6114d4eA0977142e0c11757() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 付款人验证（支付宝）
            // obj.Add("payer_check_ali", get91f6489b0f5446d19da30042b5e26453());
            // 个人付款人信息
            // obj.Add("person_payer", get2effa40bA18e472dB4cc13ac8f232ff4());

            return JsonConvert.SerializeObject(obj);
        }
        private static object get10722936D7694c069cef864fc36d8120() {
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
        private static object get3281c6153ee141bf92265e1128648634() {
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
        private static string get948f4498D5bb46b7979cA19d0f6c16df() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付宝的店铺编号
            // obj.Add("alipay_store_id", "");
            // 业务扩展参数
            // obj.Add("extend_params", get10722936D7694c069cef864fc36d8120());
            // 订单包含的商品列表信息
            // obj.Add("goods_detail", get3281c6153ee141bf92265e1128648634());
            // 商户原始订单号
            // obj.Add("merchant_order_no", "");
            // 商户操作员编号
            // obj.Add("operator_id", "");
            // 产品码
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
            // 商户贴息标记
            // obj.Add("fq_mer_discount_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getBf7b33fb979847f9890eCe3044270146() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 汇付机具号
            // obj.Add("devs_id", "test");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
