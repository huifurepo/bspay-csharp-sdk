using System;

namespace BasePaySdk.Request
{
    /**
     * 支付宝直连-申请当面付代签约
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectAlipayFacetofacesignApplyRequest : BaseRequest
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
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 上级主体ID
         */
        private string upperHuifuId;
        /**
         * 支付宝经营类目
         */
        private string directCategory;
        /**
         * 开发者的应用ID
         */
        private string appId;
        /**
         * 联系人姓名
         */
        private string contactName;
        /**
         * 联系人手机号
         */
        private string contactMobileNo;
        /**
         * 联系人电子邮箱
         */
        private string contactEmail;
        /**
         * 商户账号
         */
        private string account;
        /**
         * 服务费率（%）0.38~3之间，精确到0.01。当签约且授权sign_and_auth&#x3D;Y时，必填。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.38&lt;/font&gt;
         */
        private string rate;
        /**
         * 文件列表
         */
        private string fileList;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_ALIPAY_FACETOFACESIGN_APPLY;
        }

        public V2MerchantDirectAlipayFacetofacesignApplyRequest() {
        }

        public V2MerchantDirectAlipayFacetofacesignApplyRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string directCategory, string appId, string contactName, string contactMobileNo, string contactEmail, string account, string rate, string fileList) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.directCategory = directCategory;
            this.appId = appId;
            this.contactName = contactName;
            this.contactMobileNo = contactMobileNo;
            this.contactEmail = contactEmail;
            this.account = account;
            this.rate = rate;
            this.fileList = fileList;
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

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getDirectCategory() {
            return directCategory;
        }

        public void setDirectCategory(string directCategory) {
            this.directCategory = directCategory;
        }

        public string getAppId() {
            return appId;
        }

        public void setAppId(string appId) {
            this.appId = appId;
        }

        public string getContactName() {
            return contactName;
        }

        public void setContactName(string contactName) {
            this.contactName = contactName;
        }

        public string getContactMobileNo() {
            return contactMobileNo;
        }

        public void setContactMobileNo(string contactMobileNo) {
            this.contactMobileNo = contactMobileNo;
        }

        public string getContactEmail() {
            return contactEmail;
        }

        public void setContactEmail(string contactEmail) {
            this.contactEmail = contactEmail;
        }

        public string getAccount() {
            return account;
        }

        public void setAccount(string account) {
            this.account = account;
        }

        public string getRate() {
            return rate;
        }

        public void setRate(string rate) {
            this.rate = rate;
        }

        public string getFileList() {
            return fileList;
        }

        public void setFileList(string fileList) {
            this.fileList = fileList;
        }


    }
}
