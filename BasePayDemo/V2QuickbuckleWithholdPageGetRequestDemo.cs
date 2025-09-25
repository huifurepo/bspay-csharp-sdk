using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 代扣绑卡页面版 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleWithholdPageGetRequestDemo
    {

        public static void V2QuickbuckleWithholdPageGetRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2QuickbuckleWithholdPageGetRequest request = new V2QuickbuckleWithholdPageGetRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付Id
            request.setHuifuId("6666000103422897");
            // 订单号
            request.setOrderId("SAS20230807102136898274149");
            // 订单日期
            request.setOrderDate("20230807");

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
            // 页面有效期
            extendInfoMap.Add("expire_time", "20");
            // 页面跳转地址
            extendInfoMap.Add("return_url", "https://api.huifu.com");
            // 客户用户号
            extendInfoMap.Add("out_cust_id", "Q837467382819");
            // 用户汇付号
            extendInfoMap.Add("user_huifu_id", "6666000107386236");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "https://api.huifu.com");
            // 设备信息域
            extendInfoMap.Add("trx_device_info", get3cdad4d518854dd2Bf7f01c72ccc95e0());
            // 风控信息
            extendInfoMap.Add("risk_info", getB0c9212aAf3346629c9aB1f11b8075e2());
            // 代扣绑卡类型
            // extendInfoMap.Add("binding_card_type", "");
            return extendInfoMap;
        }

        private static object get3cdad4d518854dd2Bf7f01c72ccc95e0() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行预留手机号
            obj.Add("trx_mobile_num", "13428722321");
            // 设备类型
            obj.Add("trx_device_type", "1");
            // 交易设备IP
            obj.Add("trx_device_ip", "192.168.1.1");
            // 交易设备MAC
            obj.Add("trx_device_mac", "10.10.0.1");
            // 交易设备IMEI
            obj.Add("trx_device_imei", "imei");
            // 交易设备IMSI
            obj.Add("trx_device_imsi", "imsi");
            // 交易设备ICCID
            obj.Add("trx_device_icc_id", "icc");
            // 交易设备WIFIMAC
            obj.Add("trx_device_wfifi_mac", "wfifi");
            // 交易设备GPS
            obj.Add("trx_device_gps", "gps");

            return obj;
        }
        private static object getB0c9212aAf3346629c9aB1f11b8075e2() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // IP类型
            obj.Add("ip_type", "04");
            // IP值
            obj.Add("source_ip", "1.1.1.1");
            // 设备标识
            obj.Add("device_id", "");
            // 设备类型
            obj.Add("device_type", "");
            // 银行预留手机号
            obj.Add("mobile", "");
            // 协议编号
            // obj.Add("agreement_no", "");
            // 协议地址
            // obj.Add("agreement_url", "");

            return obj;
        }
    }
}
