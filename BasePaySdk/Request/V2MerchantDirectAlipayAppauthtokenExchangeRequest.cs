using System;

namespace BasePaySdk.Request
{
    /**
     * 支付宝直连-换取应用授权令牌
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectAlipayAppauthtokenExchangeRequest : BaseRequest
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
         * 操作类型
         */
        private string operType;
        /**
         * 授权码授权码，操作类型为0-换取令牌时必填，其它选填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：123&lt;/font&gt;
         */
        private string appAuthCode;
        /**
         * 应用授权令牌应用授权令牌，操作类型为1-刷新令牌时，且该字段有值，将与数据库值进行校验；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：202208200312104378&lt;/font&gt;
         */
        private string appAuthToken;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_ALIPAY_APPAUTHTOKEN_EXCHANGE;
        }

        public V2MerchantDirectAlipayAppauthtokenExchangeRequest() {
        }

        public V2MerchantDirectAlipayAppauthtokenExchangeRequest(string reqSeqId, string reqDate, string huifuId, string appId, string operType, string appAuthCode, string appAuthToken) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.appId = appId;
            this.operType = operType;
            this.appAuthCode = appAuthCode;
            this.appAuthToken = appAuthToken;
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

        public string getOperType() {
            return operType;
        }

        public void setOperType(string operType) {
            this.operType = operType;
        }

        public string getAppAuthCode() {
            return appAuthCode;
        }

        public void setAppAuthCode(string appAuthCode) {
            this.appAuthCode = appAuthCode;
        }

        public string getAppAuthToken() {
            return appAuthToken;
        }

        public void setAppAuthToken(string appAuthToken) {
            this.appAuthToken = appAuthToken;
        }


    }
}
