using System;

namespace BasePaySdk.Request
{
    /**
     * 商户注册
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceMerRegRequest : BaseRequest
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
         * 开票方汇付ID
         */
        private string huifuId;
        /**
         * 纳税人识别号
         */
        private string taxPayerId;
        /**
         * 销方名称
         */
        private string taxPayerName;
        /**
         * 公司电话
         */
        private string telNo;
        /**
         * 公司地址
         */
        private string regAddress;
        /**
         * 开户银行
         */
        private string bankName;
        /**
         * 开户账户
         */
        private string accountNo;
        /**
         * 联系人手机号
         */
        private string contactPhoneNo;
        /**
         * 开票方式
         */
        private string openMode;
        /**
         * 所属省
         */
        private string provId;
        /**
         * 所属市
         */
        private string cityId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_MER_REG;
        }

        public V2InvoiceMerRegRequest() {
        }

        public V2InvoiceMerRegRequest(string reqSeqId, string reqDate, string huifuId, string taxPayerId, string taxPayerName, string telNo, string regAddress, string bankName, string accountNo, string contactPhoneNo, string openMode, string provId, string cityId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.taxPayerId = taxPayerId;
            this.taxPayerName = taxPayerName;
            this.telNo = telNo;
            this.regAddress = regAddress;
            this.bankName = bankName;
            this.accountNo = accountNo;
            this.contactPhoneNo = contactPhoneNo;
            this.openMode = openMode;
            this.provId = provId;
            this.cityId = cityId;
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

        public string getTaxPayerId() {
            return taxPayerId;
        }

        public void setTaxPayerId(string taxPayerId) {
            this.taxPayerId = taxPayerId;
        }

        public string getTaxPayerName() {
            return taxPayerName;
        }

        public void setTaxPayerName(string taxPayerName) {
            this.taxPayerName = taxPayerName;
        }

        public string getTelNo() {
            return telNo;
        }

        public void setTelNo(string telNo) {
            this.telNo = telNo;
        }

        public string getRegAddress() {
            return regAddress;
        }

        public void setRegAddress(string regAddress) {
            this.regAddress = regAddress;
        }

        public string getBankName() {
            return bankName;
        }

        public void setBankName(string bankName) {
            this.bankName = bankName;
        }

        public string getAccountNo() {
            return accountNo;
        }

        public void setAccountNo(string accountNo) {
            this.accountNo = accountNo;
        }

        public string getContactPhoneNo() {
            return contactPhoneNo;
        }

        public void setContactPhoneNo(string contactPhoneNo) {
            this.contactPhoneNo = contactPhoneNo;
        }

        public string getOpenMode() {
            return openMode;
        }

        public void setOpenMode(string openMode) {
            this.openMode = openMode;
        }

        public string getProvId() {
            return provId;
        }

        public void setProvId(string provId) {
            this.provId = provId;
        }

        public string getCityId() {
            return cityId;
        }

        public void setCityId(string cityId) {
            this.cityId = cityId;
        }


    }
}
