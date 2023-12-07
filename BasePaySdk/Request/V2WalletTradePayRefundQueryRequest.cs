using System;

namespace BasePaySdk.Request
{
    /**
     * 钱包支付退款查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradePayRefundQueryRequest : BaseRequest
    {

        /**
         * 系统号
         */
        private string sysId;
        /**
         * 产品号
         */
        private string productId;
        /**
         * 加签结果
         */
        private string sign;
        /**
         * 数据
         */
        private string data;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_TRADE_PAY_REFUND_QUERY;
        }

        public V2WalletTradePayRefundQueryRequest() {
        }

        public V2WalletTradePayRefundQueryRequest(string sysId, string productId, string sign, string data) {
            this.sysId = sysId;
            this.productId = productId;
            this.sign = sign;
            this.data = data;
        }

        public string getSysId() {
            return sysId;
        }

        public void setSysId(string sysId) {
            this.sysId = sysId;
        }

        public string getProductId() {
            return productId;
        }

        public void setProductId(string productId) {
            this.productId = productId;
        }

        public string getSign() {
            return sign;
        }

        public void setSign(string sign) {
            this.sign = sign;
        }

        public string getData() {
            return data;
        }

        public void setData(string data) {
            this.data = data;
        }


    }
}
