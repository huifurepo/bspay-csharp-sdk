using System;

namespace BasePaySdk.Request
{
    /**
     * 一键绑卡-工行卡号查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleBindCardinfoQueryRequest : BaseRequest
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
         * 产品Id
         */
        private string productId;
        /**
         * 银行卡开户姓名
         */
        private string cardName;
        /**
         * 身份证类型
         */
        private string certType;
        /**
         * 银行卡绑定身份证
         */
        private string certNo;
        /**
         * 银行卡绑定手机号
         */
        private string cardMobile;
        /**
         * 回调地址
         */
        private string notifyUrl;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_QUICKBUCKLE_BIND_CARDINFO_QUERY;
        }

        public V2QuickbuckleBindCardinfoQueryRequest() {
        }

        public V2QuickbuckleBindCardinfoQueryRequest(string reqSeqId, string reqDate, string huifuId, string productId, string cardName, string certType, string certNo, string cardMobile, string notifyUrl) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.productId = productId;
            this.cardName = cardName;
            this.certType = certType;
            this.certNo = certNo;
            this.cardMobile = cardMobile;
            this.notifyUrl = notifyUrl;
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

        public string getProductId() {
            return productId;
        }

        public void setProductId(string productId) {
            this.productId = productId;
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

        public string getCertNo() {
            return certNo;
        }

        public void setCertNo(string certNo) {
            this.certNo = certNo;
        }

        public string getCardMobile() {
            return cardMobile;
        }

        public void setCardMobile(string cardMobile) {
            this.cardMobile = cardMobile;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }


    }
}
