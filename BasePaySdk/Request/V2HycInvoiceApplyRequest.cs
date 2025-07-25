using System;

namespace BasePaySdk.Request
{
    /**
     * 申请开票
     *
     * @author sdk-generator
     * @Description
     */
    public class V2HycInvoiceApplyRequest : BaseRequest
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
         * 开票类目
         */
        private string invoiceCategory;
        /**
         * 汇付全局流水号集合
         */
        private string hfSeqIds;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_HYC_INVOICE_APPLY;
        }

        public V2HycInvoiceApplyRequest() {
        }

        public V2HycInvoiceApplyRequest(string reqSeqId, string reqDate, string huifuId, string invoiceCategory, string hfSeqIds) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.invoiceCategory = invoiceCategory;
            this.hfSeqIds = hfSeqIds;
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

        public string getInvoiceCategory() {
            return invoiceCategory;
        }

        public void setInvoiceCategory(string invoiceCategory) {
            this.invoiceCategory = invoiceCategory;
        }

        public string getHfSeqIds() {
            return hfSeqIds;
        }

        public void setHfSeqIds(string hfSeqIds) {
            this.hfSeqIds = hfSeqIds;
        }


    }
}
