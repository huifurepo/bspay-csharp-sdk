using System;

namespace BasePaySdk.Request
{
    /**
     * 网银支持银行列表查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentBankpayBanklistRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 网关支付类型
         */
        private string gateType;
        /**
         * 订单类型
         */
        private string orderType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_BANKPAY_BANKLIST;
        }

        public V2TradeOnlinepaymentBankpayBanklistRequest() {
        }

        public V2TradeOnlinepaymentBankpayBanklistRequest(string huifuId, string gateType, string orderType) {
            this.huifuId = huifuId;
            this.gateType = gateType;
            this.orderType = orderType;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getGateType() {
            return gateType;
        }

        public void setGateType(string gateType) {
            this.gateType = gateType;
        }

        public string getOrderType() {
            return orderType;
        }

        public void setOrderType(string orderType) {
            this.orderType = orderType;
        }


    }
}
