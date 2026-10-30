using System;

namespace BasePaySdk.Request
{
    /**
     * 电子协议签署链接重发
     *
     * @author sdk-generator
     * @Description
     */
    public class V2AgreementElectSignurlResendRequest : BaseRequest
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
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 协议编号
         */
        private string agreementId;
        /**
         * 个人邮箱
         */
        private string signUserEmail;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_AGREEMENT_ELECT_SIGNURL_RESEND;
        }

        public V2AgreementElectSignurlResendRequest() {
        }

        public V2AgreementElectSignurlResendRequest(string reqSeqId, string reqDate, string huifuId, string agreementId, string signUserEmail) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.agreementId = agreementId;
            this.signUserEmail = signUserEmail;
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

        public string getAgreementId() {
            return agreementId;
        }

        public void setAgreementId(string agreementId) {
            this.agreementId = agreementId;
        }

        public string getSignUserEmail() {
            return signUserEmail;
        }

        public void setSignUserEmail(string signUserEmail) {
            this.signUserEmail = signUserEmail;
        }


    }
}
