using System;

namespace BasePaySdk.Request
{
    /**
     * 电子发票业务开通
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoicePermissionGrantRequest : BaseRequest
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
         * 开通类型
         */
        private string status;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_PERMISSION_GRANT;
        }

        public V2InvoicePermissionGrantRequest() {
        }

        public V2InvoicePermissionGrantRequest(string reqSeqId, string reqDate, string huifuId, string status) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.status = status;
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

        public string getStatus() {
            return status;
        }

        public void setStatus(string status) {
            this.status = status;
        }


    }
}
