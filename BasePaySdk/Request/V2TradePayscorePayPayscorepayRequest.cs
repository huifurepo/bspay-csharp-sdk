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
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 扣款登记创建请求流水号deduct_req_seq_id与deduct_hf_seq_id二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2022012614120615001&lt;/font&gt;
         */
        private string deductReqSeqId;
        /**
         * 扣款登记返回的汇付全局流水号deduct_req_seq_id与deduct_hf_seq_id二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00470topo1A211015160805P090ac132fef00000&lt;/font&gt;
         */
        private string deductHfSeqId;
        /**
         * 微信扣款单号
         */
        private string outTradeNo;
        /**
         * 商品描述
         */
        private string goodsDesc;
        /**
         * 安全信息
         */
        private string riskCheckData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYSCORE_PAY_PAYSCOREPAY;
        }

        public V2TradePayscorePayPayscorepayRequest() {
        }

        public V2TradePayscorePayPayscorepayRequest(string reqDate, string reqSeqId, string huifuId, string deductReqSeqId, string deductHfSeqId, string outTradeNo, string goodsDesc, string riskCheckData) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.deductReqSeqId = deductReqSeqId;
            this.deductHfSeqId = deductHfSeqId;
            this.outTradeNo = outTradeNo;
            this.goodsDesc = goodsDesc;
            this.riskCheckData = riskCheckData;
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

        public string getDeductReqSeqId() {
            return deductReqSeqId;
        }

        public void setDeductReqSeqId(string deductReqSeqId) {
            this.deductReqSeqId = deductReqSeqId;
        }

        public string getDeductHfSeqId() {
            return deductHfSeqId;
        }

        public void setDeductHfSeqId(string deductHfSeqId) {
            this.deductHfSeqId = deductHfSeqId;
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

        public string getRiskCheckData() {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData) {
            this.riskCheckData = riskCheckData;
        }


    }
}
