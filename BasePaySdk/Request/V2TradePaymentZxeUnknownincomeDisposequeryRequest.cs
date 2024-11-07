using System;

namespace BasePaySdk.Request
{
    /**
     * 不明来账处理结果查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentZxeUnknownincomeDisposequeryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_ZXE_UNKNOWNINCOME_DISPOSEQUERY;
        }

        public V2TradePaymentZxeUnknownincomeDisposequeryRequest() {
        }

        public V2TradePaymentZxeUnknownincomeDisposequeryRequest(string huifuId) {
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
