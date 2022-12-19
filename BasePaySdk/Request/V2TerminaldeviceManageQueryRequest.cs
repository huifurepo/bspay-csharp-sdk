using System;

namespace BasePaySdk.Request
{
    /**
     * 服务商终端列表查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TerminaldeviceManageQueryRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求时间
         */
        private string reqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TERMINALDEVICE_MANAGE_QUERY;
        }

        public V2TerminaldeviceManageQueryRequest() {
        }

        public V2TerminaldeviceManageQueryRequest(string reqSeqId, string reqDate) {
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
