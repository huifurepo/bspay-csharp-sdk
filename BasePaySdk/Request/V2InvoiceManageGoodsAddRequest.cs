using System;

namespace BasePaySdk.Request
{
    /**
     * 开票商品新增
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceManageGoodsAddRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 商品名称
         */
        private string goodsName;
        /**
         * 税收分类编码
         */
        private string taxCode;
        /**
         * 税率
         */
        private string taxRate;
        /**
         * 是否默认
         */
        private string isDefault;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_MANAGE_GOODS_ADD;
        }

        public V2InvoiceManageGoodsAddRequest() {
        }

        public V2InvoiceManageGoodsAddRequest(string huifuId, string goodsName, string taxCode, string taxRate, string isDefault) {
            this.huifuId = huifuId;
            this.goodsName = goodsName;
            this.taxCode = taxCode;
            this.taxRate = taxRate;
            this.isDefault = isDefault;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getGoodsName() {
            return goodsName;
        }

        public void setGoodsName(string goodsName) {
            this.goodsName = goodsName;
        }

        public string getTaxCode() {
            return taxCode;
        }

        public void setTaxCode(string taxCode) {
            this.taxCode = taxCode;
        }

        public string getTaxRate() {
            return taxRate;
        }

        public void setTaxRate(string taxRate) {
            this.taxRate = taxRate;
        }

        public string getIsDefault() {
            return isDefault;
        }

        public void setIsDefault(string isDefault) {
            this.isDefault = isDefault;
        }


    }
}
