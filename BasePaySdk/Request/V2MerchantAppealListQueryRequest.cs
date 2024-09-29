using System;

namespace BasePaySdk.Request
{
    /**
     * 申诉单列表查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantAppealListQueryRequest : BaseRequest
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
         * 申诉创建开始日期
         */
        private string beginDate;
        /**
         * 申诉创建结束日期
         */
        private string endDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_APPEAL_LIST_QUERY;
        }

        public V2MerchantAppealListQueryRequest() {
        }

        public V2MerchantAppealListQueryRequest(string reqSeqId, string reqDate, string pageSize, string beginDate, string endDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.pageSize = pageSize;
            this.beginDate = beginDate;
            this.endDate = endDate;
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


    }
}
