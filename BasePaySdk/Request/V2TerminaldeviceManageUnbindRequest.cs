using System;

namespace BasePaySdk.Request
{
    /**
     * 终端解绑
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TerminaldeviceManageUnbindRequest : BaseRequest
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
         * 汇付ID
         */
        private string huifuId;
        /**
         * 终端号
         */
        private string deviceId;
        /**
         * 解绑原因
         */
        private string reason;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TERMINALDEVICE_MANAGE_UNBIND;
        }

        public V2TerminaldeviceManageUnbindRequest() {
        }

        public V2TerminaldeviceManageUnbindRequest(string reqSeqId, string reqDate, string huifuId, string deviceId, string reason) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.deviceId = deviceId;
            this.reason = reason;
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

        public string getDeviceId() {
            return deviceId;
        }

        public void setDeviceId(string deviceId) {
            this.deviceId = deviceId;
        }

        public string getReason() {
            return reason;
        }

        public void setReason(string reason) {
            this.reason = reason;
        }


    }
}
