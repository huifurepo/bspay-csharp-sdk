using System;

namespace BasePaySdk.Request
{
    /**
     * 全渠道资金付款申请
     *
     * @author sdk-generator
     * @Description
     */
    public class V2EfpSurrogateRequest : BaseRequest
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
         * 交易金额.单位:元，2位小数
         */
        private string cashAmt;
        /**
         * 银行账号使用斗拱系统的公钥对银行账号进行RSA加密得到秘文；  示例值：b9LE5RccVVLChrHgo9lvp……PhWhjKrWg2NPfbe0mkQ&#x3D;&#x3D; 到账类型标识为E或P时必填
         */
        private string cardNo;
        /**
         * 银行编号银行编号 到账类型标识为E或P时必填
         */
        private string bankCode;
        /**
         * 银行卡用户名银行卡用户名 到账类型标识为E或P时必填
         */
        private string cardName;
        /**
         * 到账类型标识
         */
        private string cardAcctType;
        /**
         * 省份到账类型标识为E或P时必填
         */
        private string provId;
        /**
         * 地区到账类型标识为E或P时必填
         */
        private string areaId;
        /**
         * 手机号对私必填，使用斗拱系统的公钥对手机号进行RSA加密得到秘文；  示例值：b9LE5RccVVLChrHgo9lvp……PhWhjKrWg2NPfbe0mkUDd
         */
        private string mobileNo;
        /**
         * 证件类型证件类型01：身份证  03：护照  06：港澳通行证  07：台湾通行证  09：外国人居留证  11：营业执照  12：组织机构代码证  14：统一社会信用代码  99：其他  示例值：14 到账类型标识为E或P时必填
         */
        private string certType;
        /**
         * 证件号使用斗拱系统的公钥对证件号进行RSA加密得到秘文；  示例值：b9LE5RccVVLChrHgo9lvp……PhWhjKrWg2NPfbe0mkQ 到账类型标识为P时必填
         */
        private string certNo;
        /**
         * 统一社会信用代码到账类型标识为E时必填
         */
        private string licenceCode;
        /**
         * 入账接收方对象json格式,到账类型标识为H时必填
         */
        private string acctSplitBunch;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_EFP_SURROGATE;
        }

        public V2EfpSurrogateRequest() {
        }

        public V2EfpSurrogateRequest(string reqSeqId, string reqDate, string huifuId, string cashAmt, string cardNo, string bankCode, string cardName, string cardAcctType, string provId, string areaId, string mobileNo, string certType, string certNo, string licenceCode, string acctSplitBunch) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.cashAmt = cashAmt;
            this.cardNo = cardNo;
            this.bankCode = bankCode;
            this.cardName = cardName;
            this.cardAcctType = cardAcctType;
            this.provId = provId;
            this.areaId = areaId;
            this.mobileNo = mobileNo;
            this.certType = certType;
            this.certNo = certNo;
            this.licenceCode = licenceCode;
            this.acctSplitBunch = acctSplitBunch;
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

        public string getCashAmt() {
            return cashAmt;
        }

        public void setCashAmt(string cashAmt) {
            this.cashAmt = cashAmt;
        }

        public string getCardNo() {
            return cardNo;
        }

        public void setCardNo(string cardNo) {
            this.cardNo = cardNo;
        }

        public string getBankCode() {
            return bankCode;
        }

        public void setBankCode(string bankCode) {
            this.bankCode = bankCode;
        }

        public string getCardName() {
            return cardName;
        }

        public void setCardName(string cardName) {
            this.cardName = cardName;
        }

        public string getCardAcctType() {
            return cardAcctType;
        }

        public void setCardAcctType(string cardAcctType) {
            this.cardAcctType = cardAcctType;
        }

        public string getProvId() {
            return provId;
        }

        public void setProvId(string provId) {
            this.provId = provId;
        }

        public string getAreaId() {
            return areaId;
        }

        public void setAreaId(string areaId) {
            this.areaId = areaId;
        }

        public string getMobileNo() {
            return mobileNo;
        }

        public void setMobileNo(string mobileNo) {
            this.mobileNo = mobileNo;
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

        public string getLicenceCode() {
            return licenceCode;
        }

        public void setLicenceCode(string licenceCode) {
            this.licenceCode = licenceCode;
        }

        public string getAcctSplitBunch() {
            return acctSplitBunch;
        }

        public void setAcctSplitBunch(string acctSplitBunch) {
            this.acctSplitBunch = acctSplitBunch;
        }


    }
}
