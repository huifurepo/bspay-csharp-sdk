using System;

namespace BasePaySdk.Request
{
    /**
     * 银行大额支付解绑
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LargeamtBindcardUnbindRequest : BaseRequest
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
        /**
         * 银行卡号密文
         */
        private string cardNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_LARGEAMT_BINDCARD_UNBIND;
        }

        public V2LargeamtBindcardUnbindRequest() {
        }

        public V2LargeamtBindcardUnbindRequest(string reqSeqId, string reqDate, string huifuId, string cardNo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.cardNo = cardNo;
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

        public string getCardNo() {
            return cardNo;
        }

        public void setCardNo(string cardNo) {
            this.cardNo = cardNo;
        }


    }
}
