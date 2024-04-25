using System;

namespace BasePaySdk.Request
{
    /**
     * 电子账户设置默认卡
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantElecCardDefaultRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求时间
         */
        private string reqDate;
        /**
         * 汇付Id
         */
        private string huifuId;
        /**
         * 银行卡号
         */
        private string cardNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_ELEC_CARD_DEFAULT;
        }

        public V2MerchantElecCardDefaultRequest() {
        }

        public V2MerchantElecCardDefaultRequest(string reqSeqId, string reqDate, string huifuId, string cardNo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.cardNo = cardNo;
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

        public string getCardNo() {
            return cardNo;
        }

        public void setCardNo(string cardNo) {
            this.cardNo = cardNo;
        }


    }
}
