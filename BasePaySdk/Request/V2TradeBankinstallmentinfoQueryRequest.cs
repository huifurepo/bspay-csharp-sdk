using System;

namespace BasePaySdk.Request
{
    /**
     * 银行卡分期支持银行查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeBankinstallmentinfoQueryRequest : BaseRequest
    {

        /**
         * 页码
         */
        private string pageNum;
        /**
         * 每页条数
         */
        private string pageSize;
        /**
         * 产品号
         */
        private string productId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_BANKINSTALLMENTINFO_QUERY;
        }

        public V2TradeBankinstallmentinfoQueryRequest() {
        }

        public V2TradeBankinstallmentinfoQueryRequest(string pageNum, string pageSize, string productId) {
            this.pageNum = pageNum;
            this.pageSize = pageSize;
            this.productId = productId;
        }

        public string getPageNum() {
            return pageNum;
        }

        public void setPageNum(string pageNum) {
            this.pageNum = pageNum;
        }

        public string getPageSize() {
            return pageSize;
        }

        public void setPageSize(string pageSize) {
            this.pageSize = pageSize;
        }

        public string getProductId() {
            return productId;
        }

        public void setProductId(string productId) {
            this.productId = productId;
        }


    }
}
