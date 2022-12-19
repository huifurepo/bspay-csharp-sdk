using System;

namespace BasePaySdk.Request
{
    /**
     * 卡bin信息查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeCardbinQueryRequest : BaseRequest
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
         * 银行卡号密文
         */
        private string bankCardNoCrypt;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_CARDBIN_QUERY;
        }

        public V2TradeCardbinQueryRequest() {
        }

        public V2TradeCardbinQueryRequest(string reqDate, string reqSeqId, string bankCardNoCrypt) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.bankCardNoCrypt = bankCardNoCrypt;
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

        public string getBankCardNoCrypt() {
            return bankCardNoCrypt;
        }

        public void setBankCardNoCrypt(string bankCardNoCrypt) {
            this.bankCardNoCrypt = bankCardNoCrypt;
        }


    }
}
