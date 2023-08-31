using System;

namespace BasePaySdk.Request
{
    /**
     * 商户统一进件接口(2022)
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantIntegrateRegRequest : BaseRequest
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
         * 渠道商汇付id
         */
        private string upperHuifuId;
        /**
         * 公司类型
         */
        private string entType;
        /**
         * 商户名称
         */
        private string regName;
        /**
         * 经营类型
         */
        private string busiType;
        /**
         * 经营详细地址
         */
        private string detailAddr;
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
         * 联系人信息
         */
        private string contactInfo;
        /**
         * 卡信息配置实体
         */
        private string cardInfo;
        /**
         * 取现配置列表jsonArray格式 ；
         */
        private string cashConfig;
        /**
         * 结算配置jsonObject格式；
         */
        private string settleConfig;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_INTEGRATE_REG;
        }

        public V2MerchantIntegrateRegRequest() {
        }

        public V2MerchantIntegrateRegRequest(string reqSeqId, string reqDate, string upperHuifuId, string entType, string regName, string busiType, string detailAddr, string provId, string areaId, string districtId, string contactInfo, string cardInfo, string cashConfig, string settleConfig) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.entType = entType;
            this.regName = regName;
            this.busiType = busiType;
            this.detailAddr = detailAddr;
            this.provId = provId;
            this.areaId = areaId;
            this.districtId = districtId;
            this.contactInfo = contactInfo;
            this.cardInfo = cardInfo;
            this.cashConfig = cashConfig;
            this.settleConfig = settleConfig;
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

        public string getEntType() {
            return entType;
        }

        public void setEntType(string entType) {
            this.entType = entType;
        }

        public string getRegName() {
            return regName;
        }

        public void setRegName(string regName) {
            this.regName = regName;
        }

        public string getBusiType() {
            return busiType;
        }

        public void setBusiType(string busiType) {
            this.busiType = busiType;
        }

        public string getDetailAddr() {
            return detailAddr;
        }

        public void setDetailAddr(string detailAddr) {
            this.detailAddr = detailAddr;
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

        public string getContactInfo() {
            return contactInfo;
        }

        public void setContactInfo(string contactInfo) {
            this.contactInfo = contactInfo;
        }

        public string getCardInfo() {
            return cardInfo;
        }

        public void setCardInfo(string cardInfo) {
            this.cardInfo = cardInfo;
        }

        public string getCashConfig() {
            return cashConfig;
        }

        public void setCashConfig(string cashConfig) {
            this.cashConfig = cashConfig;
        }

        public string getSettleConfig() {
            return settleConfig;
        }

        public void setSettleConfig(string settleConfig) {
            this.settleConfig = settleConfig;
        }


    }
}
