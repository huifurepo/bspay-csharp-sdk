using System;

namespace BasePaySdk.Request
{
    /**
     * 银联活动报名
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantActivityUnionpaySignRequest : BaseRequest
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
         * 活动编号
         */
        private string activityId;
        /**
         * 银联活动商户号
         */
        private string merNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_ACTIVITY_UNIONPAY_SIGN;
        }

        public V2MerchantActivityUnionpaySignRequest() {
        }

        public V2MerchantActivityUnionpaySignRequest(string reqSeqId, string reqDate, string huifuId, string activityId, string merNo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.activityId = activityId;
            this.merNo = merNo;
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

        public string getActivityId() {
            return activityId;
        }

        public void setActivityId(string activityId) {
            this.activityId = activityId;
        }

        public string getMerNo() {
            return merNo;
        }

        public void setMerNo(string merNo) {
            this.merNo = merNo;
        }


    }
}
