using System;

namespace BasePaySdk.Request
{
    /**
     * 银联统一在线收银台签约接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentUnionsignRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 支付场景
         */
        private string payScene;
        /**
         * 异步通知地址
         */
        private string notifyUrl;
        /**
         * 设备信息
         */
        private string terminalDeviceData;
        /**
         * 三方支付数据jsonObject；&lt;br/&gt;
         */
        private string thirdPayData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_UNIONSIGN;
        }

        public V2TradeOnlinepaymentUnionsignRequest() {
        }

        public V2TradeOnlinepaymentUnionsignRequest(string huifuId, string reqDate, string reqSeqId, string payScene, string notifyUrl, string terminalDeviceData, string thirdPayData) {
            this.huifuId = huifuId;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.payScene = payScene;
            this.notifyUrl = notifyUrl;
            this.terminalDeviceData = terminalDeviceData;
            this.thirdPayData = thirdPayData;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
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

        public string getPayScene() {
            return payScene;
        }

        public void setPayScene(string payScene) {
            this.payScene = payScene;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }

        public string getTerminalDeviceData() {
            return terminalDeviceData;
        }

        public void setTerminalDeviceData(string terminalDeviceData) {
            this.terminalDeviceData = terminalDeviceData;
        }

        public string getThirdPayData() {
            return thirdPayData;
        }

        public void setThirdPayData(string thirdPayData) {
            this.thirdPayData = thirdPayData;
        }


    }
}
