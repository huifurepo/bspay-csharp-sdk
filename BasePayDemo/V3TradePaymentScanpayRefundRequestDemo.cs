using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 扫码交易退款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradePaymentScanpayRefundRequestDemo
    {

        public static void V3TradePaymentScanpayRefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3TradePaymentScanpayRefundRequest request = new V3TradePaymentScanpayRefundRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000108854952");
            // 申请退款金额
            request.setOrdAmt("0.01");
            // 原交易请求日期
            request.setOrgReqDate("20221107");

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
            extendInfoMap.Add("org_hf_seq_id", "002900TOP3B221107142320P992ac139c0c00000");
            // 原交易微信支付宝的商户单号
            // extendInfoMap.Add("org_party_order_id", "");
            // 原交易请求流水号
            // extendInfoMap.Add("org_req_seq_id", "");
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", get641df3f4C94748d48e4635007f755f47());
            // 微信拓展参数集合
            // extendInfoMap.Add("wx_data", get81730c8fEec745f89ed55ddca843c35d());
            // 数字货币拓展参数集合
            // extendInfoMap.Add("digital_currency_data", get3f660ca48e1249a8870bB36cddbf53df());
            // 抖音拓展参数集合
            // extendInfoMap.Add("dy_data", get7380711a77c943abB65dFd0262d2a339());
            // 补贴支付信息
            // extendInfoMap.Add("combinedpay_data", getB48bed7aB6174f51Af5d8d93d208f004());
            // 补贴支付手续费承担方信息
            // extendInfoMap.Add("combinedpay_data_fee_info", get337cdd659f544810B6ee091fb21950fd());
            // 备注
            // extendInfoMap.Add("remark", "");
            // 是否垫资退款
            // extendInfoMap.Add("loan_flag", "");
            // 垫资承担者
            // extendInfoMap.Add("loan_undertaker", "");
            // 垫资账户类型
            // extendInfoMap.Add("loan_acct_type", "");
            // 安全信息
            // extendInfoMap.Add("risk_check_data", get857f190d4de14c95812b472db2d4546d());
            // 设备信息
            // extendInfoMap.Add("terminal_device_data", get5b739bb834934f4cBf091bfe6f6b1751());
            // 异步通知地址
            // extendInfoMap.Add("notify_url", "");
            // 银联参数集合
            // extendInfoMap.Add("unionpay_data", get2c17c847649d4d3a84bdFff0a7b9bb33());
            return extendInfoMap;
        }

        private static object getA259171491144b858892C854abdc3633() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            // obj.Add("div_amt", "test");
            // 分账接收方ID
            // obj.Add("huifu_id", "test");
            // 垫资金额
            // obj.Add("part_loan_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get641df3f4C94748d48e4635007f755f47() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账信息列表
            // obj.Add("acct_infos", getA259171491144b858892C854abdc3633());

            return JsonConvert.SerializeObject(obj);
        }
        private static object get1c5125870a39427f96d928170154a26d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品编码
            // obj.Add("goods_id", "test");
            // 商品退款金额
            // obj.Add("refund_amt", "test");
            // 商品退款数量
            // obj.Add("refund_quantity", "test");
            // 商品单价
            // obj.Add("price", "test");
            // 微信支付商品编码
            // obj.Add("wxpay_goods_id", "");
            // 商品名称
            // obj.Add("goods_name", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object getB1dda134445a4afe9f3b1c23e906b0d0() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品详情列表
            // obj.Add("goods_detail", get1c5125870a39427f96d928170154a26d());

            return obj;
        }
        private static string get81730c8fEec745f89ed55ddca843c35d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款商品详情
            // obj.Add("detail", getB1dda134445a4afe9f3b1c23e906b0d0());
            // 退款原因
            // obj.Add("refund_desc", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get3f660ca48e1249a8870bB36cddbf53df() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款原因
            // obj.Add("refund_desc", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get7380711a77c943abB65dFd0262d2a339() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款原因
            // obj.Add("refund_desc", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getB48bed7aB6174f51Af5d8d93d208f004() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 汇付商户号
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
        private static string get337cdd659f544810B6ee091fb21950fd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴支付手续费承担方汇付编号
            // obj.Add("huifu_id", "");
            // 补贴支付手续费承担方账户号
            // obj.Add("acct_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get857f190d4de14c95812b472db2d4546d() {
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
        private static string get5b739bb834934f4cBf091bfe6f6b1751() {
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

            return JsonConvert.SerializeObject(obj);
        }
        private static string get2c17c847649d4d3a84bdFff0a7b9bb33() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 收款方附加数据
            // obj.Add("addn_data", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
