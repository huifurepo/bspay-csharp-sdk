using System;

namespace BasePaySdk.Request
{
    /**
     * 余额支付查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeAcctpaymentPayQueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 原交易请求日期
         */
        private string orgReqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ACCTPAYMENT_PAY_QUERY;
        }

        public V2TradeAcctpaymentPayQueryRequest() {
        }

        public V2TradeAcctpaymentPayQueryRequest(string huifuId, string orgReqDate) {
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }


    }
}
