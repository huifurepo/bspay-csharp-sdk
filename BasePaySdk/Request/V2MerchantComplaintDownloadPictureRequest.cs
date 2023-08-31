using System;

namespace BasePaySdk.Request
{
    /**
     * 投诉图片下载
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintDownloadPictureRequest : BaseRequest
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
         * 下载图片的url
         */
        private string mediaUrl;
        /**
         * 投诉单号
         */
        private string complaintId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_COMPLAINT_DOWNLOAD_PICTURE;
        }

        public V2MerchantComplaintDownloadPictureRequest() {
        }

        public V2MerchantComplaintDownloadPictureRequest(string reqSeqId, string reqDate, string mediaUrl, string complaintId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.mediaUrl = mediaUrl;
            this.complaintId = complaintId;
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

        public string getMediaUrl() {
            return mediaUrl;
        }

        public void setMediaUrl(string mediaUrl) {
            this.mediaUrl = mediaUrl;
        }

        public string getComplaintId() {
            return complaintId;
        }

        public void setComplaintId(string complaintId) {
            this.complaintId = complaintId;
        }


    }
}
