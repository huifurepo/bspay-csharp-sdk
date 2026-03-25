using System;

namespace BasePaySdk.Request
{
    /**
     * 查询账单计划详情
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayPlanDetailRequest : BaseRequest
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
         * 账单计划编号与原请求流水号编号二选一必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：BP202412270001&lt;/font&gt;
         */
        private string planNo;
        /**
         * 原请求流水号原请求流水号，同一商户号当天唯一；与账单计划编号二选一必填
         */
        private string orgReqSeqId;
        /**
         * 原请求日期原请求日期格式：yyyyMMdd，以北京时间为准；与账单编号二选一必填
         */
        private string orgReqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_BILLPAY_PLAN_DETAIL;
        }

        public V3BillpayPlanDetailRequest() {
        }

        public V3BillpayPlanDetailRequest(string reqSeqId, string reqDate, string huifuId, string planNo, string orgReqSeqId, string orgReqDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.planNo = planNo;
            this.orgReqSeqId = orgReqSeqId;
            this.orgReqDate = orgReqDate;
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

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }


    }
}
