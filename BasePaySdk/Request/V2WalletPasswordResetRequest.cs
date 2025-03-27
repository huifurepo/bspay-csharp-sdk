using System;

namespace BasePaySdk.Request
{
    /**
     * 钱包密码重置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletPasswordResetRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;
        /**
         * 钱包用户ID
         */
        private string userHuifuId;
        /**
         * 钱包绑定手机号
         */
        private string custMobile;
        /**
         * 手机短信验证码
         */
        private string verifyNo;
        /**
         * 短信验证流水号
         */
        private string verifySeqId;
        /**
         * 跳转地址
         */
        private string frontUrl;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_PASSWORD_RESET;
        }

        public V2WalletPasswordResetRequest() {
        }

        public V2WalletPasswordResetRequest(string reqSeqId, string reqDate, string huifuId, string userHuifuId, string custMobile, string verifyNo, string verifySeqId, string frontUrl) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.userHuifuId = userHuifuId;
            this.custMobile = custMobile;
            this.verifyNo = verifyNo;
            this.verifySeqId = verifySeqId;
            this.frontUrl = frontUrl;
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

        public string getUserHuifuId() {
            return userHuifuId;
        }

        public void setUserHuifuId(string userHuifuId) {
            this.userHuifuId = userHuifuId;
        }

        public string getCustMobile() {
            return custMobile;
        }

        public void setCustMobile(string custMobile) {
            this.custMobile = custMobile;
        }

        public string getVerifyNo() {
            return verifyNo;
        }

        public void setVerifyNo(string verifyNo) {
            this.verifyNo = verifyNo;
        }

        public string getVerifySeqId() {
            return verifySeqId;
        }

        public void setVerifySeqId(string verifySeqId) {
            this.verifySeqId = verifySeqId;
        }

        public string getFrontUrl() {
            return frontUrl;
        }

        public void setFrontUrl(string frontUrl) {
            this.frontUrl = frontUrl;
        }


    }
}
