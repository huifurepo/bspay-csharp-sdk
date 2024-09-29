using System;

namespace BasePaySdk.Request
{
    /**
     * 快捷绑卡申请接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V3QuickbuckleApplyRequest : BaseRequest
    {

        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 商户用户id
         */
        private string outCustId;
        /**
         * 银行卡号
         */
        private string cardNo;
        /**
         * 银行卡开户姓名
         */
        private string cardName;
        /**
         * 银行卡绑定身份证
         */
        private string certNo;
        /**
         * 个人证件有效期类型
         */
        private string certValidityType;
        /**
         * 个人证件有效期起始日
         */
        private string certBeginDate;
        /**
         * 个人证件有效期到期日长期有效不填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20420905&lt;/font&gt;
         */
        private string certEndDate;
        /**
         * 银行卡绑定手机号
         */
        private string mobileNo;
        /**
         * 挂网协议编号授权信息(招行绑卡需要上送)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：34463343&lt;/font&gt;
         */
        private string protocolNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_QUICKBUCKLE_APPLY;
        }

        public V3QuickbuckleApplyRequest() {
        }

        public V3QuickbuckleApplyRequest(string reqDate, string reqSeqId, string huifuId, string outCustId, string cardNo, string cardName, string certNo, string certValidityType, string certBeginDate, string certEndDate, string mobileNo, string protocolNo) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.outCustId = outCustId;
            this.cardNo = cardNo;
            this.cardName = cardName;
            this.certNo = certNo;
            this.certValidityType = certValidityType;
            this.certBeginDate = certBeginDate;
            this.certEndDate = certEndDate;
            this.mobileNo = mobileNo;
            this.protocolNo = protocolNo;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getOutCustId() {
            return outCustId;
        }

        public void setOutCustId(string outCustId) {
            this.outCustId = outCustId;
        }

        public string getCardNo() {
            return cardNo;
        }

        public void setCardNo(string cardNo) {
            this.cardNo = cardNo;
        }

        public string getCardName() {
            return cardName;
        }

        public void setCardName(string cardName) {
            this.cardName = cardName;
        }

        public string getCertNo() {
            return certNo;
        }

        public void setCertNo(string certNo) {
            this.certNo = certNo;
        }

        public string getCertValidityType() {
            return certValidityType;
        }

        public void setCertValidityType(string certValidityType) {
            this.certValidityType = certValidityType;
        }

        public string getCertBeginDate() {
            return certBeginDate;
        }

        public void setCertBeginDate(string certBeginDate) {
            this.certBeginDate = certBeginDate;
        }

        public string getCertEndDate() {
            return certEndDate;
        }

        public void setCertEndDate(string certEndDate) {
            this.certEndDate = certEndDate;
        }

        public string getMobileNo() {
            return mobileNo;
        }

        public void setMobileNo(string mobileNo) {
            this.mobileNo = mobileNo;
        }

        public string getProtocolNo() {
            return protocolNo;
        }

        public void setProtocolNo(string protocolNo) {
            this.protocolNo = protocolNo;
        }


    }
}
