using System;

namespace BasePaySdk.Request
{
    /**
     * 支付宝直连-查询申请状态
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectAlipayApplyorderstatusQueryRequest : BaseRequest
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
         * 商户汇付Id
         */
        private string huifuId;
        /**
         * 开发者的应用ID
         */
        private string appId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_ALIPAY_APPLYORDERSTATUS_QUERY;
        }

        public V2MerchantDirectAlipayApplyorderstatusQueryRequest() {
        }

        public V2MerchantDirectAlipayApplyorderstatusQueryRequest(string reqSeqId, string reqDate, string huifuId, string appId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.appId = appId;
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

        public string getAppId() {
            return appId;
        }

        public void setAppId(string appId) {
            this.appId = appId;
        }


    }
}
