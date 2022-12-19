using System;

namespace BasePaySdk.Request
{
    /**
     * 新增终端报备
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TerminaldeviceDeviceinfoAddRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TERMINALDEVICE_DEVICEINFO_ADD;
        }

        public V2TerminaldeviceDeviceinfoAddRequest() {
        }

        public V2TerminaldeviceDeviceinfoAddRequest(string reqSeqId, string reqDate, string huifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
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


    }
}
