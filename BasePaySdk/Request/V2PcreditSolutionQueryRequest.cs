using System;

namespace BasePaySdk.Request
{
    /**
     * 花呗分期活动查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2PcreditSolutionQueryRequest : BaseRequest
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
         * 汇付Id
         */
        private string huifuId;
        /**
         * 活动方案id
         */
        private string solutionId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_PCREDIT_SOLUTION_QUERY;
        }

        public V2PcreditSolutionQueryRequest() {
        }

        public V2PcreditSolutionQueryRequest(string reqSeqId, string reqDate, string huifuId, string solutionId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.solutionId = solutionId;
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

        public string getSolutionId() {
            return solutionId;
        }

        public void setSolutionId(string solutionId) {
            this.solutionId = solutionId;
        }


    }
}
