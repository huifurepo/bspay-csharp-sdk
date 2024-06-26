using System;

namespace BasePaySdk.Request
{
    /**
     * 电子账户绑卡
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantElecCardBindRequest : BaseRequest
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
         * 电子卡信息
         */
        private string elecCardInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_ELEC_CARD_BIND;
        }

        public V2MerchantElecCardBindRequest() {
        }

        public V2MerchantElecCardBindRequest(string reqSeqId, string reqDate, string huifuId, string elecCardInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.elecCardInfo = elecCardInfo;
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

        public string getElecCardInfo() {
            return elecCardInfo;
        }

        public void setElecCardInfo(string elecCardInfo) {
            this.elecCardInfo = elecCardInfo;
        }


    }
}
