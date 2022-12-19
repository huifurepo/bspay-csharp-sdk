using System;

namespace BasePaySdk.Request
{
    /**
     * 商户统一变更接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantIntegrateUpdateRequest : BaseRequest
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
         * 汇付ID
         */
        private string huifuId;
        /**
         * 渠道商汇付ID
         */
        private string upperHuifuId;
        /**
         * 业务处理类型
         */
        private string dealType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_INTEGRATE_UPDATE;
        }

        public V2MerchantIntegrateUpdateRequest() {
        }

        public V2MerchantIntegrateUpdateRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string dealType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.dealType = dealType;
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

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getDealType() {
            return dealType;
        }

        public void setDealType(string dealType) {
            this.dealType = dealType;
        }


    }
}
