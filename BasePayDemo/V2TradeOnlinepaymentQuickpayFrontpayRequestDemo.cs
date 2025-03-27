using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 快捷支付页面版 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentQuickpayFrontpayRequestDemo
    {

        public static void V2TradeOnlinepaymentQuickpayFrontpayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentQuickpayFrontpayRequest request = new V2TradeOnlinepaymentQuickpayFrontpayRequest();
            // 业务请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000109133323");
            // 订单金额
            request.setTransAmt("0.01");
            // 银行扩展信息
            request.setExtendPayData(getA5a44257248146f586ec9275ef51ed56());
            // 设备信息
            request.setTerminalDeviceData(get843a86e56f334304Ac7c38c6524abd82());
            // 安全信息
            request.setRiskCheckData(getE7f925f2Ab5041919687F439e2fba4ad());
            // 异步通知地址
            request.setNotifyUrl("http://www.baidu.com");

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
            // 用户客户号
            // extendInfoMap.Add("user_huifu_id", "");
            // 订单类型
            extendInfoMap.Add("order_type", "P");
            // 订单失效时间
            extendInfoMap.Add("time_expire", "");
            // 商品描述
            extendInfoMap.Add("goods_desc", "快捷支付接口");
            // 请求类型
            extendInfoMap.Add("request_type", "P");
            // 延时标记
            // extendInfoMap.Add("delay_acct_flag", "");
            // 分账串
            extendInfoMap.Add("acct_split_bunch", get82800b8cE35d42b9B688260754e5deef());
            // 手续费扣款标志
            extendInfoMap.Add("fee_flag", "2");
            // 备注
            extendInfoMap.Add("remark", "remark快捷支付接口");
            // 页面跳转地址
            extendInfoMap.Add("front_url", "http://www.baidu.com");
            return extendInfoMap;
        }

        private static object getDef0a935D6a343269064019353c3caf5() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账接收方ID
            obj.Add("huifu_id", "6666000109133323");
            // 分账金额
            obj.Add("div_amt", "0.01");
            // 账户号
            // obj.Add("acct_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get82800b8cE35d42b9B688260754e5deef() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", getDef0a935D6a343269064019353c3caf5());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getA5a44257248146f586ec9275ef51ed56() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品简称
            obj.Add("goods_short_name", "01");
            // 业务种类
            obj.Add("biz_tp", "123451");
            // 网关支付受理渠道
            obj.Add("gw_chnnl_tp", "02");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get843a86e56f334304Ac7c38c6524abd82() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 设备类型
            obj.Add("device_type", "1");
            // 交易设备IP
            obj.Add("device_ip", "127.0.0.1");
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

            return JsonConvert.SerializeObject(obj);
        }
        private static string getE7f925f2Ab5041919687F439e2fba4ad() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // ip地址
            obj.Add("ip_addr", "127.0.0.1");
            // 基站地址
            // obj.Add("base_station", "");
            // 纬度
            // obj.Add("latitude", "");
            // 经度
            // obj.Add("longitude", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
