using System;

namespace BasePaySdk.Request
{
    /**
     * 钱包提现下单
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradeWithdrawalRequest : BaseRequest
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
         * 银行卡序列号
         */
        private string tokenNo;
        /**
         * 提现金额
         */
        private string transAmt;
        /**
         * 跳转地址
         */
        private string frontUrl;
        /**
         * 异步通知地址
         */
        private string notifyUrl;
        /**
         * 到账日期类型
         */
        private string intoAcctDateType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_TRADE_WITHDRAWAL;
        }

        public V2WalletTradeWithdrawalRequest() {
        }

        public V2WalletTradeWithdrawalRequest(string reqSeqId, string reqDate, string huifuId, string userHuifuId, string tokenNo, string transAmt, string frontUrl, string notifyUrl, string intoAcctDateType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.userHuifuId = userHuifuId;
            this.tokenNo = tokenNo;
            this.transAmt = transAmt;
            this.frontUrl = frontUrl;
            this.notifyUrl = notifyUrl;
            this.intoAcctDateType = intoAcctDateType;
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

        public string getTokenNo() {
            return tokenNo;
        }

        public void setTokenNo(string tokenNo) {
            this.tokenNo = tokenNo;
        }

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getFrontUrl() {
            return frontUrl;
        }

        public void setFrontUrl(string frontUrl) {
            this.frontUrl = frontUrl;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }

        public string getIntoAcctDateType() {
            return intoAcctDateType;
        }

        public void setIntoAcctDateType(string intoAcctDateType) {
            this.intoAcctDateType = intoAcctDateType;
        }


    }
}
