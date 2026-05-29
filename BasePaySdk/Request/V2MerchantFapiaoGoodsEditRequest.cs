using System;

namespace BasePaySdk.Request
{
    /**
     * 开票商品修改
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantFapiaoGoodsEditRequest : BaseRequest
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
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 商品id
         */
        private string goodsId;
        /**
         * 是否默认
         */
        private string isDefault;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_FAPIAO_GOODS_EDIT;
        }

        public V2MerchantFapiaoGoodsEditRequest() {
        }

        public V2MerchantFapiaoGoodsEditRequest(string reqDate, string reqSeqId, string huifuId, string goodsId, string isDefault) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.goodsId = goodsId;
            this.isDefault = isDefault;
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

        public string getGoodsId() {
            return goodsId;
        }

        public void setGoodsId(string goodsId) {
            this.goodsId = goodsId;
        }

        public string getIsDefault() {
            return isDefault;
        }

        public void setIsDefault(string isDefault) {
            this.isDefault = isDefault;
        }


    }
}
