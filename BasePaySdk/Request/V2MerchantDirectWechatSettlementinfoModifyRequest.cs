using System;

namespace BasePaySdk.Request
{
    /**
     * 微信直连-修改微信结算帐号
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectWechatSettlementinfoModifyRequest : BaseRequest
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
         * 汇付ID
         */
        private string huifuId;
        /**
         * 开发者的应用ID
         */
        private string appId;
        /**
         * 微信商户号
         */
        private string mchId;
        /**
         * 特约商户号
         */
        private string subMchid;
        /**
         * 账户类型
         */
        private string accountType;
        /**
         * 开户银行
         */
        private string accountBank;
        /**
         * 开户银行省市编码
         */
        private string bankAddressCode;
        /**
         * 银行账号
         */
        private string accountNumber;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_WECHAT_SETTLEMENTINFO_MODIFY;
        }

        public V2MerchantDirectWechatSettlementinfoModifyRequest() {
        }

        public V2MerchantDirectWechatSettlementinfoModifyRequest(string reqSeqId, string reqDate, string huifuId, string appId, string mchId, string subMchid, string accountType, string accountBank, string bankAddressCode, string accountNumber) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.appId = appId;
            this.mchId = mchId;
            this.subMchid = subMchid;
            this.accountType = accountType;
            this.accountBank = accountBank;
            this.bankAddressCode = bankAddressCode;
            this.accountNumber = accountNumber;
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

        public string getAppId() {
            return appId;
        }

        public void setAppId(string appId) {
            this.appId = appId;
        }

        public string getMchId() {
            return mchId;
        }

        public void setMchId(string mchId) {
            this.mchId = mchId;
        }

        public string getSubMchid() {
            return subMchid;
        }

        public void setSubMchid(string subMchid) {
            this.subMchid = subMchid;
        }

        public string getAccountType() {
            return accountType;
        }

        public void setAccountType(string accountType) {
            this.accountType = accountType;
        }

        public string getAccountBank() {
            return accountBank;
        }

        public void setAccountBank(string accountBank) {
            this.accountBank = accountBank;
        }

        public string getBankAddressCode() {
            return bankAddressCode;
        }

        public void setBankAddressCode(string bankAddressCode) {
            this.bankAddressCode = bankAddressCode;
        }

        public string getAccountNumber() {
            return accountNumber;
        }

        public void setAccountNumber(string accountNumber) {
            this.accountNumber = accountNumber;
        }


    }
}
