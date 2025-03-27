using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 钱包支付退款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradePayRefundRequestDemo
    {

        public static void V2WalletTradePayRefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2WalletTradePayRefundRequest request = new V2WalletTradePayRefundRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000135653240");
            // 钱包用户ID
            request.setUserHuifuId("6666000136655020");
            // 退款金额
            request.setTransAmt("0.02");
            // 原交易请求日期
            // request.setOrgReqDate("test");

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
            // 原交易请求流水号
            // extendInfoMap.Add("org_req_seq_id", "");
            // 原交易全局流水号
            // extendInfoMap.Add("org_hf_seq_id", "");
            // 备注
            extendInfoMap.Add("remark", "remark11");
            // 商户扩展信息
            // extendInfoMap.Add("mer_priv", "");
            return extendInfoMap;
        }

    }
}
