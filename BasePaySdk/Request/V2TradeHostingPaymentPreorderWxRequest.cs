using System;

namespace BasePaySdk.Request
{
    /**
     * 微信小程序预下单接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentPreorderWxRequest : BaseRequest
    {

        /**
         * 预下单类型
         */
        private string preOrderType;
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
         * 微信小程序扩展参数集合
         */
        private string miniappData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_HOSTING_PAYMENT_PREORDER;
        }

        public V2TradeHostingPaymentPreorderWxRequest() {
        }

        public V2TradeHostingPaymentPreorderWxRequest(string preOrderType, string reqDate, string reqSeqId, string huifuId, string transAmt, string goodsDesc, string miniappData) {
            this.preOrderType = preOrderType;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.transAmt = transAmt;
            this.goodsDesc = goodsDesc;
            this.miniappData = miniappData;
        }

        public string getPreOrderType() {
            return preOrderType;
        }

        public void setPreOrderType(string preOrderType) {
            this.preOrderType = preOrderType;
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

        public string getMiniappData() {
            return miniappData;
        }

        public void setMiniappData(string miniappData) {
            this.miniappData = miniappData;
        }


    }
}
