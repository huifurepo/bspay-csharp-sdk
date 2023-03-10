using System;

namespace BasePaySdk.Request
{
    /**
     * 查询投诉协商历史
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintHistoryQueryRequest : BaseRequest
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
         * 微信商户号
         */
        private string mchId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_COMPLAINT_HISTORY_QUERY;
        }

        public V2MerchantComplaintHistoryQueryRequest() {
        }

        public V2MerchantComplaintHistoryQueryRequest(string reqSeqId, string reqDate, string complaintId, string mchId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.complaintId = complaintId;
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

        public string getMchId() {
            return mchId;
        }

        public void setMchId(string mchId) {
            this.mchId = mchId;
        }


    }
}
