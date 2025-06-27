using System;

namespace BasePaySdk.Request
{
    /**
     * 全渠道资金付款提现记录查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2EfpWithdrawQueryRequest : BaseRequest
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
         * 付款或提现的请求流水号
         */
        private string orgReqSeqId;
        /**
         * 付款或提现的请求日期
         */
        private string orgReqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_EFP_WITHDRAW_QUERY;
        }

        public V2EfpWithdrawQueryRequest() {
        }

        public V2EfpWithdrawQueryRequest(string reqSeqId, string reqDate, string huifuId, string orgReqSeqId, string orgReqDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.orgReqSeqId = orgReqSeqId;
            this.orgReqDate = orgReqDate;
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

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }


    }
}
