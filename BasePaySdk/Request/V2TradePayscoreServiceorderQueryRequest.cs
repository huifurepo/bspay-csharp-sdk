using System;

namespace BasePaySdk.Request
{
    /**
     * 查询支付分订单
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscoreServiceorderQueryRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYSCORE_SERVICEORDER_QUERY;
        }

        public V2TradePayscoreServiceorderQueryRequest() {
        }

        public V2TradePayscoreServiceorderQueryRequest(string huifuId) {
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
