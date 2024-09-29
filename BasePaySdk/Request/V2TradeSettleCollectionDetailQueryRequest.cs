using System;

namespace BasePaySdk.Request
{
    /**
     * 资金归集明细查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettleCollectionDetailQueryRequest : BaseRequest
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
         * 开始日期
         */
        private string beginDate;
        /**
         * 结束日期
         */
        private string endDate;
        /**
         * 转出方商户号转出方商户号和转入方商户号必填一个；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123124&lt;/font&gt;
         */
        private string outHuifuId;
        /**
         * 转入方商户号转出方商户号和转入方商户号必填一个；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123124&lt;/font&gt;
         */
        private string inHuifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_SETTLE_COLLECTION_DETAIL_QUERY;
        }

        public V2TradeSettleCollectionDetailQueryRequest() {
        }

        public V2TradeSettleCollectionDetailQueryRequest(string reqDate, string reqSeqId, string beginDate, string endDate, string outHuifuId, string inHuifuId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.beginDate = beginDate;
            this.endDate = endDate;
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

        public string getBeginDate() {
            return beginDate;
        }

        public void setBeginDate(string beginDate) {
            this.beginDate = beginDate;
        }

        public string getEndDate() {
            return endDate;
        }

        public void setEndDate(string endDate) {
            this.endDate = endDate;
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
