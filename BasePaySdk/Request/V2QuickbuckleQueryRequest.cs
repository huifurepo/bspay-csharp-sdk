using System;

namespace BasePaySdk.Request
{
    /**
     * 快捷绑卡查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleQueryRequest : BaseRequest
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
         * 汇付商户Id
         */
        private string huifuId;
        /**
         * 用户id
         */
        private string outCustId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_QUICKBUCKLE_QUERY;
        }

        public V2QuickbuckleQueryRequest() {
        }

        public V2QuickbuckleQueryRequest(string reqDate, string reqSeqId, string huifuId, string outCustId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.outCustId = outCustId;
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

        public string getOutCustId() {
            return outCustId;
        }

        public void setOutCustId(string outCustId) {
            this.outCustId = outCustId;
        }


    }
}
