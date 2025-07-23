using System;

namespace BasePaySdk.Request
{
    /**
     * 灵工支付退款查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleRefundQueryRequest : BaseRequest
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
         * 退款请求流水号
         */
        private string orgReqSeqId;
        /**
         * 退款请求日期
         */
        private string orgReqDate;
        /**
         * 汇付商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_FLEXIBLE_REFUND_QUERY;
        }

        public V2FlexibleRefundQueryRequest() {
        }

        public V2FlexibleRefundQueryRequest(string reqSeqId, string reqDate, string orgReqSeqId, string orgReqDate, string huifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.orgReqDate = orgReqDate;
            this.huifuId = huifuId;
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

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }


    }
}
