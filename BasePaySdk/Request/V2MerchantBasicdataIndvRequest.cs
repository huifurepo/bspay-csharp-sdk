using System;

namespace BasePaySdk.Request
{
    /**
     * 个人商户进件
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBasicdataIndvRequest : BaseRequest
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
         * 商户名
         */
        private string regName;
        /**
         * *所属行业*
         */
        private string mcc;
        /**
         * *场景类型*
         */
        private string sceneType;
        /**
         * 经营区
         */
        private string districtId;
        /**
         * 经营详细地址scene_type字段含有线下场景时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：上海市徐汇区XX路XX号&lt;/font&gt;
         */
        private string detailAddr;
        /**
         * *负责人证件号码*
         */
        private string legalCertNo;
        /**
         * *负责人证件有效期开始日期*
         */
        private string legalCertBeginDate;
        /**
         * *负责人证件有效期截止日期*
         */
        private string legalCertEndDate;
        /**
         * *负责人身份证地址*
         */
        private string legalAddr;
        /**
         * 负责人身份证国徽面
         */
        private string legalCertBackPic;
        /**
         * 负责人身份证人像面
         */
        private string legalCertFrontPic;
        /**
         * 负责人手机号
         */
        private string contactMobileNo;
        /**
         * 负责人电子邮箱
         */
        private string contactEmail;
        /**
         * 结算卡信息配置
         */
        private string cardInfo;
        /**
         * 结算卡正面
         */
        private string settleCardFrontPic;
        /**
         * *商户ICP备案编号*商户ICP备案编号或网站许可证号；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：沪ICP备06046402号-28 &lt;/font&gt;&lt;br/&gt;类型为PC网站时，且为企业商户，且开通快捷或网银，或大额转账，或余额支付或分账业务（20%（不含）-100%），或为个人商户开通分账业务（10%（不含）-100%），必填
         */
        private string merIcp;
        /**
         * 店铺门头照文件类型：F22；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;&lt;br/&gt;微信/支付宝实名认证个人商户，门头照也使用此字段； &lt;br/&gt;门店场所：提交门店门口照片，要求招牌清晰可见; &lt;br/&gt;小微商户流动经营/便民服务：提交经营/服务现场照片
         */
        private string storeHeaderPic;
        /**
         * 店铺内景/工作区域照文件类型：F24；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;&lt;br/&gt;微信/支付宝实名认证个人商户，内景照也使用此字段； &lt;br/&gt;门店场所：提交店内环境照片 &lt;br/&gt;小微商户流动经营/便民服务：可提交另一张经营/服务现场照片
         */
        private string storeIndoorPic;
        /**
         * 店铺收银台/公司前台照商户线下场景需要提供；文件类型：F105；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string storeCashierDeskPic;
        /**
         * 上级商户汇付ID如果head_office_flag&#x3D;0，则字段必填&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
         */
        private string headHuifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BASICDATA_INDV;
        }

        public V2MerchantBasicdataIndvRequest() {
        }

        public V2MerchantBasicdataIndvRequest(string reqSeqId, string reqDate, string upperHuifuId, string regName, string mcc, string sceneType, string districtId, string detailAddr, string legalCertNo, string legalCertBeginDate, string legalCertEndDate, string legalAddr, string legalCertBackPic, string legalCertFrontPic, string contactMobileNo, string contactEmail, string cardInfo, string settleCardFrontPic, string merIcp, string storeHeaderPic, string storeIndoorPic, string storeCashierDeskPic, string headHuifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.regName = regName;
            this.mcc = mcc;
            this.sceneType = sceneType;
            this.districtId = districtId;
            this.detailAddr = detailAddr;
            this.legalCertNo = legalCertNo;
            this.legalCertBeginDate = legalCertBeginDate;
            this.legalCertEndDate = legalCertEndDate;
            this.legalAddr = legalAddr;
            this.legalCertBackPic = legalCertBackPic;
            this.legalCertFrontPic = legalCertFrontPic;
            this.contactMobileNo = contactMobileNo;
            this.contactEmail = contactEmail;
            this.cardInfo = cardInfo;
            this.settleCardFrontPic = settleCardFrontPic;
            this.merIcp = merIcp;
            this.storeHeaderPic = storeHeaderPic;
            this.storeIndoorPic = storeIndoorPic;
            this.storeCashierDeskPic = storeCashierDeskPic;
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

        public string getMcc() {
            return mcc;
        }

        public void setMcc(string mcc) {
            this.mcc = mcc;
        }

        public string getSceneType() {
            return sceneType;
        }

        public void setSceneType(string sceneType) {
            this.sceneType = sceneType;
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

        public string getLegalCertNo() {
            return legalCertNo;
        }

        public void setLegalCertNo(string legalCertNo) {
            this.legalCertNo = legalCertNo;
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

        public string getHeadHuifuId() {
            return headHuifuId;
        }

        public void setHeadHuifuId(string headHuifuId) {
            this.headHuifuId = headHuifuId;
        }


    }
}
