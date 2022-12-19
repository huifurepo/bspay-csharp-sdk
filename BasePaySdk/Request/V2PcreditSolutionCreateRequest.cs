using System;

namespace BasePaySdk.Request
{
    /**
     * 创建花呗分期方案
     *
     * @author sdk-generator
     * @Description
     */
    public class V2PcreditSolutionCreateRequest : BaseRequest
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
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 花呗分期商家贴息活动名称
         */
        private string activityName;
        /**
         * 活动开始时间
         */
        private string startTime;
        /**
         * 活动结束时间
         */
        private string endTime;
        /**
         * 免息金额下限(元)
         */
        private string minMoneyLimit;
        /**
         * 免息金额上限(元)
         */
        private string maxMoneyLimit;
        /**
         * 花呗分期贴息预算金额
         */
        private string amountBudget;
        /**
         * 花呗分期数集合
         */
        private string installNumStrList;
        /**
         * 预算提醒金额(元)
         */
        private string budgetWarningMoney;
        /**
         * 预算提醒邮件列表
         */
        private string budgetWarningMailList;
        /**
         * 预算提醒手机号列表
         */
        private string budgetWarningMobileNoList;
        /**
         * 子门店信息集合
         */
        private string subShopInfoList;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_PCREDIT_SOLUTION_CREATE;
        }

        public V2PcreditSolutionCreateRequest() {
        }

        public V2PcreditSolutionCreateRequest(string reqSeqId, string reqDate, string huifuId, string activityName, string startTime, string endTime, string minMoneyLimit, string maxMoneyLimit, string amountBudget, string installNumStrList, string budgetWarningMoney, string budgetWarningMailList, string budgetWarningMobileNoList, string subShopInfoList) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.activityName = activityName;
            this.startTime = startTime;
            this.endTime = endTime;
            this.minMoneyLimit = minMoneyLimit;
            this.maxMoneyLimit = maxMoneyLimit;
            this.amountBudget = amountBudget;
            this.installNumStrList = installNumStrList;
            this.budgetWarningMoney = budgetWarningMoney;
            this.budgetWarningMailList = budgetWarningMailList;
            this.budgetWarningMobileNoList = budgetWarningMobileNoList;
            this.subShopInfoList = subShopInfoList;
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

        public string getActivityName() {
            return activityName;
        }

        public void setActivityName(string activityName) {
            this.activityName = activityName;
        }

        public string getStartTime() {
            return startTime;
        }

        public void setStartTime(string startTime) {
            this.startTime = startTime;
        }

        public string getEndTime() {
            return endTime;
        }

        public void setEndTime(string endTime) {
            this.endTime = endTime;
        }

        public string getMinMoneyLimit() {
            return minMoneyLimit;
        }

        public void setMinMoneyLimit(string minMoneyLimit) {
            this.minMoneyLimit = minMoneyLimit;
        }

        public string getMaxMoneyLimit() {
            return maxMoneyLimit;
        }

        public void setMaxMoneyLimit(string maxMoneyLimit) {
            this.maxMoneyLimit = maxMoneyLimit;
        }

        public string getAmountBudget() {
            return amountBudget;
        }

        public void setAmountBudget(string amountBudget) {
            this.amountBudget = amountBudget;
        }

        public string getInstallNumStrList() {
            return installNumStrList;
        }

        public void setInstallNumStrList(string installNumStrList) {
            this.installNumStrList = installNumStrList;
        }

        public string getBudgetWarningMoney() {
            return budgetWarningMoney;
        }

        public void setBudgetWarningMoney(string budgetWarningMoney) {
            this.budgetWarningMoney = budgetWarningMoney;
        }

        public string getBudgetWarningMailList() {
            return budgetWarningMailList;
        }

        public void setBudgetWarningMailList(string budgetWarningMailList) {
            this.budgetWarningMailList = budgetWarningMailList;
        }

        public string getBudgetWarningMobileNoList() {
            return budgetWarningMobileNoList;
        }

        public void setBudgetWarningMobileNoList(string budgetWarningMobileNoList) {
            this.budgetWarningMobileNoList = budgetWarningMobileNoList;
        }

        public string getSubShopInfoList() {
            return subShopInfoList;
        }

        public void setSubShopInfoList(string subShopInfoList) {
            this.subShopInfoList = subShopInfoList;
        }


    }
}
