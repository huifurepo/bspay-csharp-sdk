using System;

namespace BasePaySdk.Request
{
    /**
     * 商户分期配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2PcreditFeeConfigRequest : BaseRequest
    {

        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_PCREDIT_FEE_CONFIG;
        }

        public V2PcreditFeeConfigRequest() {
        }

        public V2PcreditFeeConfigRequest(string reqDate, string reqSeqId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
        }


    }
}
