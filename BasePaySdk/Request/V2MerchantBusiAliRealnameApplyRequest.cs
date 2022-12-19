using System;

namespace BasePaySdk.Request
{
    /**
     * 支付宝实名申请提交
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiAliRealnameApplyRequest : BaseRequest
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
         * 汇付ID
         */
        private string huifuId;
        /**
         * 联系人信息
         */
        private string contactPersonInfo;
        /**
         * 主体信息
         */
        private string authIdentityInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_ALI_REALNAME_APPLY;
        }

        public V2MerchantBusiAliRealnameApplyRequest() {
        }

        public V2MerchantBusiAliRealnameApplyRequest(string reqSeqId, string reqDate, string huifuId, string contactPersonInfo, string authIdentityInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.contactPersonInfo = contactPersonInfo;
            this.authIdentityInfo = authIdentityInfo;
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

        public string getContactPersonInfo() {
            return contactPersonInfo;
        }

        public void setContactPersonInfo(string contactPersonInfo) {
            this.contactPersonInfo = contactPersonInfo;
        }

        public string getAuthIdentityInfo() {
            return authIdentityInfo;
        }

        public void setAuthIdentityInfo(string authIdentityInfo) {
            this.authIdentityInfo = authIdentityInfo;
        }


    }
}
