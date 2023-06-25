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
         * 手机号
         */
        private string phone;
        /**
         * 验证类型
         */
        private string verifyType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BASICDATA_SMS_SEND;
        }

        public V2MerchantBasicdataSmsSendRequest() {
        }

        public V2MerchantBasicdataSmsSendRequest(string reqSeqId, string reqDate, string huifuId, string phone, string verifyType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.phone = phone;
            this.verifyType = verifyType;
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


    }
}
