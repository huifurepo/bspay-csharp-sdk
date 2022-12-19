using System;

namespace BasePaySdk.Request
{
    /**
     * 微信用户标识查询接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeWxusermarkQueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 支付授权码
         */
        private string authCode;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_WXUSERMARK_QUERY;
        }

        public V2TradeWxusermarkQueryRequest() {
        }

        public V2TradeWxusermarkQueryRequest(string huifuId, string reqDate, string reqSeqId, string authCode) {
            this.huifuId = huifuId;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.authCode = authCode;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
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

        public string getAuthCode() {
            return authCode;
        }

        public void setAuthCode(string authCode) {
            this.authCode = authCode;
        }


    }
}
