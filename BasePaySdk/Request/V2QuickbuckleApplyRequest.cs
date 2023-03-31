using System;

namespace BasePaySdk.Request
{
    /**
     * 快捷绑卡申请接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleApplyRequest : BaseRequest
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
         * 订单号
         */
        private string orderId;
        /**
         * 订单日期
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
        private string cardMp;
        /**
         * CVV2信用卡交易专用需要密文传输。&lt;br/&gt;使用汇付RSA公钥加密(加密前3位，加密后最长2048位），[参见参考文档](https://paas.huifu.com/partners/guide/#/api_jiami_jiemi)；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：Ly+fnExeyPOTzfOtgRRur77nJB9TAe4PGgK9M……fc6XJXZss&#x3D;&lt;/font&gt;
         */
        private string vipCode;
        /**
         * 卡有效期信用卡交易专用，格式：MMYY，需要密文传输；&lt;br/&gt;使用汇付RSA公钥加密(加密前4位，加密后最长2048位），[参见参考文档](https://paas.huifu.com/partners/guide/#/api_jiami_jiemi)；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：Ly+fnExeyPOTzfOtgRRur77nJB9TAe4PGgK9M……fc6XJXZss&#x3D;JXZss&#x3D;&lt;/font&gt;
         */
        private string expiration;
        /**
         * 挂网协议编号授权信息(招行绑卡需要上送)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：34463343&lt;/font&gt;
         */
        private string protocolNo;
        /**
         * 设备信息域 
         */
        private string trxDeviceInf;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_QUICKBUCKLE_APPLY;
        }

        public V2QuickbuckleApplyRequest() {
        }

        public V2QuickbuckleApplyRequest(string reqDate, string reqSeqId, string huifuId, string outCustId, string orderId, string orderDate, string cardId, string cardName, string certType, string certId, string certValidityType, string certBeginDate, string certEndDate, string cardMp, string vipCode, string expiration, string protocolNo, string trxDeviceInf) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.outCustId = outCustId;
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.cardId = cardId;
            this.cardName = cardName;
            this.certType = certType;
            this.certId = certId;
            this.certValidityType = certValidityType;
            this.certBeginDate = certBeginDate;
            this.certEndDate = certEndDate;
            this.cardMp = cardMp;
            this.vipCode = vipCode;
            this.expiration = expiration;
            this.protocolNo = protocolNo;
            this.trxDeviceInf = trxDeviceInf;
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

        public string getProtocolNo() {
            return protocolNo;
        }

        public void setProtocolNo(string protocolNo) {
            this.protocolNo = protocolNo;
        }

        public string getTrxDeviceInf() {
            return trxDeviceInf;
        }

        public void setTrxDeviceInf(string trxDeviceInf) {
            this.trxDeviceInf = trxDeviceInf;
        }


    }
}
