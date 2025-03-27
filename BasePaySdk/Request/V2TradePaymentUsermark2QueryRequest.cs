using System;

namespace BasePaySdk.Request
{
    /**
     * 获取银联用户标识接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentUsermark2QueryRequest : BaseRequest
    {

        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 授权码
         */
        private string authCode;
        /**
         * 银联支付标识
         */
        private string appUpIdentifier;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_USERMARK2_QUERY;
        }

        public V2TradePaymentUsermark2QueryRequest() {
        }

        public V2TradePaymentUsermark2QueryRequest(string reqDate, string reqSeqId, string huifuId, string authCode, string appUpIdentifier) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.authCode = authCode;
            this.appUpIdentifier = appUpIdentifier;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getAuthCode() {
            return authCode;
        }

        public void setAuthCode(string authCode) {
            this.authCode = authCode;
        }

        public string getAppUpIdentifier() {
            return appUpIdentifier;
        }

        public void setAppUpIdentifier(string appUpIdentifier) {
            this.appUpIdentifier = appUpIdentifier;
        }


    }
}
