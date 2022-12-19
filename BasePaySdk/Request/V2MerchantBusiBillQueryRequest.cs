using System;

namespace BasePaySdk.Request
{
    /**
     * 交易结算对账单配置查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiBillQueryRequest : BaseRequest
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
         * 汇付机构编号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_BILL_QUERY;
        }

        public V2MerchantBusiBillQueryRequest() {
        }

        public V2MerchantBusiBillQueryRequest(string reqDate, string reqSeqId, string huifuId) {
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
