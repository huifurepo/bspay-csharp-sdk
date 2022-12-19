using System;

namespace BasePaySdk.Request
{
    /**
     * 商户状态变更
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiModifyBusistatusRequest : BaseRequest
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
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 状态
         */
        private string status;
        /**
         * 状态变更原因
         */
        private string updStatusReason;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_MODIFY_BUSISTATUS;
        }

        public V2MerchantBusiModifyBusistatusRequest() {
        }

        public V2MerchantBusiModifyBusistatusRequest(string reqDate, string reqSeqId, string huifuId, string status, string updStatusReason) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.status = status;
            this.updStatusReason = updStatusReason;
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

        public string getStatus() {
            return status;
        }

        public void setStatus(string status) {
            this.status = status;
        }

        public string getUpdStatusReason() {
            return updStatusReason;
        }

        public void setUpdStatusReason(string updStatusReason) {
            this.updStatusReason = updStatusReason;
        }


    }
}
