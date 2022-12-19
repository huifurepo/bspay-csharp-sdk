using System;

namespace BasePaySdk.Request
{
    /**
     * 银联活动报名进度查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantActivityUnionpaySignStatusRequest : BaseRequest
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
         * 报名编号与serialNumber二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：521724026796785664&lt;/font&gt;
         */
        private string enlistId;
        /**
         * 报名请求流水号报名时传递的reqSysId；与enlistId二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：ZDTESTrQ202011054108473959671&lt;/font&gt;
         */
        private string serialNumber;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_ACTIVITY_UNIONPAY_SIGN_STATUS;
        }

        public V2MerchantActivityUnionpaySignStatusRequest() {
        }

        public V2MerchantActivityUnionpaySignStatusRequest(string reqSeqId, string reqDate, string huifuId, string enlistId, string serialNumber) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.enlistId = enlistId;
            this.serialNumber = serialNumber;
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

        public string getEnlistId() {
            return enlistId;
        }

        public void setEnlistId(string enlistId) {
            this.enlistId = enlistId;
        }

        public string getSerialNumber() {
            return serialNumber;
        }

        public void setSerialNumber(string serialNumber) {
            this.serialNumber = serialNumber;
        }


    }
}
