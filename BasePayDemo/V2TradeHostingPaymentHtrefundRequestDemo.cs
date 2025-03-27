using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 托管交易退款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentHtrefundRequestDemo
    {

        public static void V2TradeHostingPaymentHtrefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeHostingPaymentHtrefundRequest request = new V2TradeHostingPaymentHtrefundRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000003100616");
            // 申请退款金额
            request.setOrdAmt("0.01");
            // 原交易请求日期
            request.setOrgReqDate("20240229");
            // 安全信息线上交易退款必填，参见线上退款接口；jsonObject字符串
            request.setRiskCheckData(get195595a868964f2bB023E9566fcd0297());
            // 设备信息线上交易退款必填，参见线上退款接口；jsonObject字符串
            request.setTerminalDeviceData(get8d8843c250f94e9b80a253d37ec6f80a());
            // 大额转账支付账户信息数据jsonObject格式；银行大额转账支付交易退款申请时必填
            // request.setBankInfoData(getAa3a4591240343e2Bad5D6a0764f06dc());

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
            // 原交易全局流水号
            extendInfoMap.Add("org_hf_seq_id", "");
            // 原交易微信支付宝的商户单号
            extendInfoMap.Add("org_party_order_id", "");
            // 原交易请求流水号
            extendInfoMap.Add("org_req_seq_id", "202207099803123123199941");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", get4a68d378Cb6e41dfA9405a589b476160());
            // 备注
            // extendInfoMap.Add("remark", "");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            return extendInfoMap;
        }

        private static object get33a52525B1614d3bBc18Ff7d935b2bca() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "0.12");
            // 分账接收方ID
            obj.Add("huifu_id", "6666000003100616");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get4a68d378Cb6e41dfA9405a589b476160() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", get33a52525B1614d3bBc18Ff7d935b2bca());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get195595a868964f2bB023E9566fcd0297() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // ip地址
            // obj.Add("ip_addr", "");
            // 基站地址
            // obj.Add("base_station", "");
            // 纬度
            // obj.Add("latitude", "");
            // 经度
            // obj.Add("longitude", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get8d8843c250f94e9b80a253d37ec6f80a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 设备类型
            obj.Add("device_type", "4");
            // 交易设备IP
            // obj.Add("device_ip", "");
            // 交易设备MAC
            // obj.Add("device_mac", "");
            // 交易设备GPS
            // obj.Add("device_gps", "");
            // 交易设备IMEI
            // obj.Add("device_imei", "");
            // 交易设备IMSI
            // obj.Add("device_imsi", "");
            // 交易设备ICCID
            // obj.Add("device_icc_id", "");
            // 交易设备WIFIMAC
            // obj.Add("device_wifi_mac", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAa3a4591240343e2Bad5D6a0764f06dc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 省份付款方为对公账户时必填，参见省市地区码；示例值：0013
            // obj.Add("province", "test");
            // 地区付款方为对公账户时必填，参见省市地区码；示例值：1301
            // obj.Add("area", "test");
            // 银行编号付款方为对公账户时必填，参考：银行编码； 示例值：01040000
            // obj.Add("bank_code", "test");
            // 联行号付款方为对公账户时必填，参见：银行支行编码； 示例值：102290026507
            // obj.Add("correspondent_code", "test");
            // 付款方账户类型
            // obj.Add("card_acct_type", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
