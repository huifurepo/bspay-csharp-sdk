using System;

namespace BasePaySdk.Request
{
    /**
     * 全渠道资金付款到账户退款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2EfpAcctpaymentRefundRequest : BaseRequest
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
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 原交易全局流水号org_hf_seq_id和org_req_seq_id二选一； &lt;font color&#x3D;&quot;green&quot;&gt;示例值：00470topo1A211015160805P090ac132fef00000&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 原交易请求流水号org_hf_seq_id和org_req_seq_id二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665002&lt;/font&gt;
         */
        private string orgReqSeqId;
        /**
         * 原交易请求日期
         */
        private string orgReqDate;
        /**
         * 退款金额
         */
        private string refundAmt;
        /**
         * 接收方退款对象
         */
        private string acctSplitBunch;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_EFP_ACCTPAYMENT_REFUND;
        }

        public V2EfpAcctpaymentRefundRequest() {
        }

        public V2EfpAcctpaymentRefundRequest(string reqSeqId, string reqDate, string huifuId, string orgHfSeqId, string orgReqSeqId, string orgReqDate, string refundAmt, string acctSplitBunch) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.orgHfSeqId = orgHfSeqId;
            this.orgReqSeqId = orgReqSeqId;
            this.orgReqDate = orgReqDate;
            this.refundAmt = refundAmt;
            this.acctSplitBunch = acctSplitBunch;
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

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }

        public string getRefundAmt() {
            return refundAmt;
        }

        public void setRefundAmt(string refundAmt) {
            this.refundAmt = refundAmt;
        }

        public string getAcctSplitBunch() {
            return acctSplitBunch;
        }

        public void setAcctSplitBunch(string acctSplitBunch) {
            this.acctSplitBunch = acctSplitBunch;
        }


    }
}
