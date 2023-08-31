using System;

namespace BasePaySdk.Request
{
    /**
     * 登记扣款信息
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscoreDeductRegitsterRequest : BaseRequest
    {

        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 商户申请单号
         */
        private string reqSeqId;
        /**
         * 汇付商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYSCORE_DEDUCT_REGITSTER;
        }

        public V2TradePayscoreDeductRegitsterRequest() {
        }

        public V2TradePayscoreDeductRegitsterRequest(string reqDate, string reqSeqId, string huifuId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
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


    }
}
