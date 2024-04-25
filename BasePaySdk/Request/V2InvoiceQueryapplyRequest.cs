using System;

namespace BasePaySdk.Request
{
    /**
     * 发票开具申请查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceQueryapplyRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求时间
         */
        private string reqDate;
        /**
         * 渠道号汇付商户号为空时，必传；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812124&lt;/font&gt;
         */
        private string channelId;
        /**
         * 流水号
         */
        private string seqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_QUERYAPPLY;
        }

        public V2InvoiceQueryapplyRequest() {
        }

        public V2InvoiceQueryapplyRequest(string reqSeqId, string reqDate, string channelId, string seqId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.channelId = channelId;
            this.seqId = seqId;
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

        public string getChannelId() {
            return channelId;
        }

        public void setChannelId(string channelId) {
            this.channelId = channelId;
        }

        public string getSeqId() {
            return seqId;
        }

        public void setSeqId(string seqId) {
            this.seqId = seqId;
        }


    }
}
