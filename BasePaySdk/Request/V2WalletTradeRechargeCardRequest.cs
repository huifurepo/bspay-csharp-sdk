using System;

namespace BasePaySdk.Request
{
    /**
     * 钱包绑卡充值下单
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradeRechargeCardRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 钱包用户ID
         */
        private string userHuifuId;
        /**
         * 订单金额
         */
        private string transAmt;
        /**
         * 微信充值信息微信充值必填
         */
        private string wxRechareInfo;
        /**
         * 支付宝充值信息支付宝充值必填
         */
        private string alipayRechargeInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_TRADE_RECHARGE_CARD;
        }

        public V2WalletTradeRechargeCardRequest() {
        }

        public V2WalletTradeRechargeCardRequest(string reqSeqId, string reqDate, string huifuId, string userHuifuId, string transAmt, string wxRechareInfo, string alipayRechargeInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.userHuifuId = userHuifuId;
            this.transAmt = transAmt;
            this.wxRechareInfo = wxRechareInfo;
            this.alipayRechargeInfo = alipayRechargeInfo;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
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

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getWxRechareInfo() {
            return wxRechareInfo;
        }

        public void setWxRechareInfo(string wxRechareInfo) {
            this.wxRechareInfo = wxRechareInfo;
        }

        public string getAlipayRechargeInfo() {
            return alipayRechargeInfo;
        }

        public void setAlipayRechargeInfo(string alipayRechargeInfo) {
            this.alipayRechargeInfo = alipayRechargeInfo;
        }


    }
}
