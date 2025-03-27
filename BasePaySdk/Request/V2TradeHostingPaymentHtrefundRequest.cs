using System;

namespace BasePaySdk.Request
{
    /**
     * 托管交易退款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentHtrefundRequest : BaseRequest
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
         * 申请退款金额
         */
        private string ordAmt;
        /**
         * 原交易请求日期
         */
        private string orgReqDate;
        /**
         * 安全信息线上交易退款必填，参见线上退款接口；jsonObject字符串
         */
        private string riskCheckData;
        /**
         * 设备信息线上交易退款必填，参见线上退款接口；jsonObject字符串
         */
        private string terminalDeviceData;
        /**
         * 大额转账支付账户信息数据jsonObject格式；银行大额转账支付交易退款申请时必填
         */
        private string bankInfoData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_HOSTING_PAYMENT_HTREFUND;
        }

        public V2TradeHostingPaymentHtrefundRequest() {
        }

        public V2TradeHostingPaymentHtrefundRequest(string reqDate, string reqSeqId, string huifuId, string ordAmt, string orgReqDate, string riskCheckData, string terminalDeviceData, string bankInfoData) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.ordAmt = ordAmt;
            this.orgReqDate = orgReqDate;
            this.riskCheckData = riskCheckData;
            this.terminalDeviceData = terminalDeviceData;
            this.bankInfoData = bankInfoData;
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

        public string getOrdAmt() {
            return ordAmt;
        }

        public void setOrdAmt(string ordAmt) {
            this.ordAmt = ordAmt;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
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

        public string getBankInfoData() {
            return bankInfoData;
        }

        public void setBankInfoData(string bankInfoData) {
            this.bankInfoData = bankInfoData;
        }


    }
}
