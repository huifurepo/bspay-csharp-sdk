using System;

namespace BasePaySdk.Request
{
    /**
     * 反馈处理完成
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintCompleteRequest : BaseRequest
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
         * 微信投诉单号
         */
        private string complaintId;
        /**
         * 被诉商户微信号
         */
        private string complaintedMchid;
        /**
         * 微信商户号
         */
        private string mchId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_COMPLAINT_COMPLETE;
        }

        public V2MerchantComplaintCompleteRequest() {
        }

        public V2MerchantComplaintCompleteRequest(string reqSeqId, string reqDate, string complaintId, string complaintedMchid, string mchId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.complaintId = complaintId;
            this.complaintedMchid = complaintedMchid;
            this.mchId = mchId;
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

        public string getComplaintId() {
            return complaintId;
        }

        public void setComplaintId(string complaintId) {
            this.complaintId = complaintId;
        }

        public string getComplaintedMchid() {
            return complaintedMchid;
        }

        public void setComplaintedMchid(string complaintedMchid) {
            this.complaintedMchid = complaintedMchid;
        }

        public string getMchId() {
            return mchId;
        }

        public void setMchId(string mchId) {
            this.mchId = mchId;
        }


    }
}
