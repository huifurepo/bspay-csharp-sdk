using System;

namespace BasePaySdk.Request
{
    /**
     * 删除付款人
     *
     * @author sdk-generator
     * @Description
     */
    public class V2BillEntPayerDeleteRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求时间
         */
        private string reqDate;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 付款人
         */
        private string payerId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_BILL_ENT_PAYER_DELETE;
        }

        public V2BillEntPayerDeleteRequest() {
        }

        public V2BillEntPayerDeleteRequest(string reqSeqId, string reqDate, string huifuId, string payerId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.payerId = payerId;
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

        public string getPayerId() {
            return payerId;
        }

        public void setPayerId(string payerId) {
            this.payerId = payerId;
        }


    }
}
