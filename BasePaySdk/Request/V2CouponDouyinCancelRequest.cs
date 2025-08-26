using System;

namespace BasePaySdk.Request
{
    /**
     * 抖音卡券撤销
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponDouyinCancelRequest : BaseRequest
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
         * 门店绑定流水号
         */
        private string bindId;
        /**
         * 抖音券码
         */
        private string encryptedCode;
        /**
         * 核销标识
         */
        private string verifyId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_COUPON_DOUYIN_CANCEL;
        }

        public V2CouponDouyinCancelRequest() {
        }

        public V2CouponDouyinCancelRequest(string reqSeqId, string reqDate, string huifuId, string bindId, string encryptedCode, string verifyId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.bindId = bindId;
            this.encryptedCode = encryptedCode;
            this.verifyId = verifyId;
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

        public string getBindId() {
            return bindId;
        }

        public void setBindId(string bindId) {
            this.bindId = bindId;
        }

        public string getEncryptedCode() {
            return encryptedCode;
        }

        public void setEncryptedCode(string encryptedCode) {
            this.encryptedCode = encryptedCode;
        }

        public string getVerifyId() {
            return verifyId;
        }

        public void setVerifyId(string verifyId) {
            this.verifyId = verifyId;
        }


    }
}
