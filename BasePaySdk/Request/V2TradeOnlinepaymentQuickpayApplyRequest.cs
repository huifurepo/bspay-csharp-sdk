using System;

namespace BasePaySdk.Request
{
    /**
     * 快捷支付申请
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentQuickpayApplyRequest : BaseRequest
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
         * 订单金额
         */
        private string transAmt;
        /**
         * 绑卡id
         */
        private string cardBindId;
        /**
         * 异步通知地址
         */
        private string notifyUrl;
        /**
         * 用户客户号
         */
        private string userHuifuId;
        /**
         * 安全信息
         */
        private string riskCheckData;
        /**
         * 设备数据
         */
        private string terminalDeviceData;
        /**
         * 银行扩展字段
         */
        private string extendPayData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_QUICKPAY_APPLY;
        }

        public V2TradeOnlinepaymentQuickpayApplyRequest() {
        }

        public V2TradeOnlinepaymentQuickpayApplyRequest(string reqDate, string reqSeqId, string huifuId, string transAmt, string cardBindId, string notifyUrl, string userHuifuId, string riskCheckData, string terminalDeviceData, string extendPayData) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.transAmt = transAmt;
            this.cardBindId = cardBindId;
            this.notifyUrl = notifyUrl;
            this.userHuifuId = userHuifuId;
            this.riskCheckData = riskCheckData;
            this.terminalDeviceData = terminalDeviceData;
            this.extendPayData = extendPayData;
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

        public string getCardBindId() {
            return cardBindId;
        }

        public void setCardBindId(string cardBindId) {
            this.cardBindId = cardBindId;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }

        public string getUserHuifuId() {
            return userHuifuId;
        }

        public void setUserHuifuId(string userHuifuId) {
            this.userHuifuId = userHuifuId;
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

        public string getExtendPayData() {
            return extendPayData;
        }

        public void setExtendPayData(string extendPayData) {
            this.extendPayData = extendPayData;
        }


    }
}
