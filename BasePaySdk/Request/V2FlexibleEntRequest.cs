using System;

namespace BasePaySdk.Request
{
    /**
     * 灵工企业商户进件接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleEntRequest : BaseRequest
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
         * 渠道商号
         */
        private string upperHuifuId;
        /**
         * 商户角色
         */
        private string merRole;
        /**
         * 落地公司类型当选择落地公司时，必填;SELF-自有，COOPERATE-合作
         */
        private string localCompanyType;
        /**
         * 商户名称
         */
        private string regName;
        /**
         * 商户简称
         */
        private string shortName;
        /**
         * 证照图片
         */
        private string licensePic;
        /**
         * 证照编号
         */
        private string licenseCode;
        /**
         * 证照有效期类型
         */
        private string licenseValidityType;
        /**
         * 证照有效期开始日期
         */
        private string licenseBeginDate;
        /**
         * 证照有效期截止日期格式：yyyyMMdd。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;  当license_validity_type&#x3D;0时必填；当license_validity_type&#x3D;1时为空；
         */
        private string licenseEndDate;
        /**
         * 成立时间
         */
        private string foundDate;
        /**
         * 注册区
         */
        private string regDistrictId;
        /**
         * 注册详细地址
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
         * 法人证件有效期截止日期日期格式：yyyyMMdd， &lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;当legal_cert_validity_type&#x3D;0时必填；&lt;br/&gt;当legal_cert_validity_type&#x3D;1时为空；&lt;br/&gt;
         */
        private string legalCertEndDate;
        /**
         * 法人证件地址
         */
        private string legalAddr;
        /**
         * 法人身份证国徽面
         */
        private string legalCertBackPic;
        /**
         * 法人身份证人像面
         */
        private string legalCertFrontPic;
        /**
         * 店铺门头照
         */
        private string storeHeaderPic;
        /**
         * 联系人手机号
         */
        private string contactMobileNo;
        /**
         * 联系人电子邮箱
         */
        private string contactEmail;
        /**
         * 管理员账号
         */
        private string loginName;
        /**
         * 银行卡信息配置
         */
        private string cardInfo;
        /**
         * 签约人
         */
        private string signUserInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_FLEXIBLE_ENT;
        }

        public V2FlexibleEntRequest() {
        }

        public V2FlexibleEntRequest(string reqSeqId, string reqDate, string upperHuifuId, string merRole, string localCompanyType, string regName, string shortName, string licensePic, string licenseCode, string licenseValidityType, string licenseBeginDate, string licenseEndDate, string foundDate, string regDistrictId, string regDetail, string legalName, string legalCertType, string legalCertNo, string legalCertValidityType, string legalCertBeginDate, string legalCertEndDate, string legalAddr, string legalCertBackPic, string legalCertFrontPic, string storeHeaderPic, string contactMobileNo, string contactEmail, string loginName, string cardInfo, string signUserInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.merRole = merRole;
            this.localCompanyType = localCompanyType;
            this.regName = regName;
            this.shortName = shortName;
            this.licensePic = licensePic;
            this.licenseCode = licenseCode;
            this.licenseValidityType = licenseValidityType;
            this.licenseBeginDate = licenseBeginDate;
            this.licenseEndDate = licenseEndDate;
            this.foundDate = foundDate;
            this.regDistrictId = regDistrictId;
            this.regDetail = regDetail;
            this.legalName = legalName;
            this.legalCertType = legalCertType;
            this.legalCertNo = legalCertNo;
            this.legalCertValidityType = legalCertValidityType;
            this.legalCertBeginDate = legalCertBeginDate;
            this.legalCertEndDate = legalCertEndDate;
            this.legalAddr = legalAddr;
            this.legalCertBackPic = legalCertBackPic;
            this.legalCertFrontPic = legalCertFrontPic;
            this.storeHeaderPic = storeHeaderPic;
            this.contactMobileNo = contactMobileNo;
            this.contactEmail = contactEmail;
            this.loginName = loginName;
            this.cardInfo = cardInfo;
            this.signUserInfo = signUserInfo;
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

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getMerRole() {
            return merRole;
        }

        public void setMerRole(string merRole) {
            this.merRole = merRole;
        }

        public string getLocalCompanyType() {
            return localCompanyType;
        }

        public void setLocalCompanyType(string localCompanyType) {
            this.localCompanyType = localCompanyType;
        }

        public string getRegName() {
            return regName;
        }

        public void setRegName(string regName) {
            this.regName = regName;
        }

        public string getShortName() {
            return shortName;
        }

        public void setShortName(string shortName) {
            this.shortName = shortName;
        }

        public string getLicensePic() {
            return licensePic;
        }

        public void setLicensePic(string licensePic) {
            this.licensePic = licensePic;
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

        public string getFoundDate() {
            return foundDate;
        }

        public void setFoundDate(string foundDate) {
            this.foundDate = foundDate;
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

        public string getLegalAddr() {
            return legalAddr;
        }

        public void setLegalAddr(string legalAddr) {
            this.legalAddr = legalAddr;
        }

        public string getLegalCertBackPic() {
            return legalCertBackPic;
        }

        public void setLegalCertBackPic(string legalCertBackPic) {
            this.legalCertBackPic = legalCertBackPic;
        }

        public string getLegalCertFrontPic() {
            return legalCertFrontPic;
        }

        public void setLegalCertFrontPic(string legalCertFrontPic) {
            this.legalCertFrontPic = legalCertFrontPic;
        }

        public string getStoreHeaderPic() {
            return storeHeaderPic;
        }

        public void setStoreHeaderPic(string storeHeaderPic) {
            this.storeHeaderPic = storeHeaderPic;
        }

        public string getContactMobileNo() {
            return contactMobileNo;
        }

        public void setContactMobileNo(string contactMobileNo) {
            this.contactMobileNo = contactMobileNo;
        }

        public string getContactEmail() {
            return contactEmail;
        }

        public void setContactEmail(string contactEmail) {
            this.contactEmail = contactEmail;
        }

        public string getLoginName() {
            return loginName;
        }

        public void setLoginName(string loginName) {
            this.loginName = loginName;
        }

        public string getCardInfo() {
            return cardInfo;
        }

        public void setCardInfo(string cardInfo) {
            this.cardInfo = cardInfo;
        }

        public string getSignUserInfo() {
            return signUserInfo;
        }

        public void setSignUserInfo(string signUserInfo) {
            this.signUserInfo = signUserInfo;
        }


    }
}
