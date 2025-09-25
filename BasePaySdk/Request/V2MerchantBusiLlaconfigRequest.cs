using System;

namespace BasePaySdk.Request
{
    /**
     * 代运营代扣业务配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiLlaconfigRequest : BaseRequest
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
         * 商户汇付id
         */
        private string huifuId;
        /**
         * 所属渠道商
         */
        private string upperHuifuId;
        /**
         * 代运营配置json字符串，业务角色为AGENCY:代运营时必填
         */
        private string llaAgencyConfig;
        /**
         * 商家配置json字符串，业务角色为MERCHANT:商家时必填
         */
        private string llaMerchantConfig;
        /**
         * 纸质协议文件协议类型为纸质且业务角色不为空时必填，文件类型F633；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string paperAgreementFile;
        /**
         * 签约人信息json字符串，协议类型为电子时必填
         */
        private string signUserInfo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_LLACONFIG;
        }

        public V2MerchantBusiLlaconfigRequest() {
        }

        public V2MerchantBusiLlaconfigRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string llaAgencyConfig, string llaMerchantConfig, string paperAgreementFile, string signUserInfo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.llaAgencyConfig = llaAgencyConfig;
            this.llaMerchantConfig = llaMerchantConfig;
            this.paperAgreementFile = paperAgreementFile;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getLlaAgencyConfig() {
            return llaAgencyConfig;
        }

        public void setLlaAgencyConfig(string llaAgencyConfig) {
            this.llaAgencyConfig = llaAgencyConfig;
        }

        public string getLlaMerchantConfig() {
            return llaMerchantConfig;
        }

        public void setLlaMerchantConfig(string llaMerchantConfig) {
            this.llaMerchantConfig = llaMerchantConfig;
        }

        public string getPaperAgreementFile() {
            return paperAgreementFile;
        }

        public void setPaperAgreementFile(string paperAgreementFile) {
            this.paperAgreementFile = paperAgreementFile;
        }

        public string getSignUserInfo() {
            return signUserInfo;
        }

        public void setSignUserInfo(string signUserInfo) {
            this.signUserInfo = signUserInfo;
        }


    }
}
