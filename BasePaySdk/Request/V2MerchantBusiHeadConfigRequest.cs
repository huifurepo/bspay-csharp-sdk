using System;

namespace BasePaySdk.Request
{
    /**
     * 开通下级商户权限配置接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiHeadConfigRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求时间
         */
        private string reqDate;
        /**
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 产品编号
         */
        private string productId;
        /**
         * 直属渠道号
         */
        private string upperHuifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_HEAD_CONFIG;
        }

        public V2MerchantBusiHeadConfigRequest() {
        }

        public V2MerchantBusiHeadConfigRequest(string reqSeqId, string reqDate, string huifuId, string productId, string upperHuifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.productId = productId;
            this.upperHuifuId = upperHuifuId;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getProductId() {
            return productId;
        }

        public void setProductId(string productId) {
            this.productId = productId;
        }

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }


    }
}
