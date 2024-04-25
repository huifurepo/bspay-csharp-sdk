using System;

namespace BasePaySdk.Request
{
    /**
     * 企业用户基本信息开户
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBasicdataEntRequest : BaseRequest
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
         * 企业用户名称
         */
        private string regName;
        /**
         * 营业执照编号
         */
        private string licenseCode;
        /**
         * 证照有效期类型
         */
        private string licenseValidityType;
        /**
         * 证照有效期起始日期
         */
        private string licenseBeginDate;
        /**
         * 证照有效期结束日期日期格式：yyyyMMdd; 非长期有效时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20320905&lt;/font&gt;
         */
        private string licenseEndDate;
        /**
         * 注册地址(省)
         */
        private string regProvId;
        /**
         * 注册地址(市)
         */
        private string regAreaId;
        /**
         * 注册地址(区)
         */
        private string regDistrictId;
        /**
         * 注册地址(详细信息)
         */
        private string regDetail;
        /**
         * 法人姓名
         */
        private string legalName;
        /**
         * 法人证件类型
         */
        private string legalCertType;
        /**
         * 法人证件号码
         */
        private string legalCertNo;
        /**
         * 法人证件有效期类型
         */
        private string legalCertValidityType;
        /**
         * 法人证件有效期开始日期
         */
        private string legalCertBeginDate;
        /**
         * 法人证件有效期截止日期日期格式：yyyyMMdd; 非长期有效时必填，长期有效为空；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20320905&lt;/font&gt;
         */
        private string legalCertEndDate;
        /**
         * 联系人姓名
         */
        private string contactName;
        /**
         * 联系人手机号
         */
        private string contactMobile;
        /**
         * 管理员账号如需短信通知则必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：Lg20220222013747&lt;/font&gt;
         */
        private string loginName;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_USER_BASICDATA_ENT;
        }

        public V2UserBasicdataEntRequest() {
        }

        public V2UserBasicdataEntRequest(string reqSeqId, string reqDate, string regName, string licenseCode, string licenseValidityType, string licenseBeginDate, string licenseEndDate, string regProvId, string regAreaId, string regDistrictId, string regDetail, string legalName, string legalCertType, string legalCertNo, string legalCertValidityType, string legalCertBeginDate, string legalCertEndDate, string contactName, string contactMobile, string loginName) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.regName = regName;
            this.licenseCode = licenseCode;
            this.licenseValidityType = licenseValidityType;
            this.licenseBeginDate = licenseBeginDate;
            this.licenseEndDate = licenseEndDate;
            this.regProvId = regProvId;
            this.regAreaId = regAreaId;
            this.regDistrictId = regDistrictId;
            this.regDetail = regDetail;
            this.legalName = legalName;
            this.legalCertType = legalCertType;
            this.legalCertNo = legalCertNo;
            this.legalCertValidityType = legalCertValidityType;
            this.legalCertBeginDate = legalCertBeginDate;
            this.legalCertEndDate = legalCertEndDate;
            this.contactName = contactName;
            this.contactMobile = contactMobile;
            this.loginName = loginName;
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

        public string getRegName() {
            return regName;
        }

        public void setRegName(string regName) {
            this.regName = regName;
        }

        public string getLicenseCode() {
            return licenseCode;
        }

        public void setLicenseCode(string licenseCode) {
            this.licenseCode = licenseCode;
        }

        public string getLicenseValidityType() {
            return licenseValidityType;
        }

        public void setLicenseValidityType(string licenseValidityType) {
            this.licenseValidityType = licenseValidityType;
        }

        public string getLicenseBeginDate() {
            return licenseBeginDate;
        }

        public void setLicenseBeginDate(string licenseBeginDate) {
            this.licenseBeginDate = licenseBeginDate;
        }

        public string getLicenseEndDate() {
            return licenseEndDate;
        }

        public void setLicenseEndDate(string licenseEndDate) {
            this.licenseEndDate = licenseEndDate;
        }

        public string getRegProvId() {
            return regProvId;
        }

        public void setRegProvId(string regProvId) {
            this.regProvId = regProvId;
        }

        public string getRegAreaId() {
            return regAreaId;
        }

        public void setRegAreaId(string regAreaId) {
            this.regAreaId = regAreaId;
        }

        public string getRegDistrictId() {
            return regDistrictId;
        }

        public void setRegDistrictId(string regDistrictId) {
            this.regDistrictId = regDistrictId;
        }

        public string getRegDetail() {
            return regDetail;
        }

        public void setRegDetail(string regDetail) {
            this.regDetail = regDetail;
        }

        public string getLegalName() {
            return legalName;
        }

        public void setLegalName(string legalName) {
            this.legalName = legalName;
        }

        public string getLegalCertType() {
            return legalCertType;
        }

        public void setLegalCertType(string legalCertType) {
            this.legalCertType = legalCertType;
        }

        public string getLegalCertNo() {
            return legalCertNo;
        }

        public void setLegalCertNo(string legalCertNo) {
            this.legalCertNo = legalCertNo;
        }

        public string getLegalCertValidityType() {
            return legalCertValidityType;
        }

        public void setLegalCertValidityType(string legalCertValidityType) {
            this.legalCertValidityType = legalCertValidityType;
        }

        public string getLegalCertBeginDate() {
            return legalCertBeginDate;
        }

        public void setLegalCertBeginDate(string legalCertBeginDate) {
            this.legalCertBeginDate = legalCertBeginDate;
        }

        public string getLegalCertEndDate() {
            return legalCertEndDate;
        }

        public void setLegalCertEndDate(string legalCertEndDate) {
            this.legalCertEndDate = legalCertEndDate;
        }

        public string getContactName() {
            return contactName;
        }

        public void setContactName(string contactName) {
            this.contactName = contactName;
        }

        public string getContactMobile() {
            return contactMobile;
        }

        public void setContactMobile(string contactMobile) {
            this.contactMobile = contactMobile;
        }

        public string getLoginName() {
            return loginName;
        }

        public void setLoginName(string loginName) {
            this.loginName = loginName;
        }


    }
}
