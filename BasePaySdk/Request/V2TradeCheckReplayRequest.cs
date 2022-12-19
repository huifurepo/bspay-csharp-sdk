using System;

namespace BasePaySdk.Request
{
    /**
     * 交易结算对账文件重新生成
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeCheckReplayRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 交易日期
         */
        private string reqDate;
        /**
         * 汇付机构编号
         */
        private string huifuId;
        /**
         * 文件类型
         */
        private string fileType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_CHECK_REPLAY;
        }

        public V2TradeCheckReplayRequest() {
        }

        public V2TradeCheckReplayRequest(string reqSeqId, string reqDate, string huifuId, string fileType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.fileType = fileType;
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

        public string getFileType() {
            return fileType;
        }

        public void setFileType(string fileType) {
            this.fileType = fileType;
        }


    }
}
