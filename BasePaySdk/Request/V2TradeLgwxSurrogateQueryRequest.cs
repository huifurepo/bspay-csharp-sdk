using System;

namespace BasePaySdk.Request
{
    /**
     * 灵工微信代发查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeLgwxSurrogateQueryRequest : BaseRequest
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
         * 原交易的商户号
         */
        private string huifuId;
        /**
         * 原交易请求日期
         */
        private string orgReqDate;
        /**
         * 原交易请求流水号
         */
        private string orgReqSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_LGWX_SURROGATE_QUERY;
        }

        public V2TradeLgwxSurrogateQueryRequest() {
        }

        public V2TradeLgwxSurrogateQueryRequest(string reqDate, string reqSeqId, string huifuId, string orgReqDate, string orgReqSeqId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
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


    }
}
