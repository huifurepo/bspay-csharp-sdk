using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 统一收银台交易退款 - 示例
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
            request.setRiskCheckData(get23e26cf0945b48fa956a9cf1d9de0bc2());
            // 设备信息线上交易退款必填，参见线上退款接口；jsonObject字符串
            request.setTerminalDeviceData(get2a00d4edBc624d72A543F7981bbb91a4());
            // 大额转账支付账户信息数据jsonObject格式；银行大额转账支付交易退款申请时必填
            // request.setBankInfoData(get8715a51e6c3f4b4c8220F0c99a839c2e());

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
            extendInfoMap.Add("acct_split_bunch", get49056c85Ad904b4fB10e9184a2a9ef46());
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
            // extendInfoMap.Add("dy_data", get5557f4f4Ccc04255820eEe2ef2fae63c());
            // 子单退款信息列表
            // extendInfoMap.Add("sub_orders_request", get71c30c76C15b427eB5f138660e74cae2());
            return extendInfoMap;
        }

        private static object get8c84d690642f48ce8b4c5b44e6f1441c() {
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
        private static string get49056c85Ad904b4fB10e9184a2a9ef46() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", get8c84d690642f48ce8b4c5b44e6f1441c());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get23e26cf0945b48fa956a9cf1d9de0bc2() {
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
        private static string get2a00d4edBc624d72A543F7981bbb91a4() {
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
        private static string get8715a51e6c3f4b4c8220F0c99a839c2e() {
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
        private static string get5557f4f4Ccc04255820eEe2ef2fae63c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款原因
            // obj.Add("refund_desc", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get8fc59e80664a4493B9a0796467c8a91a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            // obj.Add("div_amt", "test");
            // 分账接收方ID
            // obj.Add("huifu_id", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getE42dd76d256b4a4595b43b74f719c75c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账信息列表
            // obj.Add("acct_infos", get8fc59e80664a4493B9a0796467c8a91a());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get71c30c76C15b427eB5f138660e74cae2() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 子单请求日期
            // obj.Add("sub_req_date", "test");
            // 子单请求流水号
            // obj.Add("sub_req_seq_id", "test");
            // 子单商户号
            // obj.Add("sub_huifu_id", "test");
            // 子单申请退款金额
            // obj.Add("sub_ord_amt", "test");
            // 原子单交易请求日期
            // obj.Add("org_sub_req_date", "test");
            // 原子单交易全局流水号
            // obj.Add("org_sub_hf_seq_id", "");
            // 原子单交易请求流水号
            // obj.Add("org_sub_req_seq_id", "");
            // 分账对象
            // obj.Add("acct_split_bunch", getE42dd76d256b4a4595b43b74f719c75c());
            // 子单备注
            // obj.Add("sub_remark", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
