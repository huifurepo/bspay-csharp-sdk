using System;

namespace BasePaySdk.Request
{
    /**
     * 银行大额支付绑卡
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LargeamtBindcardBindRequest : BaseRequest
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
         * 卡类型
         */
        private string cardType;
        /**
         * 银行账户名
         */
        private string cardName;
        /**
         * 银行卡号密文
         */
        private string cardNo;
        /**
         * 银行编码
         */
        private string bankCode;
        /**
         * 手机号
         */
        private string mobileNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_LARGEAMT_BINDCARD_BIND;
        }

        public V2LargeamtBindcardBindRequest() {
        }

        public V2LargeamtBindcardBindRequest(string reqSeqId, string reqDate, string huifuId, string cardType, string cardName, string cardNo, string bankCode, string mobileNo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.cardType = cardType;
            this.cardName = cardName;
            this.cardNo = cardNo;
            this.bankCode = bankCode;
            this.mobileNo = mobileNo;
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

        public string getCardType() {
            return cardType;
        }

        public void setCardType(string cardType) {
            this.cardType = cardType;
        }

        public string getCardName() {
            return cardName;
        }

        public void setCardName(string cardName) {
            this.cardName = cardName;
        }

        public string getCardNo() {
            return cardNo;
        }

        public void setCardNo(string cardNo) {
            this.cardNo = cardNo;
        }

        public string getBankCode() {
            return bankCode;
        }

        public void setBankCode(string bankCode) {
            this.bankCode = bankCode;
        }

        public string getMobileNo() {
            return mobileNo;
        }

        public void setMobileNo(string mobileNo) {
            this.mobileNo = mobileNo;
        }


    }
}
