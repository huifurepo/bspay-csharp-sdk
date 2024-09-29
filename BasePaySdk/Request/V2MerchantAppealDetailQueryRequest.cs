using System;

namespace BasePaySdk.Request
{
    /**
     * 申诉单详情查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantAppealDetailQueryRequest : BaseRequest
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
         * 申诉单号
         */
        private string appealId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_APPEAL_DETAIL_QUERY;
        }

        public V2MerchantAppealDetailQueryRequest() {
        }

        public V2MerchantAppealDetailQueryRequest(string reqSeqId, string reqDate, string appealId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
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

        public string getAppealId() {
            return appealId;
        }

        public void setAppealId(string appealId) {
            this.appealId = appealId;
        }


    }
}
