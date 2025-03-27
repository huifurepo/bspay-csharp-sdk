using System;

namespace BasePaySdk.Request
{
    /**
     * 发票邮件重发接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceResendmailRequest : BaseRequest
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
         * 发票号码
         */
        private string ivcNumber;
        /**
         * 重发邮箱地址
         */
        private string mailAddr;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_RESENDMAIL;
        }

        public V2InvoiceResendmailRequest() {
        }

        public V2InvoiceResendmailRequest(string reqSeqId, string reqDate, string huifuId, string ivcNumber, string mailAddr) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.ivcNumber = ivcNumber;
            this.mailAddr = mailAddr;
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

        public string getIvcNumber() {
            return ivcNumber;
        }

        public void setIvcNumber(string ivcNumber) {
            this.ivcNumber = ivcNumber;
        }

        public string getMailAddr() {
            return mailAddr;
        }

        public void setMailAddr(string mailAddr) {
            this.mailAddr = mailAddr;
        }


    }
}
