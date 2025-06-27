using System;

namespace BasePaySdk.Request
{
    /**
     * 美团非餐饮获取团购信息
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponShopdealQueryRequest : BaseRequest
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
         * 页码
         */
        private string offset;
        /**
         * 页大小
         */
        private string limit;
        /**
         * 售卖平台
         */
        private string source;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_COUPON_SHOPDEAL_QUERY;
        }

        public V2CouponShopdealQueryRequest() {
        }

        public V2CouponShopdealQueryRequest(string reqSeqId, string reqDate, string huifuId, string bindId, string offset, string limit, string source) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.bindId = bindId;
            this.offset = offset;
            this.limit = limit;
            this.source = source;
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

        public string getOffset() {
            return offset;
        }

        public void setOffset(string offset) {
            this.offset = offset;
        }

        public string getLimit() {
            return limit;
        }

        public void setLimit(string limit) {
            this.limit = limit;
        }

        public string getSource() {
            return source;
        }

        public void setSource(string source) {
            this.source = source;
        }


    }
}
