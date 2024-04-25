using System;

namespace BasePaySdk.Request
{
    /**
     * 用户申请单状态查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserApplyQueryRequest : BaseRequest
    {

        /**
         * 汇付客户Id
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
         * 申请单号
         */
        private string applyNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_USER_APPLY_QUERY;
        }

        public V2UserApplyQueryRequest() {
        }

        public V2UserApplyQueryRequest(string huifuId, string reqSeqId, string reqDate, string applyNo) {
            this.huifuId = huifuId;
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.applyNo = applyNo;
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

        public string getApplyNo() {
            return applyNo;
        }

        public void setApplyNo(string applyNo) {
            this.applyNo = applyNo;
        }


    }
}
