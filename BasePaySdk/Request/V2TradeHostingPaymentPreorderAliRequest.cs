using System;

namespace BasePaySdk.Request
{
    /**
     * 支付宝小程序预下单接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentPreorderAliRequest : BaseRequest
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
         * 预下单类型
         */
        private string preOrderType;
        /**
         * 交易金额
         */
        private string transAmt;
        /**
         * 商品描述
         */
        private string goodsDesc;
        /**
         * app扩展参数集合
         */
        private string appData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_HOSTING_PAYMENT_PREORDER;
        }

        public V2TradeHostingPaymentPreorderAliRequest() {
        }

        public V2TradeHostingPaymentPreorderAliRequest(string huifuId, string reqDate, string reqSeqId, string preOrderType, string transAmt, string goodsDesc, string appData) {
            this.huifuId = huifuId;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.preOrderType = preOrderType;
            this.transAmt = transAmt;
            this.goodsDesc = goodsDesc;
            this.appData = appData;
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

        public string getPreOrderType() {
            return preOrderType;
        }

        public void setPreOrderType(string preOrderType) {
            this.preOrderType = preOrderType;
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

        public string getAppData() {
            return appData;
        }

        public void setAppData(string appData) {
            this.appData = appData;
        }


    }
}
