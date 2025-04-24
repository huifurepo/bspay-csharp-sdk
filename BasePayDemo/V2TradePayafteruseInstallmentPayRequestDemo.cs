using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 分期扣款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayafteruseInstallmentPayRequestDemo
    {

        public static void V2TradePayafteruseInstallmentPayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePayafteruseInstallmentPayRequest request = new V2TradePayafteruseInstallmentPayRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 客户号
            request.setHuifuId("6666000108281250");
            // 交易金额
            request.setTransAmt("0.01");
            // 商品描述
            request.setGoodsDesc("聚合反扫消费");
            // 风控信息
            request.setRiskCheckData(get5f3a85d0F5914afaAcacBad2c1d9d0c1());
            // 支付宝扩展参数集合
            request.setAlipayData(getDc737f3f10584db087acA3bf4f00e91f());

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
            // 入账账户号
            extendInfoMap.Add("acct_id", "C02682415");
            // 交易备注
            extendInfoMap.Add("remark", "");
            // 是否延迟交易
            // extendInfoMap.Add("delay_acct_flag", "");
            // 分账串
            // extendInfoMap.Add("acct_split_bunch", getE3ae9a478aec40059dbc91aa66aa0d21());
            // 设备信息
            extendInfoMap.Add("terminal_device_info", getF7961ae67c874fb28754F33b592b7720());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            return extendInfoMap;
        }

        private static object get160495108cc94a02B915A460403ce173() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账接收方商户号
            // obj.Add("huifu_id", "test");
            // 分账金额
            // obj.Add("div_amt", "");
            // 分账接收方账户号
            // obj.Add("acct_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getE3ae9a478aec40059dbc91aa66aa0d21() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");
            // 分账明细
            // obj.Add("acct_infos", get160495108cc94a02B915A460403ce173());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get5f3a85d0F5914afaAcacBad2c1d9d0c1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // IP地址
            // obj.Add("ip_addr", "test");
            // 经度
            obj.Add("longitude", "1");
            // 纬度
            obj.Add("latitude", "2");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getF7961ae67c874fb28754F33b592b7720() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户设备类型
            obj.Add("mer_device_type", "01");
            // 商户终端实时经纬度信息
            obj.Add("location", "+32.10520/+118.80593");
            // 商户交易设备IP
            obj.Add("mer_device_ip", "10.11.12.13");
            // 设备类型
            obj.Add("device_type", "1");
            // 交易设备IP
            obj.Add("device_ip", "10.10.0.1");
            // 交易设备MAC
            obj.Add("device_mac", "F0E1D2C3B4A5");
            // 交易设备GPS
            obj.Add("device_gps", "20.346790");
            // 交易设备IMEI
            obj.Add("device_imei", "660035730311000126101");
            // 交易设备IMSI
            obj.Add("device_imsi", "460030912121001");
            // 交易设备ICCID
            obj.Add("device_icc_id", "660035730311000126101");
            // 交易设备WIFIMAC
            obj.Add("device_wifi_mac", "968778695A4B");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get8b2931c7A3cf4d4698bfEd6b6cb91b1f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品的编号
            // obj.Add("goods_id", "test");
            // 商品名称
            // obj.Add("goods_name", "test");
            // 商品数量
            // obj.Add("quantity", "test");
            // 商品单价
            // obj.Add("price", "test");
            // 商品类目
            // obj.Add("goods_category", "");
            // 商品描述信息
            // obj.Add("body", "");
            // 商品的展示地址
            // obj.Add("show_url", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get4449220bC6ae41b49391E552f87d642b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务主单号
            obj.Add("trade_component_order_id", "2024101001502300000002570023887054");
            // 分期履约单号
            obj.Add("tc_installment_order_id", "2024101001502301900002570004797346");
            // 系统商编号
            // obj.Add("sys_service_provider_id", "");

            return obj;
        }
        private static string getDc737f3f10584db087acA3bf4f00e91f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务扩展参数
            obj.Add("extend_params", get4449220bC6ae41b49391E552f87d642b());
            // 支付宝的店铺编号
            obj.Add("alipay_store_id", "");
            // 商户操作员编号
            // obj.Add("operator_id", "");
            // 商户业务信息
            // obj.Add("ali_business_params", "");
            // 订单包含的商品列表信息
            // obj.Add("goods_detail", get8b2931c7A3cf4d4698bfEd6b6cb91b1f());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
