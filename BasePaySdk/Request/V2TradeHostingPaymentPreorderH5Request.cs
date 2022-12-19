using System;

namespace BasePaySdk.Request
{
    /**
     * H5、PC预下单接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentPreorderH5Request : BaseRequest
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
         * 预下单类型
         */
        private string preOrderType;
        /**
         * 半支付托管扩展参数集合
         */
        private string hostingData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_HOSTING_PAYMENT_PREORDER;
        }

        public V2TradeHostingPaymentPreorderH5Request() {
        }

        public V2TradeHostingPaymentPreorderH5Request(string reqDate, string reqSeqId, string huifuId, string transAmt, string goodsDesc, string preOrderType, string hostingData) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.transAmt = transAmt;
            this.goodsDesc = goodsDesc;
            this.preOrderType = preOrderType;
            this.hostingData = hostingData;
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

        public string getPreOrderType() {
            return preOrderType;
        }

        public void setPreOrderType(string preOrderType) {
            this.preOrderType = preOrderType;
        }

        public string getHostingData() {
            return hostingData;
        }

        public void setHostingData(string hostingData) {
            this.hostingData = hostingData;
        }


    }
}
