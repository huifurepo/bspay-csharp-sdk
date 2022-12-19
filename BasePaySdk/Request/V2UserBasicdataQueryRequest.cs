using System;

namespace BasePaySdk.Request
{
    /**
     * 用户信息查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBasicdataQueryRequest : BaseRequest
    {

        /**
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求日期
         */
        private string reqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_USER_BASICDATA_QUERY;
        }

        public V2UserBasicdataQueryRequest() {
        }

        public V2UserBasicdataQueryRequest(string huifuId, string reqSeqId, string reqDate) {
            this.huifuId = huifuId;
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
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


    }
}
