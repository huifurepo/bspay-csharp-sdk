using System;

namespace BasePaySdk.Request
{
    /**
     * 代运营佣金代扣查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LlaWithholdQueryRequest : BaseRequest
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
         * 原请求流水号org_hf_seq_id与org_req_seq_id二选一必填。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665001&lt;/font&gt;
         */
        private string orgReqSeqId;
        /**
         * 原全局流水号org_hf_seq_id与org_req_seq_id二选一必填。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00470topo1A221019132207P068ac1362af00000&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 代运营汇付id
         */
        private string agencyHuifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_LLA_WITHHOLD_QUERY;
        }

        public V2LlaWithholdQueryRequest() {
        }

        public V2LlaWithholdQueryRequest(string reqSeqId, string reqDate, string orgReqDate, string orgReqSeqId, string orgHfSeqId, string agencyHuifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.orgHfSeqId = orgHfSeqId;
            this.agencyHuifuId = agencyHuifuId;
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

        public string getAgencyHuifuId() {
            return agencyHuifuId;
        }

        public void setAgencyHuifuId(string agencyHuifuId) {
            this.agencyHuifuId = agencyHuifuId;
        }


    }
}
