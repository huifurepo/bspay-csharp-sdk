using System;

namespace BasePaySdk.Request
{
    /**
     * 线上交易退款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentRefundRequest : BaseRequest
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
         * 退款金额
         */
        private string ordAmt;
        /**
         * 设备信息条件必填，当为银行大额支付时可不填，jsonObject格式
         */
        private string terminalDeviceData;
        /**
         * 安全信息条件必填，当为银行大额支付时可不填，jsonObject格式
         */
        private string riskCheckData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_REFUND;
        }

        public V2TradeOnlinepaymentRefundRequest() {
        }

        public V2TradeOnlinepaymentRefundRequest(string reqDate, string reqSeqId, string huifuId, string ordAmt, string terminalDeviceData, string riskCheckData) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.ordAmt = ordAmt;
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

        public string getOrdAmt() {
            return ordAmt;
        }

        public void setOrdAmt(string ordAmt) {
            this.ordAmt = ordAmt;
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
