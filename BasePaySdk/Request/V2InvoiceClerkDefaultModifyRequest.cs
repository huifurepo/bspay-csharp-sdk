using System;

namespace BasePaySdk.Request
{
    /**
     * 设置默认开票员
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceClerkDefaultModifyRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 登录账号
         */
        private string loginAccount;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_CLERK_DEFAULT_MODIFY;
        }

        public V2InvoiceClerkDefaultModifyRequest() {
        }

        public V2InvoiceClerkDefaultModifyRequest(string huifuId, string reqDate, string reqSeqId, string loginAccount) {
            this.huifuId = huifuId;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.loginAccount = loginAccount;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
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

        public string getLoginAccount() {
            return loginAccount;
        }

        public void setLoginAccount(string loginAccount) {
            this.loginAccount = loginAccount;
        }


    }
}
