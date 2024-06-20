using System;

namespace BasePaySdk.Request
{
    /**
     * 开票员登记
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceClerkRegRequest : BaseRequest
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
         * 商户汇付Id
         */
        private string huifuId;
        /**
         * 开票员登录身份
         */
        private string clerkIdentity;
        /**
         * 登录账号
         */
        private string loginAccount;
        /**
         * 登录密码
         */
        private string loginPassword;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_CLERK_REG;
        }

        public V2InvoiceClerkRegRequest() {
        }

        public V2InvoiceClerkRegRequest(string reqSeqId, string reqDate, string huifuId, string clerkIdentity, string loginAccount, string loginPassword) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.clerkIdentity = clerkIdentity;
            this.loginAccount = loginAccount;
            this.loginPassword = loginPassword;
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

        public string getClerkIdentity() {
            return clerkIdentity;
        }

        public void setClerkIdentity(string clerkIdentity) {
            this.clerkIdentity = clerkIdentity;
        }

        public string getLoginAccount() {
            return loginAccount;
        }

        public void setLoginAccount(string loginAccount) {
            this.loginAccount = loginAccount;
        }

        public string getLoginPassword() {
            return loginPassword;
        }

        public void setLoginPassword(string loginPassword) {
            this.loginPassword = loginPassword;
        }


    }
}
