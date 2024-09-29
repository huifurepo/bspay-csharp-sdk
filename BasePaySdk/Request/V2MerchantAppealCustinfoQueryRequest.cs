using System;

namespace BasePaySdk.Request
{
    /**
     * 申诉客户信息查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantAppealCustinfoQueryRequest : BaseRequest
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
         * 协查单号
         */
        private string assistId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_APPEAL_CUSTINFO_QUERY;
        }

        public V2MerchantAppealCustinfoQueryRequest() {
        }

        public V2MerchantAppealCustinfoQueryRequest(string reqSeqId, string reqDate, string assistId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
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

        public string getAssistId() {
            return assistId;
        }

        public void setAssistId(string assistId) {
            this.assistId = assistId;
        }


    }
}
