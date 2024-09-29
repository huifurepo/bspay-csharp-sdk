using System;

namespace BasePaySdk.Request
{
    /**
     * 全渠道资金管理配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiEfpconfigRequest : BaseRequest
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
         * 开关
         */
        private string switchState;
        /**
         * 自动入账开关0:关闭 1:开通；switch_state为1时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1&lt;/font&gt;
         */
        private string outOrderAutoAcctFlag;
        /**
         * 支付手续费外扣汇付ID支付手续费外扣标记为1时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812123&lt;/font&gt;
         */
        private string outFeeHuifuid;
        /**
         * 全域资金开户使用的银行卡信息首次开通时必填 jsonObject格式
         */
        private string outOrderAcctCard;
        /**
         * 全域资金开户手续费首次开通时必填 jsonObject格式
         */
        private string outOrderAcctOpenFees;
        /**
         * 全渠道资金管理补充材料id涉及文件类型：[F504-全渠道资金管理补充材料](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string otherPaymentInstitutionsPic;
        /**
         * 新网银行数字证书及电子签名授权委托书out_funds_gate_id为xw0时必填；涉及文件类型：[F534-银行数字证书及电子签名授权委托书](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xwDigitalCertificatePic;
        /**
         * 银行类型
         */
        private string outFundsGateId;
        /**
         * 签约人信息switch_state为1时必填 jsonObject格式
         */
        private string signUserInfo;
        /**
         * 入账来源
         */
        private string acctSource;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_EFPCONFIG;
        }

        public V2MerchantBusiEfpconfigRequest() {
        }

        public V2MerchantBusiEfpconfigRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string switchState, string outOrderAutoAcctFlag, string outFeeHuifuid, string outOrderAcctCard, string outOrderAcctOpenFees, string otherPaymentInstitutionsPic, string xwDigitalCertificatePic, string outFundsGateId, string signUserInfo, string acctSource) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.switchState = switchState;
            this.outOrderAutoAcctFlag = outOrderAutoAcctFlag;
            this.outFeeHuifuid = outFeeHuifuid;
            this.outOrderAcctCard = outOrderAcctCard;
            this.outOrderAcctOpenFees = outOrderAcctOpenFees;
            this.otherPaymentInstitutionsPic = otherPaymentInstitutionsPic;
            this.xwDigitalCertificatePic = xwDigitalCertificatePic;
            this.outFundsGateId = outFundsGateId;
            this.signUserInfo = signUserInfo;
            this.acctSource = acctSource;
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

        public string getSwitchState() {
            return switchState;
        }

        public void setSwitchState(string switchState) {
            this.switchState = switchState;
        }

        public string getOutOrderAutoAcctFlag() {
            return outOrderAutoAcctFlag;
        }

        public void setOutOrderAutoAcctFlag(string outOrderAutoAcctFlag) {
            this.outOrderAutoAcctFlag = outOrderAutoAcctFlag;
        }

        public string getOutFeeHuifuid() {
            return outFeeHuifuid;
        }

        public void setOutFeeHuifuid(string outFeeHuifuid) {
            this.outFeeHuifuid = outFeeHuifuid;
        }

        public string getOutOrderAcctCard() {
            return outOrderAcctCard;
        }

        public void setOutOrderAcctCard(string outOrderAcctCard) {
            this.outOrderAcctCard = outOrderAcctCard;
        }

        public string getOutOrderAcctOpenFees() {
            return outOrderAcctOpenFees;
        }

        public void setOutOrderAcctOpenFees(string outOrderAcctOpenFees) {
            this.outOrderAcctOpenFees = outOrderAcctOpenFees;
        }

        public string getOtherPaymentInstitutionsPic() {
            return otherPaymentInstitutionsPic;
        }

        public void setOtherPaymentInstitutionsPic(string otherPaymentInstitutionsPic) {
            this.otherPaymentInstitutionsPic = otherPaymentInstitutionsPic;
        }

        public string getXwDigitalCertificatePic() {
            return xwDigitalCertificatePic;
        }

        public void setXwDigitalCertificatePic(string xwDigitalCertificatePic) {
            this.xwDigitalCertificatePic = xwDigitalCertificatePic;
        }

        public string getOutFundsGateId() {
            return outFundsGateId;
        }

        public void setOutFundsGateId(string outFundsGateId) {
            this.outFundsGateId = outFundsGateId;
        }

        public string getSignUserInfo() {
            return signUserInfo;
        }

        public void setSignUserInfo(string signUserInfo) {
            this.signUserInfo = signUserInfo;
        }

        public string getAcctSource() {
            return acctSource;
        }

        public void setAcctSource(string acctSource) {
            this.acctSource = acctSource;
        }


    }
}
