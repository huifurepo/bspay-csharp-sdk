using System;

namespace BasePaySdk.Request
{
    /**
     * 余额支付
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeAcctpaymentPayRequest : BaseRequest
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
         * 出款方商户号
         */
        private string outHuifuId;
        /**
         * 支付金额
         */
        private string ordAmt;
        /**
         * 分账对象
         */
        private string acctSplitBunch;
        /**
         * 安全信息
         */
        private string riskCheckData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ACCTPAYMENT_PAY;
        }

        public V2TradeAcctpaymentPayRequest() {
        }

        public V2TradeAcctpaymentPayRequest(string reqSeqId, string reqDate, string outHuifuId, string ordAmt, string acctSplitBunch, string riskCheckData) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.outHuifuId = outHuifuId;
            this.ordAmt = ordAmt;
            this.acctSplitBunch = acctSplitBunch;
            this.riskCheckData = riskCheckData;
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

        public string getOutHuifuId() {
            return outHuifuId;
        }

        public void setOutHuifuId(string outHuifuId) {
            this.outHuifuId = outHuifuId;
        }

        public string getOrdAmt() {
            return ordAmt;
        }

        public void setOrdAmt(string ordAmt) {
            this.ordAmt = ordAmt;
        }

        public string getAcctSplitBunch() {
            return acctSplitBunch;
        }

        public void setAcctSplitBunch(string acctSplitBunch) {
            this.acctSplitBunch = acctSplitBunch;
        }

        public string getRiskCheckData() {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData) {
            this.riskCheckData = riskCheckData;
        }


    }
}
