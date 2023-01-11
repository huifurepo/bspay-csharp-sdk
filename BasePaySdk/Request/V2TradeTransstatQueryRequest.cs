using System;

namespace BasePaySdk.Request
{
    /**
     * 批量交易状态查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeTransstatQueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 页码
         */
        private string pageNo;
        /**
         * 页大小
         */
        private string pageSize;
        /**
         * 请求日期
         */
        private string reqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_TRANSSTAT_QUERY;
        }

        public V2TradeTransstatQueryRequest() {
        }

        public V2TradeTransstatQueryRequest(string huifuId, string pageNo, string pageSize, string reqDate) {
            this.huifuId = huifuId;
            this.pageNo = pageNo;
            this.pageSize = pageSize;
            this.reqDate = reqDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getPageNo() {
            return pageNo;
        }

        public void setPageNo(string pageNo) {
            this.pageNo = pageNo;
        }

        public string getPageSize() {
            return pageSize;
        }

        public void setPageSize(string pageSize) {
            this.pageSize = pageSize;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
        }


    }
}
