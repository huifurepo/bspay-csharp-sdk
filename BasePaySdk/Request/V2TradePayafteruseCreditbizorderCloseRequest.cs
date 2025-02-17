using System;

namespace BasePaySdk.Request
{
    /**
     * 服务单关闭
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayafteruseCreditbizorderCloseRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYAFTERUSE_CREDITBIZORDER_CLOSE;
        }

        public V2TradePayafteruseCreditbizorderCloseRequest() {
        }

        public V2TradePayafteruseCreditbizorderCloseRequest(string reqSeqId, string reqDate, string huifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
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


    }
}
