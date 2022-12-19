using System;

namespace BasePaySdk.Request
{
    /**
     * 个人用户基本信息开户
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBasicdataIndvRequest : BaseRequest
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
         * 个人姓名
         */
        private string name;
        /**
         * 个人证件类型
         */
        private string certType;
        /**
         * 个人证件号码
         */
        private string certNo;
        /**
         * 个人证件有效期类型
         */
        private string certValidityType;
        /**
         * 个人证件有效期开始日期
         */
        private string certBeginDate;
        /**
         * 手机号
         */
        private string mobileNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_USER_BASICDATA_INDV;
        }

        public V2UserBasicdataIndvRequest() {
        }

        public V2UserBasicdataIndvRequest(string reqSeqId, string reqDate, string name, string certType, string certNo, string certValidityType, string certBeginDate, string mobileNo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.name = name;
            this.certType = certType;
            this.certNo = certNo;
            this.certValidityType = certValidityType;
            this.certBeginDate = certBeginDate;
            this.mobileNo = mobileNo;
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

        public string getName() {
            return name;
        }

        public void setName(string name) {
            this.name = name;
        }

        public string getCertType() {
            return certType;
        }

        public void setCertType(string certType) {
            this.certType = certType;
        }

        public string getCertNo() {
            return certNo;
        }

        public void setCertNo(string certNo) {
            this.certNo = certNo;
        }

        public string getCertValidityType() {
            return certValidityType;
        }

        public void setCertValidityType(string certValidityType) {
            this.certValidityType = certValidityType;
        }

        public string getCertBeginDate() {
            return certBeginDate;
        }

        public void setCertBeginDate(string certBeginDate) {
            this.certBeginDate = certBeginDate;
        }

        public string getMobileNo() {
            return mobileNo;
        }

        public void setMobileNo(string mobileNo) {
            this.mobileNo = mobileNo;
        }


    }
}
