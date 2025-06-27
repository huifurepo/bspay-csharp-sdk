using System;

namespace BasePaySdk.Request
{
    /**
     * 抖音卡券校验
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponDouyinPrepareRequest : BaseRequest
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

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_COUPON_DOUYIN_PREPARE;
        }

        public V2CouponDouyinPrepareRequest() {
        }

        public V2CouponDouyinPrepareRequest(string reqSeqId, string reqDate, string huifuId, string bindId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
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

        public string getBindId() {
            return bindId;
        }

        public void setBindId(string bindId) {
            this.bindId = bindId;
        }


    }
}
