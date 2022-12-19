using System;

namespace BasePaySdk.Request
{
    /**
     * 线上交易退款查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentRefundQueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 原退款请求日期
         */
        private string orgReqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_REFUND_QUERY;
        }

        public V2TradeOnlinepaymentRefundQueryRequest() {
        }

        public V2TradeOnlinepaymentRefundQueryRequest(string huifuId, string orgReqDate) {
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }


    }
}
