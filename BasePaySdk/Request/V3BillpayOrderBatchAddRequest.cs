using System;

namespace BasePaySdk.Request
{
    /**
     * 创建批量账单数据
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayOrderBatchAddRequest : BaseRequest
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
         * 账单项目编号
         */
        private string projectNo;
        /**
         * 用户资料信息列表
         */
        private string userDocInfoList;
        /**
         * 账单收费项信息列表
         */
        private string paymentInfoList;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_BILLPAY_ORDER_BATCH_ADD;
        }

        public V3BillpayOrderBatchAddRequest() {
        }

        public V3BillpayOrderBatchAddRequest(string reqSeqId, string reqDate, string huifuId, string projectNo, string userDocInfoList, string paymentInfoList) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.projectNo = projectNo;
            this.userDocInfoList = userDocInfoList;
            this.paymentInfoList = paymentInfoList;
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

        public string getProjectNo() {
            return projectNo;
        }

        public void setProjectNo(string projectNo) {
            this.projectNo = projectNo;
        }

        public string getUserDocInfoList() {
            return userDocInfoList;
        }

        public void setUserDocInfoList(string userDocInfoList) {
            this.userDocInfoList = userDocInfoList;
        }

        public string getPaymentInfoList() {
            return paymentInfoList;
        }

        public void setPaymentInfoList(string paymentInfoList) {
            this.paymentInfoList = paymentInfoList;
        }


    }
}
