using System;

namespace BasePaySdk.Request
{
    /**
     * 完税凭证查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2HycTaxQueryRequest : BaseRequest
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
         * 商户汇付id
         */
        private string huifuId;
        /**
         * 开始时间
         */
        private string startDate;
        /**
         * 结束时间
         */
        private string endDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_HYC_TAX_QUERY;
        }

        public V2HycTaxQueryRequest() {
        }

        public V2HycTaxQueryRequest(string reqSeqId, string reqDate, string huifuId, string startDate, string endDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.startDate = startDate;
            this.endDate = endDate;
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

        public string getStartDate() {
            return startDate;
        }

        public void setStartDate(string startDate) {
            this.startDate = startDate;
        }

        public string getEndDate() {
            return endDate;
        }

        public void setEndDate(string endDate) {
            this.endDate = endDate;
        }


    }
}
