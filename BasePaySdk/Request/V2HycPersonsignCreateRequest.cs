using System;

namespace BasePaySdk.Request
{
    /**
     * 个人签约发起
     *
     * @author sdk-generator
     * @Description
     */
    public class V2HycPersonsignCreateRequest : BaseRequest
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
         * 用户汇付id
         */
        private string huifuId;
        /**
         * 落地公司机构号
         */
        private string minorAgentId;
        /**
         * 乐接活请求参数jsonObject格式 合作平台为乐接活时必传
         */
        private string ljhData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_HYC_PERSONSIGN_CREATE;
        }

        public V2HycPersonsignCreateRequest() {
        }

        public V2HycPersonsignCreateRequest(string reqSeqId, string reqDate, string huifuId, string minorAgentId, string ljhData) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.minorAgentId = minorAgentId;
            this.ljhData = ljhData;
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

        public string getMinorAgentId() {
            return minorAgentId;
        }

        public void setMinorAgentId(string minorAgentId) {
            this.minorAgentId = minorAgentId;
        }

        public string getLjhData() {
            return ljhData;
        }

        public void setLjhData(string ljhData) {
            this.ljhData = ljhData;
        }


    }
}
