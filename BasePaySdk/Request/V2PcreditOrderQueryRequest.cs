using System;

namespace BasePaySdk.Request
{
    /**
     * 花呗分期贴息查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2PcreditOrderQueryRequest : BaseRequest
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
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 贴息方案id
         */
        private string solutionId;
        /**
         * 活动开始时间
         */
        private string startTime;
        /**
         * 活动结束时间
         */
        private string endTime;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_PCREDIT_ORDER_QUERY;
        }

        public V2PcreditOrderQueryRequest() {
        }

        public V2PcreditOrderQueryRequest(string reqSeqId, string reqDate, string huifuId, string solutionId, string startTime, string endTime) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.solutionId = solutionId;
            this.startTime = startTime;
            this.endTime = endTime;
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

        public string getStartTime() {
            return startTime;
        }

        public void setStartTime(string startTime) {
            this.startTime = startTime;
        }

        public string getEndTime() {
            return endTime;
        }

        public void setEndTime(string endTime) {
            this.endTime = endTime;
        }


    }
}
