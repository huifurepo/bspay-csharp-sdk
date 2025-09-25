using System;

namespace BasePaySdk.Request
{
    /**
     * 代运营佣金代扣
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LlaWithholdRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 代运营汇付id
         */
        private string agencyHuifuId;
        /**
         * 商家汇付id
         */
        private string merchantHuifuId;
        /**
         * 平台
         */
        private string platformType;
        /**
         * 提现id
         */
        private string encashSeqId;
        /**
         * 绑卡id
         */
        private string tokenNo;
        /**
         * 抽佣金额
         */
        private string transAmt;
        /**
         * 银行扩展数据
         */
        private string extendPayData;
        /**
         * 设备信息
         */
        private string terminalDeviceData;
        /**
         * 安全信息
         */
        private string riskCheckData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_LLA_WITHHOLD;
        }

        public V2LlaWithholdRequest() {
        }

        public V2LlaWithholdRequest(string reqSeqId, string reqDate, string agencyHuifuId, string merchantHuifuId, string platformType, string encashSeqId, string tokenNo, string transAmt, string extendPayData, string terminalDeviceData, string riskCheckData) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.agencyHuifuId = agencyHuifuId;
            this.merchantHuifuId = merchantHuifuId;
            this.platformType = platformType;
            this.encashSeqId = encashSeqId;
            this.tokenNo = tokenNo;
            this.transAmt = transAmt;
            this.extendPayData = extendPayData;
            this.terminalDeviceData = terminalDeviceData;
            this.riskCheckData = riskCheckData;
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

        public string getAgencyHuifuId() {
            return agencyHuifuId;
        }

        public void setAgencyHuifuId(string agencyHuifuId) {
            this.agencyHuifuId = agencyHuifuId;
        }

        public string getMerchantHuifuId() {
            return merchantHuifuId;
        }

        public void setMerchantHuifuId(string merchantHuifuId) {
            this.merchantHuifuId = merchantHuifuId;
        }

        public string getPlatformType() {
            return platformType;
        }

        public void setPlatformType(string platformType) {
            this.platformType = platformType;
        }

        public string getEncashSeqId() {
            return encashSeqId;
        }

        public void setEncashSeqId(string encashSeqId) {
            this.encashSeqId = encashSeqId;
        }

        public string getTokenNo() {
            return tokenNo;
        }

        public void setTokenNo(string tokenNo) {
            this.tokenNo = tokenNo;
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
