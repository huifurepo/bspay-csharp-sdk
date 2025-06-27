using System;

namespace BasePaySdk.Request
{
    /**
     * 全渠道订单分账查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2OcoOrderListRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求时间
         */
        private string reqDate;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 分账数据源
         */
        private string busiSource;
        /**
         * 交易时间
         */
        private string transDate;
        /**
         * 页码
         */
        private string pageNum;
        /**
         * 每页大小
         */
        private string pageSize;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_OCO_ORDER_LIST;
        }

        public V2OcoOrderListRequest() {
        }

        public V2OcoOrderListRequest(string reqSeqId, string reqDate, string huifuId, string busiSource, string transDate, string pageNum, string pageSize) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.busiSource = busiSource;
            this.transDate = transDate;
            this.pageNum = pageNum;
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

        public string getBusiSource() {
            return busiSource;
        }

        public void setBusiSource(string busiSource) {
            this.busiSource = busiSource;
        }

        public string getTransDate() {
            return transDate;
        }

        public void setTransDate(string transDate) {
            this.transDate = transDate;
        }

        public string getPageNum() {
            return pageNum;
        }

        public void setPageNum(string pageNum) {
            this.pageNum = pageNum;
        }

        public string getPageSize() {
            return pageSize;
        }

        public void setPageSize(string pageSize) {
            this.pageSize = pageSize;
        }


    }
}
