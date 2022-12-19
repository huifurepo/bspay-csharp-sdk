using System;

namespace BasePaySdk.Request
{
    /**
     * 快捷绑卡确认接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleConfirmRequest : BaseRequest
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
         * 汇付商户Id
         */
        private string huifuId;
        /**
         * 用户id
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
         * 银行卡绑定手机号
         */
        private string cardMp;
        /**
         * 验证码
         */
        private string verifyCode;
        /**
         * CVV2信用卡代扣专用需要密文传输，使用商户RSA私钥加密(加密前3位，加密后最长2048位），[参见参考文档](https://paas.huifu.com/partners/guide/#/api_jiami_jiemi)；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：Ly+fnExeyPOTzf……rGq0l0NTebfc6XJXZss&#x3D;&lt;/font&gt;
         */
        private string vipCode;
        /**
         * 卡有效期信用卡代扣专用，格式：MMYY，需要密文传输。&lt;br/&gt;使用商户RSA私钥加密(加密前4位，加密后最长2048位），[参见参考文档](https://paas.huifu.com/partners/guide/#/api_jiami_jiemi)；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：Ly+fnExeyPO……ebfc6XJXZss&#x3D;&lt;/font&gt;
         */
        private string expiration;
        /**
         * 设备信息域 
         */
        private string trxDeviceInf;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_QUICKBUCKLE_CONFIRM;
        }

        public V2QuickbuckleConfirmRequest() {
        }

        public V2QuickbuckleConfirmRequest(string reqDate, string reqSeqId, string huifuId, string outCustId, string orderId, string orderDate, string cardId, string cardName, string certType, string certId, string cardMp, string verifyCode, string vipCode, string expiration, string trxDeviceInf) {
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
            this.cardMp = cardMp;
            this.verifyCode = verifyCode;
            this.vipCode = vipCode;
            this.expiration = expiration;
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

        public string getCardMp() {
            return cardMp;
        }

        public void setCardMp(string cardMp) {
            this.cardMp = cardMp;
        }

        public string getVerifyCode() {
            return verifyCode;
        }

        public void setVerifyCode(string verifyCode) {
            this.verifyCode = verifyCode;
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

        public string getTrxDeviceInf() {
            return trxDeviceInf;
        }

        public void setTrxDeviceInf(string trxDeviceInf) {
            this.trxDeviceInf = trxDeviceInf;
        }


    }
}
