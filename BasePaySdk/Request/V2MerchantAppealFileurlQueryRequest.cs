using System;

namespace BasePaySdk.Request
{
    /**
     * 申诉文件url查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantAppealFileurlQueryRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 申诉文件Id
         */
        private string fileId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_APPEAL_FILEURL_QUERY;
        }

        public V2MerchantAppealFileurlQueryRequest() {
        }

        public V2MerchantAppealFileurlQueryRequest(string reqSeqId, string reqDate, string fileId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.fileId = fileId;
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

        public string getFileId() {
            return fileId;
        }

        public void setFileId(string fileId) {
            this.fileId = fileId;
        }


    }
}
