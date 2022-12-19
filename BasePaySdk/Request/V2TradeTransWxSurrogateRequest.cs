using System;

namespace BasePaySdk.Request
{
    /**
     * 微信代发
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeTransWxSurrogateRequest : BaseRequest
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
         * 出账商户号
         */
        private string outHuifuId;
        /**
         * 代发金额
         */
        private string transAmt;
        /**
         * 收款用户openid
         */
        private string openId;
        /**
         * 微信收款用户姓名
         */
        private string userName;
        /**
         * 代发备注
         */
        private string remark;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_TRANS_WX_SURROGATE;
        }

        public V2TradeTransWxSurrogateRequest() {
        }

        public V2TradeTransWxSurrogateRequest(string reqSeqId, string reqDate, string outHuifuId, string transAmt, string openId, string userName, string remark) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.outHuifuId = outHuifuId;
            this.transAmt = transAmt;
            this.openId = openId;
            this.userName = userName;
            this.remark = remark;
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

        public string getOutHuifuId() {
            return outHuifuId;
        }

        public void setOutHuifuId(string outHuifuId) {
            this.outHuifuId = outHuifuId;
        }

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getOpenId() {
            return openId;
        }

        public void setOpenId(string openId) {
            this.openId = openId;
        }

        public string getUserName() {
            return userName;
        }

        public void setUserName(string userName) {
            this.userName = userName;
        }

        public string getRemark() {
            return remark;
        }

        public void setRemark(string remark) {
            this.remark = remark;
        }


    }
}
