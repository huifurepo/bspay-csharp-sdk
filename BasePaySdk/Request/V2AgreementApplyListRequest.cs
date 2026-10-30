using System;

namespace BasePaySdk.Request
{
    /**
     * 协议申请列表查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2AgreementApplyListRequest : BaseRequest
    {

        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 协议类型
         */
        private string agreementType;
        /**
         * 当前页
         */
        private string pageNum;
        /**
         * 分页大小
         */
        private string pageSize;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_AGREEMENT_APPLY_LIST;
        }

        public V2AgreementApplyListRequest() {
        }

        public V2AgreementApplyListRequest(string reqDate, string reqSeqId, string huifuId, string agreementType, string pageNum, string pageSize) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.agreementType = agreementType;
            this.pageNum = pageNum;
            this.pageSize = pageSize;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getAgreementType() {
            return agreementType;
        }

        public void setAgreementType(string agreementType) {
            this.agreementType = agreementType;
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
