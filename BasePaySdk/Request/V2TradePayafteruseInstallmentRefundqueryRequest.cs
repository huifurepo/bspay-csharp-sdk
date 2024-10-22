using System;

namespace BasePaySdk.Request
{
    /**
     * 分期交易退款查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayafteruseInstallmentRefundqueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;

        public override string getFunctionCode()
        {
            return FunctionCodeEnum.V2_TRADE_PAYAFTERUSE_INSTALLMENT_REFUNDQUERY;
        }

        public V2TradePayafteruseInstallmentRefundqueryRequest()
        {
        }

        public V2TradePayafteruseInstallmentRefundqueryRequest(string huifuId)
        {
            this.huifuId = huifuId;
        }

        public string getHuifuId()
        {
            return huifuId;
        }

        public void setHuifuId(string huifuId)
        {
            this.huifuId = huifuId;
        }


    }
}
