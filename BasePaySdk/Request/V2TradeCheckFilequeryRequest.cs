using System;

namespace BasePaySdk.Request
{
    /**
     * 交易结算对账单查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeCheckFilequeryRequest : BaseRequest
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
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 文件生成日期
         */
        private string fileDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_CHECK_FILEQUERY;
        }

        public V2TradeCheckFilequeryRequest() {
        }

        public V2TradeCheckFilequeryRequest(string reqDate, string reqSeqId, string huifuId, string fileDate) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.fileDate = fileDate;
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

        public string getFileDate() {
            return fileDate;
        }

        public void setFileDate(string fileDate) {
            this.fileDate = fileDate;
        }


    }
}
