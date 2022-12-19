using System;

namespace BasePaySdk.Request
{
    /**
     * 支付宝实名申请单查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiAliRealnameQueryRequest : BaseRequest
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

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_ALI_REALNAME_QUERY;
        }

        public V2MerchantBusiAliRealnameQueryRequest() {
        }

        public V2MerchantBusiAliRealnameQueryRequest(string reqSeqId, string reqDate, string huifuId) {
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
