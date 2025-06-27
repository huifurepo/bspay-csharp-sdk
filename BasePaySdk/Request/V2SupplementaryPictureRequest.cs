using System;

namespace BasePaySdk.Request
{
    /**
     * 图片上传
     *
     * @author sdk-generator
     * @Description
     */
    public class V2SupplementaryPictureRequest : BaseRequest
    {

        /**
         * 业务请求流水号
         */
        private string reqSeqId;
        /**
         * 业务请求日期
         */
        private string reqDate;
        /**
         * 图片类型
         */
        private string fileType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_SUPPLEMENTARY_PICTURE;
        }

        public V2SupplementaryPictureRequest() {
        }

        public V2SupplementaryPictureRequest(string reqSeqId, string reqDate, string fileType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.fileType = fileType;
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

        public string getFileType() {
            return fileType;
        }

        public void setFileType(string fileType) {
            this.fileType = fileType;
        }


    }
}
