using System;

namespace BasePaySdk.Request
{
    /**
     * 企业账单退款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2BillEntRefundRequest : BaseRequest
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
         * 账单编号
         */
        private string billNo;
        /**
         * 退款金额
         */
        private string refundAmt;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_BILL_ENT_REFUND;
        }

        public V2BillEntRefundRequest() {
        }

        public V2BillEntRefundRequest(string reqSeqId, string reqDate, string huifuId, string billNo, string refundAmt) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.billNo = billNo;
            this.refundAmt = refundAmt;
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

        public string getBillNo() {
            return billNo;
        }

        public void setBillNo(string billNo) {
            this.billNo = billNo;
        }

        public string getRefundAmt() {
            return refundAmt;
        }

        public void setRefundAmt(string refundAmt) {
            this.refundAmt = refundAmt;
        }


    }
}
