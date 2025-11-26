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
            extendInfoMap.Add("wx_data", get8f4ad72627694c18Ba86Bd9089993223());
            // 支付宝参数集合
            extendInfoMap.Add("alipay_data", get6ff391b708884f29B5bb9c38dbc05eaf());
            // 银联参数集合
            extendInfoMap.Add("unionpay_data", getFdd35a17B50c44bb9dae6dc0496e1c44());
            // 数字人民币参数集合
            // extendInfoMap.Add("dc_data", get4e4205d2Ef6b4c88B3b39af08eb7b8e7());
            // 是否延迟交易
            extendInfoMap.Add("delay_acct_flag", "N");
            // 手续费扣款标志
            // extendInfoMap.Add("fee_flag", "");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", get5f2b22187a1340818461B8baa5c50f4b());
            // 传入分账遇到优惠的处理规则
            extendInfoMap.Add("term_div_coupon_type", "0");
            // 补贴支付信息
            // extendInfoMap.Add("combinedpay_data", get9a739c81E37741baBdb45e347a0faac7());
            // 补贴支付手续费承担方信息
            // extendInfoMap.Add("combinedpay_data_fee_info", getC95f39053e964866A0b32ed0912a257f());
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
            extendInfoMap.Add("risk_check_data", get69fc765aD5704c85B3ea06703ac7f588());
            // 设备信息
            extendInfoMap.Add("terminal_device_data", get7c420dd3D80743789b387e128045019d());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            // 手续费补贴信息
            // extendInfoMap.Add("trans_fee_allowance_info", get1a44c52b2db0437e90e089cae551d69e());
            // 手续费场景标识
            // extendInfoMap.Add("fee_sign", "");
            return extendInfoMap;
        }

        private static object get10b097adD5b743408ffe5a8ef0c870a3() {
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
        private static object get4101ac5472b24fd1A43f3948d0c6409c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 单品列表
            obj.Add("goods_detail", get10b097adD5b743408ffe5a8ef0c870a3());
            // 订单原价(元)
            obj.Add("cost_price", "43.00");
            // 商品小票ID
            obj.Add("receipt_id", "20220628132043853798");

            return obj;
        }
        private static object get5f6d1a317a1049edBc256f5f7ee3f006() {
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
        private static object get2518f582Da9747b3Ac3bCc374547d331() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店信息
            // obj.Add("store_info", get5f6d1a317a1049edBc256f5f7ee3f006());

            return obj;
        }
        private static string get8f4ad72627694c18Ba86Bd9089993223() {
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
            obj.Add("detail", get4101ac5472b24fd1A43f3948d0c6409c());
            // 设备号
            // obj.Add("device_info", "");
            // 订单优惠标记
            // obj.Add("goods_tag", "");
            // 实名支付
            // obj.Add("identity", "");
            // 开发票入口开放标识
            // obj.Add("receipt", "");
            // 场景信息
            obj.Add("scene_info", get2518f582Da9747b3Ac3bCc374547d331());
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
        private static object get2d16cf16A91c46d48b34083415a8cef6() {
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

            return obj;
        }
        private static object get2cfdafba93bd41d2A00051d8605d030c() {
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
        private static object get9d9461e41bff4302847d00f06e7ba9c9() {
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
        private static string get6ff391b708884f29B5bb9c38dbc05eaf() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付宝的店铺编号
            obj.Add("alipay_store_id", "");
            // 买家的支付宝唯一用户号
            obj.Add("buyer_id", "208870269990XXXX");
            // 买家支付宝账号
            obj.Add("buyer_logon_id", "string");
            // 业务扩展参数
            obj.Add("extend_params", get2d16cf16A91c46d48b34083415a8cef6());
            // 订单包含的商品列表信息
            obj.Add("goods_detail", get2cfdafba93bd41d2A00051d8605d030c());
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
            // obj.Add("ext_user_info", get9d9461e41bff4302847d00f06e7ba9c9());
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
        private static object get388555dcFa0b49999b1f21e5f7824e11() {
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
        private static string get3222dc83Df9f474189488cd1eb19fa7c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 服务商订单编号
            // obj.Add("pnr_order_id", "");
            // 服务商密文
            // obj.Add("pid_sct", "");
            // 场景标识
            // obj.Add("trade_scene", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getFdd35a17B50c44bb9dae6dc0496e1c44() {
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
            // obj.Add("payee_info", get388555dcFa0b49999b1f21e5f7824e11());
            // 银联分配的服务商机构标识码
            // obj.Add("pnr_ins_id_cd", "");
            // 请求方自定义域
            // obj.Add("req_reserved", "");
            // 终端信息
            // obj.Add("term_info", "");
            // 银联用户标识
            // obj.Add("user_id", "");
            // 服务商信息
            // obj.Add("pid_info", get3222dc83Df9f474189488cd1eb19fa7c());
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
        private static string get4e4205d2Ef6b4c88B3b39af08eb7b8e7() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 数字货币银行编号
            // obj.Add("digital_bank_no", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getAbc106c0D4db4dc882d204d73b0e9c60() {
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
        private static string get5f2b22187a1340818461B8baa5c50f4b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", getAbc106c0D4db4dc882d204d73b0e9c60());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get9a739c81E37741baBdb45e347a0faac7() {
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
        private static string getC95f39053e964866A0b32ed0912a257f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴支付手续费承担方汇付编号
            // obj.Add("huifu_id", "");
            // 补贴支付手续费承担方账户号
            // obj.Add("acct_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get69fc765aD5704c85B3ea06703ac7f588() {
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
        private static string get7c420dd3D80743789b387e128045019d() {
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
        private static string get1a44c52b2db0437e90e089cae551d69e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴手续费金额
            // obj.Add("allowance_fee_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
