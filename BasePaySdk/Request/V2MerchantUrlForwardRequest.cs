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
         * 渠道商号汇付分配的渠道商号，该商户进件完成后将隶属该渠道商/代理商&lt;br/&gt;sys_id主体为渠道商时填写； &lt;br/&gt;sys_id主体为总部商户时选填；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
         */
        private string upperHuifuId;
        /**
         * 门店号
         */
        private string storeId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_URL_FORWARD;
        }

        public V2MerchantUrlForwardRequest() {
        }

        public V2MerchantUrlForwardRequest(string reqSeqId, string reqDate, string upperHuifuId, string storeId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
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

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getStoreId() {
            return storeId;
        }

        public void setStoreId(string storeId) {
            this.storeId = storeId;
        }


    }
}
