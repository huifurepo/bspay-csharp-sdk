using System;

namespace BasePaySdk.Request
{
    /**
     * 支付宝申诉请求凭证
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintRequestCertificatesRequest : BaseRequest
    {

        /**
         * 请求汇付流水号
         */
        private string reqSeqId;
        /**
         * 请求汇付时间
         */
        private string reqDate;
        /**
         * 支付宝推送流水号
         */
        private string riskBizId;
        /**
         * 商户类型
         */
        private string merchantType;
        /**
         * 商户经营模式
         */
        private string operationType;
        /**
         * 收款应用场景
         */
        private string paymentScene;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_COMPLAINT_REQUEST_CERTIFICATES;
        }

        public V2MerchantComplaintRequestCertificatesRequest() {
        }

        public V2MerchantComplaintRequestCertificatesRequest(string reqSeqId, string reqDate, string riskBizId, string merchantType, string operationType, string paymentScene) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.riskBizId = riskBizId;
            this.merchantType = merchantType;
            this.operationType = operationType;
            this.paymentScene = paymentScene;
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

        public string getRiskBizId() {
            return riskBizId;
        }

        public void setRiskBizId(string riskBizId) {
            this.riskBizId = riskBizId;
        }

        public string getMerchantType() {
            return merchantType;
        }

        public void setMerchantType(string merchantType) {
            this.merchantType = merchantType;
        }

        public string getOperationType() {
            return operationType;
        }

        public void setOperationType(string operationType) {
            this.operationType = operationType;
        }

        public string getPaymentScene() {
            return paymentScene;
        }

        public void setPaymentScene(string paymentScene) {
            this.paymentScene = paymentScene;
        }


    }
}
