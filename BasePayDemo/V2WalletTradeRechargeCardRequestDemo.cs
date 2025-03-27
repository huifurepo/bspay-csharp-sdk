using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 钱包绑卡充值下单 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradeRechargeCardRequestDemo
    {

        public static void V2WalletTradeRechargeCardRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2WalletTradeRechargeCardRequest request = new V2WalletTradeRechargeCardRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000003100615");
            // 钱包用户ID
            request.setUserHuifuId("6666000108133109");
            // 订单金额
            request.setTransAmt("10.00");
            // 微信充值信息微信充值必填
            // request.setWxRechareInfo(get5aab43a511384703Aee9A17b6d476396());
            // 支付宝充值信息支付宝充值必填
            // request.setAlipayRechargeInfo(get1a9a249fFf56429c8a73E7a93ef80c2b());

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
            // 订单失效时间
            extendInfoMap.Add("time_expire", "");
            // 备注
            extendInfoMap.Add("remark", "remark11");
            // 充值方式
            extendInfoMap.Add("recharge_type", "A01");
            // 绑定卡充值信息
            extendInfoMap.Add("bank_recharge_info", get0994fa46Ea53463295f1Db4d35a9e9ed());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "archer://C_TOPAT_NOTIFY");
            return extendInfoMap;
        }

        private static string get718333af8b7c4fffAe5a25a0c20f8d7e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务种类编码
            obj.Add("biz_tp", "100099");
            // 商品简称
            obj.Add("goods_short_name", "个人电脑");
            // 支付页面类型
            obj.Add("gw_chnnl_tp", "02");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCecd9a03C90045d6881d47baf8ff4e54() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易设备类型
            obj.Add("device_type", "3");
            // 交易设备IP
            obj.Add("device_ip", "172.31.31.145");
            // 交易设备MAC
            obj.Add("device_mac", "F0E1D2C3B4A5");
            // 交易终端设备IMEI
            obj.Add("device_imei", "460030912121001");
            // 交易设备IMSI
            obj.Add("device_imsi", "460030912121001");
            // 交易设备ICCID
            obj.Add("device_icc_id", "898600680113F0123014");
            // 交易设备WIFI MAC
            obj.Add("device_wifi_mac", "968778695A4B");
            // 交易设备经纬度
            obj.Add("device_gps", "20.346790,-4.654321");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getA619b5347d694307A1a8C1ef90627a60() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 经度
            obj.Add("longitude", "2");
            // 纬度
            obj.Add("latitude", "1");
            // 基站地址
            obj.Add("base_station", "460001039217563");
            // IP地址
            obj.Add("ip_addr", "172.28.52.52");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get0994fa46Ea53463295f1Db4d35a9e9ed() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行卡序列号
            obj.Add("token_no", "10000136685");
            // 跳转地址
            obj.Add("front_url", "http://www.baidu.com");
            // 网联扩展数据
            obj.Add("extend_pay_data", get718333af8b7c4fffAe5a25a0c20f8d7e());
            // 设备信息
            obj.Add("terminal_device_data", getCecd9a03C90045d6881d47baf8ff4e54());
            // 安全信息
            obj.Add("risk_check_data", getA619b5347d694307A1a8C1ef90627a60());
            // 密码页面类型
            obj.Add("request_type", "M");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get5aab43a511384703Aee9A17b6d476396() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易类型
            // obj.Add("trade_type", "test");
            // 子商户公众账号ID
            // obj.Add("sub_appid", "");
            // 用户标识
            // obj.Add("openid", "");
            // 子商户用户标识
            // obj.Add("sub_openid", "");
            // 渠道号
            // obj.Add("channel_no", "");
            // 场景类型
            // obj.Add("pay_scene", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get1a9a249fFf56429c8a73E7a93ef80c2b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易类型
            // obj.Add("trade_type", "test");
            // 买家的支付宝唯一用户号
            // obj.Add("buyer_id", "test");
            // 支付宝的店铺编号
            // obj.Add("alipay_store_id", "");
            // 渠道号
            // obj.Add("channel_no", "");
            // 场景类型
            // obj.Add("pay_scene", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
