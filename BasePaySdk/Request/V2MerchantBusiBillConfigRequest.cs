using System;

namespace BasePaySdk.Request
{
    /**
     * 交易结算对账文件配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiBillConfigRequest : BaseRequest
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
         * 汇付机构编号
         */
        private string huifuId;
        /**
         * 对账文件生成开关
         */
        private string reconSendFlag;
        /**
         * 对账单类型
         */
        private string fileType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_BILL_CONFIG;
        }

        public V2MerchantBusiBillConfigRequest() {
        }

        public V2MerchantBusiBillConfigRequest(string reqDate, string reqSeqId, string huifuId, string reconSendFlag, string fileType) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.reconSendFlag = reconSendFlag;
            this.fileType = fileType;
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

        public string getReconSendFlag() {
            return reconSendFlag;
        }

        public void setReconSendFlag(string reconSendFlag) {
            this.reconSendFlag = reconSendFlag;
        }

        public string getFileType() {
            return fileType;
        }

        public void setFileType(string fileType) {
            this.fileType = fileType;
        }


    }
}
