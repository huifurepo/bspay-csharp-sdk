using System;

namespace BasePaySdk.Request
{
    /**
     * 取消支付分订单
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscoreServiceorderCancelRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 取消服务订单原因
         */
        private string reason;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYSCORE_SERVICEORDER_CANCEL;
        }

        public V2TradePayscoreServiceorderCancelRequest() {
        }

        public V2TradePayscoreServiceorderCancelRequest(string huifuId, string reason) {
            this.huifuId = huifuId;
            this.reason = reason;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getReason() {
            return reason;
        }

        public void setReason(string reason) {
            this.reason = reason;
        }


    }
}
