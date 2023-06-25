using System;

namespace BasePaySdk.Request
{
    /**
     * 统一进件页面版查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiStatusQueryRequest : BaseRequest
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
         * 门店号
         */
        private string storeId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_STATUS_QUERY;
        }

        public V2MerchantBusiStatusQueryRequest() {
        }

        public V2MerchantBusiStatusQueryRequest(string reqSeqId, string reqDate, string storeId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.storeId = storeId;
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

        public string getStoreId() {
            return storeId;
        }

        public void setStoreId(string storeId) {
            this.storeId = storeId;
        }


    }
}
