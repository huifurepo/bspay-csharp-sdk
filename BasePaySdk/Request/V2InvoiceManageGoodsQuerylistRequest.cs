using System;

namespace BasePaySdk.Request
{
    /**
     * 开票商品查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceManageGoodsQuerylistRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_MANAGE_GOODS_QUERYLIST;
        }

        public V2InvoiceManageGoodsQuerylistRequest() {
        }

        public V2InvoiceManageGoodsQuerylistRequest(string huifuId) {
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
