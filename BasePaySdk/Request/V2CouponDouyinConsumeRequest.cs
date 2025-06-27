using System;

namespace BasePaySdk.Request
{
    /**
     * 抖音卡券核销
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponDouyinConsumeRequest : BaseRequest
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
         * 加密抖音券码列表
         */
        private string encryptedCodes;
        /**
         * 校验标识
         */
        private string verifyToken;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_COUPON_DOUYIN_CONSUME;
        }

        public V2CouponDouyinConsumeRequest() {
        }

        public V2CouponDouyinConsumeRequest(string reqSeqId, string reqDate, string huifuId, string bindId, string encryptedCodes, string verifyToken) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.bindId = bindId;
            this.encryptedCodes = encryptedCodes;
            this.verifyToken = verifyToken;
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

        public string getEncryptedCodes() {
            return encryptedCodes;
        }

        public void setEncryptedCodes(string encryptedCodes) {
            this.encryptedCodes = encryptedCodes;
        }

        public string getVerifyToken() {
            return verifyToken;
        }

        public void setVerifyToken(string verifyToken) {
            this.verifyToken = verifyToken;
        }


    }
}
