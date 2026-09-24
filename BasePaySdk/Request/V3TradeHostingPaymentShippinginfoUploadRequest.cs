using System;

namespace BasePaySdk.Request
{
    /**
     * 发货信息录入
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradeHostingPaymentShippinginfoUploadRequest : BaseRequest
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
         * 物流模式
         */
        private string logisticsType;
        /**
         * 发货模式
         */
        private string deliveryMode;
        /**
         * 否已全部发货完成分拆发货模式时必填，用于标识分拆发货模式下是否已全部发货完成，只有全部发货完成的情况下才会向用户推送发货完成通知。&lt;br/&gt;枚举值: true，false&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：true&lt;/font&gt;
         */
        private string isAllDelivered;
        /**
         * 上传时间
         */
        private string uploadTime;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_TRADE_HOSTING_PAYMENT_SHIPPINGINFO_UPLOAD;
        }

        public V3TradeHostingPaymentShippinginfoUploadRequest() {
        }

        public V3TradeHostingPaymentShippinginfoUploadRequest(string reqDate, string reqSeqId, string huifuId, string orderKey, string logisticsType, string deliveryMode, string isAllDelivered, string uploadTime) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.orderKey = orderKey;
            this.logisticsType = logisticsType;
            this.deliveryMode = deliveryMode;
            this.isAllDelivered = isAllDelivered;
            this.uploadTime = uploadTime;
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

        public string getLogisticsType() {
            return logisticsType;
        }

        public void setLogisticsType(string logisticsType) {
            this.logisticsType = logisticsType;
        }

        public string getDeliveryMode() {
            return deliveryMode;
        }

        public void setDeliveryMode(string deliveryMode) {
            this.deliveryMode = deliveryMode;
        }

        public string getIsAllDelivered() {
            return isAllDelivered;
        }

        public void setIsAllDelivered(string isAllDelivered) {
            this.isAllDelivered = isAllDelivered;
        }

        public string getUploadTime() {
            return uploadTime;
        }

        public void setUploadTime(string uploadTime) {
            this.uploadTime = uploadTime;
        }


    }
}
