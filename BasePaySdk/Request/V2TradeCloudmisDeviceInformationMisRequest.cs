using System;

namespace BasePaySdk.Request
{
    /**
     * 终端云MIS交易
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeCloudmisDeviceInformationMisRequest : BaseRequest
    {

        /**
         * 终端设备号
         */
        private string deviceId;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 交易信息
         */
        private string jsonData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_CLOUDMIS_DEVICE_INFORMATION_MIS;
        }

        public V2TradeCloudmisDeviceInformationMisRequest() {
        }

        public V2TradeCloudmisDeviceInformationMisRequest(string deviceId, string huifuId, string jsonData) {
            this.deviceId = deviceId;
            this.huifuId = huifuId;
            this.jsonData = jsonData;
        }

        public string getDeviceId() {
            return deviceId;
        }

        public void setDeviceId(string deviceId) {
            this.deviceId = deviceId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getJsonData() {
            return jsonData;
        }

        public void setJsonData(string jsonData) {
            this.jsonData = jsonData;
        }


    }
}
