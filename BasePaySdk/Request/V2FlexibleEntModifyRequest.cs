using System;

namespace BasePaySdk.Request
{
    /**
     * 灵工企业商户业务修改
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleEntModifyRequest : BaseRequest
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
         * 商户汇付id
         */
        private string huifuId;
        /**
         * 渠道商汇付ID
         */
        private string upperHuifuId;
        /**
         * 商户基本信息jsonObject格式；其中的contact_info和legal_info联系人和法人信息可能在卡信息修改时需要
         */
        private string basicInfo;
        /**
         * 签约人
         */
        private string signUserInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_FLEXIBLE_ENT_MODIFY;
        }

        public V2FlexibleEntModifyRequest() {
        }

        public V2FlexibleEntModifyRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string basicInfo, string signUserInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.basicInfo = basicInfo;
            this.signUserInfo = signUserInfo;
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

        public string getBasicInfo() {
            return basicInfo;
        }

        public void setBasicInfo(string basicInfo) {
            this.basicInfo = basicInfo;
        }

        public string getSignUserInfo() {
            return signUserInfo;
        }

        public void setSignUserInfo(string signUserInfo) {
            this.signUserInfo = signUserInfo;
        }


    }
}
