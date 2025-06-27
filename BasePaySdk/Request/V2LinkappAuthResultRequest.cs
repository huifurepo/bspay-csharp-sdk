using System;

namespace BasePaySdk.Request
{
    /**
     * 授权结果查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LinkappAuthResultRequest : BaseRequest
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
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 平台类型
         */
        private string platformType;
        /**
         * 授权请求ID
         */
        private string authSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_LINKAPP_AUTH_RESULT;
        }

        public V2LinkappAuthResultRequest() {
        }

        public V2LinkappAuthResultRequest(string reqSeqId, string reqDate, string huifuId, string platformType, string authSeqId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.platformType = platformType;
            this.authSeqId = authSeqId;
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

        public string getPlatformType() {
            return platformType;
        }

        public void setPlatformType(string platformType) {
            this.platformType = platformType;
        }

        public string getAuthSeqId() {
            return authSeqId;
        }

        public void setAuthSeqId(string authSeqId) {
            this.authSeqId = authSeqId;
        }


    }
}
