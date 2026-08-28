using System;

namespace BasePaySdk.Request
{
    /**
     * 商户基本信息修改
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBasicdataModifyRequest : BaseRequest
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
         * 直属渠道号该商户进件完成后归属的渠道商huifu_id；；&lt;br/&gt;sys_id主体为渠道商时填写； &lt;br/&gt;sys_id主体为总部商户时选填；&lt;br/&gt; &lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
         */
        private string upperHuifuId;
        /**
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 签约人jsonObject格式；agreement_info中选择电子签约时必填；个人商户填本人信息。
         */
        private string signUserInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BASICDATA_MODIFY;
        }

        public V2MerchantBasicdataModifyRequest() {
        }

        public V2MerchantBasicdataModifyRequest(string reqSeqId, string reqDate, string upperHuifuId, string huifuId, string signUserInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.upperHuifuId = upperHuifuId;
            this.huifuId = huifuId;
            this.signUserInfo = signUserInfo;
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

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getSignUserInfo() {
            return signUserInfo;
        }

        public void setSignUserInfo(string signUserInfo) {
            this.signUserInfo = signUserInfo;
        }


    }
}
