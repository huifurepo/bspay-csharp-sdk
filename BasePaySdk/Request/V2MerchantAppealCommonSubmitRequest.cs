using System;

namespace BasePaySdk.Request
{
    /**
     * 提交申诉
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantAppealCommonSubmitRequest : BaseRequest
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
         * 商户经营模式
         */
        private string businessPattern;
        /**
         * 协查单号
         */
        private string assistId;
        /**
         * 申诉单号
         */
        private string appealId;
        /**
         * 商户类型
         */
        private string merType;
        /**
         * 申诉人姓名
         */
        private string appealPersonName;
        /**
         * 申诉人身份证号
         */
        private string appealPersonCertNo;
        /**
         * 申诉人联系电话
         */
        private string appealPersonPhoneNo;
        /**
         * 法人姓名
         */
        private string legalName;
        /**
         * 法人身份证号
         */
        private string legalCertNo;
        /**
         * 法人联系电话
         */
        private string legalPhoneNo;
        /**
         * 商户主营业务
         */
        private string mainBusiness;
        /**
         * 申诉理由
         */
        private string appealDesc;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_APPEAL_COMMON_SUBMIT;
        }

        public V2MerchantAppealCommonSubmitRequest() {
        }

        public V2MerchantAppealCommonSubmitRequest(string reqSeqId, string reqDate, string businessPattern, string assistId, string appealId, string merType, string appealPersonName, string appealPersonCertNo, string appealPersonPhoneNo, string legalName, string legalCertNo, string legalPhoneNo, string mainBusiness, string appealDesc) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.businessPattern = businessPattern;
            this.assistId = assistId;
            this.appealId = appealId;
            this.merType = merType;
            this.appealPersonName = appealPersonName;
            this.appealPersonCertNo = appealPersonCertNo;
            this.appealPersonPhoneNo = appealPersonPhoneNo;
            this.legalName = legalName;
            this.legalCertNo = legalCertNo;
            this.legalPhoneNo = legalPhoneNo;
            this.mainBusiness = mainBusiness;
            this.appealDesc = appealDesc;
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

        public string getBusinessPattern() {
            return businessPattern;
        }

        public void setBusinessPattern(string businessPattern) {
            this.businessPattern = businessPattern;
        }

        public string getAssistId() {
            return assistId;
        }

        public void setAssistId(string assistId) {
            this.assistId = assistId;
        }

        public string getAppealId() {
            return appealId;
        }

        public void setAppealId(string appealId) {
            this.appealId = appealId;
        }

        public string getMerType() {
            return merType;
        }

        public void setMerType(string merType) {
            this.merType = merType;
        }

        public string getAppealPersonName() {
            return appealPersonName;
        }

        public void setAppealPersonName(string appealPersonName) {
            this.appealPersonName = appealPersonName;
        }

        public string getAppealPersonCertNo() {
            return appealPersonCertNo;
        }

        public void setAppealPersonCertNo(string appealPersonCertNo) {
            this.appealPersonCertNo = appealPersonCertNo;
        }

        public string getAppealPersonPhoneNo() {
            return appealPersonPhoneNo;
        }

        public void setAppealPersonPhoneNo(string appealPersonPhoneNo) {
            this.appealPersonPhoneNo = appealPersonPhoneNo;
        }

        public string getLegalName() {
            return legalName;
        }

        public void setLegalName(string legalName) {
            this.legalName = legalName;
        }

        public string getLegalCertNo() {
            return legalCertNo;
        }

        public void setLegalCertNo(string legalCertNo) {
            this.legalCertNo = legalCertNo;
        }

        public string getLegalPhoneNo() {
            return legalPhoneNo;
        }

        public void setLegalPhoneNo(string legalPhoneNo) {
            this.legalPhoneNo = legalPhoneNo;
        }

        public string getMainBusiness() {
            return mainBusiness;
        }

        public void setMainBusiness(string mainBusiness) {
            this.mainBusiness = mainBusiness;
        }

        public string getAppealDesc() {
            return appealDesc;
        }

        public void setAppealDesc(string appealDesc) {
            this.appealDesc = appealDesc;
        }


    }
}
