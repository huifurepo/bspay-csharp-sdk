using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 账单退款接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayOrderPaymentRefundRequestDemo
    {

        public static void V3BillpayOrderPaymentRefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3BillpayOrderPaymentRefundRequest request = new V3BillpayOrderPaymentRefundRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000108432796");
            // 账单编号
            request.setBillNo("BN2026052236198530");
            // 退款金额
            request.setRefAmt("100.00");
            // 大额转账支付账户信息数据jsonObject格式；银行大额转账支付交易的退款申请,付款方账户类型为对公时必填
            request.setBankInfoData(get39a3f6ccD87e496fB6ac4a9211667d6f());

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
            // 退款原因
            extendInfoMap.Add("reason", "退货");
            // 异步通知地址
            // extendInfoMap.Add("notify_url", "");
            return extendInfoMap;
        }

        private static string get39a3f6ccD87e496fB6ac4a9211667d6f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 省份
            obj.Add("province", "0013");
            // 地区
            obj.Add("area", "1301");
            // 银行编号
            obj.Add("bank_code", "01040000");
            // 联行号
            obj.Add("correspondent_code", "102290026507");
            // 付款方账户类型
            obj.Add("card_acct_type", "E");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
