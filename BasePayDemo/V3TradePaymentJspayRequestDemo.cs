using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 应用场景 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradePaymentJspayRequestDemo
    {

        public static void V3TradePaymentJspayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3TradePaymentJspayRequest request = new V3TradePaymentJspayRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000109133323");
            // 商品描述
            request.setGoodsDesc("hibs自动化-通用版验证");
            // 交易类型
            request.setTradeType("A_NATIVE");
            // 交易金额
            request.setTransAmt("0.10");

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
            // 账户号
            // extendInfoMap.Add("acct_id", "");
            // 交易有效期
            extendInfoMap.Add("time_expire", "20250518235959");
            // 微信参数集合
            extendInfoMap.Add("wx_data", get998445eeAb6c4ed488c875c610ab3481());
            // 支付宝参数集合
            extendInfoMap.Add("alipay_data", get00fbeb6156324125Bd0bEbe694ac88bd());
            // 银联参数集合
            extendInfoMap.Add("unionpay_data", get5044cfb9E98447b7B92f535e29bdb171());
            // 数字人民币参数集合
            // extendInfoMap.Add("dc_data", get0f98e12487334e8a9e6567b76e3a52fc());
            // 抖音参数集合
            // extendInfoMap.Add("dy_data", getA6b9cc38F0d24cd382e57696ed3ea727());
            // 是否延迟交易
            extendInfoMap.Add("delay_acct_flag", "N");
            // 手续费扣款标志
            // extendInfoMap.Add("fee_flag", "");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getF92558709e1d47889bd1Be63b20f615d());
            // 传入分账遇到优惠的处理规则
            extendInfoMap.Add("term_div_coupon_type", "0");
            // 补贴支付信息
            // extendInfoMap.Add("combinedpay_data", get8880b6224a434da6B8a922eab710043b());
            // 补贴支付手续费承担方信息
            // extendInfoMap.Add("combinedpay_data_fee_info", getB1bf828fF83141c68a6b2e28ff333aea());
            // 禁用信用卡标记
            extendInfoMap.Add("limit_pay_type", "NO_CREDIT");
            // 商户贴息标记
            extendInfoMap.Add("fq_mer_discount_flag", "N");
            // 渠道号
            extendInfoMap.Add("channel_no", "");
            // 场景类型
            extendInfoMap.Add("pay_scene", "02");
            // 备注
            extendInfoMap.Add("remark", "string");
            // 安全信息
            extendInfoMap.Add("risk_check_data", getFea340757bdb43d5BecbD0066308e07c());
            // 设备信息
            extendInfoMap.Add("terminal_device_data", getFb3c246d51f84741854aEb1d36be2601());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            // 手续费补贴信息
            // extendInfoMap.Add("trans_fee_allowance_info", getE02280afDc36435e8476D1e412d54648());
            // 手续费场景标识
            // extendInfoMap.Add("fee_sign", "");
            return extendInfoMap;
        }

        private static object get973a97319e4c4a6c8a3091c2a1516d1a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品编码
            obj.Add("goods_id", "6934572310301");
            // 商品名称
            obj.Add("goods_name", "太龙双黄连口服液");
            // 商品单价(元)
            obj.Add("price", "43.00");
            // 商品数量
            obj.Add("quantity", "1");
            // 微信侧商品编码
            obj.Add("wxpay_goods_id", "12235413214070356458058");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get8d2d8a357b2e4c809dab549f0e5f59e8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 单品列表
            obj.Add("goods_detail", get973a97319e4c4a6c8a3091c2a1516d1a());
            // 订单原价(元)
            obj.Add("cost_price", "43.00");
            // 商品小票ID
            obj.Add("receipt_id", "20220628132043853798");

            return obj;
        }
        private static object get2551f2c6B06a4d71B5f4C39bfa719267() {
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
        private static object get3ab5804a0a294a959fa9Db5e7cdf7f82() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店信息
            // obj.Add("store_info", get2551f2c6B06a4d71B5f4C39bfa719267());

            return obj;
        }
        private static string get998445eeAb6c4ed488c875c610ab3481() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 子商户应用ID
            obj.Add("sub_appid", "wxdfe9a5d141f96685");
            // 子商户用户标识
            obj.Add("sub_openid", "o8jhotzittQSetZ-N0Yj4Hz91Rqc");
            // 附加数据
            // obj.Add("attach", "");
            // 商品描述
            // obj.Add("body", "");
            // 商品详情
            obj.Add("detail", get8d2d8a357b2e4c809dab549f0e5f59e8());
            // 设备号
            // obj.Add("device_info", "");
            // 订单优惠标记
            // obj.Add("goods_tag", "");
            // 实名支付
            // obj.Add("identity", "");
            // 开发票入口开放标识
            // obj.Add("receipt", "");
            // 场景信息
            obj.Add("scene_info", get3ab5804a0a294a959fa9Db5e7cdf7f82());
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
        private static object get7d4ef20d844e4c3689d22849072e9e8b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡类型
            obj.Add("card_type", "");
            // 支付宝点餐场景类型
            obj.Add("food_order_type", "qr_order");
            // 花呗分期数
            obj.Add("hb_fq_num", "");
            // 花呗卖家手续费百分比
            obj.Add("hb_fq_seller_percent", "");
            // 行业数据回流信息
            obj.Add("industry_reflux_info", "string");
            // 信用卡分期资产方式
            // obj.Add("fq_channels", "");
            // 停车场id
            obj.Add("parking_id", "123wsx");
            // 系统商编号
            obj.Add("sys_service_provider_id", "1111111");
            // 支卡通相关参数
            // obj.Add("preset_pay_tool", "");

            return obj;
        }
        private static object getF381573c898149cb8188979228516838() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品的编号
            obj.Add("goods_id", "12312321");
            // 商品名称
            obj.Add("goods_name", "汇付");
            // 商品单价(元)
            obj.Add("price", "43.00");
            // 商品数量
            obj.Add("quantity", "20");
            // 商品描述信息
            obj.Add("body", "");
            // 商品类目树
            obj.Add("categories_tree", "string");
            // 商品的展示地址
            obj.Add("show_url", "");
            // 商品类目
            obj.Add("goods_category", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get67f8575eEd42465e8e635c1ca5b47532() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 姓名
            // obj.Add("name", "");
            // 手机号
            // obj.Add("mobile", "");
            // 证件类型
            // obj.Add("cert_type", "");
            // 证件号
            // obj.Add("cert_no", "");
            // 允许的最小买家年龄
            // obj.Add("min_age", "");
            // 是否强制校验付款人身份信息
            // obj.Add("fix_buyer", "");
            // 是否强制校验身份信息
            // obj.Add("need_check_info", "");

            return obj;
        }
        private static string get00fbeb6156324125Bd0bEbe694ac88bd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付宝的店铺编号
            obj.Add("alipay_store_id", "");
            // 买家的支付宝唯一用户号
            obj.Add("buyer_id", "208870269990XXXX");
            // 买家支付宝账号
            obj.Add("buyer_logon_id", "string");
            // 业务扩展参数
            obj.Add("extend_params", get7d4ef20d844e4c3689d22849072e9e8b());
            // 订单包含的商品列表信息
            obj.Add("goods_detail", getF381573c898149cb8188979228516838());
            // 商户原始订单号
            obj.Add("merchant_order_no", "string");
            // 商户操作员编号
            obj.Add("operator_id", "123213213");
            // 销售产品码
            obj.Add("product_code", "string");
            // 卖家支付宝用户号
            obj.Add("seller_id", "string");
            // 商户门店编号
            obj.Add("store_id", "");
            // 外部指定买家
            // obj.Add("ext_user_info", get67f8575eEd42465e8e635c1ca5b47532());
            // 订单标题
            // obj.Add("subject", "");
            // 商家门店名称
            // obj.Add("store_name", "");
            // 小程序应用的appid
            // obj.Add("op_app_id", "");
            // 商户业务信息
            // obj.Add("ali_business_params", "");
            // 订单描述
            // obj.Add("body", "");
            // 优惠明细参数
            // obj.Add("ali_promo_params", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getA2b536b5848b4d038f4781eba2d43101() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户类别
            // obj.Add("mer_cat_code", "");
            // 二级商户代码
            // obj.Add("sub_id", "");
            // 二级商户名称
            // obj.Add("sub_name", "");
            // 终端号
            // obj.Add("term_id", "");

            return obj;
        }
        private static string get6fa4c53bAffe448dA13f130b3f9454b1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 服务商订单编号
            // obj.Add("pnr_order_id", "");
            // 服务商密文
            // obj.Add("pid_sct", "");
            // 场景标识
            // obj.Add("trade_scene", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get5044cfb9E98447b7B92f535e29bdb171() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 二维码
            // obj.Add("qr_code", "");
            // 收款方附加数据
            // obj.Add("addn_data", "");
            // 地区信息
            // obj.Add("area_info", "");
            // 持卡人ip
            // obj.Add("customer_ip", "");
            // 前台通知地址
            // obj.Add("front_url", "");
            // 订单描述
            // obj.Add("order_desc", "");
            // 收款方附言
            // obj.Add("payee_comments", "");
            // 收款方信息
            // obj.Add("payee_info", getA2b536b5848b4d038f4781eba2d43101());
            // 银联分配的服务商机构标识码
            // obj.Add("pnr_ins_id_cd", "");
            // 请求方自定义域
            // obj.Add("req_reserved", "");
            // 终端信息
            // obj.Add("term_info", "");
            // 银联用户标识
            // obj.Add("user_id", "");
            // 服务商信息
            // obj.Add("pid_info", get6fa4c53bAffe448dA13f130b3f9454b1());
            // 银联支付标识
            // obj.Add("app_up_identifier", "");
            // 交易支付渠道
            // obj.Add("pay_channel", "");
            // 第三方公众账号ID
            // obj.Add("third_part_app_id", "");
            // 第三方用户标识
            // obj.Add("third_part_open_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get0f98e12487334e8a9e6567b76e3a52fc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 数字货币银行编号
            // obj.Add("digital_bank_no", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get11e98d74Dfc844a99b4679a44bb0b069() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 场景类型
            // obj.Add("type", "");
            // 应用名称
            // obj.Add("app_name", "");
            // 网站URL
            // obj.Add("app_url", "");
            // iOS平台BundleID
            // obj.Add("bundle_id", "");
            // Android平台PackageName
            // obj.Add("package_name", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getA6b9cc38F0d24cd382e57696ed3ea727() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 子商户应用ID
            // obj.Add("sub_appid", "");
            // 订单优惠标记
            // obj.Add("goods_tag", "");
            // 终端ip
            // obj.Add("order_ip", "");
            // 抖音H5支付请求信息
            // obj.Add("h5_info", get11e98d74Dfc844a99b4679a44bb0b069());
            // 第三方appid，渠道商、商户在第三方注册的appid，抖音js、小程序支付时必填
            // obj.Add("third_part_app_id", "");
            // 第三方openid，渠道商、商户在第三方注册的openid
            // obj.Add("third_part_open_id", "");
            // 收款方附加数据
            // obj.Add("acq_addn_data", "");
            // 收款方传递的门店信息
            // obj.Add("store_info", "");
            // 二维码
            // obj.Add("qr_code", "");
            // 地区信息
            // obj.Add("area_info", "");
            // 前台通知地址
            // obj.Add("front_url", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getC329f691Ebb74a3aAe524a1920e8d5b0() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账接收方ID
            obj.Add("huifu_id", "6666000109133323");
            // 分账金额
            obj.Add("div_amt", "0.10");
            // 账户号
            // obj.Add("acct_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getF92558709e1d47889bd1Be63b20f615d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", getC329f691Ebb74a3aAe524a1920e8d5b0());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get8880b6224a434da6B8a922eab710043b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴方汇付商户号
            // obj.Add("huifu_id", "test");
            // 补贴方类型
            // obj.Add("user_type", "test");
            // 补贴方账户号
            // obj.Add("acct_id", "test");
            // 补贴金额
            // obj.Add("amount", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getB1bf828fF83141c68a6b2e28ff333aea() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴支付手续费承担方汇付编号
            // obj.Add("huifu_id", "");
            // 补贴支付手续费承担方账户号
            // obj.Add("acct_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getFea340757bdb43d5BecbD0066308e07c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // ip地址
            obj.Add("ip_addr", "180.167.105.130");
            // 基站地址
            obj.Add("base_station", "192.168.1.1");
            // 纬度
            obj.Add("latitude", "33.3");
            // 经度
            obj.Add("longitude", "33.3");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getFb3c246d51f84741854aEb1d36be2601() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户设备类型
            // obj.Add("mer_device_type", "test");
            // 汇付机具号
            obj.Add("devs_id", "SPINTP357338300264411");
            // 设备类型
            obj.Add("device_type", "1");
            // 交易设备IP
            obj.Add("device_ip", "10.10.0.1");
            // 交易设备MAC
            obj.Add("device_mac", "");
            // 交易设备IMEI
            obj.Add("device_imei", "");
            // 交易设备IMSI
            obj.Add("device_imsi", "");
            // 交易设备ICCID
            obj.Add("device_icc_id", "");
            // 交易设备WIFIMAC
            obj.Add("device_wifi_mac", "");
            // 交易设备GPS
            obj.Add("device_gps", "192.168.0.0");
            // 商户终端应用程序版本
            // obj.Add("app_version", "");
            // SIM卡卡号
            // obj.Add("icc_id", "");
            // 商户终端实时经纬度信息
            // obj.Add("location", "");
            // 商户交易设备IP
            // obj.Add("mer_device_ip", "");
            // 移动国家代码
            // obj.Add("mobile_country_cd", "");
            // 移动网络号码
            // obj.Add("mobile_net_num", "");
            // 商户终端入网认证编号
            // obj.Add("network_license", "");
            // 商户终端序列号
            // obj.Add("serial_num", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getE02280afDc36435e8476D1e412d54648() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴手续费金额
            // obj.Add("allowance_fee_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
