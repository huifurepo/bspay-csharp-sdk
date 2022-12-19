using System;

namespace BasePaySdk.Request
{
    /**
     * 申请单状态查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBasicdataStatusQueryRequest : BaseRequest
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
         * 申请单
         */
        private string applyNo;
        /**
         * 汇付客户Id
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BASICDATA_STATUS_QUERY;
        }

        public V2MerchantBasicdataStatusQueryRequest() {
        }

        public V2MerchantBasicdataStatusQueryRequest(string reqSeqId, string reqDate, string applyNo, string huifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.applyNo = applyNo;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }


    }
}
