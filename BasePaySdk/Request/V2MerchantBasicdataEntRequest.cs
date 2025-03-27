using System;

namespace BasePaySdk.Request
{
    /**
     * 企业商户进件
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
         * 渠道商号
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
         * 小票名称
         */
        private string receiptName;
        /**
         * 公司类型
         */
        private string entType;
        /**
         * 所属行业参考[汇付MCC编码](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_hfmccbm) ；当use_head_info_flag&#x3D;Y时不填&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：5311&lt;/font&gt;
         */
        private string mcc;
        /**
         * 经营类型1：实体，2：虚拟 ；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1&lt;/font&gt; ；当use_head_info_flag&#x3D;Y时不填
         */
        private string busiType;
        /**
         * 场景类型
         */
        private string sceneType;
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
         * 证照有效期截止日期格式：yyyyMMdd。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;  当license_validity_type&#x3D;0时必填；当license_validity_type&#x3D;1时为空；当use_head_info_flag&#x3D;Y时不填
         */
        private string licenseEndDate;
        /**
         * 成立时间
         */
        private string foundDate;
        /**
         * 注册资本保留两位小数；条件选填，国营企业、私营企业、外资企业、事业单位、其他、集体经济必填，政府机构、个体工商户可为空；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：100.00&lt;/font&gt;
         */
        private string regCapital;
        /**
         * 注册区
         */
        private string regDistrictId;
        /**
         * 注册详细地址
         */
        private string regDetail;
        /**
         * 经营区
         */
        private string districtId;
        /**
         * 经营详细地址scene_type&#x3D;OFFLINE/ALL时必填；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：上海市徐汇区XX路XX号&lt;/font&gt;
         */
        private string detailAddr;
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
         * 法人证件有效期截止日期日期格式：yyyyMMdd， &lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;当legal_cert_validity_type&#x3D;0时必填；&lt;br/&gt;当legal_cert_validity_type&#x3D;1时为空；&lt;br/&gt;当use_head_info_flag&#x3D;Y时不填
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
         * 开户许可证企业商户需要，结算账号为对公账户必填；通过[图片上传接口](https://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)上传材料；文件类型：F08；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string regAcctPic;
        /**
         * 基本存款账户编号或核准号条件选填；当use_head_info_flag&#x3D;Y时不填 ；&lt;br/&gt;基本存款账户信息请填写基本存款账户编号；开户许可证请填写核准号。&lt;br/&gt;当注册地址或经营地址为如下地区时必填：江苏省、浙江省、湖南省、湖北省、云南省、贵州省、陕西省、河南省、吉林省、黑龙江省、福建省、海南省、重庆市、青海省、宁夏回族自治区；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：J2900123456789&lt;/font&gt;
         */
        private string openLicenceNo;
        /**
         * 银行卡信息配置
         */
        private string cardInfo;
        /**
         * 卡正面对私必填。通过[图片上传接口](https://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)上传材料；文件类型：F13 ；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string settleCardFrontPic;
        /**
         * 持卡人身份证国徽面**对私必填**。通过[图片上传接口](https://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)上传材料；文件类型：F56；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string settleCertBackPic;
        /**
         * 持卡人身份证人像面**对私必填**。通过[图片上传接口](https://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)上传材料；文件类型：F55；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string settleCertFrontPic;
        /**
         * 授权委托书**对私非法人、对公非同名结算必填**；通过[图片上传接口](https://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)上传材料；文件类型：F15；开通银行电子账户（中信E管家）需提供F520；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string authEnturstPic;
        /**
         * 上级汇付Id如果head_office_flag&#x3D;0，则字段必填，如果head_office_flag&#x3D;1，上级汇付Id不可传&lt;br/&gt;如果headOfficeFlag&#x3D;0，useHeadInfoFlag&#x3D;Y,且head_huifu_id不为空则基本信息部分复用上级的基本信息。&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
         */
        private string headHuifuId;
        /**
         * 商户ICP备案编号商户ICP备案编号或网站许可证号；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：沪ICP备06046402号-28 &lt;/font&gt;&lt;br/&gt;类型为PC网站时，且为企业商户，且开通快捷或网银，或大额转账，或余额支付或分账业务（20%（不含）-100%），或为个人商户开通分账业务（10%（不含）-100%），必填
         */
        private string merIcp;
        /**
         * 店铺门头照
         */
        private string storeHeaderPic;
        /**
         * 店铺内景/工作区域照
         */
        private string storeIndoorPic;
        /**
         * 店铺收银台/公司前台照
         */
        private string storeCashierDeskPic;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BASICDATA_ENT;
        }

        public V2MerchantBasicdataEntRequest() {
        }

        public V2MerchantBasicdataEntRequest(string reqSeqId, string reqDate, string upperHuifuId, string regName, string shortName, string receiptName, string entType, string mcc, string busiType, string sceneType, string licensePic, string licenseCode, string licenseValidityType, string licenseBeginDate, string licenseEndDate, string foundDate, string regCapital, string regDistrictId, string regDetail, string districtId, string detailAddr, string legalName, string legalCertType, string legalCertNo, string legalCertValidityType, string legalCertBeginDate, string legalCertEndDate, string legalAddr, string legalCertBackPic, string legalCertFrontPic, string contactMobileNo, string contactEmail, string loginName, string regAcctPic, string openLicenceNo, string cardInfo, string settleCardFrontPic, string settleCertBackPic, string settleCertFrontPic, string authEnturstPic, string headHuifuId, string merIcp, string storeHeaderPic, string storeIndoorPic, string storeCashierDeskPic) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.regName = regName;
            this.shortName = shortName;
            this.receiptName = receiptName;
            this.entType = entType;
            this.mcc = mcc;
            this.busiType = busiType;
            this.sceneType = sceneType;
            this.licensePic = licensePic;
            this.licenseCode = licenseCode;
            this.licenseValidityType = licenseValidityType;
            this.licenseBeginDate = licenseBeginDate;
            this.licenseEndDate = licenseEndDate;
            this.foundDate = foundDate;
            this.regCapital = regCapital;
            this.regDistrictId = regDistrictId;
            this.regDetail = regDetail;
            this.districtId = districtId;
            this.detailAddr = detailAddr;
            this.legalName = legalName;
            this.legalCertType = legalCertType;
            this.legalCertNo = legalCertNo;
            this.legalCertValidityType = legalCertValidityType;
            this.legalCertBeginDate = legalCertBeginDate;
            this.legalCertEndDate = legalCertEndDate;
            this.legalAddr = legalAddr;
            this.legalCertBackPic = legalCertBackPic;
            this.legalCertFrontPic = legalCertFrontPic;
            this.contactMobileNo = contactMobileNo;
            this.contactEmail = contactEmail;
            this.loginName = loginName;
            this.regAcctPic = regAcctPic;
            this.openLicenceNo = openLicenceNo;
            this.cardInfo = cardInfo;
            this.settleCardFrontPic = settleCardFrontPic;
            this.settleCertBackPic = settleCertBackPic;
            this.settleCertFrontPic = settleCertFrontPic;
            this.authEnturstPic = authEnturstPic;
            this.headHuifuId = headHuifuId;
            this.merIcp = merIcp;
            this.storeHeaderPic = storeHeaderPic;
            this.storeIndoorPic = storeIndoorPic;
            this.storeCashierDeskPic = storeCashierDeskPic;
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

        public string getReceiptName() {
            return receiptName;
        }

        public void setReceiptName(string receiptName) {
            this.receiptName = receiptName;
        }

        public string getEntType() {
            return entType;
        }

        public void setEntType(string entType) {
            this.entType = entType;
        }

        public string getMcc() {
            return mcc;
        }

        public void setMcc(string mcc) {
            this.mcc = mcc;
        }

        public string getBusiType() {
            return busiType;
        }

        public void setBusiType(string busiType) {
            this.busiType = busiType;
        }

        public string getSceneType() {
            return sceneType;
        }

        public void setSceneType(string sceneType) {
            this.sceneType = sceneType;
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

        public string getRegCapital() {
            return regCapital;
        }

        public void setRegCapital(string regCapital) {
            this.regCapital = regCapital;
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

        public string getRegAcctPic() {
            return regAcctPic;
        }

        public void setRegAcctPic(string regAcctPic) {
            this.regAcctPic = regAcctPic;
        }

        public string getOpenLicenceNo() {
            return openLicenceNo;
        }

        public void setOpenLicenceNo(string openLicenceNo) {
            this.openLicenceNo = openLicenceNo;
        }

        public string getCardInfo() {
            return cardInfo;
        }

        public void setCardInfo(string cardInfo) {
            this.cardInfo = cardInfo;
        }

        public string getSettleCardFrontPic() {
            return settleCardFrontPic;
        }

        public void setSettleCardFrontPic(string settleCardFrontPic) {
            this.settleCardFrontPic = settleCardFrontPic;
        }

        public string getSettleCertBackPic() {
            return settleCertBackPic;
        }

        public void setSettleCertBackPic(string settleCertBackPic) {
            this.settleCertBackPic = settleCertBackPic;
        }

        public string getSettleCertFrontPic() {
            return settleCertFrontPic;
        }

        public void setSettleCertFrontPic(string settleCertFrontPic) {
            this.settleCertFrontPic = settleCertFrontPic;
        }

        public string getAuthEnturstPic() {
            return authEnturstPic;
        }

        public void setAuthEnturstPic(string authEnturstPic) {
            this.authEnturstPic = authEnturstPic;
        }

        public string getHeadHuifuId() {
            return headHuifuId;
        }

        public void setHeadHuifuId(string headHuifuId) {
            this.headHuifuId = headHuifuId;
        }

        public string getMerIcp() {
            return merIcp;
        }

        public void setMerIcp(string merIcp) {
            this.merIcp = merIcp;
        }

        public string getStoreHeaderPic() {
            return storeHeaderPic;
        }

        public void setStoreHeaderPic(string storeHeaderPic) {
            this.storeHeaderPic = storeHeaderPic;
        }

        public string getStoreIndoorPic() {
            return storeIndoorPic;
        }

        public void setStoreIndoorPic(string storeIndoorPic) {
            this.storeIndoorPic = storeIndoorPic;
        }

        public string getStoreCashierDeskPic() {
            return storeCashierDeskPic;
        }

        public void setStoreCashierDeskPic(string storeCashierDeskPic) {
            this.storeCashierDeskPic = storeCashierDeskPic;
        }


    }
}
