using System;

namespace BasePaySdk.Request
{
    /**
     * 一键绑卡
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleOnekeyCardbindRequest : BaseRequest
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
         * 汇付Id
         */
        private string huifuId;
        /**
         * 顾客用户号 
         */
        private string outCustId;
        /**
         * 银行号
         */
        private string bankId;
        /**
         * 银行卡开户姓名 
         */
        private string cardName;
        /**
         * 银行卡绑定身份证
         */
        private string certId;
        /**
         * 银行卡绑定证件类型
         */
        private string certType;
        /**
         * 证件有效期到期日长期有效不填.格式：yyyyMMdd。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20311111&lt;/font&gt;
         */
        private string certEndDate;
        /**
         * 银行卡绑定手机号 
         */
        private string cardMp;
        /**
         * 卡的借贷类型
         */
        private string dcType;
        /**
         * 异步请求地址
         */
        private string asyncReturnUrl;
        /**
         * 设备信息域
         */
        private string trxDeviceInf;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_QUICKBUCKLE_ONEKEY_CARDBIND;
        }

        public V2QuickbuckleOnekeyCardbindRequest() {
        }

        public V2QuickbuckleOnekeyCardbindRequest(string reqSeqId, string reqDate, string huifuId, string outCustId, string bankId, string cardName, string certId, string certType, string certEndDate, string cardMp, string dcType, string asyncReturnUrl, string trxDeviceInf) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.outCustId = outCustId;
            this.bankId = bankId;
            this.cardName = cardName;
            this.certId = certId;
            this.certType = certType;
            this.certEndDate = certEndDate;
            this.cardMp = cardMp;
            this.dcType = dcType;
            this.asyncReturnUrl = asyncReturnUrl;
            this.trxDeviceInf = trxDeviceInf;
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

        public string getOutCustId() {
            return outCustId;
        }

        public void setOutCustId(string outCustId) {
            this.outCustId = outCustId;
        }

        public string getBankId() {
            return bankId;
        }

        public void setBankId(string bankId) {
            this.bankId = bankId;
        }

        public string getCardName() {
            return cardName;
        }

        public void setCardName(string cardName) {
            this.cardName = cardName;
        }

        public string getCertId() {
            return certId;
        }

        public void setCertId(string certId) {
            this.certId = certId;
        }

        public string getCertType() {
            return certType;
        }

        public void setCertType(string certType) {
            this.certType = certType;
        }

        public string getCertEndDate() {
            return certEndDate;
        }

        public void setCertEndDate(string certEndDate) {
            this.certEndDate = certEndDate;
        }

        public string getCardMp() {
            return cardMp;
        }

        public void setCardMp(string cardMp) {
            this.cardMp = cardMp;
        }

        public string getDcType() {
            return dcType;
        }

        public void setDcType(string dcType) {
            this.dcType = dcType;
        }

        public string getAsyncReturnUrl() {
            return asyncReturnUrl;
        }

        public void setAsyncReturnUrl(string asyncReturnUrl) {
            this.asyncReturnUrl = asyncReturnUrl;
        }

        public string getTrxDeviceInf() {
            return trxDeviceInf;
        }

        public void setTrxDeviceInf(string trxDeviceInf) {
            this.trxDeviceInf = trxDeviceInf;
        }


    }
}
