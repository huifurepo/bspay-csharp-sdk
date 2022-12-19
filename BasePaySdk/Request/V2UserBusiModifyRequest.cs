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
         * 渠道商汇付Id
         */
        private string upperHuifuId;
        /**
         * 汇付ID
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_USER_BUSI_MODIFY;
        }

        public V2UserBusiModifyRequest() {
        }

        public V2UserBusiModifyRequest(string reqSeqId, string reqDate, string upperHuifuId, string huifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }


    }
}
