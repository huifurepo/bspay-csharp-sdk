using System;

namespace BasePaySdk.Request
{
    /**
     * 代运营佣金代扣退款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LlaWithholdRefundRequest : BaseRequest
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
        /**
         * 退款金额
         */
        private string transAmt;
        /**
         * 设备信息
         */
        private string terminalDeviceData;
        /**
         * 安全信息
         */
        private string riskCheckData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_LLA_WITHHOLD_REFUND;
        }

        public V2LlaWithholdRefundRequest() {
        }

        public V2LlaWithholdRefundRequest(string reqSeqId, string reqDate, string orgReqDate, string orgReqSeqId, string orgHfSeqId, string agencyHuifuId, string transAmt, string terminalDeviceData, string riskCheckData) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.orgHfSeqId = orgHfSeqId;
            this.agencyHuifuId = agencyHuifuId;
            this.transAmt = transAmt;
            this.terminalDeviceData = terminalDeviceData;
            this.riskCheckData = riskCheckData;
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

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getTerminalDeviceData() {
            return terminalDeviceData;
        }

        public void setTerminalDeviceData(string terminalDeviceData) {
            this.terminalDeviceData = terminalDeviceData;
        }

        public string getRiskCheckData() {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData) {
            this.riskCheckData = riskCheckData;
        }


    }
}
