using System;

namespace BasePaySdk.Request
{
    /**
     * 用户业务入驻
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBusiOpenRequest : BaseRequest
    {

        /**
         * 汇付ID
         */
        private string huifuId;
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
         * 乐接活配置当合作平台为乐接活，必填
         */
        private string ljhData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_USER_BUSI_OPEN;
        }

        public V2UserBusiOpenRequest() {
        }

        public V2UserBusiOpenRequest(string huifuId, string reqSeqId, string reqDate, string upperHuifuId, string ljhData) {
            this.huifuId = huifuId;
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.ljhData = ljhData;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
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

        public string getLjhData() {
            return ljhData;
        }

        public void setLjhData(string ljhData) {
            this.ljhData = ljhData;
        }


    }
}
