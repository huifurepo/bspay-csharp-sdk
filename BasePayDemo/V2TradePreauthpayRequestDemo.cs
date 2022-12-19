using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信支付宝预授权完成 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePreauthpayRequestDemo
    {

        public static void V2TradePreauthpayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePreauthpayRequest request = new V2TradePreauthpayRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000108854952");
            // 原交易请求日期
            request.setOrgReqDate("20221031");
            // 交易金额
            request.setTransAmt("0.02");
            // 商品描述
            request.setGoodsDesc("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567");
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
            // 外部订单号
            extendInfoMap.Add("out_ord_id", "12345678901234567890123456789012");
            // 原授权号
            extendInfoMap.Add("org_auth_no", "");
            // 原预授权交易请求流水号
            extendInfoMap.Add("org_req_seq_id", "");
            // 预授权汇付全局流水号
            extendInfoMap.Add("pre_auth_hf_seq_id", "0029000topB221031163126P798c0a8305400000");
            // 交易发起时间
            extendInfoMap.Add("send_time", "12345678901234567");
            // 是否立即入账
            extendInfoMap.Add("is_settled", "1");
            // 备注
            extendInfoMap.Add("remark", "123451111");
            // 批次号
            // extendInfoMap.Add("batch_id", "");
            // 商户操作员号
            // extendInfoMap.Add("mer_oper_id", "");
            // 扩展域
            // extendInfoMap.Add("mer_priv", "");
            // 设备信息
            extendInfoMap.Add("terminal_device_data", getTerminalDeviceData());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            return extendInfoMap;
        }

        private static string getTerminalDeviceData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户终端序列号
            obj.Add("app_version", "");
            // 交易设备GPS
            obj.Add("device_gps", "");
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
            obj.Add("devs_id", "");
            // ICCID
            obj.Add("icc_id", "");
            // 商户终端实时经纬度信息
            obj.Add("location", "+32.10520/+118.80593");
            // 商户交易设备IP
            obj.Add("mer_device_ip", "");
            // 商户设备类型
            obj.Add("mer_device_type", "01");
            // 移动国家代码
            obj.Add("mobile_country_cd", "");
            // 移动网络号码
            obj.Add("mobile_net_num", "");
            // 商户终端入网认证编号
            obj.Add("network_license", "P3111");
            // 商户终端序列号
            obj.Add("serial_num", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getRiskCheckData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 基站地址
            obj.Add("base_station", "192.168.1.1");
            // ip地址
            obj.Add("ip_addr", "180.167.105.130");
            // 纬度
            obj.Add("latitude", "33.3");
            // 经度
            obj.Add("longitude", "33.3");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
