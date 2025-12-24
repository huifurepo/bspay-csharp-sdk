using System;

namespace BasePaySdk.Request
{
    /**
     * 账单退款接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayOrderPaymentRefundRequest : BaseRequest
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
        private string refAmt;
        /**
         * 大额转账支付账户信息数据jsonObject格式；银行大额转账支付交易的退款申请,付款方账户类型为对公时必填
         */
        private string bankInfoData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_BILLPAY_ORDER_PAYMENT_REFUND;
        }

        public V3BillpayOrderPaymentRefundRequest() {
        }

        public V3BillpayOrderPaymentRefundRequest(string reqSeqId, string reqDate, string huifuId, string billNo, string refAmt, string bankInfoData) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.billNo = billNo;
            this.refAmt = refAmt;
            this.bankInfoData = bankInfoData;
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

        public string getRefAmt() {
            return refAmt;
        }

        public void setRefAmt(string refAmt) {
            this.refAmt = refAmt;
        }

        public string getBankInfoData() {
            return bankInfoData;
        }

        public void setBankInfoData(string bankInfoData) {
            this.bankInfoData = bankInfoData;
        }


    }
}
