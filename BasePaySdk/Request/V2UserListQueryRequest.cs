using System;

namespace BasePaySdk.Request
{
    /**
     * 用户列表查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserListQueryRequest : BaseRequest
    {

        /**
         * 法人证件号
         */
        private string legalCertNo;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_USER_LIST_QUERY;
        }

        public V2UserListQueryRequest() {
        }

        public V2UserListQueryRequest(string legalCertNo, string reqDate, string reqSeqId) {
            this.legalCertNo = legalCertNo;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
        }

        public string getLegalCertNo() {
            return legalCertNo;
        }

        public void setLegalCertNo(string legalCertNo) {
            this.legalCertNo = legalCertNo;
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


    }
}
