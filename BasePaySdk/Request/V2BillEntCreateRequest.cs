using System;

namespace BasePaySdk.Request
{
    /**
     * 创建企业账单
     *
     * @author sdk-generator
     * @Description
     */
    public class V2BillEntCreateRequest : BaseRequest
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
        /**
         * 账单名称
         */
        private string billName;
        /**
         * 账单金额
         */
        private string billAmt;
        /**
         * 可支持的付款方式
         */
        private string supportPayType;
        /**
         * 账单截止日期
         */
        private string billEndDate;
        /**
         * 收款人信息
         */
        private string payeeInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_BILL_ENT_CREATE;
        }

        public V2BillEntCreateRequest() {
        }

        public V2BillEntCreateRequest(string reqSeqId, string reqDate, string huifuId, string payerId, string billName, string billAmt, string supportPayType, string billEndDate, string payeeInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.payerId = payerId;
            this.billName = billName;
            this.billAmt = billAmt;
            this.supportPayType = supportPayType;
            this.billEndDate = billEndDate;
            this.payeeInfo = payeeInfo;
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

        public string getBillName() {
            return billName;
        }

        public void setBillName(string billName) {
            this.billName = billName;
        }

        public string getBillAmt() {
            return billAmt;
        }

        public void setBillAmt(string billAmt) {
            this.billAmt = billAmt;
        }

        public string getSupportPayType() {
            return supportPayType;
        }

        public void setSupportPayType(string supportPayType) {
            this.supportPayType = supportPayType;
        }

        public string getBillEndDate() {
            return billEndDate;
        }

        public void setBillEndDate(string billEndDate) {
            this.billEndDate = billEndDate;
        }

        public string getPayeeInfo() {
            return payeeInfo;
        }

        public void setPayeeInfo(string payeeInfo) {
            this.payeeInfo = payeeInfo;
        }


    }
}
