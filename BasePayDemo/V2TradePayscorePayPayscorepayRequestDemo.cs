using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 支付分扣款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscorePayPayscorepayRequestDemo
    {

        public static void V2TradePayscorePayPayscorepayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePayscorePayPayscorepayRequest request = new V2TradePayscorePayPayscorepayRequest();
            // 微信扣款单号
            // request.setOutTradeNo("test");
            // 商品描述
            // request.setGoodsDesc("test");
            // 商户号
            request.setHuifuId("6666000108854952");
            // 安全信息
            // request.setRiskCheckData("test");

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
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", getAcctSplitBunch());
            // 扣款登记返回的汇付全局流水号
            // extendInfoMap.Add("deduct_hf_seq_id", "");
            // 扣款登记创建请求流水号
            // extendInfoMap.Add("deduct_req_seq_id", "");
            // 是否延迟交易
            // extendInfoMap.Add("delay_acct_flag", "");
            // 商户回调地址
            // extendInfoMap.Add("notify_url", "");
            // 交易备注
            // extendInfoMap.Add("remark", "");
            // 请求日期
            extendInfoMap.Add("req_date", DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            extendInfoMap.Add("req_seq_id", DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 设备信息
            // extendInfoMap.Add("terminal_device_info", getTerminalDeviceInfo());
            // 聚合反扫微信参数集合
            // extendInfoMap.Add("wx_data", getWxData());
            return extendInfoMap;
        }

        private static object getAcctInfos() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            // obj.Add("div_amt", "test");
            // 分账商户号
            // obj.Add("huifu_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getAcctSplitBunch() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            // obj.Add("acct_infos", getAcctInfos());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getTerminalDeviceInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
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

            return JsonConvert.SerializeObject(obj);
        }
        private static string getWxData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 子商户公众账号id
            // obj.Add("sub_appid", "");
            // 用户标识
            // obj.Add("openid", "");
            // 子商户用户标识
            // obj.Add("sub_openid", "");
            // 设备号
            // obj.Add("device_info", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
