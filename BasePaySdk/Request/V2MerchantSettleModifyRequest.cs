using System;

namespace BasePaySdk.Request
{
    /**
     * 修改子账户配置(2022)
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantSettleModifyRequest : BaseRequest
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
         * 商户/用户汇付Id
         */
        private string huifuId;
        /**
         * 上级汇付Id
         */
        private string upperHuifuId;
        /**
         * 子账户号
         */
        private string acctId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_SETTLE_MODIFY;
        }

        public V2MerchantSettleModifyRequest() {
        }

        public V2MerchantSettleModifyRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string acctId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.acctId = acctId;
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

        public string getAcctId() {
            return acctId;
        }

        public void setAcctId(string acctId) {
            this.acctId = acctId;
        }


    }
}
