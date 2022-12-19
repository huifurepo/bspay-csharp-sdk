using System;

namespace BasePaySdk.Request
{
    /**
     * 微信商户配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiConfigRequest : BaseRequest
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
         * 业务开通类型
         */
        private string feeType;
        /**
         * 公众号支付Appid条件必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx3767c5bd01df5061&lt;/font&gt; ；wx_woa_app_id 和 wx_applet_app_id两者不能同时为空
         */
        private string wxWoaAppId;
        /**
         * 微信小程序APPID条件必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx8523175fea790f10&lt;/font&gt; ；wx_woa_app_id，wx_applet_app_id两者不能同时为空
         */
        private string wxAppletAppId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_CONFIG;
        }

        public V2MerchantBusiConfigRequest() {
        }

        public V2MerchantBusiConfigRequest(string reqSeqId, string reqDate, string huifuId, string feeType, string wxWoaAppId, string wxAppletAppId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.feeType = feeType;
            this.wxWoaAppId = wxWoaAppId;
            this.wxAppletAppId = wxAppletAppId;
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

        public string getFeeType() {
            return feeType;
        }

        public void setFeeType(string feeType) {
            this.feeType = feeType;
        }

        public string getWxWoaAppId() {
            return wxWoaAppId;
        }

        public void setWxWoaAppId(string wxWoaAppId) {
            this.wxWoaAppId = wxWoaAppId;
        }

        public string getWxAppletAppId() {
            return wxAppletAppId;
        }

        public void setWxAppletAppId(string wxAppletAppId) {
            this.wxAppletAppId = wxAppletAppId;
        }


    }
}
