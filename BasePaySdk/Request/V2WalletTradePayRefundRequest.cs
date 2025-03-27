using System;

namespace BasePaySdk.Request
{
    /**
     * 钱包支付退款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradePayRefundRequest : BaseRequest
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
         * 钱包用户ID
         */
        private string userHuifuId;
        /**
         * 退款金额
         */
        private string transAmt;
        /**
         * 原交易请求日期
         */
        private string orgReqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_TRADE_PAY_REFUND;
        }

        public V2WalletTradePayRefundRequest() {
        }

        public V2WalletTradePayRefundRequest(string reqSeqId, string reqDate, string huifuId, string userHuifuId, string transAmt, string orgReqDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.userHuifuId = userHuifuId;
            this.transAmt = transAmt;
            this.orgReqDate = orgReqDate;
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

        public string getUserHuifuId() {
            return userHuifuId;
        }

        public void setUserHuifuId(string userHuifuId) {
            this.userHuifuId = userHuifuId;
        }

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }


    }
}
