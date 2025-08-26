using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 代扣支付 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentWithholdpayRequestDemo
    {

        public static void V2TradeOnlinepaymentWithholdpayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentWithholdpayRequest request = new V2TradeOnlinepaymentWithholdpayRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000109812884");
            // 用户客户号
            request.setUserHuifuId("6666000109818115");
            // 绑卡id
            request.setCardBindId("10024597199");
            // 订单金额
            request.setTransAmt("0.01");
            // 商品描述
            request.setGoodsDesc("代扣test");
            // 代扣类型
            request.setWithholdType("2");
            // 异步通知地址
            request.setNotifyUrl("http://www.chinapnr.com/");
            // 银行扩展数据
            request.setExtendPayData(getBc0e9e11Ebff43daB92bE7ea5bd7bdad());
            // 风控信息
            request.setRiskCheckData(get6d53968b60e147a197e6D79df28ee365());
            // 设备信息数据
            request.setTerminalDeviceData(get8d44fde70e4249e882ce8efb9fbc3271());

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
            // 备注
            extendInfoMap.Add("remark", "reamrk123");
            // 账户号
            // extendInfoMap.Add("acct_id", "");
            // 订单失效时间
            extendInfoMap.Add("time_expire", "20221212121212");
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", getAef0b506B3fe41ff8743B17ba618b928());
            // 补贴支付信息
            // extendInfoMap.Add("combinedpay_data", getD5fdec34Fc2744729c6968ab05d267b6());
            return extendInfoMap;
        }

        private static object get64536140Aaa8449a8dfa21cf20fb67b2() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付金额
            // obj.Add("div_amt", "");
            // 商户号
            // obj.Add("huifu_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getAef0b506B3fe41ff8743B17ba618b928() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账信息列表
            // obj.Add("acct_infos", get64536140Aaa8449a8dfa21cf20fb67b2());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getBc0e9e11Ebff43daB92bE7ea5bd7bdad() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务种类
            obj.Add("biz_tp", "012345");
            // 商品简称
            obj.Add("goods_short_name", "看看");
            // 网关支付受理渠道
            // obj.Add("gw_chnnl_tp", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get6d53968b60e147a197e6D79df28ee365() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 基站地址经纬度、基站地址、IP地址三组信息至少填写一组；&lt;br/&gt;【mcc】+【mnc】+【location_cd】+【lbs_num】&lt;br/&gt;- mcc:移动国家代码，460代表中国；3位长&lt;br/&gt;- mnc：移动网络号码；2位长；&lt;br/&gt;- location_cd：位置区域码，16进制，5位长&lt;br/&gt;- lbs_num：基站编号，16进制，5位长&lt;br/&gt;- 注意若位数不足用空格补足；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：460001039217563&lt;/font&gt;，460（mcc)， 00(mnc)，10392(location_cd)， 17563(lbs_num)
            obj.Add("base_station", "");
            // ip地址经纬度、基站地址、IP地址三组信息至少填写一组；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：172.28.52.52&lt;/font&gt;
            obj.Add("ip_addr", "192.168.1.1");
            // 纬度纬度整数位不超过2位，小数位不超过6位。格式为：+表示北纬，-表示南纬。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：+37.12&lt;/font&gt;；&lt;br/&gt;经纬度、基站地址、IP地址三组信息至少填写一组
            obj.Add("latitude", "");
            // 经度经度整数位不超过3位，小数位不超过5位；格式为:+表示东经，-表示西经。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：-121.213&lt;/font&gt;；&lt;br/&gt;经纬度、基站地址、IP地址三组信息至少填写一组
            obj.Add("longitude", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get8d44fde70e4249e882ce8efb9fbc3271() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易设备ip
            obj.Add("device_ip", "172.31.31.145");
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
        private static string getD5fdec34Fc2744729c6968ab05d267b6() {
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
