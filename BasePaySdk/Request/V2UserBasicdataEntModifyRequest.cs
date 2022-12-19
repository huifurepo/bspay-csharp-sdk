using System;

namespace BasePaySdk.Request
{
    /**
     * 企业用户基本信息修改
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBasicdataEntModifyRequest : BaseRequest
    {

        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 汇付客户Id
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_USER_BASICDATA_ENT_MODIFY;
        }

        public V2UserBasicdataEntModifyRequest() {
        }

        public V2UserBasicdataEntModifyRequest(string reqDate, string reqSeqId, string huifuId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }


    }
}
