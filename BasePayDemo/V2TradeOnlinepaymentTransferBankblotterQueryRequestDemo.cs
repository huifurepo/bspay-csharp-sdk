using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银行大额未入账流水列表查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferBankblotterQueryRequestDemo
    {

        public static void V2TradeOnlinepaymentTransferBankblotterQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentTransferBankblotterQueryRequest request = new V2TradeOnlinepaymentTransferBankblotterQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000003100615");
            // 原请求流水号
            request.setOrgReqSeqId("2021091708126665001");
            // 原请求日期
            request.setOrgReqDate("20231215");

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
            // 实际付款方银行卡号
            // extendInfoMap.Add("bank_card_no", "");
            // 实际付款方姓名
            extendInfoMap.Add("certificate_name", "沈显龙");
            // 实际付款日期
            // extendInfoMap.Add("trans_date", "");
            // 交易金额
            // extendInfoMap.Add("trans_amt", "");
            // 收款账号/打款备注
            // extendInfoMap.Add("bank_remark", "");
            return extendInfoMap;
        }

    }
}
