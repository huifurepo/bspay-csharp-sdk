using System;

namespace BasePaySdk.Request
{
    /**
     * 灵工支付退款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleRefundRequest : BaseRequest
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
         * 原请求日期
         */
        private string orgReqDate;
        /**
         * 原灵工支付交易流水号&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665231&lt;/font&gt;
         */
        private string orgReqSeqId;
        /**
         * 原灵工支付汇付全局流水号与原灵工支付交易流水号必选其一&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665001&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 发起方商户号
         */
        private string huifuId;
        /**
         * 支付金额
         */
        private string ordAmt;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_FLEXIBLE_REFUND;
        }

        public V2FlexibleRefundRequest() {
        }

        public V2FlexibleRefundRequest(string reqSeqId, string reqDate, string orgReqDate, string orgReqSeqId, string orgHfSeqId, string huifuId, string ordAmt) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.orgHfSeqId = orgHfSeqId;
            this.huifuId = huifuId;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getOrdAmt() {
            return ordAmt;
        }

        public void setOrdAmt(string ordAmt) {
            this.ordAmt = ordAmt;
        }


    }
}
