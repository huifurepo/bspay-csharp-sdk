using System;

namespace BasePaySdk.Request
{
    /**
     * 支付宝申诉提交凭证
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintSubmitCertificatesRequest : BaseRequest
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
         * 申诉解限的唯一ID
         */
        private string relievingId;
        /**
         * 解限风险类型
         */
        private string relieveRiskType;
        /**
         * 提交的凭证数据
         */
        private string relieveCertDataList;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_COMPLAINT_SUBMIT_CERTIFICATES;
        }

        public V2MerchantComplaintSubmitCertificatesRequest() {
        }

        public V2MerchantComplaintSubmitCertificatesRequest(string reqSeqId, string reqDate, string riskBizId, string relievingId, string relieveRiskType, string relieveCertDataList) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.riskBizId = riskBizId;
            this.relievingId = relievingId;
            this.relieveRiskType = relieveRiskType;
            this.relieveCertDataList = relieveCertDataList;
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

        public string getRelievingId() {
            return relievingId;
        }

        public void setRelievingId(string relievingId) {
            this.relievingId = relievingId;
        }

        public string getRelieveRiskType() {
            return relieveRiskType;
        }

        public void setRelieveRiskType(string relieveRiskType) {
            this.relieveRiskType = relieveRiskType;
        }

        public string getRelieveCertDataList() {
            return relieveCertDataList;
        }

        public void setRelieveCertDataList(string relieveCertDataList) {
            this.relieveCertDataList = relieveCertDataList;
        }


    }
}
