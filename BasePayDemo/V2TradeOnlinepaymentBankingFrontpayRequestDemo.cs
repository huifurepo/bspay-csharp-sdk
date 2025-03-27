using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 网银支付 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentBankingFrontpayRequestDemo
    {

        public static void V2TradeOnlinepaymentBankingFrontpayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentBankingFrontpayRequest request = new V2TradeOnlinepaymentBankingFrontpayRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000109133323");
            // 订单金额
            request.setTransAmt("0.02");
            // 商品描述
            request.setGoodsDesc("网银支付下单");
            // 网联扩展数据
            request.setExtendPayData(get3194e7baDdea4c7188127b568d867933());
            // 设备信息
            request.setTerminalDeviceData(get311c0af960b243a4Ae3797b5e7958321());
            // 安全信息
            request.setRiskCheckData(get3189111156d949719cc958f824f77fbd());
            // 异步通知地址
            request.setNotifyUrl("http://www.chinapnr.com");

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
            // 收款汇付账户号
            extendInfoMap.Add("acct_id", "");
            // 订单类型
            extendInfoMap.Add("order_type", "P");
            // 付款方银行编号
            extendInfoMap.Add("bank_id", "");
            // 卡类型
            extendInfoMap.Add("card_type", "D");
            // 备注
            extendInfoMap.Add("remark", "网银支付接口");
            // 订单失效时间
            extendInfoMap.Add("time_expire", "");
            // 网关支付类型
            extendInfoMap.Add("gate_type", "01");
            // 延时标记
            extendInfoMap.Add("delay_acct_flag", "N");
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", get25c8debcE5ba43afAcd2738c16b98199());
            // 手续费扣款标志
            // extendInfoMap.Add("fee_flag", "");
            // 页面跳转地址
            extendInfoMap.Add("front_url", "http://www.chinapnr.com");
            return extendInfoMap;
        }

        private static object getD0d7f539767c4784A84eA384d0e3ee19() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            // obj.Add("div_amt", "");
            // 分账接收方ID
            // obj.Add("huifu_id", "");
            // 接收方账户号
            // obj.Add("acct_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get25c8debcE5ba43afAcd2738c16b98199() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            // obj.Add("acct_infos", getD0d7f539767c4784A84eA384d0e3ee19());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get3194e7baDdea4c7188127b568d867933() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品简称
            obj.Add("goods_short_name", "011111");
            // 网关支付受理渠道
            obj.Add("gw_chnnl_tp", "01");
            // 业务种类
            obj.Add("biz_tp", "123451");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get311c0af960b243a4Ae3797b5e7958321() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易设备类型
            obj.Add("device_type", "1");
            // 交易设备IP
            obj.Add("device_ip", "127.0.0.1");
            // 交易设备MAC
            // obj.Add("device_mac", "");
            // 交易终端设备IMEI
            // obj.Add("device_imei", "");
            // 交易设备IMSI
            // obj.Add("device_imsi", "");
            // 交易设备ICCID
            // obj.Add("device_icc_id", "");
            // 交易设备WIFIMAC
            // obj.Add("device_wifi_mac", "");
            // 交易设备GPS
            // obj.Add("device_gps", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get3189111156d949719cc958f824f77fbd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // ip地址
            obj.Add("ip_addr", "1");
            // 基站地址
            obj.Add("base_station", "2");
            // 纬度
            obj.Add("latitude", "3");
            // 经度
            obj.Add("longitude", "4");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
