using System;

namespace BasePaySdk.Request
{
    /**
     * 微信实名认证
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiRealnameRequest : BaseRequest
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
         * 联系人姓名
         */
        private string name;
        /**
         * 联系人手机号
         */
        private string mobile;
        /**
         * 联系人身份证号码
         */
        private string idCardNumber;
        /**
         * 联系人类型
         */
        private string contactType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_REALNAME;
        }

        public V2MerchantBusiRealnameRequest() {
        }

        public V2MerchantBusiRealnameRequest(string reqSeqId, string reqDate, string huifuId, string name, string mobile, string idCardNumber, string contactType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.name = name;
            this.mobile = mobile;
            this.idCardNumber = idCardNumber;
            this.contactType = contactType;
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

        public string getMobile() {
            return mobile;
        }

        public void setMobile(string mobile) {
            this.mobile = mobile;
        }

        public string getIdCardNumber() {
            return idCardNumber;
        }

        public void setIdCardNumber(string idCardNumber) {
            this.idCardNumber = idCardNumber;
        }

        public string getContactType() {
            return contactType;
        }

        public void setContactType(string contactType) {
            this.contactType = contactType;
        }


    }
}
