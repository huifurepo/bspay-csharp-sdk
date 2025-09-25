using System;

namespace BasePaySdk.Request
{
    /**
     * 银行卡代发
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettlementSurrogateRequest : BaseRequest
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
         * 代发金额
         */
        private string cashAmt;
        /**
         * 代发用途描述
         */
        private string purposeDesc;
        /**
         * 省份选填，参见[代发省市地区码](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/area/%E6%96%97%E6%8B%B1%E4%BB%A3%E5%8F%91%E7%9C%81%E4%BB%BD%E5%9C%B0%E5%8C%BA%E7%BC%96%E7%A0%81.xlsx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0013&lt;/font&gt;&lt;br/&gt;对公代发(省份+地区)与联行号信息二选一填入；对私代发非必填；
         */
        private string province;
        /**
         * 地区选填，参见[代发省市地区码](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/area/%E6%96%97%E6%8B%B1%E4%BB%A3%E5%8F%91%E7%9C%81%E4%BB%BD%E5%9C%B0%E5%8C%BA%E7%BC%96%E7%A0%81.xlsx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1301&lt;/font&gt;&lt;br/&gt;对公代发(省份+地区)与联行号信息二选一填入；对私代发非必填；
         */
        private string area;
        /**
         * 银行编号参考： [银行编码](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_yhbm)； &lt;font color&#x3D;&quot;green&quot;&gt;&lt;br/&gt; 选填 ，card_acct_type&#x3D;E 时必填， 示例值：01040000&lt;/font&gt;
         */
        private string bankCode;
        /**
         * 联行号选填，参见：[银行支行编码](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_yhzhbm) &lt;font color&#x3D;&quot;green&quot;&gt;示例值：102290026507&lt;/font&gt;&lt;br/&gt;对公代发(省份+地区)与联行号信息二选一填入；对私代发非必填；
         */
        private string correspondentCode;
        /**
         * 银行卡用户名
         */
        private string bankAccountName;
        /**
         * 对公对私标识
         */
        private string cardAcctType;
        /**
         * 银行账号密文
         */
        private string bankCardNoCrypt;
        /**
         * 证件号密文
         */
        private string certificateNoCrypt;
        /**
         * 证件类型对私必填，类型&lt;br/&gt;01：身份证&lt;br/&gt;03：护照（国内）&lt;br/&gt;09：外国人居留证&lt;br/&gt;15：港澳台居住证&lt;br/&gt;16：回乡证&lt;br/&gt;17：台胞证&lt;br/&gt;
         */
        private string certificateType;
        /**
         * 手机号密文
         */
        private string mobileNoCrypt;
        /**
         * 到账日期类型
         */
        private string intoAcctDateType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_SETTLEMENT_SURROGATE;
        }

        public V2TradeSettlementSurrogateRequest() {
        }

        public V2TradeSettlementSurrogateRequest(string reqSeqId, string reqDate, string huifuId, string cashAmt, string purposeDesc, string province, string area, string bankCode, string correspondentCode, string bankAccountName, string cardAcctType, string bankCardNoCrypt, string certificateNoCrypt, string certificateType, string mobileNoCrypt, string intoAcctDateType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.cashAmt = cashAmt;
            this.purposeDesc = purposeDesc;
            this.province = province;
            this.area = area;
            this.bankCode = bankCode;
            this.correspondentCode = correspondentCode;
            this.bankAccountName = bankAccountName;
            this.cardAcctType = cardAcctType;
            this.bankCardNoCrypt = bankCardNoCrypt;
            this.certificateNoCrypt = certificateNoCrypt;
            this.certificateType = certificateType;
            this.mobileNoCrypt = mobileNoCrypt;
            this.intoAcctDateType = intoAcctDateType;
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

        public string getPurposeDesc() {
            return purposeDesc;
        }

        public void setPurposeDesc(string purposeDesc) {
            this.purposeDesc = purposeDesc;
        }

        public string getProvince() {
            return province;
        }

        public void setProvince(string province) {
            this.province = province;
        }

        public string getArea() {
            return area;
        }

        public void setArea(string area) {
            this.area = area;
        }

        public string getBankCode() {
            return bankCode;
        }

        public void setBankCode(string bankCode) {
            this.bankCode = bankCode;
        }

        public string getCorrespondentCode() {
            return correspondentCode;
        }

        public void setCorrespondentCode(string correspondentCode) {
            this.correspondentCode = correspondentCode;
        }

        public string getBankAccountName() {
            return bankAccountName;
        }

        public void setBankAccountName(string bankAccountName) {
            this.bankAccountName = bankAccountName;
        }

        public string getCardAcctType() {
            return cardAcctType;
        }

        public void setCardAcctType(string cardAcctType) {
            this.cardAcctType = cardAcctType;
        }

        public string getBankCardNoCrypt() {
            return bankCardNoCrypt;
        }

        public void setBankCardNoCrypt(string bankCardNoCrypt) {
            this.bankCardNoCrypt = bankCardNoCrypt;
        }

        public string getCertificateNoCrypt() {
            return certificateNoCrypt;
        }

        public void setCertificateNoCrypt(string certificateNoCrypt) {
            this.certificateNoCrypt = certificateNoCrypt;
        }

        public string getCertificateType() {
            return certificateType;
        }

        public void setCertificateType(string certificateType) {
            this.certificateType = certificateType;
        }

        public string getMobileNoCrypt() {
            return mobileNoCrypt;
        }

        public void setMobileNoCrypt(string mobileNoCrypt) {
            this.mobileNoCrypt = mobileNoCrypt;
        }

        public string getIntoAcctDateType() {
            return intoAcctDateType;
        }

        public void setIntoAcctDateType(string intoAcctDateType) {
            this.intoAcctDateType = intoAcctDateType;
        }


    }
}
