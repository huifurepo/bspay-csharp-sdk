using System;

namespace BasePaySdk.Request
{
    /**
     * 电子账户付款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentZxeAcctpyerRequest : BaseRequest
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
         * 出款方商户号
         */
        private string outHuifuId;
        /**
         * 订单金额
         */
        private string transAmt;
        /**
         * 三方支付数据
         */
        private string thirdPayData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_ZXE_ACCTPYER;
        }

        public V2TradePaymentZxeAcctpyerRequest() {
        }

        public V2TradePaymentZxeAcctpyerRequest(string reqSeqId, string reqDate, string huifuId, string outHuifuId, string transAmt, string thirdPayData) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.outHuifuId = outHuifuId;
            this.transAmt = transAmt;
            this.thirdPayData = thirdPayData;
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

        public string getOutHuifuId() {
            return outHuifuId;
        }

        public void setOutHuifuId(string outHuifuId) {
            this.outHuifuId = outHuifuId;
        }

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getThirdPayData() {
            return thirdPayData;
        }

        public void setThirdPayData(string thirdPayData) {
            this.thirdPayData = thirdPayData;
        }


    }
}
