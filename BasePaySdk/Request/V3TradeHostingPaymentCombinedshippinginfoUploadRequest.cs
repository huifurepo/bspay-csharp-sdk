using System;

namespace BasePaySdk.Request
{
    /**
     * 发货信息合单录入
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradeHostingPaymentCombinedshippinginfoUploadRequest : BaseRequest
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
         * 订单信息
         */
        private string orderKey;
        /**
         * 上传时间
         */
        private string uploadTime;
        /**
         * 支付者
         */
        private string payer;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_TRADE_HOSTING_PAYMENT_COMBINEDSHIPPINGINFO_UPLOAD;
        }

        public V3TradeHostingPaymentCombinedshippinginfoUploadRequest() {
        }

        public V3TradeHostingPaymentCombinedshippinginfoUploadRequest(string reqDate, string reqSeqId, string huifuId, string orderKey, string uploadTime, string payer) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.orderKey = orderKey;
            this.uploadTime = uploadTime;
            this.payer = payer;
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

        public string getOrderKey() {
            return orderKey;
        }

        public void setOrderKey(string orderKey) {
            this.orderKey = orderKey;
        }

        public string getUploadTime() {
            return uploadTime;
        }

        public void setUploadTime(string uploadTime) {
            this.uploadTime = uploadTime;
        }

        public string getPayer() {
            return payer;
        }

        public void setPayer(string payer) {
            this.payer = payer;
        }


    }
}
