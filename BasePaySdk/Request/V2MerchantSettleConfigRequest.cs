using System;

namespace BasePaySdk.Request
{
    /**
     * 子账户开通配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantSettleConfigRequest : BaseRequest
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
         * 商户汇付Id
         */
        private string huifuId;
        /**
         * 渠道商汇付Id
         */
        private string upperHuifuId;
        /**
         * 子账户类型
         */
        private string acctType;
        /**
         * 账户名称
         */
        private string acctName;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_SETTLE_CONFIG;
        }

        public V2MerchantSettleConfigRequest() {
        }

        public V2MerchantSettleConfigRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string acctType, string acctName) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.acctType = acctType;
            this.acctName = acctName;
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

        public string getAcctType() {
            return acctType;
        }

        public void setAcctType(string acctType) {
            this.acctType = acctType;
        }

        public string getAcctName() {
            return acctName;
        }

        public void setAcctName(string acctName) {
            this.acctName = acctName;
        }


    }
}
