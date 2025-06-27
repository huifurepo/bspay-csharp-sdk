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
            request.setRiskCheckData(getE02463d1F3ac4fd185f6Bd24cf501ecb());

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
            // extendInfoMap.Add("combinedpay_data", getD189c8daF937403e94adB2dc377cd6f3());
            // 场景类型
            // extendInfoMap.Add("pay_scene", "");
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", get952a291c2c2d4e7fAd7fB8c75a17d553());
            // 传入分帐遇到优惠的处理规则
            // extendInfoMap.Add("term_div_coupon_type", "");
            // 聚合反扫微信参数集合
            // extendInfoMap.Add("wx_data", get51a97cb269b946b9B82e5914fc3f6a27());
            // 支付宝扩展参数集合
            // extendInfoMap.Add("alipay_data", getD45cb0c863e54be08f25361846e3ff85());
            // 银联参数集合
            // extendInfoMap.Add("unionpay_data", get7edfab7e6c614384Bb2f533e62768584());
            // 设备信息
            // extendInfoMap.Add("terminal_device_info", get09d5b65841d64f27B5bdD2683394cbd3());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            // 交易备注
            // extendInfoMap.Add("remark", "");
            // 账户号
            // extendInfoMap.Add("acct_id", "");
            // 手续费补贴信息
            // extendInfoMap.Add("trans_fee_allowance_info", getB2dbe76d86d948b9Ac3a4a6f0b746d2e());
            return extendInfoMap;
        }

        private static string getD189c8daF937403e94adB2dc377cd6f3() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴方汇付编号
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
        private static object getA56f49b9844246c9B55fBf2472320755() {
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
        private static string get952a291c2c2d4e7fAd7fB8c75a17d553() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            // obj.Add("acct_infos", getA56f49b9844246c9B55fBf2472320755());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get10b1cca5C03347feB177111ddd9d36a6() {
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
        private static object getA2c3e07bC8a14a008b0602fd5168e36f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 单品列表
            // obj.Add("goods_detail", get10b1cca5C03347feB177111ddd9d36a6());
            // 订单原价
            // obj.Add("cost_price", "");
            // 商品小票ID
            // obj.Add("receipt_id", "");

            return obj;
        }
        private static object get73010fa6565b457c8744B5bb6e7a01bd() {
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
        private static object get5e84ee5d6ea649579fe80ca194a2e26a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店信息
            // obj.Add("store_info", get73010fa6565b457c8744B5bb6e7a01bd());

            return obj;
        }
        private static string get51a97cb269b946b9B82e5914fc3f6a27() {
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
            // obj.Add("detail", getA2c3e07bC8a14a008b0602fd5168e36f());
            // 场景信息
            // obj.Add("scene_info", get5e84ee5d6ea649579fe80ca194a2e26a());
            // 单品优惠标识
            // obj.Add("promotion_flag", "");
            // 电子发票入口开放标识
            // obj.Add("receipt", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get19fa5b18C0d94fc2B57977b3841c51a4() {
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
        private static object getD81ce040C3eb4af0821e8f9d78eba159() {
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
        private static object get63b7f4ecFfa2408f8bb475033858e953() {
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
        private static string getD45cb0c863e54be08f25361846e3ff85() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付宝的店铺编号
            // obj.Add("alipay_store_id", "");
            // 订单包含的商品列表信息
            // obj.Add("goods_detail", get19fa5b18C0d94fc2B57977b3841c51a4());
            // 业务扩展参数
            // obj.Add("extend_params", getD81ce040C3eb4af0821e8f9d78eba159());
            // 商户操作员编号
            // obj.Add("operator_id", "");
            // 商户门店编号
            // obj.Add("store_id", "");
            // 外部指定买家
            // obj.Add("ext_user_info", get63b7f4ecFfa2408f8bb475033858e953());
            // 商户业务信息
            // obj.Add("ali_business_params", "");
            // 订单描述
            // obj.Add("body", "");
            // 优惠明细参数
            // obj.Add("ali_promo_params", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get7edfab7e6c614384Bb2f533e62768584() {
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

            return JsonConvert.SerializeObject(obj);
        }
        private static string getE02463d1F3ac4fd185f6Bd24cf501ecb() {
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
        private static string get09d5b65841d64f27B5bdD2683394cbd3() {
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
        private static string getB2dbe76d86d948b9Ac3a4a6f0b746d2e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴手续费金额
            // obj.Add("allowance_fee_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
