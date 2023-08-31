using System;

namespace BasePaySdk.Request
{
    /**
     * 银行转账资金流水查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferAccountQueryRequest : BaseRequest
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
         * 原请求流水号
         */
        private string orgReqSeqId;
        /**
         * 原请求日期
         */
        private string orgReqDate;
        /**
         * 打款结束日期
         */
        private string transEndDate;
        /**
         * 交易开始日期
         */
        private string transStartDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_TRANSFER_ACCOUNT_QUERY;
        }

        public V2TradeOnlinepaymentTransferAccountQueryRequest() {
        }

        public V2TradeOnlinepaymentTransferAccountQueryRequest(string reqSeqId, string reqDate, string huifuId, string orgReqSeqId, string orgReqDate, string transEndDate, string transStartDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.orgReqSeqId = orgReqSeqId;
            this.orgReqDate = orgReqDate;
            this.transEndDate = transEndDate;
            this.transStartDate = transStartDate;
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

        public string getTransEndDate() {
            return transEndDate;
        }

        public void setTransEndDate(string transEndDate) {
            this.transEndDate = transEndDate;
        }

        public string getTransStartDate() {
            return transStartDate;
        }

        public void setTransStartDate(string transStartDate) {
            this.transStartDate = transStartDate;
        }


    }
}
