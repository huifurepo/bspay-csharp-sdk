using System;

namespace BasePaySdk.Request
{
    /**
     * 商户短信发送
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBasicdataSmsSendRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求时间
         */
        private string reqDate;
        /**
         * 商户汇付Id
         */
        private string huifuId;
        /**
         * 手机号verify_type&#x3D;&#39;elecAcctSign&#39;时，手机号为空，系统自动取联系人手机号; &lt;font color&#x3D;&quot;green&quot;&gt;示例值：13911111111&lt;/font&gt;
         */
        private string phone;
        /**
         * 验证类型
         */
        private string verifyType;
        /**
         * 操作类型verify_type&#x3D;&#39;elecAcctSign&#39;时必填；枚举值：sendSmsCode-发送验证码；identitySmsCode-验证码核实；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：sendSmsCode&lt;/font&gt;
         */
        private string operationType;
        /**
         * 验证码verify_type&#x3D;&#39;elecAcctSign&#39;且operation_type&#x3D;&#39;identitySmsCode&#39;时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：123456&lt;/font&gt;
         */
        private string verifyCode;
        /**
         * 中信签约流水号verify_type&#x3D;&#39;elecAcctSign&#39;且operation_type&#x3D;&#39;identitySmsCode&#39;时必填；值为中信E管家签约发送短信时返回值；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：EMSSBPG2504284593690058431260676&lt;/font&gt;
         */
        private string elecAcctSignSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BASICDATA_SMS_SEND;
        }

        public V2MerchantBasicdataSmsSendRequest() {
        }

        public V2MerchantBasicdataSmsSendRequest(string reqSeqId, string reqDate, string huifuId, string phone, string verifyType, string operationType, string verifyCode, string elecAcctSignSeqId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.phone = phone;
            this.verifyType = verifyType;
            this.operationType = operationType;
            this.verifyCode = verifyCode;
            this.elecAcctSignSeqId = elecAcctSignSeqId;
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

        public string getPhone() {
            return phone;
        }

        public void setPhone(string phone) {
            this.phone = phone;
        }

        public string getVerifyType() {
            return verifyType;
        }

        public void setVerifyType(string verifyType) {
            this.verifyType = verifyType;
        }

        public string getOperationType() {
            return operationType;
        }

        public void setOperationType(string operationType) {
            this.operationType = operationType;
        }

        public string getVerifyCode() {
            return verifyCode;
        }

        public void setVerifyCode(string verifyCode) {
            this.verifyCode = verifyCode;
        }

        public string getElecAcctSignSeqId() {
            return elecAcctSignSeqId;
        }

        public void setElecAcctSignSeqId(string elecAcctSignSeqId) {
            this.elecAcctSignSeqId = elecAcctSignSeqId;
        }


    }
}
