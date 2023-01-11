using System;

namespace BasePaySdk.Request
{
    /**
     * 更新退款审批结果
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintUpdateRefundprogressRequest : BaseRequest
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
         * 投诉单号
         */
        private string complaintId;
        /**
         * 审批动作
         */
        private string action;
        /**
         * 微信商户号
         */
        private string mchId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_COMPLAINT_UPDATE_REFUNDPROGRESS;
        }

        public V2MerchantComplaintUpdateRefundprogressRequest() {
        }

        public V2MerchantComplaintUpdateRefundprogressRequest(string reqSeqId, string reqDate, string complaintId, string action, string mchId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.complaintId = complaintId;
            this.action = action;
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

        public string getAction() {
            return action;
        }

        public void setAction(string action) {
            this.action = action;
        }

        public string getMchId() {
            return mchId;
        }

        public void setMchId(string mchId) {
            this.mchId = mchId;
        }


    }
}
