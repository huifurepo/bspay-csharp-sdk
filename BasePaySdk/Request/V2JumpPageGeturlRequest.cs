using System;

namespace BasePaySdk.Request
{
    /**
     * 获取控台页面跳转链接
     *
     * @author sdk-generator
     * @Description
     */
    public class V2JumpPageGeturlRequest : BaseRequest
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
         * 外部系统用户标识
         */
        private string externalUserId;
        /**
         * 功能菜单
         */
        private string jumpFunctionType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_JUMP_PAGE_GETURL;
        }

        public V2JumpPageGeturlRequest() {
        }

        public V2JumpPageGeturlRequest(string reqSeqId, string reqDate, string huifuId, string externalUserId, string jumpFunctionType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.externalUserId = externalUserId;
            this.jumpFunctionType = jumpFunctionType;
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

        public string getExternalUserId() {
            return externalUserId;
        }

        public void setExternalUserId(string externalUserId) {
            this.externalUserId = externalUserId;
        }

        public string getJumpFunctionType() {
            return jumpFunctionType;
        }

        public void setJumpFunctionType(string jumpFunctionType) {
            this.jumpFunctionType = jumpFunctionType;
        }


    }
}
