using System;

namespace BasePaySdk.Request
{
    /**
     * 不明来账列表查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentZxeUnknownincomeQueryRequest : BaseRequest
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
         * 交易开始日期
         */
        private string transStartDate;
        /**
         * 交易结束日期
         */
        private string transEndDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_ZXE_UNKNOWNINCOME_QUERY;
        }

        public V2TradePaymentZxeUnknownincomeQueryRequest() {
        }

        public V2TradePaymentZxeUnknownincomeQueryRequest(string reqSeqId, string reqDate, string huifuId, string transStartDate, string transEndDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.transStartDate = transStartDate;
            this.transEndDate = transEndDate;
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

        public string getTransStartDate() {
            return transStartDate;
        }

        public void setTransStartDate(string transStartDate) {
            this.transStartDate = transStartDate;
        }

        public string getTransEndDate() {
            return transEndDate;
        }

        public void setTransEndDate(string transEndDate) {
            this.transEndDate = transEndDate;
        }


    }
}
