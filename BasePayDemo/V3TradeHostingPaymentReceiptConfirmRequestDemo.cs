using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 确认收货提醒 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradeHostingPaymentReceiptConfirmRequestDemo
    {

        public static void V3TradeHostingPaymentReceiptConfirmRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3TradeHostingPaymentReceiptConfirmRequest request = new V3TradeHostingPaymentReceiptConfirmRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000109133323");
            // 快递签收时间
            request.setReceivedTime("1670829139");

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
            // 原支付交易对应的微信订单号
            extendInfoMap.Add("transaction_id", "fake-transid-20221209132531-44");
            // 支付下单商户的商户号
            extendInfoMap.Add("merchant_id", "fake-mchid-123");
            // 二级商户号
            // extendInfoMap.Add("sub_merchant_id", "");
            // 商户系统内部订单号
            extendInfoMap.Add("merchant_trade_no", "fake-tradeno-20221209132531-44");
            return extendInfoMap;
        }

    }
}
