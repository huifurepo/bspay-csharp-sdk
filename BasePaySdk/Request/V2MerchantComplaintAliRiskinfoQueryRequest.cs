using System;

namespace BasePaySdk.Request
{
    /**
     * 支付宝投诉查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintAliRiskinfoQueryRequest : BaseRequest
    {

        /**
         * 请求汇付流水号
         */
        private string reqSeqId;
        /**
         * 请求汇付时间
         */
        private string reqDate;
        /**
         * 开始日期
         */
        private string beginDate;
        /**
         * 结束日期
         */
        private string endDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_COMPLAINT_ALI_RISKINFO_QUERY;
        }

        public V2MerchantComplaintAliRiskinfoQueryRequest() {
        }

        public V2MerchantComplaintAliRiskinfoQueryRequest(string reqSeqId, string reqDate, string beginDate, string endDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
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
