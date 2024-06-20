using System;

namespace BasePaySdk.Request
{
    /**
     * 交易分账明细查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeTransSplitQueryRequest : BaseRequest
    {

        /**
         * 分账交易汇付全局流水号
         */
        private string hfSeqId;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 交易类型
         */
        private string ordType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_TRANS_SPLIT_QUERY;
        }

        public V2TradeTransSplitQueryRequest() {
        }

        public V2TradeTransSplitQueryRequest(string hfSeqId, string huifuId, string ordType) {
            this.hfSeqId = hfSeqId;
            this.huifuId = huifuId;
            this.ordType = ordType;
        }

        public string getHfSeqId() {
            return hfSeqId;
        }

        public void setHfSeqId(string hfSeqId) {
            this.hfSeqId = hfSeqId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getOrdType() {
            return ordType;
        }

        public void setOrdType(string ordType) {
            this.ordType = ordType;
        }


    }
}
