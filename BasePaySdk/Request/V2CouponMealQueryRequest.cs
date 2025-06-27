using System;

namespace BasePaySdk.Request
{
    /**
     * 美团餐饮门店套餐映射
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponMealQueryRequest : BaseRequest
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
         * 套餐状态
         */
        private string dealStatus;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_COUPON_MEAL_QUERY;
        }

        public V2CouponMealQueryRequest() {
        }

        public V2CouponMealQueryRequest(string reqSeqId, string reqDate, string huifuId, string bindId, string dealStatus) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.bindId = bindId;
            this.dealStatus = dealStatus;
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

        public string getDealStatus() {
            return dealStatus;
        }

        public void setDealStatus(string dealStatus) {
            this.dealStatus = dealStatus;
        }


    }
}
