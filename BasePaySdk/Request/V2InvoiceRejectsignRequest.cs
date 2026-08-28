using System;

namespace BasePaySdk.Request
{
    /**
     * 电子合同拒签
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceRejectsignRequest : BaseRequest
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
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 协议编号
         */
        private string agreementId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_REJECTSIGN;
        }

        public V2InvoiceRejectsignRequest() {
        }

        public V2InvoiceRejectsignRequest(string reqDate, string reqSeqId, string huifuId, string agreementId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.agreementId = agreementId;
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

        public string getAgreementId() {
            return agreementId;
        }

        public void setAgreementId(string agreementId) {
            this.agreementId = agreementId;
        }


    }
}
