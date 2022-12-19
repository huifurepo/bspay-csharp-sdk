using System;

namespace BasePaySdk.Request
{
    /**
     * 新增快捷/代扣解绑接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleUnbindRequest : BaseRequest
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
         * 用户ID
         */
        private string outCustId;
        /**
         * 卡令牌
         */
        private string tokenNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_QUICKBUCKLE_UNBIND;
        }

        public V2QuickbuckleUnbindRequest() {
        }

        public V2QuickbuckleUnbindRequest(string reqDate, string reqSeqId, string huifuId, string outCustId, string tokenNo) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.outCustId = outCustId;
            this.tokenNo = tokenNo;
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

        public string getOutCustId() {
            return outCustId;
        }

        public void setOutCustId(string outCustId) {
            this.outCustId = outCustId;
        }

        public string getTokenNo() {
            return tokenNo;
        }

        public void setTokenNo(string tokenNo) {
            this.tokenNo = tokenNo;
        }


    }
}
