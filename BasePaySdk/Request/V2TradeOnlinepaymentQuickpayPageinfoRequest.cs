using System;

namespace BasePaySdk.Request
{
    /**
     * 快捷支付页面版接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentQuickpayPageinfoRequest : BaseRequest
    {

        /**
         * 业务请求流水号
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
        /**
         * 订单金额
         */
        private string transAmt;
        /**
         * 设备信息
         */
        private string terminalDeviceData;
        /**
         * 银行扩展信息
         */
        private string extendPayData;
        /**
         * 安全信息
         */
        private string riskCheckData;
        /**
         * 异步通知地址
         */
        private string notifyUrl;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_QUICKPAY_PAGEINFO;
        }

        public V2TradeOnlinepaymentQuickpayPageinfoRequest() {
        }

        public V2TradeOnlinepaymentQuickpayPageinfoRequest(string reqSeqId, string reqDate, string huifuId, string transAmt, string terminalDeviceData, string extendPayData, string riskCheckData, string notifyUrl) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.transAmt = transAmt;
            this.terminalDeviceData = terminalDeviceData;
            this.extendPayData = extendPayData;
            this.riskCheckData = riskCheckData;
            this.notifyUrl = notifyUrl;
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

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
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

        public string getRiskCheckData() {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData) {
            this.riskCheckData = riskCheckData;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }


    }
}
