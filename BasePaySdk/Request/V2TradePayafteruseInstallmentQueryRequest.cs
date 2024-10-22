using System;

namespace BasePaySdk.Request
{
    /**
     * 分期扣款查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayafteruseInstallmentQueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;

        public override string getFunctionCode()
        {
            return FunctionCodeEnum.V2_TRADE_PAYAFTERUSE_INSTALLMENT_QUERY;
        }

        public V2TradePayafteruseInstallmentQueryRequest()
        {
        }

        public V2TradePayafteruseInstallmentQueryRequest(string huifuId)
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
