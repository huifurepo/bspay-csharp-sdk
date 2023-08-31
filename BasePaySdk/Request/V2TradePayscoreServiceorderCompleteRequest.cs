using System;

namespace BasePaySdk.Request
{
    /**
     * 完结支付分订单
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscoreServiceorderCompleteRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 汇付订单号
         */
        private string outOrderNo;
        /**
         * 完结金额
         */
        private string ordAmt;
        /**
         * 服务时间
         */
        private string timeRange;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYSCORE_SERVICEORDER_COMPLETE;
        }

        public V2TradePayscoreServiceorderCompleteRequest() {
        }

        public V2TradePayscoreServiceorderCompleteRequest(string huifuId, string outOrderNo, string ordAmt, string timeRange) {
            this.huifuId = huifuId;
            this.outOrderNo = outOrderNo;
            this.ordAmt = ordAmt;
            this.timeRange = timeRange;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getOutOrderNo() {
            return outOrderNo;
        }

        public void setOutOrderNo(string outOrderNo) {
            this.outOrderNo = outOrderNo;
        }

        public string getOrdAmt() {
            return ordAmt;
        }

        public void setOrdAmt(string ordAmt) {
            this.ordAmt = ordAmt;
        }

        public string getTimeRange() {
            return timeRange;
        }

        public void setTimeRange(string timeRange) {
            this.timeRange = timeRange;
        }


    }
}
