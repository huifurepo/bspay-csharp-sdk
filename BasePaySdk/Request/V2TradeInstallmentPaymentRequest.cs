using System;

namespace BasePaySdk.Request
{
    /**
     * 分期支付
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeInstallmentPaymentRequest : BaseRequest
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
         * 交易金额
         */
        private string transAmt;
        /**
         * 分期数
         */
        private string installmentNum;
        /**
         * 商品描述
         */
        private string goodsDesc;
        /**
         * 安全信息
         */
        private string riskCheckData;
        /**
         * 京东白条分期信息trans_type&#x3D;JDBT时，必填jsonObject字符串，京东白条分期相关信息通过该参数集上送
         */
        private string jdbtData;
        /**
         * 银联聚分期信息trans_type&#x3D;YLJFQ-银联聚分期时，必填jsonObject字符串，银联聚分期相关信息通过该参数集上送
         */
        private string yljfqData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_INSTALLMENT_PAYMENT;
        }

        public V2TradeInstallmentPaymentRequest() {
        }

        public V2TradeInstallmentPaymentRequest(string reqDate, string reqSeqId, string huifuId, string transAmt, string installmentNum, string goodsDesc, string riskCheckData, string jdbtData, string yljfqData) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.transAmt = transAmt;
            this.installmentNum = installmentNum;
            this.goodsDesc = goodsDesc;
            this.riskCheckData = riskCheckData;
            this.jdbtData = jdbtData;
            this.yljfqData = yljfqData;
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

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getInstallmentNum() {
            return installmentNum;
        }

        public void setInstallmentNum(string installmentNum) {
            this.installmentNum = installmentNum;
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

        public string getJdbtData() {
            return jdbtData;
        }

        public void setJdbtData(string jdbtData) {
            this.jdbtData = jdbtData;
        }

        public string getYljfqData() {
            return yljfqData;
        }

        public void setYljfqData(string yljfqData) {
            this.yljfqData = yljfqData;
        }


    }
}
