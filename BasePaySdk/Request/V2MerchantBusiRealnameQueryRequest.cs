using System;

namespace BasePaySdk.Request
{
    /**
     * 微信实名认证状态查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiRealnameQueryRequest : BaseRequest
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
         * 汇付Id
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_REALNAME_QUERY;
        }

        public V2MerchantBusiRealnameQueryRequest() {
        }

        public V2MerchantBusiRealnameQueryRequest(string reqSeqId, string reqDate, string huifuId) {
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
