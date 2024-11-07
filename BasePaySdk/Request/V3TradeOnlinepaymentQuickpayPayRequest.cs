using System;

namespace BasePaySdk.Request
{
    /**
     * 快捷支付
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradeOnlinepaymentQuickpayPayRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;
        /**
         * 短信验证码
         */
        private string smsCode;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_TRADE_ONLINEPAYMENT_QUICKPAY_PAY;
        }

        public V3TradeOnlinepaymentQuickpayPayRequest() {
        }

        public V3TradeOnlinepaymentQuickpayPayRequest(string reqSeqId, string reqDate, string huifuId, string smsCode) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.smsCode = smsCode;
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

        public string getSmsCode() {
            return smsCode;
        }

        public void setSmsCode(string smsCode) {
            this.smsCode = smsCode;
        }


    }
}
