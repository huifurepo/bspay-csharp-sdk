using System;

namespace BasePaySdk.Request
{
    /**
     * 账单计划变更
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayPlanModifyRequest : BaseRequest
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
         * 账单计划编号
         */
        private string planNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_BILLPAY_PLAN_MODIFY;
        }

        public V3BillpayPlanModifyRequest() {
        }

        public V3BillpayPlanModifyRequest(string reqSeqId, string reqDate, string huifuId, string planNo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.planNo = planNo;
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


    }
}
