using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 快捷支付申请 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentQuickpayApplyRequestDemo
    {

        public static void V2TradeOnlinepaymentQuickpayApplyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentQuickpayApplyRequest request = new V2TradeOnlinepaymentQuickpayApplyRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000119640000");
            // 订单金额
            request.setTransAmt("1980.00");
            // 绑卡id
            request.setCardBindId("10032850000");
            // 异步通知地址
            request.setNotifyUrl("http://tianyi.demo.test.cn/core/extend/BsPaySdk/notify_quick.php");
            // 用户客户号
            request.setUserHuifuId("6666000121370000");
            // 安全信息
            request.setRiskCheckData(getRiskCheckData());
            // 设备数据
            request.setTerminalDeviceData(getTerminalDeviceData());
            // 银行扩展字段
            request.setExtendPayData(getExtendPayData());

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
            // 营销补贴信息
            // extendInfoMap.Add("combinedpay_data", getCombinedpayData());
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", getAcctSplitBunchRucan());
            // 是否延迟交易
            // extendInfoMap.Add("delay_acct_flag", "");
            return extendInfoMap;
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
        private static string getTerminalDeviceData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易设备ip
            obj.Add("device_ip", "106.33.180.238");
            // 设备类型
            obj.Add("device_type", "1");
            // 交易设备gps
            // obj.Add("device_gps", "");
            // 交易设备iccid
            // obj.Add("device_icc_id", "");
            // 交易设备imei
            // obj.Add("device_imei", "");
            // 交易设备imsi
            // obj.Add("device_imsi", "");
            // 交易设备mac
            // obj.Add("device_mac", "");
            // 交易设备wifimac
            // obj.Add("device_wifi_mac", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getRiskCheckData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // ip地址
            obj.Add("ip_addr", "106.33.180.238");
            // 基站地址
            // obj.Add("base_atation", "");
            // 纬度
            // obj.Add("latitude", "");
            // 经度
            // obj.Add("longitude", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getAcctInfos() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            // obj.Add("div_amt", "");
            // 被分账方ID
            // obj.Add("huifu_id", "");
            // 账户号
            // obj.Add("acct_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getExtendPayData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务种类
            // obj.Add("biz_tp", "test");
            // 商品简称
            // obj.Add("goods_short_name", "test");
            // 网关支付受理渠道
            obj.Add("gw_chnnl_tp", "99");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAcctSplitBunchRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账信息列表
            // obj.Add("acct_infos", getAcctInfos());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
