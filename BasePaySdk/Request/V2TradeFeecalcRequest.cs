using System;

namespace BasePaySdk.Request
{
    /**
     * 手续费试算
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeFeecalcRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 交易类型
         */
        private string tradeType;
        /**
         * 交易金额
         */
        private string transAmt;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_FEECALC;
        }

        public V2TradeFeecalcRequest() {
        }

        public V2TradeFeecalcRequest(string huifuId, string reqDate, string reqSeqId, string tradeType, string transAmt) {
            this.huifuId = huifuId;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.tradeType = tradeType;
            this.transAmt = transAmt;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
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

        public string getTradeType() {
            return tradeType;
        }

        public void setTradeType(string tradeType) {
            this.tradeType = tradeType;
        }

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }


    }
}
