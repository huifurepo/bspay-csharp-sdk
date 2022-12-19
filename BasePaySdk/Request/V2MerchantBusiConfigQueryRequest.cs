using System;

namespace BasePaySdk.Request
{
    /**
     * 微信配置查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiConfigQueryRequest : BaseRequest
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

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_CONFIG_QUERY;
        }

        public V2MerchantBusiConfigQueryRequest() {
        }

        public V2MerchantBusiConfigQueryRequest(string reqSeqId, string reqDate, string huifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
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


    }
}
