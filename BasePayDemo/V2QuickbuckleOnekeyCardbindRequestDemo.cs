using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 一键绑卡 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleOnekeyCardbindRequestDemo
    {

        public static void V2QuickbuckleOnekeyCardbindRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2QuickbuckleOnekeyCardbindRequest request = new V2QuickbuckleOnekeyCardbindRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付Id
            request.setHuifuId("6666000003078984");
            // 顾客用户号 
            request.setOutCustId("6666000103633619");
            // 银行号
            request.setBankId("01030000");
            // 银行卡开户姓名 
            request.setCardName("YTRf65hBDkH9UU1AwG16r4Nlc/X1rH6ejKbvmqT80exJ6whdHI1zB+izBtNBOJfhRNbIOhi1FrRuE5b7wnt/03Q+vwWQQLDGJXWZf92yp+eIRDHg8JdbjOgxKvF2q4Qw5704jbsjQm4UJW5fqRhzRPtnnAL9zzTSgVhuQ0KCwc8=");
            // 银行卡绑定身份证
            request.setCertId("gk8zqa+zvIUAvzV3Bjzzw+vRgq2LgTzQI8PRoqUdbeuFMbFZ6LllQpcOhWIz6F82VtFBKzLd5kPOaCwlQCiwsXhSqUFB11zgzKUtVIuiv9lHY/EsjRwqDBhgeR5f2H9FXr3wQ9f7bI7t8ca9o93QxrXr/1MDBq7fGok0xu2ytsM=");
            // 银行卡绑定证件类型
            request.setCertType("00");
            // 证件有效期到期日长期有效不填.格式：yyyyMMdd。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20311111&lt;/font&gt;
            request.setCertEndDate("20370121");
            // 银行卡绑定手机号 
            request.setCardMp("e2zKkJ6PE6UtZhgz42pqgPLQh6p83/WJsG7EVSgYYgN+7MIiCzXnjTpmpv0Cgv7cYTbQTBf/NF5jqeI8BpFjP7C6gg+0cjqW2tgdVxyfqZLu2fEJRth7NgZKgS2ZKbkZ8PNfUk7V+aHbqkAVKY92bdcSQSNIuWaJCeIF34w+l+k=");
            // 卡的借贷类型
            request.setDcType("D");
            // 异步请求地址
            request.setAsyncReturnUrl("http://192.168.85.157:30031/sspm/testVirgo");
            // 设备信息域
            request.setTrxDeviceInf(getTrxDeviceInf());

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
            // 证件有效期类型
            extendInfoMap.Add("cert_validity_type", "0");
            // 证件有效期起始日
            extendInfoMap.Add("cert_begin_date", "20170121");
            // 挂网协议编号
            extendInfoMap.Add("protocol_no", "");
            // 风控信息
            // extendInfoMap.Add("risk_info", getRiskInfo());
            return extendInfoMap;
        }

        private static string getRiskInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // IP类型
            // obj.Add("ip_type", "test");
            // IP值
            // obj.Add("source_ip", "test");
            // 设备标识
            // obj.Add("device_id", "");
            // 设备类型
            // obj.Add("device_type", "");
            // 应用提供方账户ID
            // obj.Add("account_id_hash", "");
            // 银行预留手机号
            // obj.Add("mobile", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getTrxDeviceInf() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行预留手机号
            obj.Add("trx_mobile_num", "15556622368");
            // 设备类型
            obj.Add("trx_device_type", "1");
            // 交易设备IP
            obj.Add("trx_device_ip", "10.10.0.1");
            // 交易设备MAC
            obj.Add("trx_device_mac", "10.10.0.1");
            // 交易设备IMEI
            obj.Add("trx_device_imei", "030147441006000182623");
            // 交易设备IMSI
            obj.Add("trx_device_imsi", "030147441006000182623");
            // 交易设备ICCID
            obj.Add("trx_device_icc_id", "030147441006000182623");
            // 交易设备WIFIMAC
            obj.Add("trx_device_wfifi_mac", "030147441006000182623");
            // 交易设备GPS
            obj.Add("trx_device_gps", "030147441006000182623");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
