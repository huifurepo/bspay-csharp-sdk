using System;

namespace BasePaySdk.Request
{
    /**
     * 开票员删除
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceClerkDeleteRequest : BaseRequest
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
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 登录账号
         */
        private string loginAccount;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_CLERK_DELETE;
        }

        public V2InvoiceClerkDeleteRequest() {
        }

        public V2InvoiceClerkDeleteRequest(string reqSeqId, string reqDate, string huifuId, string loginAccount) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.loginAccount = loginAccount;
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

        public string getLoginAccount() {
            return loginAccount;
        }

        public void setLoginAccount(string loginAccount) {
            this.loginAccount = loginAccount;
        }


    }
}
