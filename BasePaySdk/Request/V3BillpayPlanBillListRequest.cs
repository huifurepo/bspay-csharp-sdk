using System;

namespace BasePaySdk.Request
{
    /**
     * 查询账单计划下已生成账单数据
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayPlanBillListRequest : BaseRequest
    {

        /**
         * 客户请求流水号
         */
        private string reqSeqId;
        /**
         * 客户请求日期
         */
        private string reqDate;
        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 账单计划编号
         */
        private string planNo;
        /**
         * 页码
         */
        private string pageNum;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_BILLPAY_PLAN_BILL_LIST;
        }

        public V3BillpayPlanBillListRequest() {
        }

        public V3BillpayPlanBillListRequest(string reqSeqId, string reqDate, string huifuId, string planNo, string pageNum) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.planNo = planNo;
            this.pageNum = pageNum;
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

        public string getPlanNo() {
            return planNo;
        }

        public void setPlanNo(string planNo) {
            this.planNo = planNo;
        }

        public string getPageNum() {
            return pageNum;
        }

        public void setPageNum(string pageNum) {
            this.pageNum = pageNum;
        }


    }
}
