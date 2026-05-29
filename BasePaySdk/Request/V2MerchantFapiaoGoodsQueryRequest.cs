using System;

namespace BasePaySdk.Request
{
    /**
     * 开票商品查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantFapiaoGoodsQueryRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_FAPIAO_GOODS_QUERY;
        }

        public V2MerchantFapiaoGoodsQueryRequest() {
        }

        public V2MerchantFapiaoGoodsQueryRequest(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }


    }
}
