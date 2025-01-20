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
        /**
         * 交易类型**原交易为快捷支付必填：QUICK_PAY**；&lt;br/&gt;**原交易为余额支付必填：ACCT_PAYMENT**；&lt;br/&gt;原交易为全域资金必填：REMITTANCE_PAY；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：ACCT_PAYMENT&lt;/font&gt;
         */
        private string payType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_DELAYTRANS_CONFIRM;
        }

        public V2TradePaymentDelaytransConfirmRequest() {
        }

        public V2TradePaymentDelaytransConfirmRequest(string reqDate, string reqSeqId, string huifuId, string payType) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.payType = payType;
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

        public string getPayType() {
            return payType;
        }

        public void setPayType(string payType) {
            this.payType = payType;
        }


    }
}
