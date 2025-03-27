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
    public class V2TradePaymentScanpayRefundRequestDemo
    {

        public static void V2TradePaymentScanpayRefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePaymentScanpayRefundRequest request = new V2TradePaymentScanpayRefundRequest();
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
            // extendInfoMap.Add("acct_split_bunch", get3b184c4f594a4e5dAd16139e268ea262());
            // 聚合正扫微信拓展参数集合
            // extendInfoMap.Add("wx_data", getEca5a6193ca0415d8858C68b04f2b084());
            // 数字货币扩展参数集合
            // extendInfoMap.Add("digital_currency_data", get2e8257160acc40feA926348d6b93e397());
            // 补贴支付信息
            // extendInfoMap.Add("combinedpay_data", get4ff4cb7c1f3441c3A6e42c67977ba3d5());
            // 备注
            // extendInfoMap.Add("remark", "");
            // 是否垫资退款
            // extendInfoMap.Add("loan_flag", "");
            // 垫资承担者
            // extendInfoMap.Add("loan_undertaker", "");
            // 垫资账户类型
            // extendInfoMap.Add("loan_acct_type", "");
            // 安全信息
            // extendInfoMap.Add("risk_check_data", getCf92bb6eC72f4cb99aecD93ab8feb1ad());
            // 设备信息
            // extendInfoMap.Add("terminal_device_data", get4266b1ebBea34de29bee87926120bbe1());
            // 异步通知地址
            // extendInfoMap.Add("notify_url", "");
            // 银联参数集合
            // extendInfoMap.Add("unionpay_data", getE49018bbB7564fb09a8b095ba2b266e4());
            return extendInfoMap;
        }

        private static object getF34b22c421e84e59Ba80499431bed84a() {
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
        private static string get3b184c4f594a4e5dAd16139e268ea262() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账信息列表
            // obj.Add("acct_infos", getF34b22c421e84e59Ba80499431bed84a());

            return JsonConvert.SerializeObject(obj);
        }
        private static object get5cd41df8Aa5e4da58c2aD4e6e6946efe() {
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
        private static object get0993f7b168404b65Ba8bBd063915d7c8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品详情列表
            // obj.Add("goods_detail", get5cd41df8Aa5e4da58c2aD4e6e6946efe());

            return obj;
        }
        private static string getEca5a6193ca0415d8858C68b04f2b084() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款商品详情
            // obj.Add("detail", get0993f7b168404b65Ba8bBd063915d7c8());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get2e8257160acc40feA926348d6b93e397() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款原因
            // obj.Add("refund_desc", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get4ff4cb7c1f3441c3A6e42c67977ba3d5() {
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
        private static string getCf92bb6eC72f4cb99aecD93ab8feb1ad() {
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
        private static string get4266b1ebBea34de29bee87926120bbe1() {
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
        private static string getE49018bbB7564fb09a8b095ba2b266e4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 收款方附加数据
            // obj.Add("addn_data", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
