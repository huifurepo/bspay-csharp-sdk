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
            // extendInfoMap.Add("acct_split_bunch", get1f5395ed86894c808813E6a27953c50c());
            // 聚合正扫微信拓展参数集合
            // extendInfoMap.Add("wx_data", get68eb81298737430a8f2b8da59080c888());
            // 数字货币扩展参数集合
            // extendInfoMap.Add("digital_currency_data", getA3f915fbA5294f6b9bb28a7e97c0b3e2());
            // 补贴支付信息
            // extendInfoMap.Add("combinedpay_data", getCe0391ca1e844725857302eb521048b7());
            // 补贴支付手续费承担方信息
            // extendInfoMap.Add("combinedpay_data_fee_info", get61edc7bbFc184f81B1ceDba458180413());
            // 备注
            // extendInfoMap.Add("remark", "");
            // 是否垫资退款
            // extendInfoMap.Add("loan_flag", "");
            // 垫资承担者
            // extendInfoMap.Add("loan_undertaker", "");
            // 垫资账户类型
            // extendInfoMap.Add("loan_acct_type", "");
            // 安全信息
            // extendInfoMap.Add("risk_check_data", get6904788c8d984f0dA5288680f6090a4b());
            // 设备信息
            // extendInfoMap.Add("terminal_device_data", get1526d8190f3f472dB84319c324f39144());
            // 异步通知地址
            // extendInfoMap.Add("notify_url", "");
            // 银联参数集合
            // extendInfoMap.Add("unionpay_data", get0cb4a76928044c648a0e7baee6844270());
            return extendInfoMap;
        }

        private static object get9efcc2a7003245c9990e036c286c99bd() {
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
        private static string get1f5395ed86894c808813E6a27953c50c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账信息列表
            // obj.Add("acct_infos", get9efcc2a7003245c9990e036c286c99bd());

            return JsonConvert.SerializeObject(obj);
        }
        private static object getC97a242f7fbd416d84a7620a344c536e() {
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
        private static object get817b95cf1e3d4353B3ba5c4dcbbe33cd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品详情列表
            // obj.Add("goods_detail", getC97a242f7fbd416d84a7620a344c536e());

            return obj;
        }
        private static string get68eb81298737430a8f2b8da59080c888() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款商品详情
            // obj.Add("detail", get817b95cf1e3d4353B3ba5c4dcbbe33cd());
            // 退款原因
            // obj.Add("refund_desc", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getA3f915fbA5294f6b9bb28a7e97c0b3e2() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款原因
            // obj.Add("refund_desc", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCe0391ca1e844725857302eb521048b7() {
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
        private static string get61edc7bbFc184f81B1ceDba458180413() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴支付手续费承担方汇付编号
            // obj.Add("huifu_id", "");
            // 补贴支付手续费承担方账户号
            // obj.Add("acct_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get6904788c8d984f0dA5288680f6090a4b() {
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
        private static string get1526d8190f3f472dB84319c324f39144() {
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
        private static string get0cb4a76928044c648a0e7baee6844270() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 收款方附加数据
            // obj.Add("addn_data", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
