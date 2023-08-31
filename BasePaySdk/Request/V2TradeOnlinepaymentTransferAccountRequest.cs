using System;

namespace BasePaySdk.Request
{
    /**
     * 银行大额转账
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferAccountRequest : BaseRequest
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
         * 收款方商户号
         */
        private string huifuId;
        /**
         * 付款方名称
         */
        private string certificateName;
        /**
         * 付款方银行卡号
         */
        private string bankCardNo;
        /**
         * 交易金额
         */
        private string transAmt;
        /**
         * 商品描述
         */
        private string goodsDesc;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_TRANSFER_ACCOUNT;
        }

        public V2TradeOnlinepaymentTransferAccountRequest() {
        }

        public V2TradeOnlinepaymentTransferAccountRequest(string reqSeqId, string reqDate, string huifuId, string certificateName, string bankCardNo, string transAmt, string goodsDesc) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.certificateName = certificateName;
            this.bankCardNo = bankCardNo;
            this.transAmt = transAmt;
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

        public string getCertificateName() {
            return certificateName;
        }

        public void setCertificateName(string certificateName) {
            this.certificateName = certificateName;
        }

        public string getBankCardNo() {
            return bankCardNo;
        }

        public void setBankCardNo(string bankCardNo) {
            this.bankCardNo = bankCardNo;
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


    }
}
