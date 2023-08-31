using System;

namespace BasePaySdk.Request
{
    /**
     * 查询扣款信息
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscoreDeductQueryRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYSCORE_DEDUCT_QUERY;
        }

        public V2TradePayscoreDeductQueryRequest() {
        }

        public V2TradePayscoreDeductQueryRequest(string huifuId) {
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
