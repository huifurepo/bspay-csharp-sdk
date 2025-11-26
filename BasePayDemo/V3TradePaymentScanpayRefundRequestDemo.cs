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
            // extendInfoMap.Add("acct_split_bunch", get4629bffb4aeb4056BccfD91677682781());
            // 聚合正扫微信拓展参数集合
            // extendInfoMap.Add("wx_data", get8127ea82Bb624aa79327Cc2f375d3de1());
            // 数字货币扩展参数集合
            // extendInfoMap.Add("digital_currency_data", get200ed59d3a0446c68e4c07c854b89648());
            // 补贴支付信息
            // extendInfoMap.Add("combinedpay_data", getC44b0e407056405aAd573d294d10ef39());
            // 补贴支付手续费承担方信息
            // extendInfoMap.Add("combinedpay_data_fee_info", get3920c70aA6c149efBce679fc1c8d0819());
            // 备注
            // extendInfoMap.Add("remark", "");
            // 是否垫资退款
            // extendInfoMap.Add("loan_flag", "");
            // 垫资承担者
            // extendInfoMap.Add("loan_undertaker", "");
            // 垫资账户类型
            // extendInfoMap.Add("loan_acct_type", "");
            // 安全信息
            // extendInfoMap.Add("risk_check_data", get0b045ad32faa435bBd5574b03e9e9e98());
            // 设备信息
            // extendInfoMap.Add("terminal_device_data", get411d7c00147943a3965dF6bba761ee53());
            // 异步通知地址
            // extendInfoMap.Add("notify_url", "");
            // 银联参数集合
            // extendInfoMap.Add("unionpay_data", getCc367526F93249e6A323E13395783a0a());
            return extendInfoMap;
        }

        private static object get87cc28b5Fc79456cB1a59d08e88fe304() {
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
        private static string get4629bffb4aeb4056BccfD91677682781() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账信息列表
            // obj.Add("acct_infos", get87cc28b5Fc79456cB1a59d08e88fe304());

            return JsonConvert.SerializeObject(obj);
        }
        private static object get0059e5f35941405694a8B9ff28bd7946() {
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
        private static object get0dbb50d42cbf47d9Bf0929cb435e6de5() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品详情列表
            // obj.Add("goods_detail", get0059e5f35941405694a8B9ff28bd7946());

            return obj;
        }
        private static string get8127ea82Bb624aa79327Cc2f375d3de1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款商品详情
            // obj.Add("detail", get0dbb50d42cbf47d9Bf0929cb435e6de5());
            // 退款原因
            // obj.Add("refund_desc", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get200ed59d3a0446c68e4c07c854b89648() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款原因
            // obj.Add("refund_desc", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getC44b0e407056405aAd573d294d10ef39() {
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
        private static string get3920c70aA6c149efBce679fc1c8d0819() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 补贴支付手续费承担方汇付编号
            // obj.Add("huifu_id", "");
            // 补贴支付手续费承担方账户号
            // obj.Add("acct_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get0b045ad32faa435bBd5574b03e9e9e98() {
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
        private static string get411d7c00147943a3965dF6bba761ee53() {
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
        private static string getCc367526F93249e6A323E13395783a0a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 收款方附加数据
            // obj.Add("addn_data", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
