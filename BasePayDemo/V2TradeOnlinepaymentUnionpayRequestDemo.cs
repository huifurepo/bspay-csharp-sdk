using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银联统一在线收银台 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentUnionpayRequestDemo
    {

        public static void V2TradeOnlinepaymentUnionpayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentUnionpayRequest request = new V2TradeOnlinepaymentUnionpayRequest();
            // 商户号
            request.setHuifuId("6666000109133323");
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 订单金额
            request.setTransAmt("0.11");
            // 商品描述
            request.setOrderDesc("通用性商品1");
            // 安全信息
            request.setRiskCheckData(get72948c317e164ae79d4a93cef8895c95());
            // 三方支付数据jsonObject&lt;br/&gt;pay_scene&#x3D;U_JSAPI或pay_scene&#x3D;U_MINIAPP时，必填
            // request.setThirdPayData(getE6adb6f3591a41ec9c6137c27ca2398d());

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
            // 卡号锁定标识
            extendInfoMap.Add("card_number_lock", "");
            // 直通模式的银行标识
            extendInfoMap.Add("ebank_en_abbr", "");
            // 交易银行卡卡号
            extendInfoMap.Add("pay_card_no", "");
            // 支付卡类型
            // extendInfoMap.Add("pay_card_type", "");
            // 订单失效时间
            extendInfoMap.Add("time_expire", "");
            // 前端跳转地址
            extendInfoMap.Add("front_url", "https://www.service.com/getresp");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "https://www.service.com/getresp");
            // 备注
            extendInfoMap.Add("remark", "merPriv11");
            // 支付场景
            // extendInfoMap.Add("pay_scene", "");
            // 签约令牌号
            // extendInfoMap.Add("sign_token_no", "");
            // 延时标记
            extendInfoMap.Add("delay_acct_flag", "Y");
            // 手续费扣款标志
            // extendInfoMap.Add("fee_flag", "");
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", get938f9796E5bd4f85A4cf2ce4a306837d());
            // 设备信息数据
            // extendInfoMap.Add("terminal_device_data", get86e6396a54f5492cB3b06678723bed4b());
            return extendInfoMap;
        }

        private static object get0aa0431065074e9f92016d99005ce03e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
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
        private static string get938f9796E5bd4f85A4cf2ce4a306837d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            // obj.Add("acct_infos", get0aa0431065074e9f92016d99005ce03e());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get72948c317e164ae79d4a93cef8895c95() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 基站地址
            obj.Add("base_station", "7");
            // ip地址
            obj.Add("ip_addr", "172.28.52.52");
            // 纬度
            obj.Add("latitude", "4");
            // 经度
            obj.Add("longitude", "3");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getE6adb6f3591a41ec9c6137c27ca2398d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 小程序id
            // obj.Add("app_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get86e6396a54f5492cB3b06678723bed4b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 终端设备号
            // obj.Add("device_id", "test");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
