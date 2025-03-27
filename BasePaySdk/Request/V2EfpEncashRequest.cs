using System;

namespace BasePaySdk.Request
{
    /**
     * 全渠道资金提现申请
     *
     * @author sdk-generator
     * @Description
     */
    public class V2EfpEncashRequest : BaseRequest
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
         * 交易金额.单位:元，2位小数
         */
        private string cashAmt;
        /**
         * 取现卡序列号
         */
        private string tokenNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_EFP_ENCASH;
        }

        public V2EfpEncashRequest() {
        }

        public V2EfpEncashRequest(string reqSeqId, string reqDate, string huifuId, string cashAmt, string tokenNo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.cashAmt = cashAmt;
            this.tokenNo = tokenNo;
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

        public string getCashAmt() {
            return cashAmt;
        }

        public void setCashAmt(string cashAmt) {
            this.cashAmt = cashAmt;
        }

        public string getTokenNo() {
            return tokenNo;
        }

        public void setTokenNo(string tokenNo) {
            this.tokenNo = tokenNo;
        }


    }
}
