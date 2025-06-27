using System;

namespace BasePaySdk.Request
{
    /**
     * 电子账户资金清分
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettlementClearingAddRequest : BaseRequest
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
         * 清分文件ID
         */
        private string fileId;
        /**
         * 交易日期
         */
        private string transDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_SETTLEMENT_CLEARING_ADD;
        }

        public V2TradeSettlementClearingAddRequest() {
        }

        public V2TradeSettlementClearingAddRequest(string reqDate, string reqSeqId, string fileId, string transDate) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.fileId = fileId;
            this.transDate = transDate;
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

        public string getFileId() {
            return fileId;
        }

        public void setFileId(string fileId) {
            this.fileId = fileId;
        }

        public string getTransDate() {
            return transDate;
        }

        public void setTransDate(string transDate) {
            this.transDate = transDate;
        }


    }
}
