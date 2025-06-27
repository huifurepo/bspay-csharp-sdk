using System;

namespace BasePaySdk.Request
{
    /**
     * 美团卡券校验
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponMeituanPrepareRequest : BaseRequest
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
         * 团购券码
         */
        private string couponCode;
        /**
         * 门店绑定流水号
         */
        private string bindId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_COUPON_MEITUAN_PREPARE;
        }

        public V2CouponMeituanPrepareRequest() {
        }

        public V2CouponMeituanPrepareRequest(string reqSeqId, string reqDate, string huifuId, string couponCode, string bindId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.couponCode = couponCode;
            this.bindId = bindId;
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

        public string getCouponCode() {
            return couponCode;
        }

        public void setCouponCode(string couponCode) {
            this.couponCode = couponCode;
        }

        public string getBindId() {
            return bindId;
        }

        public void setBindId(string bindId) {
            this.bindId = bindId;
        }


    }
}
