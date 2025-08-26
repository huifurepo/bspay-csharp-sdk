using System;

namespace BasePaySdk.Request
{
    /**
     * 直付通商户入驻
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectZftRegRequest : BaseRequest
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
         * 汇付ID
         */
        private string huifuId;
        /**
         * 进件的二级商户名称
         */
        private string name;
        /**
         * 商家类型
         */
        private string merchantType;
        /**
         * 商户经营类目
         */
        private string mcc;
        /**
         * 商户证件类型
         */
        private string certType;
        /**
         * 商户证件编号
         */
        private string certNo;
        /**
         * 证件名称目前只有个体工商户商户类型要求填入本字段，填写值为个体工商户营业执照上的名称。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：xxxx小卖铺&lt;/font&gt;
         */
        private string certName;
        /**
         * 法人名称仅个人商户非必填，其他必填。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：张三&lt;/font&gt;
         */
        private string legalName;
        /**
         * 法人证件号码仅个人商户非必填，其他必填。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：3209261975120284333&lt;/font&gt;
         */
        private string legalCertNo;
        /**
         * 客服电话
         */
        private string servicePhone;
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
         * 商户联系人业务标识
         */
        private string contactTag;
        /**
         * 联系人类型
         */
        private string contactType;
        /**
         * 联系人手机号
         */
        private string contactMobileNo;
        /**
         * 商户结算卡信息jsonArray格式。本业务当前只允许传入一张结算卡。与支付宝账号字段二选一必填
         */
        private string zftCardInfoList;
        /**
         * 商户支付宝账号商户支付宝账号，用作结算账号。与银行卡对象字段二选一必填。&lt;br/&gt;本字段要求支付宝账号的名称与商户名称mch_name同名，且是实名认证过的支付宝账户。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：test@huifu.com&lt;/font&gt;
         */
        private string alipayLogonId;
        /**
         * 商户行业资质类型当商户是特殊行业时必填，具体取值[参见表格](https://mif-pub.alipayobjects.com/QualificationType.xlsx)。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：310&lt;/font&gt;
         */
        private string industryQualificationType;
        /**
         * 商户使用服务
         */
        private string service;
        /**
         * 商户与服务商的签约时间
         */
        private string signTimeWithIsv;
        /**
         * 商户支付宝账户用于协议确认。目前商业场景（除医疗、中小学教育等）下必填。本字段要求上送的支付宝账号的名称与商户名称name同名，且是实名认证支付宝账户。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：test@huifu.com&lt;/font&gt;
         */
        private string bindingAlipayLogonId;
        /**
         * 默认结算类型
         */
        private string defaultSettleType;
        /**
         * 文件列表
         */
        private string fileList;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_ZFT_REG;
        }

        public V2MerchantDirectZftRegRequest() {
        }

        public V2MerchantDirectZftRegRequest(string reqSeqId, string reqDate, string huifuId, string name, string merchantType, string mcc, string certType, string certNo, string certName, string legalName, string legalCertNo, string servicePhone, string provId, string areaId, string districtId, string detailAddr, string contactName, string contactTag, string contactType, string contactMobileNo, string zftCardInfoList, string alipayLogonId, string industryQualificationType, string service, string signTimeWithIsv, string bindingAlipayLogonId, string defaultSettleType, string fileList) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.name = name;
            this.merchantType = merchantType;
            this.mcc = mcc;
            this.certType = certType;
            this.certNo = certNo;
            this.certName = certName;
            this.legalName = legalName;
            this.legalCertNo = legalCertNo;
            this.servicePhone = servicePhone;
            this.provId = provId;
            this.areaId = areaId;
            this.districtId = districtId;
            this.detailAddr = detailAddr;
            this.contactName = contactName;
            this.contactTag = contactTag;
            this.contactType = contactType;
            this.contactMobileNo = contactMobileNo;
            this.zftCardInfoList = zftCardInfoList;
            this.alipayLogonId = alipayLogonId;
            this.industryQualificationType = industryQualificationType;
            this.service = service;
            this.signTimeWithIsv = signTimeWithIsv;
            this.bindingAlipayLogonId = bindingAlipayLogonId;
            this.defaultSettleType = defaultSettleType;
            this.fileList = fileList;
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

        public string getMerchantType() {
            return merchantType;
        }

        public void setMerchantType(string merchantType) {
            this.merchantType = merchantType;
        }

        public string getMcc() {
            return mcc;
        }

        public void setMcc(string mcc) {
            this.mcc = mcc;
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

        public string getCertName() {
            return certName;
        }

        public void setCertName(string certName) {
            this.certName = certName;
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

        public string getServicePhone() {
            return servicePhone;
        }

        public void setServicePhone(string servicePhone) {
            this.servicePhone = servicePhone;
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

        public string getContactTag() {
            return contactTag;
        }

        public void setContactTag(string contactTag) {
            this.contactTag = contactTag;
        }

        public string getContactType() {
            return contactType;
        }

        public void setContactType(string contactType) {
            this.contactType = contactType;
        }

        public string getContactMobileNo() {
            return contactMobileNo;
        }

        public void setContactMobileNo(string contactMobileNo) {
            this.contactMobileNo = contactMobileNo;
        }

        public string getZftCardInfoList() {
            return zftCardInfoList;
        }

        public void setZftCardInfoList(string zftCardInfoList) {
            this.zftCardInfoList = zftCardInfoList;
        }

        public string getAlipayLogonId() {
            return alipayLogonId;
        }

        public void setAlipayLogonId(string alipayLogonId) {
            this.alipayLogonId = alipayLogonId;
        }

        public string getIndustryQualificationType() {
            return industryQualificationType;
        }

        public void setIndustryQualificationType(string industryQualificationType) {
            this.industryQualificationType = industryQualificationType;
        }

        public string getService() {
            return service;
        }

        public void setService(string service) {
            this.service = service;
        }

        public string getSignTimeWithIsv() {
            return signTimeWithIsv;
        }

        public void setSignTimeWithIsv(string signTimeWithIsv) {
            this.signTimeWithIsv = signTimeWithIsv;
        }

        public string getBindingAlipayLogonId() {
            return bindingAlipayLogonId;
        }

        public void setBindingAlipayLogonId(string bindingAlipayLogonId) {
            this.bindingAlipayLogonId = bindingAlipayLogonId;
        }

        public string getDefaultSettleType() {
            return defaultSettleType;
        }

        public void setDefaultSettleType(string defaultSettleType) {
            this.defaultSettleType = defaultSettleType;
        }

        public string getFileList() {
            return fileList;
        }

        public void setFileList(string fileList) {
            this.fileList = fileList;
        }


    }
}
