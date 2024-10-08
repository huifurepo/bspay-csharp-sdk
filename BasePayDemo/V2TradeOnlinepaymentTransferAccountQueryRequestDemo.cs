using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银行大额资金流水查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferAccountQueryRequestDemo
    {

        public static void V2TradeOnlinepaymentTransferAccountQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentTransferAccountQueryRequest request = new V2TradeOnlinepaymentTransferAccountQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000003100615");

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
            // 订单模式
            // extendInfoMap.Add("order_mode", "");
            // 原请求流水号
            extendInfoMap.Add("org_req_seq_id", "20211659949882");
            // 原请求日期
            extendInfoMap.Add("org_req_date", "20220808");
            // 银行卡号
            extendInfoMap.Add("bank_card_no", "Xmjm1RB4AAOaFYQ+PgjBlpugXbd8VAYAGB3J2zrbLfC42Bh5xiB47OOV1EdXyGpBq4H8je7mB/MlyEEs6O8PX6aoI4QHumr8VglrLM6uzbVNCIc3S5RPSmi2M+9+EdIQ6nlWd5+XQ7RJXX5Uvnegn74XzQBcN1d4gd04buwKbLpUPV3tWd1qjQwEE8w4gwEtH3L5AP75Mynz+wHFrUKJF3BTiW2/zJlcq5GJomOl06GEW52AZkXwn6U2suP3a0ySd0Rxbf1yQ1lj3SP56NeeEzuBaFLQWB7mEqJfZF3pE9MHNfi6tR1xwLdcxt98bdIqlteKdNAmgfQzcS13UcwH+w==");
            // 付款方名称
            extendInfoMap.Add("certificate_name", "沈显龙");
            // 入账标识
            extendInfoMap.Add("in_acct_flag", "YDNI2NDJIKKPAFGQ");
            // 交易开始日期
            extendInfoMap.Add("trans_start_date", "20220801");
            // 交易结束日期
            extendInfoMap.Add("trans_end_date", "20220808");
            // 实际打款日期
            // extendInfoMap.Add("remit_date", "");
            // 每页条数
            // extendInfoMap.Add("page_size", "");
            // 分页页码
            // extendInfoMap.Add("page_no", "");
            return extendInfoMap;
        }

    }
}
