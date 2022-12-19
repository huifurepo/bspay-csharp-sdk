using System;

namespace BasePaySdk.Request
{
    /**
     * 交易查询接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentScanpayQueryRequest : BaseRequest
    {

        /**
         * 原机构请求日期
         */
        private string orgReqDate;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 商户订单号线下POS、扫码机具发起的交易需要提供；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：22577563652260773965&lt;/font&gt;
         */
        private string merOrdId;
        /**
         * 交易返回的全局流水号org_hf_seq_id，org_req_seq_id，out_trans_id，party_order_id四选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00290TOP1GR210919004230P853ac13262200000&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 原机构请求流水号org_hf_seq_id，org_req_seq_id，out_trans_id，party_order_id四选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：202110210012100005&lt;/font&gt;
         */
        private string orgReqSeqId;
        /**
         * 用户账单上的交易订单号org_hf_seq_id，org_req_seq_id，out_trans_id，party_order_id四选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：092021091922001451301445517582&lt;/font&gt;；参见[用户账单说明](https://paas.huifu.com/partners/api/#/czsm/api_czsm_yhzd)
         */
        private string outTransId;
        /**
         * 用户账单上的商户订单号org_hf_seq_id，org_req_seq_id，out_trans_id，party_order_id四选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：03232109190255105603561&lt;/font&gt;；参见[用户账单说明](https://paas.huifu.com/partners/api/#/czsm/api_czsm_yhzd)
         */
        private string partyOrderId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_SCANPAY_QUERY;
        }

        public V2TradePaymentScanpayQueryRequest() {
        }

        public V2TradePaymentScanpayQueryRequest(string orgReqDate, string huifuId, string merOrdId, string orgHfSeqId, string orgReqSeqId, string outTransId, string partyOrderId) {
            this.orgReqDate = orgReqDate;
            this.huifuId = huifuId;
            this.merOrdId = merOrdId;
            this.orgHfSeqId = orgHfSeqId;
            this.orgReqSeqId = orgReqSeqId;
            this.outTransId = outTransId;
            this.partyOrderId = partyOrderId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getMerOrdId() {
            return merOrdId;
        }

        public void setMerOrdId(string merOrdId) {
            this.merOrdId = merOrdId;
        }

        public string getOrgHfSeqId() {
            return orgHfSeqId;
        }

        public void setOrgHfSeqId(string orgHfSeqId) {
            this.orgHfSeqId = orgHfSeqId;
        }

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getOutTransId() {
            return outTransId;
        }

        public void setOutTransId(string outTransId) {
            this.outTransId = outTransId;
        }

        public string getPartyOrderId() {
            return partyOrderId;
        }

        public void setPartyOrderId(string partyOrderId) {
            this.partyOrderId = partyOrderId;
        }


    }
}
