using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 聚合正扫接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentJspayRequestDemo
    {

        public static void V2TradePaymentJspayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePaymentJspayRequest request = new V2TradePaymentJspayRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000108854952");
            // 交易类型
            request.setTradeType("A_NATIVE");
            // 交易金额
            request.setTransAmt("0.10");
            // 商品描述
            request.setGoodsDesc("hibs自动化-通用版验证");

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
            extendInfoMap.Add("time_expire", "20230418235959");
            // 禁用信用卡标记
            extendInfoMap.Add("limit_pay_type", "NO_CREDIT");
            // 是否延迟交易
            extendInfoMap.Add("delay_acct_flag", "N");
            // 渠道号
            extendInfoMap.Add("channel_no", "");
            // 手续费扣款标志
            // extendInfoMap.Add("fee_flag", "");
            // 营销补贴信息
            // extendInfoMap.Add("combinedpay_data", getCombinedpayData());
            // 场景类型
            extendInfoMap.Add("pay_scene", "02");
            // 安全信息
            extendInfoMap.Add("risk_check_data", getRiskCheckData());
            // 设备信息
            extendInfoMap.Add("terminal_device_data", getTerminalDeviceData());
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getAcctSplitBunch());
            // 传入分帐遇到优惠的处理规则
            extendInfoMap.Add("term_div_coupon_type", "0");
            // 聚合正扫微信拓展参数集合
            // extendInfoMap.Add("wx_data", getWxData());
            // 支付宝扩展参数集合
            extendInfoMap.Add("alipay_data", getAlipayData());
            // 银联参数集合
            // extendInfoMap.Add("unionpay_data", getUnionpayData());
            // 数字人民币参数集合
            // extendInfoMap.Add("dc_data", getDcData());
            // 商户贴息标记
            extendInfoMap.Add("fq_mer_discount_flag", "N");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            // 备注
            extendInfoMap.Add("remark", "string");
            // 账户号
            // extendInfoMap.Add("acct_id", "");
            return extendInfoMap;
        }

        private static object getPayeeInfo() {
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
        private static object getGoodsDetail() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品的编号
            obj.Add("goods_id", "12312321");
            // 商品名称(元)
            obj.Add("goods_name", "阿里");
            // 商品单价
            obj.Add("price", "0.01");
            // 商品数量
            obj.Add("quantity", "20");
            // 商品描述信息
            obj.Add("body", "");
            // 商品类目树
            obj.Add("categories_tree", "string");
            // 商品类目
            obj.Add("goods_category", "");
            // 商品的展示地址
            obj.Add("show_url", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object getStoreInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店id
            // obj.Add("id", "");
            // 门店名称
            // obj.Add("name", "");
            // 门店行政区划码
            // obj.Add("area_code", "");
            // 门店详细地址
            // obj.Add("address", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getCombinedpayData() {
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
        private static object getAcctInfosRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            // obj.Add("div_amt", "test");
            // 被分账方ID
            // obj.Add("huifu_id", "test");
            // 账户号
            // obj.Add("acct_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getTerminalDeviceData() {
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
            // 商户终端序列号
            // obj.Add("serial_num", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAcctSplitBunch() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            // obj.Add("acct_infos", getAcctInfosRucan());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getRiskCheckData() {
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
        private static string getUnionpayData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 收款方附加数据
            // obj.Add("acq_addn_data", "");
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
            // obj.Add("payee_info", getPayeeInfo());
            // 银联分配的服务商机构标识码
            // obj.Add("pnr_ins_id_cd", "");
            // 请求方自定义域
            // obj.Add("req_reserved", "");
            // 终端信息
            // obj.Add("term_info", "");
            // 云闪付用户标识
            // obj.Add("user_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getDcData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 数字货币银行编号
            // obj.Add("digital_bank_no", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getSceneInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店信息
            // obj.Add("store_info", getStoreInfo());

            return obj;
        }
        private static string getWxData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 子商户公众账号id
            // obj.Add("sub_appid", "");
            // 用户标识
            // obj.Add("openid", "");
            // 子商户用户标识
            // obj.Add("sub_openid", "");
            // 附加数据
            // obj.Add("attach", "");
            // 商品描述
            // obj.Add("body", "");
            // 商品详情
            // obj.Add("detail", getDetail());
            // 设备号
            // obj.Add("device_info", "");
            // 订单优惠标记
            // obj.Add("goods_tag", "");
            // 实名支付
            // obj.Add("identity", "");
            // 开发票入口开放标识
            // obj.Add("receipt", "");
            // 场景信息
            // obj.Add("scene_info", getSceneInfo());
            // 终端ip
            // obj.Add("spbill_create_ip", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getExtendParams() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡类型
            obj.Add("card_type", "");
            // 支付宝点餐场景类型
            obj.Add("food_order_type", "qr_order");
            // 花呗分期数
            obj.Add("hb_fq_num", "");
            // 花呗卖家承担的手续费百分比
            obj.Add("hb_fq_seller_percent", "");
            // 行业数据回流信息
            obj.Add("industry_reflux_info", "string");
            // 停车场id
            obj.Add("parking_id", "123wsx");
            // 系统商编号
            obj.Add("sys_service_provider_id", "1111111");
            // 信用卡分期资产方式
            // obj.Add("fq_channels", "");

            return obj;
        }
        private static string getAlipayData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 买家的支付宝唯一用户号
            obj.Add("buyer_id", "2088502835860454");
            // 支付宝的店铺编号
            obj.Add("alipay_store_id", "");
            // 买家支付宝账号
            obj.Add("buyer_logon_id", "string");
            // 业务扩展参数
            obj.Add("extend_params", getExtendParams());
            // 订单包含的商品列表信息
            obj.Add("goods_detail", getGoodsDetail());
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

            return JsonConvert.SerializeObject(obj);
        }
        private static object getDetail() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 单品列表
            // obj.Add("goods_detail", getGoodsDetailWxRucan());
            // 订单原价(元)
            // obj.Add("cost_price", "");
            // 商品小票ID
            // obj.Add("receipt_id", "");

            return obj;
        }
        private static object getGoodsDetailWxRucan() {
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
    }
}
