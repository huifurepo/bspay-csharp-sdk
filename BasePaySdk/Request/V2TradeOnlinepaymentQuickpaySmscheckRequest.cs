using System;

namespace BasePaySdk.Request
{
    /**
     * 快捷支付短信预校验
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentQuickpaySmscheckRequest : BaseRequest
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
         * 原请求流水号
         */
        private string orgReqSeqId;
        /**
         * 原请求日期
         */
        private string orgReqDate;
        /**
         * 短信验证码
         */
        private string smsCode;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_QUICKPAY_SMSCHECK;
        }

        public V2TradeOnlinepaymentQuickpaySmscheckRequest() {
        }

        public V2TradeOnlinepaymentQuickpaySmscheckRequest(string reqSeqId, string reqDate, string huifuId, string orgReqSeqId, string orgReqDate, string smsCode) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.orgReqSeqId = orgReqSeqId;
            this.orgReqDate = orgReqDate;
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

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }

        public string getSmsCode() {
            return smsCode;
        }

        public void setSmsCode(string smsCode) {
            this.smsCode = smsCode;
        }


    }
}
