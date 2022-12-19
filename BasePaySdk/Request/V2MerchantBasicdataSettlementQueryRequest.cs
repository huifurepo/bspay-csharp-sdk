using System;

namespace BasePaySdk.Request
{
    /**
     * 结算记录查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBasicdataSettlementQueryRequest : BaseRequest
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
         * 结算开始日期
         */
        private string beginDate;
        /**
         * 结算结束日期
         */
        private string endDate;
        /**
         * 分页条数
         */
        private string pageSize;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BASICDATA_SETTLEMENT_QUERY;
        }

        public V2MerchantBasicdataSettlementQueryRequest() {
        }

        public V2MerchantBasicdataSettlementQueryRequest(string reqSeqId, string reqDate, string huifuId, string beginDate, string endDate, string pageSize) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.beginDate = beginDate;
            this.endDate = endDate;
            this.pageSize = pageSize;
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

        public string getPageSize() {
            return pageSize;
        }

        public void setPageSize(string pageSize) {
            this.pageSize = pageSize;
        }


    }
}
