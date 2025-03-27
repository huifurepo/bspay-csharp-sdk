using System;

namespace BasePaySdk.Request
{
    /**
     * 完税凭证下载
     *
     * @author sdk-generator
     * @Description
     */
    public class V2HycTaxDownloadRequest : BaseRequest
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
         * 商户汇付id
         */
        private string huifuId;
        /**
         * 附件编号
         */
        private string taxId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_HYC_TAX_DOWNLOAD;
        }

        public V2HycTaxDownloadRequest() {
        }

        public V2HycTaxDownloadRequest(string reqSeqId, string reqDate, string huifuId, string taxId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.taxId = taxId;
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

        public string getTaxId() {
            return taxId;
        }

        public void setTaxId(string taxId) {
            this.taxId = taxId;
        }


    }
}
