using System;

namespace BasePaySdk.Request
{
    /**
     * 代扣绑卡申请
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleWithholdApplyRequest : BaseRequest
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
         * 汇付Id
         */
        private string huifuId;
        /**
         * 返回地址
         */
        private string returnUrl;
        /**
         * 用户id
         */
        private string outCustId;
        /**
         * 绑卡订单号
         */
        private string orderId;
        /**
         * 绑卡订单日期
         */
        private string orderDate;
        /**
         * 银行卡号
         */
        private string cardId;
        /**
         * 银行卡开户姓名 
         */
        private string cardName;
        /**
         * 银行卡绑定证件类型 
         */
        private string certType;
        /**
         * 银行卡绑定身份证
         */
        private string certId;
        /**
         * 银行卡绑定手机号 
         */
        private string cardMp;
        /**
         * CVV2信用卡代扣专用 需要密文传输，需要密文传输，使用汇付RSA公钥加密(加密前64位，加密后最长2048位），参见[参考文档](https://paas.huifu.com/open/doc/guide/#/api_jiami_jiemi)；
         */
        private string vipCode;
        /**
         * 卡有效期 信用卡代扣专用，格式：MMYY 需要密文传输，使用汇付RSA公钥加密(加密前64位，加密后最长2048位），参见[参考文档](https://paas.huifu.com/open/doc/guide/#/api_jiami_jiemi)；
         */
        private string expiration;
        /**
         * 个人证件有效期类型
         */
        private string certValidityType;
        /**
         * 个人证件有效期起始日
         */
        private string certBeginDate;
        /**
         * 个人证件有效期到期日长期有效不填.格式：YYYYMMDD；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20450112&lt;/font&gt;
         */
        private string certEndDate;
        /**
         * 卡的借贷类型
         */
        private string dcType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_QUICKBUCKLE_WITHHOLD_APPLY;
        }

        public V2QuickbuckleWithholdApplyRequest() {
        }

        public V2QuickbuckleWithholdApplyRequest(string reqSeqId, string reqDate, string huifuId, string returnUrl, string outCustId, string orderId, string orderDate, string cardId, string cardName, string certType, string certId, string cardMp, string vipCode, string expiration, string certValidityType, string certBeginDate, string certEndDate, string dcType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.returnUrl = returnUrl;
            this.outCustId = outCustId;
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.cardId = cardId;
            this.cardName = cardName;
            this.certType = certType;
            this.certId = certId;
            this.cardMp = cardMp;
            this.vipCode = vipCode;
            this.expiration = expiration;
            this.certValidityType = certValidityType;
            this.certBeginDate = certBeginDate;
            this.certEndDate = certEndDate;
            this.dcType = dcType;
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

        public string getReturnUrl() {
            return returnUrl;
        }

        public void setReturnUrl(string returnUrl) {
            this.returnUrl = returnUrl;
        }

        public string getOutCustId() {
            return outCustId;
        }

        public void setOutCustId(string outCustId) {
            this.outCustId = outCustId;
        }

        public string getOrderId() {
            return orderId;
        }

        public void setOrderId(string orderId) {
            this.orderId = orderId;
        }

        public string getOrderDate() {
            return orderDate;
        }

        public void setOrderDate(string orderDate) {
            this.orderDate = orderDate;
        }

        public string getCardId() {
            return cardId;
        }

        public void setCardId(string cardId) {
            this.cardId = cardId;
        }

        public string getCardName() {
            return cardName;
        }

        public void setCardName(string cardName) {
            this.cardName = cardName;
        }

        public string getCertType() {
            return certType;
        }

        public void setCertType(string certType) {
            this.certType = certType;
        }

        public string getCertId() {
            return certId;
        }

        public void setCertId(string certId) {
            this.certId = certId;
        }

        public string getCardMp() {
            return cardMp;
        }

        public void setCardMp(string cardMp) {
            this.cardMp = cardMp;
        }

        public string getVipCode() {
            return vipCode;
        }

        public void setVipCode(string vipCode) {
            this.vipCode = vipCode;
        }

        public string getExpiration() {
            return expiration;
        }

        public void setExpiration(string expiration) {
            this.expiration = expiration;
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

        public string getDcType() {
            return dcType;
        }

        public void setDcType(string dcType) {
            this.dcType = dcType;
        }


    }
}
