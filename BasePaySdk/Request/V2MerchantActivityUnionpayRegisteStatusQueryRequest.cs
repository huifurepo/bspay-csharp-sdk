using System;

namespace BasePaySdk.Request
{
    /**
     * 银联活动商户入驻状态查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantActivityUnionpayRegisteStatusQueryRequest : BaseRequest
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
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 工单号
         */
        private string serialNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_ACTIVITY_UNIONPAY_REGISTE_STATUS_QUERY;
        }

        public V2MerchantActivityUnionpayRegisteStatusQueryRequest() {
        }

        public V2MerchantActivityUnionpayRegisteStatusQueryRequest(string reqSeqId, string reqDate, string huifuId, string serialNo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.serialNo = serialNo;
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

        public string getSerialNo() {
            return serialNo;
        }

        public void setSerialNo(string serialNo) {
            this.serialNo = serialNo;
        }


    }
}
