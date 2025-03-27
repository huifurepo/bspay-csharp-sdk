using System;

namespace BasePaySdk.Request
{
    /**
     * 红字发票开具接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceRedopenRequest : BaseRequest
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
         * 原发票号码
         */
        private string oriIvcNumber;
        /**
         * 红冲原因
         */
        private string redApplyReason;
        /**
         * 红冲申请来源
         */
        private string redApplySource;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_REDOPEN;
        }

        public V2InvoiceRedopenRequest() {
        }

        public V2InvoiceRedopenRequest(string reqSeqId, string reqDate, string huifuId, string oriIvcNumber, string redApplyReason, string redApplySource) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.oriIvcNumber = oriIvcNumber;
            this.redApplyReason = redApplyReason;
            this.redApplySource = redApplySource;
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

        public string getOriIvcNumber() {
            return oriIvcNumber;
        }

        public void setOriIvcNumber(string oriIvcNumber) {
            this.oriIvcNumber = oriIvcNumber;
        }

        public string getRedApplyReason() {
            return redApplyReason;
        }

        public void setRedApplyReason(string redApplyReason) {
            this.redApplyReason = redApplyReason;
        }

        public string getRedApplySource() {
            return redApplySource;
        }

        public void setRedApplySource(string redApplySource) {
            this.redApplySource = redApplySource;
        }


    }
}
