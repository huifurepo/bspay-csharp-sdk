using System;

namespace BasePaySdk.Request
{
    /**
     * 用户补贴
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradeRechargeTransferRequest : BaseRequest
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
        private string huifuId;
        /**
         * 收款方用户号
         */
        private string userHuifuId;
        /**
         * 转账金额
         */
        private string transAmt;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_TRADE_RECHARGE_TRANSFER;
        }

        public V2WalletTradeRechargeTransferRequest() {
        }

        public V2WalletTradeRechargeTransferRequest(string reqSeqId, string reqDate, string huifuId, string userHuifuId, string transAmt) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.userHuifuId = userHuifuId;
            this.transAmt = transAmt;
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


    }
}
