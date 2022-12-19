using System;

namespace BasePaySdk.Request
{
    /**
     * 分期证书配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2PcreditCertificateConfigRequest : BaseRequest
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
         * 开发者的应用ID
         */
        private string appId;
        /**
         * 证书文件列表
         */
        private string fileList;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_PCREDIT_CERTIFICATE_CONFIG;
        }

        public V2PcreditCertificateConfigRequest() {
        }

        public V2PcreditCertificateConfigRequest(string reqSeqId, string reqDate, string appId, string fileList) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
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
