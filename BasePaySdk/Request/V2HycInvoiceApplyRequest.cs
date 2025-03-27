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
         * 交易流水列表
         */
        private string batchList;
        /**
         * 接收人手机号
         */
        private string receiveMobile;
        /**
         * 接收人姓名
         */
        private string receiveName;
        /**
         * 快递地址
         */
        private string courierAddress;
        /**
         * 开票类目
         */
        private string invoiceCategory;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_HYC_INVOICE_APPLY;
        }

        public V2HycInvoiceApplyRequest() {
        }

        public V2HycInvoiceApplyRequest(string reqSeqId, string reqDate, string huifuId, string batchList, string receiveMobile, string receiveName, string courierAddress, string invoiceCategory) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.batchList = batchList;
            this.receiveMobile = receiveMobile;
            this.receiveName = receiveName;
            this.courierAddress = courierAddress;
            this.invoiceCategory = invoiceCategory;
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

        public string getBatchList() {
            return batchList;
        }

        public void setBatchList(string batchList) {
            this.batchList = batchList;
        }

        public string getReceiveMobile() {
            return receiveMobile;
        }

        public void setReceiveMobile(string receiveMobile) {
            this.receiveMobile = receiveMobile;
        }

        public string getReceiveName() {
            return receiveName;
        }

        public void setReceiveName(string receiveName) {
            this.receiveName = receiveName;
        }

        public string getCourierAddress() {
            return courierAddress;
        }

        public void setCourierAddress(string courierAddress) {
            this.courierAddress = courierAddress;
        }

        public string getInvoiceCategory() {
            return invoiceCategory;
        }

        public void setInvoiceCategory(string invoiceCategory) {
            this.invoiceCategory = invoiceCategory;
        }


    }
}
