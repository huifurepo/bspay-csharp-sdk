using System;

namespace BasePaySdk.Request
{
    /**
     * 个人签约状态查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2HycContractQueryRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求日期
         */
        private string reqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_HYC_CONTRACT_QUERY;
        }

        public V2HycContractQueryRequest() {
        }

        public V2HycContractQueryRequest(string reqSeqId, string reqDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
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


    }
}
