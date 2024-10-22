using System;

namespace BasePaySdk.Request
{
    /**
     * 分期交易退款
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayafteruseInstallmentRefundRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;
        /**
         * 申请退款金额
         */
        private string ordAmt;

        public override string getFunctionCode()
        {
            return FunctionCodeEnum.V2_TRADE_PAYAFTERUSE_INSTALLMENT_REFUND;
        }

        public V2TradePayafteruseInstallmentRefundRequest()
        {
        }

        public V2TradePayafteruseInstallmentRefundRequest(string reqDate, string reqSeqId, string huifuId, string ordAmt)
        {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.ordAmt = ordAmt;
        }

        public string getReqDate()
        {
            return reqDate;
        }

        public void setReqDate(string reqDate)
        {
            this.reqDate = reqDate;
        }

        public string getReqSeqId()
        {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId)
        {
            this.reqSeqId = reqSeqId;
        }

        public string getHuifuId()
        {
            return huifuId;
        }

        public void setHuifuId(string huifuId)
        {
            this.huifuId = huifuId;
        }

        public string getOrdAmt()
        {
            return ordAmt;
        }

        public void setOrdAmt(string ordAmt)
        {
            this.ordAmt = ordAmt;
        }


    }
}
