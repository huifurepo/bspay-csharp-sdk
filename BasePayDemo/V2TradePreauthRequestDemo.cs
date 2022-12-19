using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信支付宝预授权 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePreauthRequestDemo
    {

        public static void V2TradePreauthRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePreauthRequest request = new V2TradePreauthRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000108854952");
            // 交易金额
            request.setTransAmt("0.02");
            // 商品描述
            request.setGoodsDesc("123213213");
            // 支付授权码
            request.setAuthCode("280426995846228615");
            // 安全信息
            request.setRiskCheckData(getRiskCheckData());

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
            // 外部订单号
            extendInfoMap.Add("out_ord_id", "2021031722001427671459048436");
            // 交易发起时间
            extendInfoMap.Add("send_time", "12345678901234567");
            // 交易失效时间
            extendInfoMap.Add("time_expire", "20221130121212");
            // 禁用信用卡标记
            extendInfoMap.Add("limit_pay_type", "NO_CREDIT");
            // 场景类型
            extendInfoMap.Add("pay_scene", "02");
            // 渠道号
            extendInfoMap.Add("channel_no", "");
            // 传入分帐遇到优惠的处理规则
            extendInfoMap.Add("term_div_coupon_type", "1");
            // 支付宝扩展参数集合
            extendInfoMap.Add("alipay_data", getAlipayData());
            // 微信扩展参数集合
            extendInfoMap.Add("wx_data", getWxData());
            // 商户扩展域
            extendInfoMap.Add("mer_priv", "{\"callType\":\"01\",\"lc\":\"12345678901234567890123456789012123\",\"softVersion\":\"6.5.3\"}");
            // 备注
            extendInfoMap.Add("remark", "123213132132");
            // 授权号
            extendInfoMap.Add("auth_no", "608467");
            // 批次号
            extendInfoMap.Add("batch_id", "987654");
            // 商户操作员号
            extendInfoMap.Add("mer_oper_id", "12345678901234567890123456789012");
            // 输入密码提示
            // extendInfoMap.Add("password_trade", "");
            // 设备信息
            extendInfoMap.Add("terminal_device_data", getTerminalDeviceData());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            return extendInfoMap;
        }

        private static string getTerminalDeviceData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户终端版本号
            obj.Add("app_version", "");
            // 交易设备GPS
            obj.Add("device_gps", "");
            // 交易设备ICCID
            obj.Add("device_icc_id", "");
            // 交易设备IMEI
            obj.Add("device_imei", "");
            // 交易设备IMSI
            obj.Add("device_imsi", "");
            // 交易设备IP
            obj.Add("device_ip", "10.10.0.1");
            // 交易设备MAC
            obj.Add("device_mac", "");
            // 设备类型
            obj.Add("device_type", "1");
            // 交易设备WIFIMAC
            obj.Add("device_wifi_mac", "");
            // 汇付机具号
            obj.Add("devs_id", "SPINTP366020000360401");
            // ICCID
            obj.Add("icc_id", "");
            // 商户终端实时经纬度信息
            obj.Add("location", "+32.10520/+118.80593");
            // 商户交易设备IP
            obj.Add("mer_device_ip", "");
            // 商户设备类型
            obj.Add("mer_device_type", "01");
            // 移动国家代码
            obj.Add("mobile_country_cd", "");
            // 移动网络号码
            obj.Add("mobile_net_num", "");
            // 商户终端入网认证编号
            obj.Add("network_license", "P3111");
            // 商户终端序列号
            obj.Add("serial_num", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getWxSceneRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店信息
            obj.Add("store_info", getWxStoreRucan());

            return obj;
        }
        private static string getRiskCheckData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 基站地址
            obj.Add("base_station", "192.168.1.1");
            // ip地址
            obj.Add("ip_addr", "180.167.105.130");
            // 纬度
            obj.Add("latitude", "33.3");
            // 经度
            obj.Add("longitude", "33.3");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getWxGoodsDetailRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品编码
            obj.Add("goods_id", "1232131");
            // 商品名称
            obj.Add("goods_name", "汇付天下");
            // 商品单价
            obj.Add("price", "0.50");
            // 商品数量
            obj.Add("quantity", 0);
            // 微信侧商品编码
            obj.Add("wxpay_goods_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getWxData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 附加数据
            obj.Add("attach", "");
            // 商品详情
            obj.Add("detail", getWxGoodsRucan());
            // 设备号
            obj.Add("device_info", "");
            // 订单优惠标记
            obj.Add("goods_tag", "12321312");
            // 场景信息
            obj.Add("scene_info", getWxSceneRucan());
            // 子商户公众账号ID
            obj.Add("sub_appid", "wx48abf94e085e98e1");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getExtendParams() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡类型
            obj.Add("card_type", "");
            // 支付宝点餐场景类型
            obj.Add("food_order_type", "qr_order");
            // 花呗分期数
            obj.Add("hb_fq_num", "");
            // 手续费百分比
            obj.Add("hb_fq_seller_percent", "");
            // 行业数据回流信息
            obj.Add("industry_reflux_info", "");
            // 停车场ID
            obj.Add("parking_id", "123wsx");
            // 系统商编号
            obj.Add("sys_service_provider_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getWxStoreRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店详细地址
            obj.Add("address", "汇付天下桂林路");
            // 门店行政区划码
            obj.Add("area_code", "310");
            // 门店id
            obj.Add("id", "1232131");
            // 门店名称
            obj.Add("name", "测试");

            return obj;
        }
        private static string getAlipayData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付宝的店铺编号
            obj.Add("alipay_store_id", "");
            // 业务扩展参数
            obj.Add("extend_params", getExtendParams());
            // 订单包含的商品列表信息
            obj.Add("goods_detail", getAliGoodsDetail());
            // 商户操作员编号
            obj.Add("operator_id", "1234567890123456789012345678");
            // 商户门店编号
            obj.Add("store_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getWxGoodsRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 单品列表
            obj.Add("goods_detail", getWxGoodsDetailRucan());
            // 订单原价
            obj.Add("cost_price", "1");
            // 商品小票ID
            obj.Add("receipt_id", "");

            return obj;
        }
        private static object getAliGoodsDetail() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品的编号
            obj.Add("goods_id", "12345678901234567890123456789012");
            // 商品名称
            obj.Add("goods_name", "111");
            // 商品单价
            obj.Add("price", "1.01");
            // 商品数量
            obj.Add("quantity", "1");
            // 商品描述信息
            obj.Add("body", "");
            // 商品类目树
            obj.Add("categories_tree", "");
            // 商品类目
            obj.Add("goods_category", "");
            // 商品的展示地址
            obj.Add("show_url", "321313");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
    }
}
