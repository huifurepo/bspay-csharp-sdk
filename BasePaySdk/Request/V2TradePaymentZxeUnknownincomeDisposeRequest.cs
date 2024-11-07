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
         * 银行侧交易流水号
         */
        private string bankSerialNo;
        /**
         * 操作类型
         */
        private string operateType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_ZXE_UNKNOWNINCOME_DISPOSE;
        }

        public V2TradePaymentZxeUnknownincomeDisposeRequest() {
        }

        public V2TradePaymentZxeUnknownincomeDisposeRequest(string reqSeqId, string reqDate, string huifuId, string bankSerialNo, string operateType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.bankSerialNo = bankSerialNo;
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

        public string getOperateType() {
            return operateType;
        }

        public void setOperateType(string operateType) {
            this.operateType = operateType;
        }


    }
}
