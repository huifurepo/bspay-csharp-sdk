using System;

namespace BasePaySdk.Request
{
    /**
     * 创建支付分订单
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscoreServiceorderCreateRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 商户申请单号
         */
        private string reqSeqId;
        /**
         * 服务信息
         */
        private string serviceIntroduction;
        /**
         * 服务风险金
         */
        private string riskFund;
        /**
         * 服务时间
         */
        private string timeRange;
        /**
         * 商户回调地址
         */
        private string notifyUrl;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYSCORE_SERVICEORDER_CREATE;
        }

        public V2TradePayscoreServiceorderCreateRequest() {
        }

        public V2TradePayscoreServiceorderCreateRequest(string huifuId, string reqDate, string reqSeqId, string serviceIntroduction, string riskFund, string timeRange, string notifyUrl) {
            this.huifuId = huifuId;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.serviceIntroduction = serviceIntroduction;
            this.riskFund = riskFund;
            this.timeRange = timeRange;
            this.notifyUrl = notifyUrl;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
        }

        public string getServiceIntroduction() {
            return serviceIntroduction;
        }

        public void setServiceIntroduction(string serviceIntroduction) {
            this.serviceIntroduction = serviceIntroduction;
        }

        public string getRiskFund() {
            return riskFund;
        }

        public void setRiskFund(string riskFund) {
            this.riskFund = riskFund;
        }

        public string getTimeRange() {
            return timeRange;
        }

        public void setTimeRange(string timeRange) {
            this.timeRange = timeRange;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }


    }
}
