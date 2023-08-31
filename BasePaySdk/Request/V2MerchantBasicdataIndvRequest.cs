using System;

namespace BasePaySdk.Request
{
    /**
     * 个人商户基本信息入驻(2022)
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
         * 上级主体ID
         */
        private string upperHuifuId;
        /**
         * 商户名
         */
        private string regName;
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
         * 结算卡信息配置
         */
        private string cardInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BASICDATA_INDV;
        }

        public V2MerchantBasicdataIndvRequest() {
        }

        public V2MerchantBasicdataIndvRequest(string reqSeqId, string reqDate, string upperHuifuId, string regName, string provId, string areaId, string districtId, string detailAddr, string contactName, string contactMobileNo, string contactEmail, string cardInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.regName = regName;
            this.provId = provId;
            this.areaId = areaId;
            this.districtId = districtId;
            this.detailAddr = detailAddr;
            this.contactName = contactName;
            this.contactMobileNo = contactMobileNo;
            this.contactEmail = contactEmail;
            this.cardInfo = cardInfo;
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

        public string getCardInfo() {
            return cardInfo;
        }

        public void setCardInfo(string cardInfo) {
            this.cardInfo = cardInfo;
        }


    }
}
