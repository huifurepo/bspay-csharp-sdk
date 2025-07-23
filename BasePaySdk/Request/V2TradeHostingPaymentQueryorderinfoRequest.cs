using System;

namespace BasePaySdk.Request
{
    /**
     * 托管交易查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentQueryorderinfoRequest : BaseRequest
    {

        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 原交易请求日期
         */
        private string orgReqDate;
        /**
         * 原交易请求流水号与**party_order_id**二选一，必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：rQ2021121311173944&lt;/font&gt;
         */
        private string orgReqSeqId;
        /**
         * 用户账单上的商户订单号与**org_req_seq_id**二选一，必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：03232109190255105603561&lt;/font&gt;
         */
        private string partyOrderId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_HOSTING_PAYMENT_QUERYORDERINFO;
        }

        public V2TradeHostingPaymentQueryorderinfoRequest() {
        }

        public V2TradeHostingPaymentQueryorderinfoRequest(string reqDate, string reqSeqId, string huifuId, string orgReqDate, string orgReqSeqId, string partyOrderId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.partyOrderId = partyOrderId;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
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

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getPartyOrderId() {
            return partyOrderId;
        }

        public void setPartyOrderId(string partyOrderId) {
            this.partyOrderId = partyOrderId;
        }


    }
}
