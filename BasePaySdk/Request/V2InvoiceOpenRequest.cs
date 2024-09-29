using System;

namespace BasePaySdk.Request
{
    /**
     * 发票开具
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceOpenRequest : BaseRequest
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
         * 渠道号汇付商户号为空时，必传；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812124&lt;/font&gt;
         */
        private string channelId;
        /**
         * 发票类型
         */
        private string ivcType;
        /**
         * 开票类型
         */
        private string openType;
        /**
         * 购方单位名称
         */
        private string buyerName;
        /**
         * 含税合计金额(元)
         */
        private string orderAmt;
        /**
         * 冲红原因open_type&#x3D;1时必填01：开票有误02：销货退回03：服务终止04：销售转让
         */
        private string redApplyReason;
        /**
         * 冲红申请来源open_type&#x3D;1时必填01：销方02：购方
         */
        private string redApplySource;
        /**
         * 原发票代码openType&#x3D;1时必填；参见[发票右上角](https://paas.huifu.com/open/doc/api/#/fp/api_fp_yanglitu.md)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：144032209110&lt;/font&gt;
         */
        private string oriIvcCode;
        /**
         * 原发票号码openType&#x3D;1时必填；参见[发票右上角](https://paas.huifu.com/open/doc/api/#/fp/api_fp_yanglitu.md)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20685767&lt;/font&gt;
         */
        private string oriIvcNumber;
        /**
         * 开票商品信息
         */
        private string goodsInfos;
        /**
         * 开票人信息
         */
        private string payerInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_OPEN;
        }

        public V2InvoiceOpenRequest() {
        }

        public V2InvoiceOpenRequest(string reqSeqId, string reqDate, string channelId, string ivcType, string openType, string buyerName, string orderAmt, string redApplyReason, string redApplySource, string oriIvcCode, string oriIvcNumber, string goodsInfos, string payerInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.channelId = channelId;
            this.ivcType = ivcType;
            this.openType = openType;
            this.buyerName = buyerName;
            this.orderAmt = orderAmt;
            this.redApplyReason = redApplyReason;
            this.redApplySource = redApplySource;
            this.oriIvcCode = oriIvcCode;
            this.oriIvcNumber = oriIvcNumber;
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

        public string getChannelId() {
            return channelId;
        }

        public void setChannelId(string channelId) {
            this.channelId = channelId;
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

        public string getBuyerName() {
            return buyerName;
        }

        public void setBuyerName(string buyerName) {
            this.buyerName = buyerName;
        }

        public string getOrderAmt() {
            return orderAmt;
        }

        public void setOrderAmt(string orderAmt) {
            this.orderAmt = orderAmt;
        }

        public string getRedApplyReason() {
            return redApplyReason;
        }

        public void setRedApplyReason(string redApplyReason) {
            this.redApplyReason = redApplyReason;
        }

        public string getRedApplySource() {
            return redApplySource;
        }

        public void setRedApplySource(string redApplySource) {
            this.redApplySource = redApplySource;
        }

        public string getOriIvcCode() {
            return oriIvcCode;
        }

        public void setOriIvcCode(string oriIvcCode) {
            this.oriIvcCode = oriIvcCode;
        }

        public string getOriIvcNumber() {
            return oriIvcNumber;
        }

        public void setOriIvcNumber(string oriIvcNumber) {
            this.oriIvcNumber = oriIvcNumber;
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
