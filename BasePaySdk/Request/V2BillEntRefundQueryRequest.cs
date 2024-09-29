using System;

namespace BasePaySdk.Request
{
    /**
     * 企业账单退款查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2BillEntRefundQueryRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求时间
         */
        private string reqDate;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 退款请求时间
         */
        private string orgReqDate;
        /**
         * 退款请求流水号
         */
        private string orgReqSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_BILL_ENT_REFUND_QUERY;
        }

        public V2BillEntRefundQueryRequest() {
        }

        public V2BillEntRefundQueryRequest(string reqSeqId, string reqDate, string huifuId, string orgReqDate, string orgReqSeqId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
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
