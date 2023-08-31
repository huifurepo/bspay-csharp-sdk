using System;

namespace BasePaySdk.Request
{
    /**
     * 支付分扣款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscorePayPayscorepayRequest : BaseRequest
    {

        /**
         * 微信扣款单号
         */
        private string outTradeNo;
        /**
         * 商品描述
         */
        private string goodsDesc;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 安全信息
         */
        private string riskCheckData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYSCORE_PAY_PAYSCOREPAY;
        }

        public V2TradePayscorePayPayscorepayRequest() {
        }

        public V2TradePayscorePayPayscorepayRequest(string outTradeNo, string goodsDesc, string huifuId, string riskCheckData) {
            this.outTradeNo = outTradeNo;
            this.goodsDesc = goodsDesc;
            this.huifuId = huifuId;
            this.riskCheckData = riskCheckData;
        }

        public string getOutTradeNo() {
            return outTradeNo;
        }

        public void setOutTradeNo(string outTradeNo) {
            this.outTradeNo = outTradeNo;
        }

        public string getGoodsDesc() {
            return goodsDesc;
        }

        public void setGoodsDesc(string goodsDesc) {
            this.goodsDesc = goodsDesc;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getRiskCheckData() {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData) {
            this.riskCheckData = riskCheckData;
        }


    }
}
