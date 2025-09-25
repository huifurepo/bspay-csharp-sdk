using System;

namespace BasePaySdk.Request
{
    /**
     * 余额支付
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeAcctpaymentPayRequest : BaseRequest
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
         * 出款方商户号
         */
        private string outHuifuId;
        /**
         * 支付金额
         */
        private string ordAmt;
        /**
         * 分账对象
         */
        private string acctSplitBunch;
        /**
         * 安全信息
         */
        private string riskCheckData;
        /**
         * 资金类型资金类型。支付渠道为中信E管家时，资金类型必填（[详见说明](https://paas.huifu.com/open/doc/api/#/yuer/api_zxegjzllx)）
         */
        private string fundType;
        /**
         * 手续费承担方标识余额支付手续费承担方标识；商户余额支付扣收规则为接口指定承担方时必填！枚举值：&lt;br/&gt;OUT：出款方；&lt;br/&gt;IN：分账接受方。&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：IN&lt;/font&gt;
         */
        private string transFeeTakeFlag;
        /**
         * 核验值verify_type不为空时必填。当verify_type&#x3D;SMS时，填写用户收到的短信验证码
         */
        private string verifyValue;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ACCTPAYMENT_PAY;
        }

        public V2TradeAcctpaymentPayRequest() {
        }

        public V2TradeAcctpaymentPayRequest(string reqSeqId, string reqDate, string outHuifuId, string ordAmt, string acctSplitBunch, string riskCheckData, string fundType, string transFeeTakeFlag, string verifyValue) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.outHuifuId = outHuifuId;
            this.ordAmt = ordAmt;
            this.acctSplitBunch = acctSplitBunch;
            this.riskCheckData = riskCheckData;
            this.fundType = fundType;
            this.transFeeTakeFlag = transFeeTakeFlag;
            this.verifyValue = verifyValue;
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

        public string getOutHuifuId() {
            return outHuifuId;
        }

        public void setOutHuifuId(string outHuifuId) {
            this.outHuifuId = outHuifuId;
        }

        public string getOrdAmt() {
            return ordAmt;
        }

        public void setOrdAmt(string ordAmt) {
            this.ordAmt = ordAmt;
        }

        public string getAcctSplitBunch() {
            return acctSplitBunch;
        }

        public void setAcctSplitBunch(string acctSplitBunch) {
            this.acctSplitBunch = acctSplitBunch;
        }

        public string getRiskCheckData() {
            return riskCheckData;
        }

        public void setRiskCheckData(string riskCheckData) {
            this.riskCheckData = riskCheckData;
        }

        public string getFundType() {
            return fundType;
        }

        public void setFundType(string fundType) {
            this.fundType = fundType;
        }

        public string getTransFeeTakeFlag() {
            return transFeeTakeFlag;
        }

        public void setTransFeeTakeFlag(string transFeeTakeFlag) {
            this.transFeeTakeFlag = transFeeTakeFlag;
        }

        public string getVerifyValue() {
            return verifyValue;
        }

        public void setVerifyValue(string verifyValue) {
            this.verifyValue = verifyValue;
        }


    }
}
