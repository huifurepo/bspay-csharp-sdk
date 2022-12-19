using System;

namespace BasePaySdk.Request
{
    /**
     * 微信直连-微信关注配置查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectWechatSubscribeQueryRequest : BaseRequest
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
         * 汇付ID
         */
        private string huifuId;
        /**
         * 开发者的应用ID
         */
        private string appId;
        /**
         * 商户号
         */
        private string mchId;
        /**
         * 特约商户号
         */
        private string subMchid;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_WECHAT_SUBSCRIBE_QUERY;
        }

        public V2MerchantDirectWechatSubscribeQueryRequest() {
        }

        public V2MerchantDirectWechatSubscribeQueryRequest(string reqSeqId, string reqDate, string huifuId, string appId, string mchId, string subMchid) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.appId = appId;
            this.mchId = mchId;
            this.subMchid = subMchid;
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

        public string getSubMchid() {
            return subMchid;
        }

        public void setSubMchid(string subMchid) {
            this.subMchid = subMchid;
        }


    }
}
