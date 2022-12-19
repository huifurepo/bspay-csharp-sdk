using System;

namespace BasePaySdk.Request
{
    /**
     * 终端绑定
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TerminaldeviceManageBindRequest : BaseRequest
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

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TERMINALDEVICE_MANAGE_BIND;
        }

        public V2TerminaldeviceManageBindRequest() {
        }

        public V2TerminaldeviceManageBindRequest(string reqSeqId, string reqDate, string huifuId, string deviceId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.deviceId = deviceId;
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


    }
}
