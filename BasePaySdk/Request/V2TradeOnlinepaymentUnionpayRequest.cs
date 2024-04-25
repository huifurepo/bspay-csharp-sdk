using System;

namespace BasePaySdk.Request
{
    /**
     * 银联统一在线收银台
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentUnionpayRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 订单金额
         */
        private string transAmt;
        /**
         * 商品描述
         */
        private string orderDesc;
        /**
         * 安全信息
         */
        private string riskCheckData;
        /**
         * 三方支付数据jsonObject；pay_scene为云闪付公众号与云闪付小程序时必填
         */
        private string thirdPayData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_UNIONPAY;
        }

        public V2TradeOnlinepaymentUnionpayRequest() {
        }

        public V2TradeOnlinepaymentUnionpayRequest(string huifuId, string reqDate, string reqSeqId, string transAmt, string orderDesc, string riskCheckData, string thirdPayData) {
            this.huifuId = huifuId;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.transAmt = transAmt;
            this.orderDesc = orderDesc;
            this.riskCheckData = riskCheckData;
            this.thirdPayData = thirdPayData;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
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

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getOrderDesc() {
            return orderDesc;
        }

        public void setOrderDesc(string orderDesc) {
            this.orderDesc = orderDesc;
        }

        public string getRiskCheckData() {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData) {
            this.riskCheckData = riskCheckData;
        }

        public string getThirdPayData() {
            return thirdPayData;
        }

        public void setThirdPayData(string thirdPayData) {
            this.thirdPayData = thirdPayData;
        }


    }
}
