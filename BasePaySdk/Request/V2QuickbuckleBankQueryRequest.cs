using System;

namespace BasePaySdk.Request
{
    /**
     * 银行列表查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleBankQueryRequest : BaseRequest
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
         * 业务类型
         */
        private string bizType;
        /**
         * 借贷类型
         */
        private string dcType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_QUICKBUCKLE_BANK_QUERY;
        }

        public V2QuickbuckleBankQueryRequest() {
        }

        public V2QuickbuckleBankQueryRequest(string reqSeqId, string reqDate, string huifuId, string bizType, string dcType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.bizType = bizType;
            this.dcType = dcType;
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

        public string getBizType() {
            return bizType;
        }

        public void setBizType(string bizType) {
            this.bizType = bizType;
        }

        public string getDcType() {
            return dcType;
        }

        public void setDcType(string dcType) {
            this.dcType = dcType;
        }


    }
}
