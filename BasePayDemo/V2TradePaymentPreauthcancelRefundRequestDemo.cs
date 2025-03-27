using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信支付宝预授权撤销 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentPreauthcancelRefundRequestDemo
    {

        public static void V2TradePaymentPreauthcancelRefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePaymentPreauthcancelRefundRequest request = new V2TradePaymentPreauthcancelRefundRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 客户号
            request.setHuifuId("6666000108854952");
            // 原交易请求日期
            request.setOrgReqDate("20221031");
            // 撤销金额
            request.setOrdAmt("0.02");
            // 风控信息
            request.setRiskCheckInfo(getBa2f25bc65d74cb3988e7e446466b598());

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
            // 外部订单号
            extendInfoMap.Add("out_ord_Id", "");
            // 原授权号
            extendInfoMap.Add("org_auth_no", "");
            // 原交易请求流水号
            extendInfoMap.Add("org_req_seq_id", "");
            // 原预授权全局流水号
            extendInfoMap.Add("pre_auth_hf_seq_id", "0029000topB221031162644P959c0a8305400000");
            // 批次号
            extendInfoMap.Add("batch_id", "");
            // 商品描述
            extendInfoMap.Add("good_desc", "");
            // 备注
            extendInfoMap.Add("remark", "");
            // 交易发起时间
            extendInfoMap.Add("send_time", "");
            // 是否人工介入
            extendInfoMap.Add("is_manual_process", "Y");
            // 汇付机具号
            extendInfoMap.Add("devs_id", "SPINTP366020000360401");
            // 商户操作员号
            // extendInfoMap.Add("mer_oper_id", "");
            // 扩展域
            // extendInfoMap.Add("mer_priv", "");
            // 设备信息
            extendInfoMap.Add("terminal_device_info", get79fb2f88C61b423e8bd8B4696ecef9d7());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            return extendInfoMap;
        }

        private static string getBa2f25bc65d74cb3988e7e446466b598() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 基站地址
            obj.Add("base_station", "192.168.1.1");
            // ip地址
            obj.Add("ip_addr", "192.168.1.1");
            // 纬度
            obj.Add("latitude", "33.3");
            // 经度
            obj.Add("longitude", "33.3");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get79fb2f88C61b423e8bd8B4696ecef9d7() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易设备GPS
            obj.Add("device_gps", "192.168.0.0");
            // 交易设备ICCID
            obj.Add("device_icc_id", "");
            // 交易设备IMEI
            obj.Add("device_imei", "");
            // 交易设备IMSI
            obj.Add("device_imsi", "");
            // 交易设备IP
            obj.Add("device_ip", "10.10.0.1");
            // 交易设备MAC
            obj.Add("device_mac", "");
            // 设备类型
            obj.Add("device_type", "1");
            // 交易设备WIFIMAC
            obj.Add("device_wifi_mac", "");
            // 汇付机具号
            obj.Add("devs_id", "SPINTP366061800405501");
            // 操作员号
            obj.Add("mer_oper_id", "");
            // 逻辑终端号
            obj.Add("pnr_dev_id", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
