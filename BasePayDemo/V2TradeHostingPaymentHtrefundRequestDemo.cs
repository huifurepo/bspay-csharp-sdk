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
            request.setRiskCheckData(getD4cd573b43424f3e9983Ead4f24a05f1());
            // 设备信息线上交易退款必填，参见线上退款接口；jsonObject字符串
            request.setTerminalDeviceData(get5eab0ab7309b4319934991997b4e02a7());
            // 大额转账支付账户信息数据jsonObject格式；银行大额转账支付交易退款申请时必填
            // request.setBankInfoData(get4884ae34D72f4674Bba3Ecf6bd9b6249());

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
            extendInfoMap.Add("acct_split_bunch", getAf13d5ba8edf4124Bca861e10b605ae0());
            // 备注
            // extendInfoMap.Add("remark", "");
            // 是否垫资退款
            // extendInfoMap.Add("loan_flag", "");
            // 垫资承担者
            // extendInfoMap.Add("loan_undertaker", "");
            // 垫资账户类型
            // extendInfoMap.Add("loan_acct_type", "");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            // 抖音拓展参数集合
            // extendInfoMap.Add("dy_data", get7c0cf89bD0ab4d89969195b6b74d6ebd());
            return extendInfoMap;
        }

        private static object get562e286f9afe4c608dee36bfbfe12c6e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "0.12");
            // 分账接收方ID
            obj.Add("huifu_id", "6666000003100616");
            // 垫资金额
            // obj.Add("part_loan_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getAf13d5ba8edf4124Bca861e10b605ae0() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", get562e286f9afe4c608dee36bfbfe12c6e());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getD4cd573b43424f3e9983Ead4f24a05f1() {
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
        private static string get5eab0ab7309b4319934991997b4e02a7() {
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
        private static string get4884ae34D72f4674Bba3Ecf6bd9b6249() {
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
        private static string get7c0cf89bD0ab4d89969195b6b74d6ebd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款原因
            // obj.Add("refund_desc", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
