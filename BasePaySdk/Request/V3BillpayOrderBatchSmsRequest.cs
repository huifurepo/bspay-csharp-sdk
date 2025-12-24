using System;

namespace BasePaySdk.Request
{
    /**
     * 账单数据短信通知
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayOrderBatchSmsRequest : BaseRequest
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

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_BILLPAY_ORDER_BATCH_SMS;
        }

        public V3BillpayOrderBatchSmsRequest() {
        }

        public V3BillpayOrderBatchSmsRequest(string reqSeqId, string reqDate, string huifuId, string billNo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.billNo = billNo;
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


    }
}
