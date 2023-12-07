using System;

namespace BasePaySdk.Request
{
    /**
     * 聚合正扫接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentJspayRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;
        /**
         * 商品描述
         */
        private string goodsDesc;
        /**
         * 交易类型
         */
        private string tradeType;
        /**
         * 交易金额
         */
        private string transAmt;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_JSPAY;
        }

        public V2TradePaymentJspayRequest() {
        }

        public V2TradePaymentJspayRequest(string reqDate, string reqSeqId, string huifuId, string goodsDesc, string tradeType, string transAmt) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.goodsDesc = goodsDesc;
            this.tradeType = tradeType;
            this.transAmt = transAmt;
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

        public string getGoodsDesc() {
            return goodsDesc;
        }

        public void setGoodsDesc(string goodsDesc) {
            this.goodsDesc = goodsDesc;
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
