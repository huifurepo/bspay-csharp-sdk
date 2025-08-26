using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 聚合反扫 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradePaymentMicropayRequestDemo
    {

        public static void V3TradePaymentMicropayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3TradePaymentMicropayRequest request = new V3TradePaymentMicropayRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000109133323");
            // 交易金额
            request.setTransAmt("1.01");
            // 商品描述
            request.setGoodsDesc("聚合反扫消费");
            // 支付授权码
            request.setAuthCode("131135212661863252");
            // 安全信息
            request.setRiskCheckData(get5532fa68450f46b58e3a179fcc348380());

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
            // 交易有效期
            // extendInfoMap.Add("time_expire", "");
            // 手续费扣款标志
            // extendInfoMap.Add("fee_flag", "");
            // 禁用支付方式
            // extendInfoMap.Add("limit_pay_type", "");
            // 是否延迟交易
            // extendInfoMap.Add("delay_acct_flag", "");
            // 渠道号
            // extendInfoMap.Add("channel_no", "");
            // 补贴支付信息
            // extendInfoMap.Add("combinedpay_data", get37ad64f6950c44719d83462c2615c98f());
            // 补贴支付手续费承担方信息
            // extendInfoMap.Add("combinedpay_data_fee_info", get4b527f2e91c14c7f9b5390820598e80c());
            // 场景类型
            // extendInfoMap.Add("pay_scene", "");
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", getB8816aa2Eb074eb093c7F8981939a028());
            // 传入分帐遇到优惠的处理规则
            // extendInfoMap.Add("term_div_coupon_type", "");
            // 聚合反扫微信参数集合
            // extendInfoMap.Add("wx_data", get43ab2d7320984566Af4cA9d285a79624());
            // 支付宝扩展参数集合
            // extendInfoMap.Add("alipay_data", get985d922a84c74774Bb5621ce46000533());
            // 银联参数集合
            // extendInfoMap.Add("unionpay_data", get85ec4d56988349c18016A14805976b6d());
            // 设备信息
            // extendInfoMap.Add("terminal_device_info", getA0a2516292fd4b1e8c5a4b13bb444ccc());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            // 交易备注
            // extendInfoMap.Add("remark", "");
            // 账户号
            // extendInfoMap.Add("acct_id", "");
            // 手续费补贴信息
            // extendInfoMap.Add("trans_fee_allowance_info", getBfc3ff1710df4b9cB94c1d4645bd6016());
            return extendInfoMap;
        }

        private static string get37ad64f6950c44719d83462c2615c98f() {
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
        private static string get4b527f2e91c14c7f9b5390820598e80c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴支付手续费承担方汇付编号
            // obj.Add("huifu_id", "");
            // 补贴支付手续费承担方账户号
            // obj.Add("acct_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get26006cd40fdf48b299d3Fe6b9f1c7ae4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账接收方ID
            // obj.Add("huifu_id", "test");
            // 分账金额
            // obj.Add("div_amt", "");
            // 账户号
            // obj.Add("acct_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getB8816aa2Eb074eb093c7F8981939a028() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            // obj.Add("acct_infos", get26006cd40fdf48b299d3Fe6b9f1c7ae4());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getF4d1fa8474e649c586d8Ad12fa19ec79() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品编码
            // obj.Add("goods_id", "test");
            // 商品数量
            // obj.Add("quantity", "test");
            // 商品名称
            // obj.Add("goods_name", "");
            // 商品单价
            // obj.Add("price", "");
            // 微信侧商品编码
            // obj.Add("wxpay_goods_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get0f7b40a9833441138aeeA7efa6b062bc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 单品列表
            // obj.Add("goods_detail", getF4d1fa8474e649c586d8Ad12fa19ec79());
            // 订单原价
            // obj.Add("cost_price", "");
            // 商品小票ID
            // obj.Add("receipt_id", "");

            return obj;
        }
        private static object get50877803A06245d38bcb6a45871203a5() {
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
        private static object get2aa619b3D0cd4f5c815a6f91454837d7() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店信息
            // obj.Add("store_info", get50877803A06245d38bcb6a45871203a5());

            return obj;
        }
        private static string get43ab2d7320984566Af4cA9d285a79624() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 收款设备IP直联模式必填字段；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：192.168.2.2&lt;/font&gt;
            // obj.Add("spbill_create_ip", "test");
            // 子商户公众账号id
            // obj.Add("sub_appid", "");
            // 设备号
            // obj.Add("device_info", "");
            // 订单优惠标记
            // obj.Add("goods_tag", "");
            // 附加数据
            // obj.Add("attach", "");
            // 商品详情
            // obj.Add("detail", get0f7b40a9833441138aeeA7efa6b062bc());
            // 场景信息
            // obj.Add("scene_info", get2aa619b3D0cd4f5c815a6f91454837d7());
            // 单品优惠标识
            // obj.Add("promotion_flag", "");
            // 电子发票入口开放标识
            // obj.Add("receipt", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get2aaf1ab89e3640f0B0c39b0a3e706d3b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品的编号
            // obj.Add("goods_id", "test");
            // 商品名称
            // obj.Add("goods_name", "test");
            // 商品数量
            // obj.Add("quantity", "test");
            // 商品单价
            // obj.Add("price", "test");
            // 商品类目树
            // obj.Add("categories_tree", "");
            // 商品类目
            // obj.Add("goods_category", "");
            // 商品描述信息
            // obj.Add("body", "");
            // 商品的展示地址
            // obj.Add("show_url", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get79386404D962492eBc108a1991549354() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡类型
            // obj.Add("card_type", "");
            // 支付宝点餐场景类型
            // obj.Add("food_order_type", "");
            // 花呗分期数
            // obj.Add("hb_fq_num", "");
            // 花呗卖家承担的手续费百分比
            // obj.Add("hb_fq_seller_percent", "");
            // 行业数据回流信息
            // obj.Add("industry_reflux_info", "");
            // 停车场id
            // obj.Add("parking_id", "");
            // 系统商编号
            // obj.Add("sys_service_provider_id", "");

            return obj;
        }
        private static object get7ca7c63f25694a18Ae14831ab2970756() {
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
        private static string get985d922a84c74774Bb5621ce46000533() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付宝的店铺编号
            // obj.Add("alipay_store_id", "");
            // 订单包含的商品列表信息
            // obj.Add("goods_detail", get2aaf1ab89e3640f0B0c39b0a3e706d3b());
            // 业务扩展参数
            // obj.Add("extend_params", get79386404D962492eBc108a1991549354());
            // 商户操作员编号
            // obj.Add("operator_id", "");
            // 商户门店编号
            // obj.Add("store_id", "");
            // 外部指定买家
            // obj.Add("ext_user_info", get7ca7c63f25694a18Ae14831ab2970756());
            // 商户业务信息
            // obj.Add("ali_business_params", "");
            // 订单描述
            // obj.Add("body", "");
            // 优惠明细参数
            // obj.Add("ali_promo_params", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get1a0bcb2115af4e268b2d8a8dc54411ac() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 服务商订单编号
            // obj.Add("pnr_order_id", "");
            // 服务商密文
            // obj.Add("pid_sct", "");
            // 场景标识
            // obj.Add("trade_scene", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get85ec4d56988349c18016A14805976b6d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 币种
            // obj.Add("currency_code", "");
            // 支持发票
            // obj.Add("invoice_st", "");
            // 商户类别
            // obj.Add("mer_cat_code", "");
            // 服务商机构标识码
            // obj.Add("pnr_ins_id_cd", "");
            // 特殊计费信息
            // obj.Add("specfeeinfo", "");
            // 终端号
            // obj.Add("term_id", "");
            // 收款方附加数据
            // obj.Add("addn_data", "");
            // 服务商信息
            // obj.Add("pid_info", get1a0bcb2115af4e268b2d8a8dc54411ac());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get5532fa68450f46b58e3a179fcc348380() {
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
        private static string getA0a2516292fd4b1e8c5a4b13bb444ccc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户设备类型
            // obj.Add("mer_device_type", "test");
            // 汇付机具号
            // obj.Add("devs_id", "test");
            // 设备类型
            // obj.Add("device_type", "");
            // 交易设备IP
            // obj.Add("device_ip", "");
            // 交易设备MAC
            // obj.Add("device_mac", "");
            // 交易设备IMEI
            // obj.Add("device_imei", "");
            // 交易设备IMSI
            // obj.Add("device_imsi", "");
            // 交易设备ICCID
            // obj.Add("device_icc_id", "");
            // 交易设备WIFIMAC
            // obj.Add("device_wifi_mac", "");
            // 交易设备GPS
            // obj.Add("device_gps", "");
            // 商户终端应用程序版
            // obj.Add("app_version", "");
            // 加密随机因子
            // obj.Add("encrypt_rand_num", "");
            // SIM 卡卡号
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
            // 密文数据
            // obj.Add("secret_text", "");
            // 商户终端序列号
            // obj.Add("serial_num", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getBfc3ff1710df4b9cB94c1d4645bd6016() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴手续费金额
            // obj.Add("allowance_fee_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
