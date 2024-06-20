using System;

namespace BasePaySdk.Request
{
    /**
     * 上传短信验证码
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceMerVerifycodeUploadRequest : BaseRequest
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
         * 开票方汇付ID
         */
        private string huifuId;
        /**
         * 校验类型
         */
        private string verifyType;
        /**
         * 流水号
         */
        private string serialNum;
        /**
         * 验证码
         */
        private string verifyCode;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_MER_VERIFYCODE_UPLOAD;
        }

        public V2InvoiceMerVerifycodeUploadRequest() {
        }

        public V2InvoiceMerVerifycodeUploadRequest(string reqSeqId, string reqDate, string huifuId, string verifyType, string serialNum, string verifyCode) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.verifyType = verifyType;
            this.serialNum = serialNum;
            this.verifyCode = verifyCode;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getVerifyType() {
            return verifyType;
        }

        public void setVerifyType(string verifyType) {
            this.verifyType = verifyType;
        }

        public string getSerialNum() {
            return serialNum;
        }

        public void setSerialNum(string serialNum) {
            this.serialNum = serialNum;
        }

        public string getVerifyCode() {
            return verifyCode;
        }

        public void setVerifyCode(string verifyCode) {
            this.verifyCode = verifyCode;
        }


    }
}
