using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 线上交易退款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentRefundRequestDemo
    {

        public static void V2TradeOnlinepaymentRefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentRefundRequest request = new V2TradeOnlinepaymentRefundRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000109133323");
            // 退款金额
            request.setOrdAmt("0.01");
            // 设备信息条件必填，当为银行大额支付时可不填，jsonObject格式
            request.setTerminalDeviceData(get75ed576a25334009B39c9a32ba35a82c());
            // 安全信息条件必填，当为银行大额支付时可不填，jsonObject格式
            request.setRiskCheckData(getE9afd6ee9b9d4d3792ecD7fece10e129());

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
            // 原交易请求日期
            extendInfoMap.Add("org_req_date", "20240401");
            // 原交易全局流水号
            extendInfoMap.Add("org_hf_seq_id", "");
            // 原交易请求流水号
            extendInfoMap.Add("org_req_seq_id", "295700155481522176");
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", getAdb4ca3e488f4d15Bce4257e00e08036());
            // 备注
            // extendInfoMap.Add("remark", "");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            // 补贴支付信息
            // extendInfoMap.Add("combinedpay_data", get270ca5b037324d64B30165369e52c256());
            // 大额转账支付账户信息数据
            // extendInfoMap.Add("bank_info_data", getF6a68fdf9cbc4bc3Ba31B8362ac62484());
            // 是否垫资
            // extendInfoMap.Add("loan_flag", "");
            // 垫资承担者
            // extendInfoMap.Add("loan_undertaker", "");
            // 垫资账户类型
            // extendInfoMap.Add("loan_acct_type", "");
            return extendInfoMap;
        }

        private static object get089d1506323646b3Be73F47b7c92e50e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户号
            // obj.Add("huifu_id", "test");
            // 支付金额
            // obj.Add("div_amt", "");
            // 账户号
            // obj.Add("acct_id", "");
            // 垫资金额
            // obj.Add("part_loan_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getAdb4ca3e488f4d15Bce4257e00e08036() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账信息列表
            // obj.Add("acct_infos", get089d1506323646b3Be73F47b7c92e50e());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get75ed576a25334009B39c9a32ba35a82c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易设备ip
            obj.Add("device_ip", "172.31.31.145");
            // 设备类型
            obj.Add("device_type", "1");
            // 交易设备gps
            obj.Add("device_gps", "07");
            // 交易设备iccid
            obj.Add("device_icc_id", "05");
            // 交易设备imei
            obj.Add("device_imei", "02");
            // 交易设备imsi
            obj.Add("device_imsi", "03");
            // 交易设备mac
            obj.Add("device_mac", "01");
            // 交易设备wifimac
            obj.Add("device_wifi_mac", "06");
            // 终端设备号
            // obj.Add("device_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getE9afd6ee9b9d4d3792ecD7fece10e129() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 经度
            // obj.Add("longitude", "test");
            // 纬度
            // obj.Add("latitude", "test");
            // 基站地址
            // obj.Add("base_station", "test");
            // ip地址
            obj.Add("ip_addr", "172.1.1.1");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get270ca5b037324d64B30165369e52c256() {
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
        private static string getF6a68fdf9cbc4bc3Ba31B8362ac62484() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 省份
            // obj.Add("province", "");
            // 地区
            // obj.Add("area", "");
            // 银行编号
            // obj.Add("bank_code", "");
            // 联行号
            // obj.Add("correspondent_code", "");
            // 付款方账户类型
            // obj.Add("card_acct_type", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
