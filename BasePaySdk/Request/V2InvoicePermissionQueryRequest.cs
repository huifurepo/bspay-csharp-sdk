using System;

namespace BasePaySdk.Request
{
    /**
     * 电子发票业务开通查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoicePermissionQueryRequest : BaseRequest
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
         * 商户汇付Id
         */
        private string huifuId;
        /**
         * 是否包含下级
         */
        private string includeSubFlag;
        /**
         * 当前页
         */
        private string pageNum;
        /**
         * 分页大小
         */
        private string pageSize;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_PERMISSION_QUERY;
        }

        public V2InvoicePermissionQueryRequest() {
        }

        public V2InvoicePermissionQueryRequest(string reqSeqId, string reqDate, string huifuId, string includeSubFlag, string pageNum, string pageSize) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.includeSubFlag = includeSubFlag;
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

        public string getIncludeSubFlag() {
            return includeSubFlag;
        }

        public void setIncludeSubFlag(string includeSubFlag) {
            this.includeSubFlag = includeSubFlag;
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
