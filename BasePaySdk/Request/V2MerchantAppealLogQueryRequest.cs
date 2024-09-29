using System;

namespace BasePaySdk.Request
{
    /**
     * 操作日志查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantAppealLogQueryRequest : BaseRequest
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
         * 申诉单号
         */
        private string appealId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_APPEAL_LOG_QUERY;
        }

        public V2MerchantAppealLogQueryRequest() {
        }

        public V2MerchantAppealLogQueryRequest(string reqSeqId, string reqDate, string pageSize, string appealId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.pageSize = pageSize;
            this.appealId = appealId;
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

        public string getAppealId() {
            return appealId;
        }

        public void setAppealId(string appealId) {
            this.appealId = appealId;
        }


    }
}
