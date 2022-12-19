using System;

namespace BasePaySdk.Request
{
    /**
     * 证书登记
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectCertinfoAddRequest : BaseRequest
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
         * 渠道商汇付Id
         */
        private string upperHuifuId;
        /**
         * 开通类型
         */
        private string payWay;
        /**
         * 开发者的应用ID
         */
        private string appId;
        /**
         * 文件列表
         */
        private string fileList;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_CERTINFO_ADD;
        }

        public V2MerchantDirectCertinfoAddRequest() {
        }

        public V2MerchantDirectCertinfoAddRequest(string reqSeqId, string reqDate, string upperHuifuId, string payWay, string appId, string fileList) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.payWay = payWay;
            this.appId = appId;
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

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getPayWay() {
            return payWay;
        }

        public void setPayWay(string payWay) {
            this.payWay = payWay;
        }

        public string getAppId() {
            return appId;
        }

        public void setAppId(string appId) {
            this.appId = appId;
        }

        public string getFileList() {
            return fileList;
        }

        public void setFileList(string fileList) {
            this.fileList = fileList;
        }


    }
}
