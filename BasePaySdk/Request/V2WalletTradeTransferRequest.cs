using System;

namespace BasePaySdk.Request
{
    /**
     * 钱包转账下单
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradeTransferRequest : BaseRequest
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
         * 出款方钱包用户ID
         */
        private string userHuifuId;
        /**
         * 收款方钱包用户ID
         */
        private string inUserHuifuId;
        /**
         * 订单金额
         */
        private string transAmt;
        /**
         * 跳转地址
         */
        private string frontUrl;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_TRADE_TRANSFER;
        }

        public V2WalletTradeTransferRequest() {
        }

        public V2WalletTradeTransferRequest(string reqSeqId, string reqDate, string huifuId, string userHuifuId, string inUserHuifuId, string transAmt, string frontUrl) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.userHuifuId = userHuifuId;
            this.inUserHuifuId = inUserHuifuId;
            this.transAmt = transAmt;
            this.frontUrl = frontUrl;
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

        public string getInUserHuifuId() {
            return inUserHuifuId;
        }

        public void setInUserHuifuId(string inUserHuifuId) {
            this.inUserHuifuId = inUserHuifuId;
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


    }
}
