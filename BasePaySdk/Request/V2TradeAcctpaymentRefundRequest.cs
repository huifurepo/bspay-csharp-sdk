using System;

namespace BasePaySdk.Request
{
    /**
     * 余额支付退款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeAcctpaymentRefundRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 原余额支付请求日期org_hf_seq_id和（orgReqDate+orgReqSeqId）二选一；&lt;br/&gt;格式：yyyyMMdd；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20221023&lt;/font&gt;
         */
        private string orgReqDate;
        /**
         * 原余额支付请求流水号org_hf_seq_id和（orgReqDate+orgReqSeqId）二选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665001&lt;/font&gt;
         */
        private string orgReqSeqId;
        /**
         * 原余额支付支付全局流水号org_hf_seq_id和（orgReqDate+orgReqSeqId）二选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00470topo1A211015160805P090ac132fef00000&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 退款金额
         */
        private string ordAmt;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ACCTPAYMENT_REFUND;
        }

        public V2TradeAcctpaymentRefundRequest() {
        }

        public V2TradeAcctpaymentRefundRequest(string reqSeqId, string reqDate, string huifuId, string orgReqDate, string orgReqSeqId, string orgHfSeqId, string ordAmt) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.orgHfSeqId = orgHfSeqId;
            this.ordAmt = ordAmt;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
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

        public string getOrgHfSeqId() {
            return orgHfSeqId;
        }

        public void setOrgHfSeqId(string orgHfSeqId) {
            this.orgHfSeqId = orgHfSeqId;
        }

        public string getOrdAmt() {
            return ordAmt;
        }

        public void setOrdAmt(string ordAmt) {
            this.ordAmt = ordAmt;
        }


    }
}
