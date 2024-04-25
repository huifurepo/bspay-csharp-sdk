using System;

namespace BasePaySdk.Request
{
    /**
     * E账户转账及充值查询接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentZxeIncashQueryRequest : BaseRequest
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
         * 商户号/用户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_ZXE_INCASH_QUERY;
        }

        public V2TradePaymentZxeIncashQueryRequest() {
        }

        public V2TradePaymentZxeIncashQueryRequest(string reqDate, string reqSeqId, string huifuId) {
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
