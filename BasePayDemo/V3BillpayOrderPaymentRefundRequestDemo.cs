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
            // request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            // request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            // request.setHuifuId("test");
            // 账单编号
            // request.setBillNo("test");
            // 退款金额
            // request.setRefAmt("test");
            // 大额转账支付账户信息数据jsonObject格式；银行大额转账支付交易的退款申请,付款方账户类型为对公时必填
            // request.setBankInfoData(get1d68b0833d9146359c7eAb5f4dbf001b());

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
            // extendInfoMap.Add("reason", "");
            // 异步通知地址
            // extendInfoMap.Add("notify_url", "");
            return extendInfoMap;
        }

        private static string get1d68b0833d9146359c7eAb5f4dbf001b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 省份付款方为对公账户时必填,参见[代发省市地区码](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/area/%E6%96%97%E6%8B%B1%E4%BB%A3%E5%8F%91%E7%9C%81%E4%BB%BD%E5%9C%B0%E5%8C%BA%E7%BC%96%E7%A0%81.xlsx#代发省市地区码);&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0013&lt;/font&gt;
            // obj.Add("province", "test");
            // 地区付款方为对公账户时必填，,参见[代发省市地区码](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/area/%E6%96%97%E6%8B%B1%E4%BB%A3%E5%8F%91%E7%9C%81%E4%BB%BD%E5%9C%B0%E5%8C%BA%E7%BC%96%E7%A0%81.xlsx#代发省市地区码)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1301&lt;/font&gt;
            // obj.Add("area", "test");
            // 银行编号付款方为对公账户时必填,参见[银行编码](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_yhbm#银行编码);&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01040000&lt;/font&gt;
            // obj.Add("bank_code", "test");
            // 联行号付款方为对公账户时必填,参见[银行支行编码](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_yhzhbm#银行支行编码);&lt;font color&#x3D;&quot;green&quot;&gt;示例值：102290026507&lt;/font&gt;
            // obj.Add("correspondent_code", "test");
            // 付款方账户类型
            // obj.Add("card_acct_type", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
