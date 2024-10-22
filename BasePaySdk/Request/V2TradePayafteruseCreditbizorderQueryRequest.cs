using System;

namespace BasePaySdk.Request
{
    /**
     * 服务单查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayafteruseCreditbizorderQueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;

        public override string getFunctionCode()
        {
            return FunctionCodeEnum.V2_TRADE_PAYAFTERUSE_CREDITBIZORDER_QUERY;
        }

        public V2TradePayafteruseCreditbizorderQueryRequest()
        {
        }

        public V2TradePayafteruseCreditbizorderQueryRequest(string huifuId)
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
