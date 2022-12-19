using System;

namespace BasePaySdk.Request
{
    /**
     * 余额支付退款查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeAcctpaymentRefundQueryRequest : BaseRequest
    {

        /**
         * 退款请求流水号
         */
        private string orgReqSeqId;
        /**
         * 余额支付退款请求日期
         */
        private string orgReqDate;
        /**
         * 商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ACCTPAYMENT_REFUND_QUERY;
        }

        public V2TradeAcctpaymentRefundQueryRequest() {
        }

        public V2TradeAcctpaymentRefundQueryRequest(string orgReqSeqId, string orgReqDate, string huifuId) {
            this.orgReqSeqId = orgReqSeqId;
            this.orgReqDate = orgReqDate;
            this.huifuId = huifuId;
        }

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }


    }
}
