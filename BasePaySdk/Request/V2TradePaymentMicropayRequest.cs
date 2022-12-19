using System;

namespace BasePaySdk.Request
{
    /**
     * 聚合反扫接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentMicropayRequest : BaseRequest
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
         * 交易金额
         */
        private string transAmt;
        /**
         * 商品描述
         */
        private string goodsDesc;
        /**
         * 支付授权码
         */
        private string authCode;
        /**
         * 安全信息
         */
        private string riskCheckData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_MICROPAY;
        }

        public V2TradePaymentMicropayRequest() {
        }

        public V2TradePaymentMicropayRequest(string reqDate, string reqSeqId, string huifuId, string transAmt, string goodsDesc, string authCode, string riskCheckData) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.transAmt = transAmt;
            this.goodsDesc = goodsDesc;
            this.authCode = authCode;
            this.riskCheckData = riskCheckData;
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

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getGoodsDesc() {
            return goodsDesc;
        }

        public void setGoodsDesc(string goodsDesc) {
            this.goodsDesc = goodsDesc;
        }

        public string getAuthCode() {
            return authCode;
        }

        public void setAuthCode(string authCode) {
            this.authCode = authCode;
        }

        public string getRiskCheckData() {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData) {
            this.riskCheckData = riskCheckData;
        }


    }
}
