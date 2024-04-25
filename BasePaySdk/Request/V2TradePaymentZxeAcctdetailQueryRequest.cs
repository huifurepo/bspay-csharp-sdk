using System;

namespace BasePaySdk.Request
{
    /**
     * 电子账户账务明细查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentZxeAcctdetailQueryRequest : BaseRequest
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
         * 商户号/用户号
         */
        private string huifuId;
        /**
         * 交易日期
         */
        private string transDate;
        /**
         * 交易类型
         */
        private string transType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_ZXE_ACCTDETAIL_QUERY;
        }

        public V2TradePaymentZxeAcctdetailQueryRequest() {
        }

        public V2TradePaymentZxeAcctdetailQueryRequest(string reqDate, string reqSeqId, string huifuId, string transDate, string transType) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.transDate = transDate;
            this.transType = transType;
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

        public string getTransDate() {
            return transDate;
        }

        public void setTransDate(string transDate) {
            this.transDate = transDate;
        }

        public string getTransType() {
            return transType;
        }

        public void setTransType(string transType) {
            this.transType = transType;
        }


    }
}
