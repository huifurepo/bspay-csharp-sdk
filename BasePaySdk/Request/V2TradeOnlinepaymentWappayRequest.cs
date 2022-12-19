using System;

namespace BasePaySdk.Request
{
    /**
     * 手机WAP支付
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentWappayRequest : BaseRequest
    {

        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 交易金额
         */
        private string transAmt;
        /**
         * 网联扩展数据
         */
        private string extendPayData;
        /**
         * 安全信息
         */
        private string riskCheckData;
        /**
         * 设备信息
         */
        private string terminalDeviceData;
        /**
         * 页面跳转地址
         */
        private string frontUrl;
        /**
         * 异步通知地址
         */
        private string notifyUrl;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_WAPPAY;
        }

        public V2TradeOnlinepaymentWappayRequest() {
        }

        public V2TradeOnlinepaymentWappayRequest(string reqDate, string reqSeqId, string huifuId, string transAmt, string extendPayData, string riskCheckData, string terminalDeviceData, string frontUrl, string notifyUrl) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.transAmt = transAmt;
            this.extendPayData = extendPayData;
            this.riskCheckData = riskCheckData;
            this.terminalDeviceData = terminalDeviceData;
            this.frontUrl = frontUrl;
            this.notifyUrl = notifyUrl;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getExtendPayData() {
            return extendPayData;
        }

        public void setExtendPayData(string extendPayData) {
            this.extendPayData = extendPayData;
        }

        public string getRiskCheckData() {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData) {
            this.riskCheckData = riskCheckData;
        }

        public string getTerminalDeviceData() {
            return terminalDeviceData;
        }

        public void setTerminalDeviceData(string terminalDeviceData) {
            this.terminalDeviceData = terminalDeviceData;
        }

        public string getFrontUrl() {
            return frontUrl;
        }

        public void setFrontUrl(string frontUrl) {
            this.frontUrl = frontUrl;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }


    }
}
