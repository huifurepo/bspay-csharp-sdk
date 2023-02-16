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
            request.setHuifuId("6666000108854952");
            // 退款金额
            request.setOrdAmt("0.01");
            // 设备信息
            request.setTerminalDeviceData(getTerminalDeviceData());
            // 安全信息
            request.setRiskCheckData(getRiskCheckData());

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
            // 原交易请求流水号
            extendInfoMap.Add("org_req_seq_id", "RQ1212333113");
            // 原交易请求日期
            extendInfoMap.Add("org_req_date", "20221110");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            // 备注
            extendInfoMap.Add("remark", "remark123");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getAcctSplitBunchRucan());
            // 营销补贴信息
            extendInfoMap.Add("combinedpay_data", getCombinedpayData());
            return extendInfoMap;
        }

        private static object getAcctInfosRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户号
            // obj.Add("huifu_id", "");
            // 支付金额
            // obj.Add("div_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getAcctSplitBunchRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账信息列表
            // obj.Add("acct_infos", getAcctInfosRucan());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getTerminalDeviceData() {
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

            return JsonConvert.SerializeObject(obj);
        }
        private static string getRiskCheckData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // ip地址
            // obj.Add("ip_addr", "");
            // 基站地址
            // obj.Add("base_atation", "");
            // 纬度
            // obj.Add("latitude", "");
            // 经度
            // obj.Add("longitude", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCombinedpayData() {
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
    }
}
