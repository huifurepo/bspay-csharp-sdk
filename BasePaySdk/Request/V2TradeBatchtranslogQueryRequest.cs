using System;

namespace BasePaySdk.Request
{
    /**
     * 批量出金交易查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeBatchtranslogQueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 开始日期
         */
        private string beginDate;
        /**
         * 结束日期
         */
        private string endDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_BATCHTRANSLOG_QUERY;
        }

        public V2TradeBatchtranslogQueryRequest() {
        }

        public V2TradeBatchtranslogQueryRequest(string huifuId, string beginDate, string endDate) {
            this.huifuId = huifuId;
            this.beginDate = beginDate;
            this.endDate = endDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getBeginDate() {
            return beginDate;
        }

        public void setBeginDate(string beginDate) {
            this.beginDate = beginDate;
        }

        public string getEndDate() {
            return endDate;
        }

        public void setEndDate(string endDate) {
            this.endDate = endDate;
        }


    }
}
