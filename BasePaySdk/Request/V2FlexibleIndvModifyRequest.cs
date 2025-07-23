using System;

namespace BasePaySdk.Request
{
    /**
     * 灵工个人用户修改
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleIndvModifyRequest : BaseRequest
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

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_FLEXIBLE_INDV_MODIFY;
        }

        public V2FlexibleIndvModifyRequest() {
        }

        public V2FlexibleIndvModifyRequest(string reqSeqId, string reqDate, string upperHuifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
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


    }
}
