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
         * 超级管理员信息
         */
        private string contactInfo;
        /**
         * 经营场景类型
         */
        private string salesScenesType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_WECHAT_SIGN;
        }

        public V2MerchantDirectWechatSignRequest() {
        }

        public V2MerchantDirectWechatSignRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string appId, string mchId, string contactInfo, string salesScenesType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.appId = appId;
            this.mchId = mchId;
            this.contactInfo = contactInfo;
            this.salesScenesType = salesScenesType;
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


    }
}
