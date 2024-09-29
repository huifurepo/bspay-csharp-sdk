using System;

namespace BasePaySdk.Request
{
    /**
     * 新建付款人
     *
     * @author sdk-generator
     * @Description
     */
    public class V2BillEntPayerCreateRequest : BaseRequest
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
         * 付款人名称
         */
        private string payerName;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_BILL_ENT_PAYER_CREATE;
        }

        public V2BillEntPayerCreateRequest() {
        }

        public V2BillEntPayerCreateRequest(string reqSeqId, string reqDate, string huifuId, string payerName) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.payerName = payerName;
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

        public string getPayerName() {
            return payerName;
        }

        public void setPayerName(string payerName) {
            this.payerName = payerName;
        }


    }
}
