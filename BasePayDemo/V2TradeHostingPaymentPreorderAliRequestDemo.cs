using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 支付宝小程序预下单接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentPreorderAliRequestDemo
    {

        public static void V2TradeHostingPaymentPreorderAliRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeHostingPaymentPreorderAliRequest request = new V2TradeHostingPaymentPreorderAliRequest();
            // 商户号
            request.setHuifuId("6666000111546360");
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 预下单类型
            request.setPreOrderType("2");
            // 交易金额
            request.setTransAmt("0.10");
            // 商品描述
            request.setGoodsDesc("app跳支付宝消费");
            // app扩展参数集合
            request.setAppData(getAppData());

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
            // 收银台ID
            extendInfoMap.Add("checkout_id", "");
            // 是否延迟交易
            extendInfoMap.Add("delay_acct_flag", "N");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getAcctSplitBunchRucan());
            // 异步通知地址
            extendInfoMap.Add("notify_url", "https://callback.service.com/xx");
            // 交易失效时间
            // extendInfoMap.Add("time_expire", "");
            return extendInfoMap;
        }

        private static object getAcctInfosRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "0.08");
            // 被分账方ID
            obj.Add("huifu_id", "6666000111546360");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getAcctSplitBunchRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", getAcctInfosRucan());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAppData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 小程序返回码
            obj.Add("app_schema", "app跳转链接");
            // 私有信息
            // obj.Add("private_info", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
