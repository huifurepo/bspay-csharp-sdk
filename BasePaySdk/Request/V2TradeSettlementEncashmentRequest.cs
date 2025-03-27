using System;

namespace BasePaySdk.Request
{
    /**
     * 取现
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettlementEncashmentRequest : BaseRequest
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
         * 取现金额
         */
        private string cashAmt;
        /**
         * 取现方ID号
         */
        private string huifuId;
        /**
         * 到账日期类型
         */
        private string intoAcctDateType;
        /**
         * 取现卡序列号
         */
        private string tokenNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_SETTLEMENT_ENCASHMENT;
        }

        public V2TradeSettlementEncashmentRequest() {
        }

        public V2TradeSettlementEncashmentRequest(string reqDate, string reqSeqId, string cashAmt, string huifuId, string intoAcctDateType, string tokenNo) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.cashAmt = cashAmt;
            this.huifuId = huifuId;
            this.intoAcctDateType = intoAcctDateType;
            this.tokenNo = tokenNo;
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

        public string getCashAmt() {
            return cashAmt;
        }

        public void setCashAmt(string cashAmt) {
            this.cashAmt = cashAmt;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getIntoAcctDateType() {
            return intoAcctDateType;
        }

        public void setIntoAcctDateType(string intoAcctDateType) {
            this.intoAcctDateType = intoAcctDateType;
        }

        public string getTokenNo() {
            return tokenNo;
        }

        public void setTokenNo(string tokenNo) {
            this.tokenNo = tokenNo;
        }


    }
}
