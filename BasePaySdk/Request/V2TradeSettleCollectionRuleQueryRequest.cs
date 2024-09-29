using System;

namespace BasePaySdk.Request
{
    /**
     * 归集配置查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettleCollectionRuleQueryRequest : BaseRequest
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
         * 转出方商户号转出方商户号和转入方商户号二选一必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123124&lt;/font&gt;
         */
        private string outHuifuId;
        /**
         * 转入方商户号转出方商户号和转入方商户号二选一必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123124&lt;/font&gt;
         */
        private string inHuifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_SETTLE_COLLECTION_RULE_QUERY;
        }

        public V2TradeSettleCollectionRuleQueryRequest() {
        }

        public V2TradeSettleCollectionRuleQueryRequest(string reqDate, string reqSeqId, string outHuifuId, string inHuifuId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.outHuifuId = outHuifuId;
            this.inHuifuId = inHuifuId;
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

        public string getInHuifuId() {
            return inHuifuId;
        }

        public void setInHuifuId(string inHuifuId) {
            this.inHuifuId = inHuifuId;
        }


    }
}
