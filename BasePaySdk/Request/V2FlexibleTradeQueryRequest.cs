using System;

namespace BasePaySdk.Request
{
    /**
     * 灵工支付查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleTradeQueryRequest : BaseRequest
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
         * 原请求流水号原请求流水号与原请求全局流水号二选一必填，示例值：2021091708126665001
         */
        private string orgReqSeqId;
        /**
         * 原请求日期原请求流水号必填则原请求日期必填，格式：yyyyMMdd；示例值：20210917
         */
        private string orgReqDate;
        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 原交易全局流水号原请求流水号与原请求全局流水号二选一必填，  &lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值： 003100TOP1A230816150903P990ac139c0600000&lt;/font&gt;
         */
        private string orgHfSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_FLEXIBLE_TRADE_QUERY;
        }

        public V2FlexibleTradeQueryRequest() {
        }

        public V2FlexibleTradeQueryRequest(string reqSeqId, string reqDate, string orgReqSeqId, string orgReqDate, string huifuId, string orgHfSeqId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.orgReqDate = orgReqDate;
            this.huifuId = huifuId;
            this.orgHfSeqId = orgHfSeqId;
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


    }
}
