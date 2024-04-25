using System;

namespace BasePaySdk.Request
{
    /**
     * 汇付入账确认
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferRemittanceRequest : BaseRequest
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
         * 交易金额
         */
        private string transAmt;
        /**
         * 异步通知地址
         */
        private string notifyUrl;
        /**
         * 原汇付通道流水号
         */
        private string orgRemittanceOrderId;
        /**
         * 商品描述
         */
        private string goodsDesc;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_TRANSFER_REMITTANCE;
        }

        public V2TradeOnlinepaymentTransferRemittanceRequest() {
        }

        public V2TradeOnlinepaymentTransferRemittanceRequest(string reqSeqId, string reqDate, string huifuId, string transAmt, string notifyUrl, string orgRemittanceOrderId, string goodsDesc) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.transAmt = transAmt;
            this.notifyUrl = notifyUrl;
            this.orgRemittanceOrderId = orgRemittanceOrderId;
            this.goodsDesc = goodsDesc;
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

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }

        public string getOrgRemittanceOrderId() {
            return orgRemittanceOrderId;
        }

        public void setOrgRemittanceOrderId(string orgRemittanceOrderId) {
            this.orgRemittanceOrderId = orgRemittanceOrderId;
        }

        public string getGoodsDesc() {
            return goodsDesc;
        }

        public void setGoodsDesc(string goodsDesc) {
            this.goodsDesc = goodsDesc;
        }


    }
}
