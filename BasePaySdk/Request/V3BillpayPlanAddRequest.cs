using System;

namespace BasePaySdk.Request
{
    /**
     * 创建账单计划
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayPlanAddRequest : BaseRequest
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
         * 账单项目编号
         */
        private string projectNo;
        /**
         * 账单周期
         */
        private string planCycle;
        /**
         * 账单日
         */
        private string billDay;
        /**
         * 补发当前周期账单标志枚举:Y-是、N-否；指定账单日时，必填；若填写是，则立即生成当前系统时间所在周期的账单； 滚动账单日时，此字段无效
         */
        private string reissueBillFlag;
        /**
         * 代扣信息jsonObject格式；账单计划需自动代扣时必填
         */
        private string withholdInfoData;
        /**
         * 用户资料信息列表
         */
        private string userDocInfoList;
        /**
         * 账单收费项信息列表
         */
        private string paymentInfoList;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_BILLPAY_PLAN_ADD;
        }

        public V3BillpayPlanAddRequest() {
        }

        public V3BillpayPlanAddRequest(string reqSeqId, string reqDate, string huifuId, string projectNo, string planCycle, string billDay, string reissueBillFlag, string withholdInfoData, string userDocInfoList, string paymentInfoList) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.projectNo = projectNo;
            this.planCycle = planCycle;
            this.billDay = billDay;
            this.reissueBillFlag = reissueBillFlag;
            this.withholdInfoData = withholdInfoData;
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

        public string getPlanCycle() {
            return planCycle;
        }

        public void setPlanCycle(string planCycle) {
            this.planCycle = planCycle;
        }

        public string getBillDay() {
            return billDay;
        }

        public void setBillDay(string billDay) {
            this.billDay = billDay;
        }

        public string getReissueBillFlag() {
            return reissueBillFlag;
        }

        public void setReissueBillFlag(string reissueBillFlag) {
            this.reissueBillFlag = reissueBillFlag;
        }

        public string getWithholdInfoData() {
            return withholdInfoData;
        }

        public void setWithholdInfoData(string withholdInfoData) {
            this.withholdInfoData = withholdInfoData;
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
