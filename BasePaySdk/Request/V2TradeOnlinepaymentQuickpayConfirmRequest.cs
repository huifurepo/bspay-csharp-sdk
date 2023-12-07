using System;

namespace BasePaySdk.Request
{
    /**
     * 快捷支付确认
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentQuickpayConfirmRequest : BaseRequest
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
         * 短信验证码
         */
        private string smsCode;
        /**
         * 商品描述
         */
        private string goodsDesc;
        /**
         * 外部地址
         */
        private string notifyUrl;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_QUICKPAY_CONFIRM;
        }

        public V2TradeOnlinepaymentQuickpayConfirmRequest() {
        }

        public V2TradeOnlinepaymentQuickpayConfirmRequest(string reqDate, string reqSeqId, string huifuId, string smsCode, string goodsDesc, string notifyUrl) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.smsCode = smsCode;
            this.goodsDesc = goodsDesc;
            this.notifyUrl = notifyUrl;
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

        public string getSmsCode() {
            return smsCode;
        }

        public void setSmsCode(string smsCode) {
            this.smsCode = smsCode;
        }

        public string getGoodsDesc() {
            return goodsDesc;
        }

        public void setGoodsDesc(string goodsDesc) {
            this.goodsDesc = goodsDesc;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }


    }
}
