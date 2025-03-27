using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 快捷短信发送 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradeOnlinepaymentQuickpaySmssendRequestDemo
    {

        public static void V3TradeOnlinepaymentQuickpaySmssendRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3TradeOnlinepaymentQuickpaySmssendRequest request = new V3TradeOnlinepaymentQuickpaySmssendRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000109133323");
            // 用户客户号
            request.setUserHuifuId("6666000149909053");
            // 绑卡id
            request.setCardBindId("10049847200");
            // 订单金额
            request.setTransAmt("10.00");
            // 异步通知地址
            request.setNotifyUrl("http://tianyi.demo.test.cn/core/extend/BsPaySdk/notify_quick.php");
            // 网联数据
            // request.setNuccData(getA552c831Cd0846b8830f0ce1be990e53());
            // 设备数据
            request.setTerminalDeviceData(getEb10401d27a0468aA840Fd020391c341());
            // 安全信息
            request.setRiskCheckData(getBe09da814577476eA71c6d47f2fac2ac());

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
            // 订单类型
            // extendInfoMap.Add("order_type", "");
            // 备注
            // extendInfoMap.Add("remark", "");
            // 订单失效时间
            // extendInfoMap.Add("time_expire", "");
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", get0fda4a7803b94a2fB5f17a083f8b015f());
            // 是否延迟交易
            // extendInfoMap.Add("delay_acct_flag", "");
            // 账户号
            // extendInfoMap.Add("acct_id", "");
            // 手续费扣款标志
            // extendInfoMap.Add("fee_flag", "");
            // 补贴支付信息
            // extendInfoMap.Add("combinedpay_data", get79bd2ee956e844ee8bb65e2f3ebf8096());
            return extendInfoMap;
        }

        private static object getAdfb77e661f444deB2ddF0631bb7f4d4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账接收方ID
            // obj.Add("huifu_id", "test");
            // 分账金额
            // obj.Add("div_amt", "");
            // 账户号
            // obj.Add("acct_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get0fda4a7803b94a2fB5f17a083f8b015f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");
            // 分账信息列表，Array格式
            // obj.Add("acct_infos", getAdfb77e661f444deB2ddF0631bb7f4d4());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getA552c831Cd0846b8830f0ce1be990e53() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品简称
            // obj.Add("goods_short_name", "test");
            // 网关支付受理渠道
            // obj.Add("gw_chnnl_tp", "test");
            // 业务种类
            // obj.Add("biz_tp", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getEb10401d27a0468aA840Fd020391c341() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 设备类型
            obj.Add("device_type", "1");
            // 交易设备ip
            obj.Add("device_ip", "106.33.180.238");
            // 交易设备mac
            // obj.Add("device_mac", "");
            // 交易设备imei
            // obj.Add("device_imei", "");
            // 交易设备imsi
            // obj.Add("device_imsi", "");
            // 交易设备iccid
            // obj.Add("device_icc_id", "");
            // 交易设备wifimac
            // obj.Add("device_wifi_mac", "");
            // 交易设备gps
            // obj.Add("device_gps", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getBe09da814577476eA71c6d47f2fac2ac() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // ip地址
            obj.Add("ip_addr", "106.33.180.238");
            // 基站地址
            // obj.Add("base_station", "");
            // 纬度
            // obj.Add("latitude", "");
            // 经度
            // obj.Add("longitude", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get79bd2ee956e844ee8bb65e2f3ebf8096() {
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
