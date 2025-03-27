using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银行大额支付差错申请 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferBankmistakeApplyRequestDemo
    {

        public static void V2TradeOnlinepaymentTransferBankmistakeApplyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentTransferBankmistakeApplyRequest request = new V2TradeOnlinepaymentTransferBankmistakeApplyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000110468104");
            // 交易金额
            request.setTransAmt("0.01");
            // 订单类型
            request.setOrderType("REFUND");
            // 原请求流水号order_flag&#x3D;Y时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2022012514120615009&lt;/font&gt;
            request.setOrgReqSeqId("202308312345678931");
            // 原请求日期格式:yyyyMMdd；order_flag&#x3D;Y时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;
            request.setOrgReqDate("20230831");
            // 异步通知地址
            request.setNotifyUrl("http://www.baidu.com");

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
            // 下单标识
            // extendInfoMap.Add("order_flag", "");
            // 备注
            extendInfoMap.Add("remark", "大额支付补入账验证");
            // 银行信息数据
            extendInfoMap.Add("bank_info_data", getAbecf41199e2427189e378ecb5bc0872());
            // 延时标记
            // extendInfoMap.Add("delay_acct_flag", "");
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", get887cec5eC9324ee3B2b5282eb708eb87());
            // 实际打款信息
            // extendInfoMap.Add("actual_remit_data", get8bcd25edC7614d4181cf7d7f6bd6e4b5());
            return extendInfoMap;
        }

        private static string getAbecf41199e2427189e378ecb5bc0872() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行编号
            obj.Add("bank_code", "03080000");
            // 对公对私标识
            obj.Add("card_acct_type", "P");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get7cb41945E40f4907Ab1e1dd0dcfaee14() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付金额
            // obj.Add("div_amt", "");
            // 商户号
            // obj.Add("huifu_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get887cec5eC9324ee3B2b5282eb708eb87() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账信息列表
            // obj.Add("acct_infos", get7cb41945E40f4907Ab1e1dd0dcfaee14());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get8bcd25edC7614d4181cf7d7f6bd6e4b5() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 实际打款日期
            // obj.Add("actual_remit_date", "test");
            // 实际打款方姓名
            // obj.Add("actual_remit_name", "test");
            // 实际打款金额
            // obj.Add("actual_remit_amt", "test");
            // 实际打款方银行卡号
            // obj.Add("actual_remit_card_no", "test");
            // 汇款凭证文件ID
            // obj.Add("certificate_file_id", "test");
            // 退款卡标识
            // obj.Add("refund_card_flag", "test");
            // 实际打款卡号银行名称
            // obj.Add("actual_bank_name", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
