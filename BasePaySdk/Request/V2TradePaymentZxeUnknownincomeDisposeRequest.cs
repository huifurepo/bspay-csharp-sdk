using System;

namespace BasePaySdk.Request
{
    /**
     * 不明来账处理
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentZxeUnknownincomeDisposeRequest : BaseRequest
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
         * 银行侧交易流水号参照异步通知里的bank_serial_no；&lt;br/&gt;“银行侧交易流水号”和“来账银行账号，来账账户名称，交易金额，交易日期”二选一必填。
         */
        private string bankSerialNo;
        /**
         * 来账银行账号需要密文传输，使用汇付RSA公钥加密(加密前64位，加密后最长2048位），参见[参考文档](https://paas.huifu.com/open/doc/guide/#/api_jiami_jiemi)；示例值：Ly+fnExeyPOTzfOtgRRur77nJB9TAe4PGgK9M……fc6XJXZss&#x3D;“银行侧交易流水号”和“来账银行账号，来账账户名称，交易金额，交易日期”二选一必填。
         */
        private string payAcct;
        /**
         * 来账账户名称“银行侧交易流水号”和“来账银行账号，来账账户名称，交易金额，交易日期”二选一必填。
         */
        private string payAcctName;
        /**
         * 交易金额“银行侧交易流水号”和“来账银行账号，来账账户名称，交易金额，交易日期”二选一必填。
         */
        private string transAmt;
        /**
         * 交易日期“银行侧交易流水号”和“来账银行账号，来账账户名称，交易金额，交易日期”二选一必填。
         */
        private string transDate;
        /**
         * 操作类型
         */
        private string operateType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_ZXE_UNKNOWNINCOME_DISPOSE;
        }

        public V2TradePaymentZxeUnknownincomeDisposeRequest() {
        }

        public V2TradePaymentZxeUnknownincomeDisposeRequest(string reqSeqId, string reqDate, string huifuId, string bankSerialNo, string payAcct, string payAcctName, string transAmt, string transDate, string operateType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.bankSerialNo = bankSerialNo;
            this.payAcct = payAcct;
            this.payAcctName = payAcctName;
            this.transAmt = transAmt;
            this.transDate = transDate;
            this.operateType = operateType;
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

        public string getBankSerialNo() {
            return bankSerialNo;
        }

        public void setBankSerialNo(string bankSerialNo) {
            this.bankSerialNo = bankSerialNo;
        }

        public string getPayAcct() {
            return payAcct;
        }

        public void setPayAcct(string payAcct) {
            this.payAcct = payAcct;
        }

        public string getPayAcctName() {
            return payAcctName;
        }

        public void setPayAcctName(string payAcctName) {
            this.payAcctName = payAcctName;
        }

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getTransDate() {
            return transDate;
        }

        public void setTransDate(string transDate) {
            this.transDate = transDate;
        }

        public string getOperateType() {
            return operateType;
        }

        public void setOperateType(string operateType) {
            this.operateType = operateType;
        }


    }
}
