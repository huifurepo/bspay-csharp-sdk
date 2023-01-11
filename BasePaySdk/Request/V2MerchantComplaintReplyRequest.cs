using System;

namespace BasePaySdk.Request
{
    /**
     * 回复用户
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintReplyRequest : BaseRequest
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
         * 回复内容
         */
        private string responseContent;
        /**
         * 跳转链接
         */
        private string jumpUrl;
        /**
         * 跳转链接文案
         */
        private string jumpUrlText;
        /**
         * 微信商户号
         */
        private string mchId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_COMPLAINT_REPLY;
        }

        public V2MerchantComplaintReplyRequest() {
        }

        public V2MerchantComplaintReplyRequest(string reqSeqId, string reqDate, string complaintId, string complaintedMchid, string responseContent, string jumpUrl, string jumpUrlText, string mchId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.complaintId = complaintId;
            this.complaintedMchid = complaintedMchid;
            this.responseContent = responseContent;
            this.jumpUrl = jumpUrl;
            this.jumpUrlText = jumpUrlText;
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

        public string getResponseContent() {
            return responseContent;
        }

        public void setResponseContent(string responseContent) {
            this.responseContent = responseContent;
        }

        public string getJumpUrl() {
            return jumpUrl;
        }

        public void setJumpUrl(string jumpUrl) {
            this.jumpUrl = jumpUrl;
        }

        public string getJumpUrlText() {
            return jumpUrlText;
        }

        public void setJumpUrlText(string jumpUrlText) {
            this.jumpUrlText = jumpUrlText;
        }

        public string getMchId() {
            return mchId;
        }

        public void setMchId(string mchId) {
            this.mchId = mchId;
        }


    }
}
