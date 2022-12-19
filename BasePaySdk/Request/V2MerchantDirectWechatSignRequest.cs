using System;

namespace BasePaySdk.Request
{
    /**
     * 微信特约商户进件
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectWechatSignRequest : BaseRequest
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
         * 商户汇付Id
         */
        private string huifuId;
        /**
         * 渠道商汇付Id
         */
        private string upperHuifuId;
        /**
         * 开发者的应用ID
         */
        private string appId;
        /**
         * 商户号
         */
        private string mchId;
        /**
         * 经营者/法人是否为受益人
         */
        private string owner;
        /**
         * 超级管理员信息
         */
        private string contactInfo;
        /**
         * 经营场景类型
         */
        private string salesScenesType;
        /**
         * 经营场景
         */
        private string salesInfo;
        /**
         * 结算信息
         */
        private string settlementInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_WECHAT_SIGN;
        }

        public V2MerchantDirectWechatSignRequest() {
        }

        public V2MerchantDirectWechatSignRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string appId, string mchId, string owner, string contactInfo, string salesScenesType, string salesInfo, string settlementInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.appId = appId;
            this.mchId = mchId;
            this.owner = owner;
            this.contactInfo = contactInfo;
            this.salesScenesType = salesScenesType;
            this.salesInfo = salesInfo;
            this.settlementInfo = settlementInfo;
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

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getAppId() {
            return appId;
        }

        public void setAppId(string appId) {
            this.appId = appId;
        }

        public string getMchId() {
            return mchId;
        }

        public void setMchId(string mchId) {
            this.mchId = mchId;
        }

        public string getOwner() {
            return owner;
        }

        public void setOwner(string owner) {
            this.owner = owner;
        }

        public string getContactInfo() {
            return contactInfo;
        }

        public void setContactInfo(string contactInfo) {
            this.contactInfo = contactInfo;
        }

        public string getSalesScenesType() {
            return salesScenesType;
        }

        public void setSalesScenesType(string salesScenesType) {
            this.salesScenesType = salesScenesType;
        }

        public string getSalesInfo() {
            return salesInfo;
        }

        public void setSalesInfo(string salesInfo) {
            this.salesInfo = salesInfo;
        }

        public string getSettlementInfo() {
            return settlementInfo;
        }

        public void setSettlementInfo(string settlementInfo) {
            this.settlementInfo = settlementInfo;
        }


    }
}
