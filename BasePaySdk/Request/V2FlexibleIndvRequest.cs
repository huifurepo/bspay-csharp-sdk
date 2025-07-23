using System;

namespace BasePaySdk.Request
{
    /**
     * 灵工个人用户进件
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleIndvRequest : BaseRequest
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
         * 渠道商/商户汇付Id
         */
        private string upperHuifuId;
        /**
         * 基本信息
         */
        private string basicInfo;
        /**
         * 卡信息
         */
        private string cardInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_FLEXIBLE_INDV;
        }

        public V2FlexibleIndvRequest() {
        }

        public V2FlexibleIndvRequest(string reqSeqId, string reqDate, string upperHuifuId, string basicInfo, string cardInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.basicInfo = basicInfo;
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

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getBasicInfo() {
            return basicInfo;
        }

        public void setBasicInfo(string basicInfo) {
            this.basicInfo = basicInfo;
        }

        public string getCardInfo() {
            return cardInfo;
        }

        public void setCardInfo(string cardInfo) {
            this.cardInfo = cardInfo;
        }


    }
}
