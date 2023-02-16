using System;

namespace BasePaySdk.Request
{
    /**
     * DM取现额度查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettlementEnchashmentDmamtQueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_SETTLEMENT_ENCHASHMENT_DMAMT_QUERY;
        }

        public V2TradeSettlementEnchashmentDmamtQueryRequest() {
        }

        public V2TradeSettlementEnchashmentDmamtQueryRequest(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }


    }
}
