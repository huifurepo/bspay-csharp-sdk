using System;

namespace BasePaySdk.Request
{
    /**
     * 代扣支付
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentWithholdpayRequest : BaseRequest
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
         * 用户客户号
         */
        private string userHuifuId;
        /**
         * 绑卡id
         */
        private string cardBindId;
        /**
         * 订单金额
         */
        private string transAmt;
        /**
         * 商品描述
         */
        private string goodsDesc;
        /**
         * 代扣类型
         */
        private string withholdType;
        /**
         * 异步通知地址
         */
        private string notifyUrl;
        /**
         * 银行扩展数据
         */
        private string extendPayData;
        /**
         * 风控信息
         */
        private string riskCheckData;
        /**
         * 设备信息数据
         */
        private string terminalDeviceData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_WITHHOLDPAY;
        }

        public V2TradeOnlinepaymentWithholdpayRequest() {
        }

        public V2TradeOnlinepaymentWithholdpayRequest(string reqDate, string reqSeqId, string huifuId, string userHuifuId, string cardBindId, string transAmt, string goodsDesc, string withholdType, string notifyUrl, string extendPayData, string riskCheckData, string terminalDeviceData) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.userHuifuId = userHuifuId;
            this.cardBindId = cardBindId;
            this.transAmt = transAmt;
            this.goodsDesc = goodsDesc;
            this.withholdType = withholdType;
            this.notifyUrl = notifyUrl;
            this.extendPayData = extendPayData;
            this.riskCheckData = riskCheckData;
            this.terminalDeviceData = terminalDeviceData;
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

        public string getUserHuifuId() {
            return userHuifuId;
        }

        public void setUserHuifuId(string userHuifuId) {
            this.userHuifuId = userHuifuId;
        }

        public string getCardBindId() {
            return cardBindId;
        }

        public void setCardBindId(string cardBindId) {
            this.cardBindId = cardBindId;
        }

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getGoodsDesc() {
            return goodsDesc;
        }

        public void setGoodsDesc(string goodsDesc) {
            this.goodsDesc = goodsDesc;
        }

        public string getWithholdType() {
            return withholdType;
        }

        public void setWithholdType(string withholdType) {
            this.withholdType = withholdType;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }

        public string getExtendPayData() {
            return extendPayData;
        }

        public void setExtendPayData(string extendPayData) {
            this.extendPayData = extendPayData;
        }

        public string getRiskCheckData() {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData) {
            this.riskCheckData = riskCheckData;
        }

        public string getTerminalDeviceData() {
            return terminalDeviceData;
        }

        public void setTerminalDeviceData(string terminalDeviceData) {
            this.terminalDeviceData = terminalDeviceData;
        }


    }
}
