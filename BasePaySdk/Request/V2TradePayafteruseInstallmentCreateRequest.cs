using System;

namespace BasePaySdk.Request
{
    /**
     * 分期单创建
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayafteruseInstallmentCreateRequest : BaseRequest
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
         * 分期金额
         */
        private string fqAmt;

        public override string getFunctionCode()
        {
            return FunctionCodeEnum.V2_TRADE_PAYAFTERUSE_INSTALLMENT_CREATE;
        }

        public V2TradePayafteruseInstallmentCreateRequest()
        {
        }

        public V2TradePayafteruseInstallmentCreateRequest(string reqSeqId, string reqDate, string huifuId, string fqAmt)
        {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.fqAmt = fqAmt;
        }

        public string getReqSeqId()
        {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId)
        {
            this.reqSeqId = reqSeqId;
        }

        public string getReqDate()
        {
            return reqDate;
        }

        public void setReqDate(string reqDate)
        {
            this.reqDate = reqDate;
        }

        public string getHuifuId()
        {
            return huifuId;
        }

        public void setHuifuId(string huifuId)
        {
            this.huifuId = huifuId;
        }

        public string getFqAmt()
        {
            return fqAmt;
        }

        public void setFqAmt(string fqAmt)
        {
            this.fqAmt = fqAmt;
        }


    }
}
