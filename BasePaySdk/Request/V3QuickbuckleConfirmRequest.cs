using System;

namespace BasePaySdk.Request
{
    /**
     * 快捷绑卡确认接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V3QuickbuckleConfirmRequest : BaseRequest
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
         * 汇付商户Id
         */
        private string huifuId;
        /**
         * 原申请流水号
         */
        private string orgReqSeqId;
        /**
         * 原申请日期
         */
        private string orgReqDate;
        /**
         * 验证码
         */
        private string verifyCode;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_QUICKBUCKLE_CONFIRM;
        }

        public V3QuickbuckleConfirmRequest() {
        }

        public V3QuickbuckleConfirmRequest(string reqDate, string reqSeqId, string huifuId, string orgReqSeqId, string orgReqDate, string verifyCode) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.orgReqSeqId = orgReqSeqId;
            this.orgReqDate = orgReqDate;
            this.verifyCode = verifyCode;
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

        public string getVerifyCode() {
            return verifyCode;
        }

        public void setVerifyCode(string verifyCode) {
            this.verifyCode = verifyCode;
        }


    }
}
