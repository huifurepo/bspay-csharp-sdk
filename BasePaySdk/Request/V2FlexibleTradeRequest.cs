using System;

namespace BasePaySdk.Request
{
    /**
     * 灵工支付
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleTradeRequest : BaseRequest
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
         * 出款方商户号
         */
        private string outHuifuId;
        /**
         * 交易阶段操作类型
         */
        private string stageOperationType;
        /**
         * 前段交易流水号** 当交易阶段操作类型为02时，该字段必填。填写的是交易阶段操作类型为01时交易已完成的交易全局流水号。 &lt;font color&#x3D;&quot;green&quot;&gt;示例值：20250620112533115566896&lt;/font&gt;
         */
        private string phaseHfSeqId;
        /**
         * 支付金额
         */
        private string ordAmt;
        /**
         * 分账对象
         */
        private string acctSplitBunch;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_FLEXIBLE_TRADE;
        }

        public V2FlexibleTradeRequest() {
        }

        public V2FlexibleTradeRequest(string reqSeqId, string reqDate, string outHuifuId, string stageOperationType, string phaseHfSeqId, string ordAmt, string acctSplitBunch) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.outHuifuId = outHuifuId;
            this.stageOperationType = stageOperationType;
            this.phaseHfSeqId = phaseHfSeqId;
            this.ordAmt = ordAmt;
            this.acctSplitBunch = acctSplitBunch;
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

        public string getOutHuifuId() {
            return outHuifuId;
        }

        public void setOutHuifuId(string outHuifuId) {
            this.outHuifuId = outHuifuId;
        }

        public string getStageOperationType() {
            return stageOperationType;
        }

        public void setStageOperationType(string stageOperationType) {
            this.stageOperationType = stageOperationType;
        }

        public string getPhaseHfSeqId() {
            return phaseHfSeqId;
        }

        public void setPhaseHfSeqId(string phaseHfSeqId) {
            this.phaseHfSeqId = phaseHfSeqId;
        }

        public string getOrdAmt() {
            return ordAmt;
        }

        public void setOrdAmt(string ordAmt) {
            this.ordAmt = ordAmt;
        }

        public string getAcctSplitBunch() {
            return acctSplitBunch;
        }

        public void setAcctSplitBunch(string acctSplitBunch) {
            this.acctSplitBunch = acctSplitBunch;
        }


    }
}
