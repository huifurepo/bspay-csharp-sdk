using System;

namespace BasePaySdk.Request
{
    /**
     * 灵工微信代发
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeLgwxSurrogateRequest : BaseRequest
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
         * 出款方商户号
         */
        private string huifuId;
        /**
         * 支付金额(元)
         */
        private string cashAmt;
        /**
         * 代发模式
         */
        private string salaryModleType;
        /**
         * 落地公司商户号
         */
        private string bmemberId;
        /**
         * 子商户应用ID
         */
        private string subAppid;
        /**
         * 异步通知地址
         */
        private string notifyUrl;
        /**
         * 分账明细
         */
        private string acctSplitBunch;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_LGWX_SURROGATE;
        }

        public V2TradeLgwxSurrogateRequest() {
        }

        public V2TradeLgwxSurrogateRequest(string reqDate, string reqSeqId, string huifuId, string cashAmt, string salaryModleType, string bmemberId, string subAppid, string notifyUrl, string acctSplitBunch) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.cashAmt = cashAmt;
            this.salaryModleType = salaryModleType;
            this.bmemberId = bmemberId;
            this.subAppid = subAppid;
            this.notifyUrl = notifyUrl;
            this.acctSplitBunch = acctSplitBunch;
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

        public string getCashAmt() {
            return cashAmt;
        }

        public void setCashAmt(string cashAmt) {
            this.cashAmt = cashAmt;
        }

        public string getSalaryModleType() {
            return salaryModleType;
        }

        public void setSalaryModleType(string salaryModleType) {
            this.salaryModleType = salaryModleType;
        }

        public string getBmemberId() {
            return bmemberId;
        }

        public void setBmemberId(string bmemberId) {
            this.bmemberId = bmemberId;
        }

        public string getSubAppid() {
            return subAppid;
        }

        public void setSubAppid(string subAppid) {
            this.subAppid = subAppid;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }

        public string getAcctSplitBunch() {
            return acctSplitBunch;
        }

        public void setAcctSplitBunch(string acctSplitBunch) {
            this.acctSplitBunch = acctSplitBunch;
        }


    }
}
