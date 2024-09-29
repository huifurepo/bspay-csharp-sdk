using System;

namespace BasePaySdk.Request
{
    /**
     * 银行大额支付差错申请
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferBankmistakeApplyRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;
        /**
         * 交易金额
         */
        private string transAmt;
        /**
         * 订单类型
         */
        private string orderType;
        /**
         * 原请求流水号
         */
        private string orgReqSeqId;
        /**
         * 原请求日期
         */
        private string orgReqDate;
        /**
         * 实际打款日期
         */
        private string remitDate;
        /**
         * 实际付款方姓名
         */
        private string certificateName;
        /**
         * 实际付款方银行卡号
         */
        private string bankCardNo;
        /**
         * 实际付款方银行名称
         */
        private string bankName;
        /**
         * 异步通知地址
         */
        private string notifyUrl;
        /**
         * 商品描述
         */
        private string goodsDesc;
        /**
         * 汇款凭证文件id
         */
        private string certificateFileId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_TRANSFER_BANKMISTAKE_APPLY;
        }

        public V2TradeOnlinepaymentTransferBankmistakeApplyRequest() {
        }

        public V2TradeOnlinepaymentTransferBankmistakeApplyRequest(string reqSeqId, string reqDate, string huifuId, string transAmt, string orderType, string orgReqSeqId, string orgReqDate, string remitDate, string certificateName, string bankCardNo, string bankName, string notifyUrl, string goodsDesc, string certificateFileId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.transAmt = transAmt;
            this.orderType = orderType;
            this.orgReqSeqId = orgReqSeqId;
            this.orgReqDate = orgReqDate;
            this.remitDate = remitDate;
            this.certificateName = certificateName;
            this.bankCardNo = bankCardNo;
            this.bankName = bankName;
            this.notifyUrl = notifyUrl;
            this.goodsDesc = goodsDesc;
            this.certificateFileId = certificateFileId;
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

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getOrderType() {
            return orderType;
        }

        public void setOrderType(string orderType) {
            this.orderType = orderType;
        }

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }

        public string getRemitDate() {
            return remitDate;
        }

        public void setRemitDate(string remitDate) {
            this.remitDate = remitDate;
        }

        public string getCertificateName() {
            return certificateName;
        }

        public void setCertificateName(string certificateName) {
            this.certificateName = certificateName;
        }

        public string getBankCardNo() {
            return bankCardNo;
        }

        public void setBankCardNo(string bankCardNo) {
            this.bankCardNo = bankCardNo;
        }

        public string getBankName() {
            return bankName;
        }

        public void setBankName(string bankName) {
            this.bankName = bankName;
        }

        public string getNotifyUrl() {
            return notifyUrl;
        }

        public void setNotifyUrl(string notifyUrl) {
            this.notifyUrl = notifyUrl;
        }

        public string getGoodsDesc() {
            return goodsDesc;
        }

        public void setGoodsDesc(string goodsDesc) {
            this.goodsDesc = goodsDesc;
        }

        public string getCertificateFileId() {
            return certificateFileId;
        }

        public void setCertificateFileId(string certificateFileId) {
            this.certificateFileId = certificateFileId;
        }


    }
}
