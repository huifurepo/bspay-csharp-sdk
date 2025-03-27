using System;

namespace BasePaySdk.Request
{
    /**
     * 钱包支付退款查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradePayRefundQueryRequest : BaseRequest
    {

        /**
         * 原退款交易请求日期
         */
        private string orgReqDate;
        /**
         * 原退款交易请求流水号
         */
        private string orgReqSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_TRADE_PAY_REFUND_QUERY;
        }

        public V2WalletTradePayRefundQueryRequest() {
        }

        public V2WalletTradePayRefundQueryRequest(string orgReqDate, string orgReqSeqId) {
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }


    }
}
