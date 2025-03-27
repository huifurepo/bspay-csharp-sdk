using System;

namespace BasePaySdk.Request
{
    /**
     * 钱包开户
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletCreateRequest : BaseRequest
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
         * 个人姓名钱包账户开户人的本人真实姓名；wallet_type&#x3D;1时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：张三&lt;/font&gt;
         */
        private string name;
        /**
         * 钱包绑定手机号
         */
        private string mobileNo;
        /**
         * 手机短信验证码
         */
        private string verifyCode;
        /**
         * 短信验证流水号
         */
        private string verifySeqId;
        /**
         * 跳转地址
         */
        private string frontUrl;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_CREATE;
        }

        public V2WalletCreateRequest() {
        }

        public V2WalletCreateRequest(string reqSeqId, string reqDate, string huifuId, string name, string mobileNo, string verifyCode, string verifySeqId, string frontUrl) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.name = name;
            this.mobileNo = mobileNo;
            this.verifyCode = verifyCode;
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

        public string getName() {
            return name;
        }

        public void setName(string name) {
            this.name = name;
        }

        public string getMobileNo() {
            return mobileNo;
        }

        public void setMobileNo(string mobileNo) {
            this.mobileNo = mobileNo;
        }

        public string getVerifyCode() {
            return verifyCode;
        }

        public void setVerifyCode(string verifyCode) {
            this.verifyCode = verifyCode;
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
