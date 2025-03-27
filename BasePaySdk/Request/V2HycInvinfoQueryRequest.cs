using System;

namespace BasePaySdk.Request
{
    /**
     * 开票信息查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2HycInvinfoQueryRequest : BaseRequest
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
         * 开票批次号
         */
        private string invoiceBatch;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_HYC_INVINFO_QUERY;
        }

        public V2HycInvinfoQueryRequest() {
        }

        public V2HycInvinfoQueryRequest(string reqSeqId, string reqDate, string huifuId, string invoiceBatch) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.invoiceBatch = invoiceBatch;
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

        public string getInvoiceBatch() {
            return invoiceBatch;
        }

        public void setInvoiceBatch(string invoiceBatch) {
            this.invoiceBatch = invoiceBatch;
        }


    }
}
