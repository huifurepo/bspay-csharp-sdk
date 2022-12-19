using System;

namespace BasePaySdk.Request
{
    /**
     * 交易确认接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentDelaytransConfirmRequest : BaseRequest
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

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_DELAYTRANS_CONFIRM;
        }

        public V2TradePaymentDelaytransConfirmRequest() {
        }

        public V2TradePaymentDelaytransConfirmRequest(string reqDate, string reqSeqId, string huifuId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }


    }
}
