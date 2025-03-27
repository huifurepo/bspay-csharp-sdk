using System;

namespace BasePaySdk.Request
{
    /**
     * 修改子账户配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantSettleModifyRequest : BaseRequest
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
         * 商户汇付Id
         */
        private string huifuId;
        /**
         * 上级汇付Id
         */
        private string upperHuifuId;
        /**
         * 子账户号
         */
        private string acctId;
        /**
         * 结算规则配置
         */
        private string settleConfig;
        /**
         * 结算卡信息配置新账户绑定的结算银行账户。jsonObject格式。若结算规则中上送token_no，则card_info不填。
         */
        private string cardInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_SETTLE_MODIFY;
        }

        public V2MerchantSettleModifyRequest() {
        }

        public V2MerchantSettleModifyRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string acctId, string settleConfig, string cardInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.acctId = acctId;
            this.settleConfig = settleConfig;
            this.cardInfo = cardInfo;
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

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getAcctId() {
            return acctId;
        }

        public void setAcctId(string acctId) {
            this.acctId = acctId;
        }

        public string getSettleConfig() {
            return settleConfig;
        }

        public void setSettleConfig(string settleConfig) {
            this.settleConfig = settleConfig;
        }

        public string getCardInfo() {
            return cardInfo;
        }

        public void setCardInfo(string cardInfo) {
            this.cardInfo = cardInfo;
        }


    }
}
