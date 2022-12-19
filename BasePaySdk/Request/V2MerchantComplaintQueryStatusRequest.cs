using System;

namespace BasePaySdk.Request
{
    /**
     * 支付宝申诉查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintQueryStatusRequest : BaseRequest
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
         * 支付宝推送流水号
         */
        private string riskBizId;
        /**
         * 申诉的商户
         */
        private string bankMerCode;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_COMPLAINT_QUERY_STATUS;
        }

        public V2MerchantComplaintQueryStatusRequest() {
        }

        public V2MerchantComplaintQueryStatusRequest(string reqSeqId, string reqDate, string riskBizId, string bankMerCode) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.riskBizId = riskBizId;
            this.bankMerCode = bankMerCode;
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

        public string getRiskBizId() {
            return riskBizId;
        }

        public void setRiskBizId(string riskBizId) {
            this.riskBizId = riskBizId;
        }

        public string getBankMerCode() {
            return bankMerCode;
        }

        public void setBankMerCode(string bankMerCode) {
            this.bankMerCode = bankMerCode;
        }


    }
}
