using System;

namespace BasePaySdk.Request
{
    /**
     * 用户业务入驻修改
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBusiModifyRequest : BaseRequest
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
         * 汇付ID
         */
        private string huifuId;
        /**
         * 乐接活配置当合作平台为乐接活，必填
         */
        private string ljhData;
        /**
         * 签约人信息当电子回单配置开关为开通时必填
         */
        private string signUserInfo;
        /**
         * 汇薪云配置当合作平台为汇薪云时，该参数必填
         */
        private string hxyData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_USER_BUSI_MODIFY;
        }

        public V2UserBusiModifyRequest() {
        }

        public V2UserBusiModifyRequest(string reqSeqId, string reqDate, string upperHuifuId, string huifuId, string ljhData, string signUserInfo, string hxyData) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.huifuId = huifuId;
            this.ljhData = ljhData;
            this.signUserInfo = signUserInfo;
            this.hxyData = hxyData;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getLjhData() {
            return ljhData;
        }

        public void setLjhData(string ljhData) {
            this.ljhData = ljhData;
        }

        public string getSignUserInfo() {
            return signUserInfo;
        }

        public void setSignUserInfo(string signUserInfo) {
            this.signUserInfo = signUserInfo;
        }

        public string getHxyData() {
            return hxyData;
        }

        public void setHxyData(string hxyData) {
            this.hxyData = hxyData;
        }


    }
}
