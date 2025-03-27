using System;

namespace BasePaySdk.Request
{
    /**
     * 交易确认查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradePaymentDelaytransConfirmqueryRequest : BaseRequest
    {

        /**
         * 原请求日期
         */
        private string orgReqDate;
        /**
         * 原请求流水号
         */
        private string orgReqSeqId;
        /**
         * 商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_TRADE_PAYMENT_DELAYTRANS_CONFIRMQUERY;
        }

        public V3TradePaymentDelaytransConfirmqueryRequest() {
        }

        public V3TradePaymentDelaytransConfirmqueryRequest(string orgReqDate, string orgReqSeqId, string huifuId) {
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }


    }
}
