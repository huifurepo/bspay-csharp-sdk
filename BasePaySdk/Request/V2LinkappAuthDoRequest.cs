using System;

namespace BasePaySdk.Request
{
    /**
     * 商户公域授权
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LinkappAuthDoRequest : BaseRequest
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
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 平台类型
         */
        private string platformType;
        /**
         * 协议地址
         */
        private string contractUrl;
        /**
         * 签约商户名称
         */
        private string contractMerName;
        /**
         * 签约时间
         */
        private string contractTime;
        /**
         * 登录用手机号第一次登录有需要手机验证码的情况;（需要授权手机安装一个转发短信的应用）
         */
        private string phoneNumber;
        /**
         * 商户类型商户类型：0个人店 1企业 2个体工商户 3其他(目前固定填3即可)
         */
        private string merchantType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_LINKAPP_AUTH_DO;
        }

        public V2LinkappAuthDoRequest() {
        }

        public V2LinkappAuthDoRequest(string reqSeqId, string reqDate, string huifuId, string platformType, string contractUrl, string contractMerName, string contractTime, string phoneNumber, string merchantType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.platformType = platformType;
            this.contractUrl = contractUrl;
            this.contractMerName = contractMerName;
            this.contractTime = contractTime;
            this.phoneNumber = phoneNumber;
            this.merchantType = merchantType;
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

        public string getPlatformType() {
            return platformType;
        }

        public void setPlatformType(string platformType) {
            this.platformType = platformType;
        }

        public string getContractUrl() {
            return contractUrl;
        }

        public void setContractUrl(string contractUrl) {
            this.contractUrl = contractUrl;
        }

        public string getContractMerName() {
            return contractMerName;
        }

        public void setContractMerName(string contractMerName) {
            this.contractMerName = contractMerName;
        }

        public string getContractTime() {
            return contractTime;
        }

        public void setContractTime(string contractTime) {
            this.contractTime = contractTime;
        }

        public string getPhoneNumber() {
            return phoneNumber;
        }

        public void setPhoneNumber(string phoneNumber) {
            this.phoneNumber = phoneNumber;
        }

        public string getMerchantType() {
            return merchantType;
        }

        public void setMerchantType(string merchantType) {
            this.merchantType = merchantType;
        }


    }
}
