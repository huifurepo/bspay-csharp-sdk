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
            request.setRiskCheckData(get24cac05aE51448a1960b54ff953dcaf2());
            // 三方支付数据jsonObject；pay_scene为云闪付公众号与云闪付小程序时必填
            // request.setThirdPayData(get7945798a32654321Bea45a70676268d8());

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
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", get4629873c1e2342f689ccE0172d96371f());
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
            return extendInfoMap;
        }

        private static object get10d0f278Ee0e4dedB75b4d7f64376944() {
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
        private static string get4629873c1e2342f689ccE0172d96371f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            // obj.Add("acct_infos", get10d0f278Ee0e4dedB75b4d7f64376944());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get24cac05aE51448a1960b54ff953dcaf2() {
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
        private static string get7945798a32654321Bea45a70676268d8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 小程序id
            // obj.Add("app_id", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
