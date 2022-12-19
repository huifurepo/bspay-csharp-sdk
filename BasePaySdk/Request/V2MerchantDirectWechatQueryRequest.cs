using System;

namespace BasePaySdk.Request
{
    /**
     * 查询微信申请状态
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectWechatQueryRequest : BaseRequest
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
         * 商户汇付Id
         */
        private string huifuId;
        /**
         * 开发者的应用ID
         */
        private string appId;
        /**
         * 微信商户号
         */
        private string mchId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_WECHAT_QUERY;
        }

        public V2MerchantDirectWechatQueryRequest() {
        }

        public V2MerchantDirectWechatQueryRequest(string reqSeqId, string reqDate, string huifuId, string appId, string mchId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.appId = appId;
            this.mchId = mchId;
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


    }
}
