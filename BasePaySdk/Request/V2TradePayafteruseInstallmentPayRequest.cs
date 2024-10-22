using System;

namespace BasePaySdk.Request
{
    /**
     * 分期扣款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayafteruseInstallmentPayRequest : BaseRequest
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
         * 客户号
         */
        private string huifuId;
        /**
         * 交易金额
         */
        private string transAmt;
        /**
         * 商品描述
         */
        private string goodsDesc;
        /**
         * 风控信息
         */
        private string riskCheckData;
        /**
         * 交易有效期
         */
        private string timeExpire;
        /**
         * 支付宝扩展参数集合
         */
        private string alipayData;

        public override string getFunctionCode()
        {
            return FunctionCodeEnum.V2_TRADE_PAYAFTERUSE_INSTALLMENT_PAY;
        }

        public V2TradePayafteruseInstallmentPayRequest()
        {
        }

        public V2TradePayafteruseInstallmentPayRequest(string reqDate, string reqSeqId, string huifuId, string transAmt, string goodsDesc, string riskCheckData, string timeExpire, string alipayData)
        {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.transAmt = transAmt;
            this.goodsDesc = goodsDesc;
            this.riskCheckData = riskCheckData;
            this.timeExpire = timeExpire;
            this.alipayData = alipayData;
        }

        public string getReqDate()
        {
            return reqDate;
        }

        public void setReqDate(string reqDate)
        {
            this.reqDate = reqDate;
        }

        public string getReqSeqId()
        {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId)
        {
            this.reqSeqId = reqSeqId;
        }

        public string getHuifuId()
        {
            return huifuId;
        }

        public void setHuifuId(string huifuId)
        {
            this.huifuId = huifuId;
        }

        public string getTransAmt()
        {
            return transAmt;
        }

        public void setTransAmt(string transAmt)
        {
            this.transAmt = transAmt;
        }

        public string getGoodsDesc()
        {
            return goodsDesc;
        }

        public void setGoodsDesc(string goodsDesc)
        {
            this.goodsDesc = goodsDesc;
        }

        public string getRiskCheckData()
        {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData)
        {
            this.riskCheckData = riskCheckData;
        }

        public string getTimeExpire()
        {
            return timeExpire;
        }

        public void setTimeExpire(string timeExpire)
        {
            this.timeExpire = timeExpire;
        }

        public string getAlipayData()
        {
            return alipayData;
        }

        public void setAlipayData(string alipayData)
        {
            this.alipayData = alipayData;
        }


    }
}
