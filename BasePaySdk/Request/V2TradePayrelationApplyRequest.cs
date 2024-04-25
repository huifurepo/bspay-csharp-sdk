using System;

namespace BasePaySdk.Request
{
    /**
     * 付款关系提交
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayrelationApplyRequest : BaseRequest
    {

        /**
         * 出款方商户号
         */
        private string outHuifuId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 付款关系明细
         */
        private string payRelations;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYRELATION_APPLY;
        }

        public V2TradePayrelationApplyRequest() {
        }

        public V2TradePayrelationApplyRequest(string outHuifuId, string reqDate, string reqSeqId, string payRelations) {
            this.outHuifuId = outHuifuId;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.payRelations = payRelations;
        }

        public string getOutHuifuId() {
            return outHuifuId;
        }

        public void setOutHuifuId(string outHuifuId) {
            this.outHuifuId = outHuifuId;
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

        public string getPayRelations() {
            return payRelations;
        }

        public void setPayRelations(string payRelations) {
            this.payRelations = payRelations;
        }


    }
}
