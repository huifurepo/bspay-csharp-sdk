using System;

namespace BasePaySdk.Request
{
    /**
     * 开票类目查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2HycInvcategoryQueryRequest : BaseRequest
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
         * 落地公司机构号
         */
        private string minorAgentId;
        /**
         * 商户号lg_platform_type为HXY或空时必填
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_HYC_INVCATEGORY_QUERY;
        }

        public V2HycInvcategoryQueryRequest() {
        }

        public V2HycInvcategoryQueryRequest(string reqSeqId, string reqDate, string minorAgentId, string huifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.minorAgentId = minorAgentId;
            this.huifuId = huifuId;
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

        public string getMinorAgentId() {
            return minorAgentId;
        }

        public void setMinorAgentId(string minorAgentId) {
            this.minorAgentId = minorAgentId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }


    }
}
