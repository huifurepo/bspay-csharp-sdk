using System;

namespace BasePaySdk.Request
{
    /**
     * 自助扫码开票
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceSelfscanopenRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求时间
         */
        private string reqDate;
        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 发票类型
         */
        private string ivcType;
        /**
         * 开票类型
         */
        private string openType;
        /**
         * 含税合计金额（元）
         */
        private string orderAmt;
        /**
         * 开票商品信息
         */
        private string goodsInfos;
        /**
         * 开票人信息
         */
        private string payerInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_SELFSCANOPEN;
        }

        public V2InvoiceSelfscanopenRequest() {
        }

        public V2InvoiceSelfscanopenRequest(string reqSeqId, string reqDate, string huifuId, string ivcType, string openType, string orderAmt, string goodsInfos, string payerInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.ivcType = ivcType;
            this.openType = openType;
            this.orderAmt = orderAmt;
            this.goodsInfos = goodsInfos;
            this.payerInfo = payerInfo;
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

        public string getIvcType() {
            return ivcType;
        }

        public void setIvcType(string ivcType) {
            this.ivcType = ivcType;
        }

        public string getOpenType() {
            return openType;
        }

        public void setOpenType(string openType) {
            this.openType = openType;
        }

        public string getOrderAmt() {
            return orderAmt;
        }

        public void setOrderAmt(string orderAmt) {
            this.orderAmt = orderAmt;
        }

        public string getGoodsInfos() {
            return goodsInfos;
        }

        public void setGoodsInfos(string goodsInfos) {
            this.goodsInfos = goodsInfos;
        }

        public string getPayerInfo() {
            return payerInfo;
        }

        public void setPayerInfo(string payerInfo) {
            this.payerInfo = payerInfo;
        }


    }
}
