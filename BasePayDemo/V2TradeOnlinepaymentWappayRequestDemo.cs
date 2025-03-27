using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 手机WAP支付 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentWappayRequestDemo
    {

        public static void V2TradeOnlinepaymentWappayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentWappayRequest request = new V2TradeOnlinepaymentWappayRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000103124174");
            // 交易金额
            request.setTransAmt("300.01");
            // 分期期数分期支付时必填；支持：03、06、12、24；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：03&lt;/font&gt;；&lt;br/&gt;空值时是wap支付；
            request.setInstalmentsNum("03");
            // 银行卡号instalments_num不为空时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6228480031509440000&lt;/font&gt;
            request.setBankCardNo("6222021102043040313");
            // 网联扩展数据
            request.setExtendPayData(getCf4cb2ef02d648cb9e1b0b20679972ad());
            // 安全信息
            request.setRiskCheckData(get1f8253a4Fbf2498e8907Ca25050286a9());
            // 设备信息
            request.setTerminalDeviceData(getDc79daa055e84e08A6d9Acb7c6852009());
            // 页面跳转地址
            request.setFrontUrl("http://www.baidu.com");
            // 异步通知地址
            request.setNotifyUrl("virgo://http://192.168.25.213:30030/sspc/onlineAsync");

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
            // 延时标记
            extendInfoMap.Add("delay_acct_flag", "N");
            // 交易有效期
            extendInfoMap.Add("time_expire", "20220406210038");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getB6e97b2d46914697Aba811c3a961e747());
            // 备注
            extendInfoMap.Add("remark", "");
            // 页面失败跳转地址
            extendInfoMap.Add("front_fail_url", "http://www.baidu.com");
            return extendInfoMap;
        }

        private static string getCf4cb2ef02d648cb9e1b0b20679972ad() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品简称
            obj.Add("goods_short_name", "一般商品");
            // 网关支付受理渠道
            obj.Add("gw_chnnl_tp", "01");
            // 业务种类
            obj.Add("biz_tp", "123456");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getA82d6734Fde04413B5e365e64f965e1f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付金额
            // obj.Add("div_amt", "");
            // 分账接收方ID
            // obj.Add("huifu_id", "");
            // 账户号
            // obj.Add("acct_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getB6e97b2d46914697Aba811c3a961e747() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账信息列表
            obj.Add("acct_infos", getA82d6734Fde04413B5e365e64f965e1f());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get1f8253a4Fbf2498e8907Ca25050286a9() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // ip地址
            obj.Add("ip_addr", "111");
            // 基站地址
            // obj.Add("base_station", "");
            // 纬度
            // obj.Add("latitude", "");
            // 经度
            // obj.Add("longitude", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getDc79daa055e84e08A6d9Acb7c6852009() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易设备ip
            obj.Add("device_ip", "127.0.0.1");
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
    }
}
