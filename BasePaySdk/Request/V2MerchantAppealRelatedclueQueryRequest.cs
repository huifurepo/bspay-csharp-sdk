using System;

namespace BasePaySdk.Request
{
    /**
     * 关联线索查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantAppealRelatedclueQueryRequest : BaseRequest
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
         * 分页条数
         */
        private string pageSize;
        /**
         * 协查单号
         */
        private string assistId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_APPEAL_RELATEDCLUE_QUERY;
        }

        public V2MerchantAppealRelatedclueQueryRequest() {
        }

        public V2MerchantAppealRelatedclueQueryRequest(string reqSeqId, string reqDate, string pageSize, string assistId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.pageSize = pageSize;
            this.assistId = assistId;
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

        public string getPageSize() {
            return pageSize;
        }

        public void setPageSize(string pageSize) {
            this.pageSize = pageSize;
        }

        public string getAssistId() {
            return assistId;
        }

        public void setAssistId(string assistId) {
            this.assistId = assistId;
        }


    }
}
