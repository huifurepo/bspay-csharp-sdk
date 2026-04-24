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
            request.setHuifuId("6666000109133323");
            // 交易金额
            request.setTransAmt("0.13");
            // 商品描述
            request.setGoodsDesc("app跳微信消费");
            // 微信小程序扩展参数集合
            request.setMiniappData(get79ae16abF80243edA1d2716c18993dc8());

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
            extendInfoMap.Add("delay_acct_flag", "Y");
            // 是否拆单支付
            // extendInfoMap.Add("split_pay_flag", "");
            // 拆单支付参数集合
            // extendInfoMap.Add("split_pay_data", getB32820656b19491f8493Aedc93824585());
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getCeb7c110604a4eb38a354b753b81e01b());
            // 交易失效时间
            // extendInfoMap.Add("time_expire", "");
            // 业务信息
            // extendInfoMap.Add("biz_info", get0f1e1b4eA8f9463981573b6d52fca20a());
            // 交易异步通知地址
            extendInfoMap.Add("notify_url", "https://callback.service.com/xx");
            // 微信参数集合
            // extendInfoMap.Add("wx_data", get3857dabb491b41e9970e2222c78d52fe());
            // 设备信息
            // extendInfoMap.Add("terminal_device_data", getAb459ff28d4b44f4Bfc77c6c7dee40fe());
            // 手续费场景标识
            // extendInfoMap.Add("fee_sign", "");
            return extendInfoMap;
        }

        private static string getB32820656b19491f8493Aedc93824585() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户贴息标记
            // obj.Add("fq_mer_discount_flag", "");
            // 商户业务信息
            // obj.Add("ali_business_params", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get7b637af0A8a54de5B5b870f0910a95be() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "0.01");
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
        private static string getCeb7c110604a4eb38a354b753b81e01b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", get7b637af0A8a54de5B5b870f0910a95be());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get79ae16abF80243edA1d2716c18993dc8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否生成scheme_code
            obj.Add("need_scheme", "Y");
            // 应用ID
            obj.Add("seq_id", "APP_2022100912694428");
            // 私有信息
            obj.Add("private_info", "oppsHosting://");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get7ffdabd5E3f746ca982369231061f240() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 指定支付者
            // obj.Add("limit_payer", "");
            // 微信实名验证
            // obj.Add("real_name_flag", "");

            return obj;
        }
        private static object get0793f164B5b145788ff8Fa84a17ca207() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 姓名
            // obj.Add("name", "");
            // 证件类型
            // obj.Add("cert_type", "");
            // 证件号
            // obj.Add("cert_no", "");

            return obj;
        }
        private static string get0f1e1b4eA8f9463981573b6d52fca20a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 付款人验证（微信）
            // obj.Add("payer_check_wx", get7ffdabd5E3f746ca982369231061f240());
            // 个人付款人信息
            // obj.Add("person_payer", get0793f164B5b145788ff8Fa84a17ca207());

            return JsonConvert.SerializeObject(obj);
        }
        private static object get5ff89689878e4a6e933622ed380efe16() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品编码
            // obj.Add("goods_id", "");
            // 商品名称
            // obj.Add("goods_name", "");
            // 商品单价(元)
            // obj.Add("price", "");
            // 商品数量
            // obj.Add("quantity", "");
            // 微信侧商品编码
            // obj.Add("wxpay_goods_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object getDe266714D5b449028d11C7a909c892bd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 单品列表
            // obj.Add("goods_detail", get5ff89689878e4a6e933622ed380efe16());
            // 订单原价(元)
            // obj.Add("cost_price", "");
            // 商品小票ID
            // obj.Add("receipt_id", "");

            return obj;
        }
        private static object get786f1eb02d7942e3905fA5d785d10ecd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店id
            // obj.Add("id", "");
            // 门店名称
            // obj.Add("name", "");
            // 门店行政区划码
            // obj.Add("area_code", "");
            // 门店详细地址
            // obj.Add("address", "");

            return obj;
        }
        private static object getD0cb0ae880e946238db7025f18752e7c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店信息
            // obj.Add("store_info", get786f1eb02d7942e3905fA5d785d10ecd());

            return obj;
        }
        private static string get3857dabb491b41e9970e2222c78d52fe() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 子商户应用ID
            // obj.Add("sub_appid", "");
            // 子商户用户标识
            // obj.Add("sub_openid", "");
            // 附加数据
            // obj.Add("attach", "");
            // 商品描述
            // obj.Add("body", "");
            // 商品详情
            // obj.Add("detail", getDe266714D5b449028d11C7a909c892bd());
            // 设备号
            // obj.Add("device_info", "");
            // 订单优惠标记
            // obj.Add("goods_tag", "");
            // 实名支付
            // obj.Add("identity", "");
            // 开发票入口开放标识
            // obj.Add("receipt", "");
            // 场景信息
            // obj.Add("scene_info", getD0cb0ae880e946238db7025f18752e7c());
            // 终端ip
            // obj.Add("spbill_create_ip", "");
            // 单品优惠标识
            // obj.Add("promotion_flag", "");
            // 新增商品ID
            // obj.Add("product_id", "");
            // 指定支付者
            // obj.Add("limit_payer", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAb459ff28d4b44f4Bfc77c6c7dee40fe() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 汇付机具号
            // obj.Add("devs_id", "test");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
