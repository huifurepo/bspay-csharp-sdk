using System;

namespace BasePaySdk.Request
{
    /**
     * 确认收货提醒
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradeHostingPaymentReceiptConfirmRequest : BaseRequest
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
         * 快递签收时间
         */
        private string receivedTime;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_TRADE_HOSTING_PAYMENT_RECEIPT_CONFIRM;
        }

        public V3TradeHostingPaymentReceiptConfirmRequest() {
        }

        public V3TradeHostingPaymentReceiptConfirmRequest(string reqDate, string reqSeqId, string huifuId, string receivedTime) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.receivedTime = receivedTime;
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

        public string getReceivedTime() {
            return receivedTime;
        }

        public void setReceivedTime(string receivedTime) {
            this.receivedTime = receivedTime;
        }


    }
}
