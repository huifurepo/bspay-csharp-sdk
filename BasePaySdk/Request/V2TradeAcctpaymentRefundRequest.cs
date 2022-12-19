using System;

namespace BasePaySdk.Request
{
    /**
     * 余额支付退款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeAcctpaymentRefundRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 原余额支付请求日期
         */
        private string orgReqDate;
        /**
         * 退款金额
         */
        private string ordAmt;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ACCTPAYMENT_REFUND;
        }

        public V2TradeAcctpaymentRefundRequest() {
        }

        public V2TradeAcctpaymentRefundRequest(string reqSeqId, string reqDate, string huifuId, string orgReqDate, string ordAmt) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.ordAmt = ordAmt;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
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

        public string getOrdAmt() {
            return ordAmt;
        }

        public void setOrdAmt(string ordAmt) {
            this.ordAmt = ordAmt;
        }


    }
}
