using System;

namespace BasePaySdk.Request
{
    /**
     * 钱包绑定手机号验证
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletMobileVerifyRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;
        /**
         * 钱包用户ID斗拱系统生成的钱包用户ID。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123122343&lt;/font&gt;&lt;br/&gt;验证类型为2-密码修改和3-密码重置时，必须提供钱包用户的汇付ID。
         */
        private string userHuifuId;
        /**
         * 用户手机号
         */
        private string mobileNo;
        /**
         * 验证类型
         */
        private string type;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_MOBILE_VERIFY;
        }

        public V2WalletMobileVerifyRequest() {
        }

        public V2WalletMobileVerifyRequest(string reqSeqId, string reqDate, string huifuId, string userHuifuId, string mobileNo, string type) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.userHuifuId = userHuifuId;
            this.mobileNo = mobileNo;
            this.type = type;
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

        public string getUserHuifuId() {
            return userHuifuId;
        }

        public void setUserHuifuId(string userHuifuId) {
            this.userHuifuId = userHuifuId;
        }

        public string getMobileNo() {
            return mobileNo;
        }

        public void setMobileNo(string mobileNo) {
            this.mobileNo = mobileNo;
        }

        public string getType() {
            return type;
        }

        public void setType(string type) {
            this.type = type;
        }


    }
}
