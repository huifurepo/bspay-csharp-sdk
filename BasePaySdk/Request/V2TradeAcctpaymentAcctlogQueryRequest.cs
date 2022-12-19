using System;

namespace BasePaySdk.Request
{
    /**
     * 账务流水查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeAcctpaymentAcctlogQueryRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 渠道/代理/商户/用户编号
         */
        private string huifuId;
        /**
         * 账务日期
         */
        private string acctDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ACCTPAYMENT_ACCTLOG_QUERY;
        }

        public V2TradeAcctpaymentAcctlogQueryRequest() {
        }

        public V2TradeAcctpaymentAcctlogQueryRequest(string reqSeqId, string huifuId, string acctDate) {
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.acctDate = acctDate;
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

        public string getAcctDate() {
            return acctDate;
        }

        public void setAcctDate(string acctDate) {
            this.acctDate = acctDate;
        }


    }
}
