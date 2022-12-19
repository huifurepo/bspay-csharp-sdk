using System;

namespace BasePaySdk.Request
{
    /**
     * 商户统一进件（页面版）
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantUrlForwardRequest : BaseRequest
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
         * 渠道商号
         */
        private string upperHuifuId;
        /**
         * 手机号
         */
        private string phone;
        /**
         * 门店号
         */
        private string storeid;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_URL_FORWARD;
        }

        public V2MerchantUrlForwardRequest() {
        }

        public V2MerchantUrlForwardRequest(string reqSeqId, string reqDate, string upperHuifuId, string phone, string storeid) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.phone = phone;
            this.storeid = storeid;
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

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getPhone() {
            return phone;
        }

        public void setPhone(string phone) {
            this.phone = phone;
        }

        public string getStoreid() {
            return storeid;
        }

        public void setStoreid(string storeid) {
            this.storeid = storeid;
        }


    }
}
