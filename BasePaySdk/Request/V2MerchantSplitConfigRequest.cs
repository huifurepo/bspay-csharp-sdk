using System;

namespace BasePaySdk.Request
{
    /**
     * 商户分账配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantSplitConfigRequest : BaseRequest
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
         * 商户汇付Id
         */
        private string huifuId;
        /**
         * 分账规则来源
         */
        private string ruleOrigin;
        /**
         * 分账开关
         */
        private string divFlag;
        /**
         * 最大分账比例
         */
        private string applyRatio;
        /**
         * 生效类型
         */
        private string startType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_SPLIT_CONFIG;
        }

        public V2MerchantSplitConfigRequest() {
        }

        public V2MerchantSplitConfigRequest(string reqSeqId, string reqDate, string huifuId, string ruleOrigin, string divFlag, string applyRatio, string startType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.ruleOrigin = ruleOrigin;
            this.divFlag = divFlag;
            this.applyRatio = applyRatio;
            this.startType = startType;
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

        public string getRuleOrigin() {
            return ruleOrigin;
        }

        public void setRuleOrigin(string ruleOrigin) {
            this.ruleOrigin = ruleOrigin;
        }

        public string getDivFlag() {
            return divFlag;
        }

        public void setDivFlag(string divFlag) {
            this.divFlag = divFlag;
        }

        public string getApplyRatio() {
            return applyRatio;
        }

        public void setApplyRatio(string applyRatio) {
            this.applyRatio = applyRatio;
        }

        public string getStartType() {
            return startType;
        }

        public void setStartType(string startType) {
            this.startType = startType;
        }


    }
}
