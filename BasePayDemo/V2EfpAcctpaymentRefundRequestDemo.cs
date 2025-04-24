using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 全渠道资金付款到账户退款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2EfpAcctpaymentRefundRequestDemo
    {

        public static void V2EfpAcctpaymentRefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2EfpAcctpaymentRefundRequest request = new V2EfpAcctpaymentRefundRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付商户号
            request.setHuifuId("6666000123123123");
            // 原交易全局流水号org_hf_seq_id和org_req_seq_id二选一； &lt;font color&#x3D;&quot;green&quot;&gt;示例值：00470topo1A211015160805P090ac132fef00000&lt;/font&gt;
            request.setOrgHfSeqId("00470topo1A211015160805P090ac132fef00000");
            // 原交易请求流水号org_hf_seq_id和org_req_seq_id二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665002&lt;/font&gt;
            request.setOrgReqSeqId("2021091708126665002");
            // 原交易请求日期
            request.setOrgReqDate("20221022");
            // 退款金额
            request.setRefundAmt("10.00");
            // 接收方退款对象
            request.setAcctSplitBunch(get5bf3321f6c604d67Ad10C58a4cce226c());

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
            // 备注
            extendInfoMap.Add("remark", "备注");
            return extendInfoMap;
        }

        private static object getE1cff61a45374e07B6a5Fd58a85a8f13() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退款金额
            obj.Add("div_amt", "1.00");
            // 退款方ID
            obj.Add("huifu_id", "6666000123123123");
            // 退款方账户号
            obj.Add("acct_id", "F00598600");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get5bf3321f6c604d67Ad10C58a4cce226c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 退账明细
            obj.Add("acct_infos", getE1cff61a45374e07B6a5Fd58a85a8f13());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
