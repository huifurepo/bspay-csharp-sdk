using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 余额支付退款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeAcctpaymentRefundRequestDemo
    {

        public static void V2TradeAcctpaymentRefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeAcctpaymentRefundRequest request = new V2TradeAcctpaymentRefundRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000108854952");
            // 原余额支付请求日期
            request.setOrgReqDate("20211021");
            // 原余额支付请求流水号org_hf_seq_id和orgReqSeqId二选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665001&lt;/font&gt;
            request.setOrgReqSeqId("202110210012100005");
            // 原余额支付支付全局流水号org_hf_seq_id和orgReqSeqId二选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00470topo1A211015160805P090ac132fef00000&lt;/font&gt;
            request.setOrgHfSeqId("");
            // 退款金额
            request.setOrdAmt("0.01");

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
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", getAcctSplitBunch());
            // 安全信息
            extendInfoMap.Add("risk_check_data", getRiskCheckData());
            // 备注
            extendInfoMap.Add("remark", "1234567890");
            return extendInfoMap;
        }

        private static object getAcctInfos() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款金额
            // obj.Add("div_amt", "test");
            // 退款方ID
            // obj.Add("huifu_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getAcctSplitBunch() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退账明细
            // obj.Add("acct_infos", getAcctInfos());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getRiskCheckData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 转账原因
            obj.Add("transfer_type", "04");
            // 产品子类
            obj.Add("sub_product", "卡券推广类");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
