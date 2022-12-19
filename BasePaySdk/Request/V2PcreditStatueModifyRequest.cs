using System;

namespace BasePaySdk.Request
{
    /**
     * 上架下架分期活动接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2PcreditStatueModifyRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;
        /**
         * 贴息方案实例id
         */
        private string solutionId;
        /**
         * 状态控制
         */
        private string status;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_PCREDIT_STATUE_MODIFY;
        }

        public V2PcreditStatueModifyRequest() {
        }

        public V2PcreditStatueModifyRequest(string reqSeqId, string reqDate, string huifuId, string solutionId, string status) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.solutionId = solutionId;
            this.status = status;
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

        public string getStatus() {
            return status;
        }

        public void setStatus(string status) {
            this.status = status;
        }


    }
}
