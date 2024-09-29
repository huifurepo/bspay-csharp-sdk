using System;

namespace BasePaySdk.Request
{
    /**
     * 修改归集配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettleCollectionRuleModifyRequest : BaseRequest
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
         * 转出方商户号
         */
        private string outHuifuId;
        /**
         * 转出方账户号
         */
        private string outAcctId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_SETTLE_COLLECTION_RULE_MODIFY;
        }

        public V2TradeSettleCollectionRuleModifyRequest() {
        }

        public V2TradeSettleCollectionRuleModifyRequest(string reqDate, string reqSeqId, string outHuifuId, string outAcctId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.outHuifuId = outHuifuId;
            this.outAcctId = outAcctId;
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

        public string getOutHuifuId() {
            return outHuifuId;
        }

        public void setOutHuifuId(string outHuifuId) {
            this.outHuifuId = outHuifuId;
        }

        public string getOutAcctId() {
            return outAcctId;
        }

        public void setOutAcctId(string outAcctId) {
            this.outAcctId = outAcctId;
        }


    }
}
