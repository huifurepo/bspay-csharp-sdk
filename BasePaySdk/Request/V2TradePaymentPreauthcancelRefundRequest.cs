using System;

namespace BasePaySdk.Request
{
    /**
     * 微信支付宝预授权撤销
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentPreauthcancelRefundRequest : BaseRequest
    {

        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 客户号
         */
        private string huifuId;
        /**
         * 原交易请求日期
         */
        private string orgReqDate;
        /**
         * 撤销金额
         */
        private string ordAmt;
        /**
         * 风控信息
         */
        private string riskCheckInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_PREAUTHCANCEL_REFUND;
        }

        public V2TradePaymentPreauthcancelRefundRequest() {
        }

        public V2TradePaymentPreauthcancelRefundRequest(string reqDate, string reqSeqId, string huifuId, string orgReqDate, string ordAmt, string riskCheckInfo) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.ordAmt = ordAmt;
            this.riskCheckInfo = riskCheckInfo;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
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

        public string getRiskCheckInfo() {
            return riskCheckInfo;
        }

        public void setRiskCheckInfo(string riskCheckInfo) {
            this.riskCheckInfo = riskCheckInfo;
        }


    }
}
