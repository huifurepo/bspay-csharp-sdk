using System;

namespace BasePaySdk.Request
{
    /**
     * 银行大额支付固定转账标识申请接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferFixedflagApplyRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 唯一标识号
         */
        private string uniqueNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_TRANSFER_FIXEDFLAG_APPLY;
        }

        public V2TradeOnlinepaymentTransferFixedflagApplyRequest() {
        }

        public V2TradeOnlinepaymentTransferFixedflagApplyRequest(string huifuId, string reqDate, string reqSeqId, string uniqueNo) {
            this.huifuId = huifuId;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.uniqueNo = uniqueNo;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
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

        public string getUniqueNo() {
            return uniqueNo;
        }

        public void setUniqueNo(string uniqueNo) {
            this.uniqueNo = uniqueNo;
        }


    }
}
