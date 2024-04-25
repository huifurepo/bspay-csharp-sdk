using System;

namespace BasePaySdk.Request
{
    /**
     * 企业商户基本信息入驻(2022)
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBasicdataEntRequest : BaseRequest
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
         * 直属渠道号
         */
        private string upperHuifuId;
        /**
         * 商户名称
         */
        private string regName;
        /**
         * 商户简称
         */
        private string shortName;
        /**
         * 公司类型
         */
        private string entType;
        /**
         * 营业执照编号
         */
        private string licenseCode;
        /**
         * 营业执照有效期类型
         */
        private string licenseValidityType;
        /**
         * 营业执照有效期开始日期
         */
        private string licenseBeginDate;
        /**
         * 营业执照有效期截止日期日期格式：yyyyMMdd，以北京时间为准。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;  当license_validity_type&#x3D;0时必填  ;当license_validity_type&#x3D;1时为空；当使用总部资质时不填
         */
        private string licenseEndDate;
        /**
         * 注册省
         */
        private string regProvId;
        /**
         * 注册市
         */
        private string regAreaId;
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
         * 法人证件有效期截止日期日期格式：yyyyMMdd，以北京时间为准。  &lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;当legal_cert_validity_type&#x3D;0时必填 ；当legal_cert_validity_type&#x3D;1时为空 ；当使用总部资质时不填
         */
        private string legalCertEndDate;
        /**
         * 经营省
         */
        private string provId;
        /**
         * 经营市
         */
        private string areaId;
        /**
         * 经营区
         */
        private string districtId;
        /**
         * 经营详细地址
         */
        private string detailAddr;
        /**
         * 联系人姓名
         */
        private string contactName;
        /**
         * 联系人手机号
         */
        private string contactMobileNo;
        /**
         * 联系人电子邮箱
         */
        private string contactEmail;
        /**
         * 客服电话
         */
        private string servicePhone;
        /**
         * 经营类型
         */
        private string busiType;
        /**
         * 小票名称
         */
        private string receiptName;
        /**
         * 所属行业
         */
        private string mcc;
        /**
         * 结算卡信息配置
         */
        private string cardInfo;
        /**
         * 基本存款账户编号或核准号基本存款账户信息请填写基本存款账户编号；开户许可证请填写核准号 ；&lt;br/&gt;当注册地址或经营地址为如下地区时必填：浙江,海南,重庆,河南,江苏,宁波市,黑龙江,吉林,湖南,贵州,陕西,湖北 &lt;br/&gt;当使用总部资质时不填 ；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：J2900123456789&lt;/font&gt;
         */
        private string openLicenceNo;
        /**
         * 总部汇付Id如果headOfficeFlag&#x3D;0，useHeadInfoFlag&#x3D;Y,且head_huifu_id不为空则基本信息部分复用总部的基本信息。&lt;br/&gt;如果head_office_flag&#x3D;0，则字段必填,如果head_office_flag&#x3D;1，总部汇付Id不可传&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
         */
        private string headHuifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BASICDATA_ENT;
        }

        public V2MerchantBasicdataEntRequest() {
        }

        public V2MerchantBasicdataEntRequest(string reqSeqId, string reqDate, string upperHuifuId, string regName, string shortName, string entType, string licenseCode, string licenseValidityType, string licenseBeginDate, string licenseEndDate, string regProvId, string regAreaId, string regDistrictId, string regDetail, string legalName, string legalCertType, string legalCertNo, string legalCertValidityType, string legalCertBeginDate, string legalCertEndDate, string provId, string areaId, string districtId, string detailAddr, string contactName, string contactMobileNo, string contactEmail, string servicePhone, string busiType, string receiptName, string mcc, string cardInfo, string openLicenceNo, string headHuifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.regName = regName;
            this.shortName = shortName;
            this.entType = entType;
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
            this.provId = provId;
            this.areaId = areaId;
            this.districtId = districtId;
            this.detailAddr = detailAddr;
            this.contactName = contactName;
            this.contactMobileNo = contactMobileNo;
            this.contactEmail = contactEmail;
            this.servicePhone = servicePhone;
            this.busiType = busiType;
            this.receiptName = receiptName;
            this.mcc = mcc;
            this.cardInfo = cardInfo;
            this.openLicenceNo = openLicenceNo;
            this.headHuifuId = headHuifuId;
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

        public string getEntType() {
            return entType;
        }

        public void setEntType(string entType) {
            this.entType = entType;
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

        public string getProvId() {
            return provId;
        }

        public void setProvId(string provId) {
            this.provId = provId;
        }

        public string getAreaId() {
            return areaId;
        }

        public void setAreaId(string areaId) {
            this.areaId = areaId;
        }

        public string getDistrictId() {
            return districtId;
        }

        public void setDistrictId(string districtId) {
            this.districtId = districtId;
        }

        public string getDetailAddr() {
            return detailAddr;
        }

        public void setDetailAddr(string detailAddr) {
            this.detailAddr = detailAddr;
        }

        public string getContactName() {
            return contactName;
        }

        public void setContactName(string contactName) {
            this.contactName = contactName;
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

        public string getServicePhone() {
            return servicePhone;
        }

        public void setServicePhone(string servicePhone) {
            this.servicePhone = servicePhone;
        }

        public string getBusiType() {
            return busiType;
        }

        public void setBusiType(string busiType) {
            this.busiType = busiType;
        }

        public string getReceiptName() {
            return receiptName;
        }

        public void setReceiptName(string receiptName) {
            this.receiptName = receiptName;
        }

        public string getMcc() {
            return mcc;
        }

        public void setMcc(string mcc) {
            this.mcc = mcc;
        }

        public string getCardInfo() {
            return cardInfo;
        }

        public void setCardInfo(string cardInfo) {
            this.cardInfo = cardInfo;
        }

        public string getOpenLicenceNo() {
            return openLicenceNo;
        }

        public void setOpenLicenceNo(string openLicenceNo) {
            this.openLicenceNo = openLicenceNo;
        }

        public string getHeadHuifuId() {
            return headHuifuId;
        }

        public void setHeadHuifuId(string headHuifuId) {
            this.headHuifuId = headHuifuId;
        }


    }
}
