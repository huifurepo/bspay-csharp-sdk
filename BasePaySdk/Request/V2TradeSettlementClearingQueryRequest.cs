using System;

namespace BasePaySdk.Request
{
    /**
     * 电子账户资金清分结果查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettlementClearingQueryRequest : BaseRequest
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

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_SETTLEMENT_CLEARING_QUERY;
        }

        public V2TradeSettlementClearingQueryRequest() {
        }

        public V2TradeSettlementClearingQueryRequest(string reqDate, string reqSeqId, string fileId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.fileId = fileId;
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


    }
}
