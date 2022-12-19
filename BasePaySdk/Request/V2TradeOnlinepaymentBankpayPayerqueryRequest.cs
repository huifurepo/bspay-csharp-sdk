using System;

namespace BasePaySdk.Request
{
    /**
     * 网银付款银行账户查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentBankpayPayerqueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 原交易请求日期
         */
        private string orgReqDate;
        /**
         * 原交易请求流水号
         */
        private string orgReqSeqId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 原交易汇付全局流水号
         */
        private string orgHfSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_BANKPAY_PAYERQUERY;
        }

        public V2TradeOnlinepaymentBankpayPayerqueryRequest() {
        }

        public V2TradeOnlinepaymentBankpayPayerqueryRequest(string huifuId, string orgReqDate, string orgReqSeqId, string reqDate, string reqSeqId, string orgHfSeqId) {
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.orgHfSeqId = orgHfSeqId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
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

        public string getOrgHfSeqId() {
            return orgHfSeqId;
        }

        public void setOrgHfSeqId(string orgHfSeqId) {
            this.orgHfSeqId = orgHfSeqId;
        }


    }
}
