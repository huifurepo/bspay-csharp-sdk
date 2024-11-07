using System;

namespace BasePaySdk.Request
{
    /**
     * 快捷短信发送
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradeOnlinepaymentQuickpaySmssendRequest : BaseRequest
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
         * 用户客户号
         */
        private string userHuifuId;
        /**
         * 绑卡id
         */
        private string cardBindId;
        /**
         * 订单金额
         */
        private string transAmt;
        /**
         * 异步通知地址
         */
        private string notifyUrl;
        /**
         * 网联数据
         */
        private string nuccData;
        /**
         * 设备数据
         */
        private string terminalDeviceData;
        /**
         * 安全信息
         */
        private string riskCheckData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_TRADE_ONLINEPAYMENT_QUICKPAY_SMSSEND;
        }

        public V3TradeOnlinepaymentQuickpaySmssendRequest() {
        }

        public V3TradeOnlinepaymentQuickpaySmssendRequest(string reqDate, string reqSeqId, string huifuId, string userHuifuId, string cardBindId, string transAmt, string notifyUrl, string nuccData, string terminalDeviceData, string riskCheckData) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.userHuifuId = userHuifuId;
            this.cardBindId = cardBindId;
            this.transAmt = transAmt;
            this.notifyUrl = notifyUrl;
            this.nuccData = nuccData;
            this.terminalDeviceData = terminalDeviceData;
            this.riskCheckData = riskCheckData;
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

        public string getUserHuifuId() {
            return userHuifuId;
        }

        public void setUserHuifuId(string userHuifuId) {
            this.userHuifuId = userHuifuId;
        }

        public string getCardBindId() {
            return cardBindId;
        }

        public void setCardBindId(string cardBindId) {
            this.cardBindId = cardBindId;
        }

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }

        public string getNuccData() {
            return nuccData;
        }

        public void setNuccData(string nuccData) {
            this.nuccData = nuccData;
        }

        public string getTerminalDeviceData() {
            return terminalDeviceData;
        }

        public void setTerminalDeviceData(string terminalDeviceData) {
            this.terminalDeviceData = terminalDeviceData;
        }

        public string getRiskCheckData() {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData) {
            this.riskCheckData = riskCheckData;
        }


    }
}
