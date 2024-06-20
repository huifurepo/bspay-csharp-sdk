using System;

namespace BasePaySdk.Request
{
    /**
     * 全渠道资金管理配置查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiEfpdetailRequest : BaseRequest
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
         * 银行类型
         */
        private string outFundsGateId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_EFPDETAIL;
        }

        public V2MerchantBusiEfpdetailRequest() {
        }

        public V2MerchantBusiEfpdetailRequest(string reqSeqId, string reqDate, string huifuId, string outFundsGateId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.outFundsGateId = outFundsGateId;
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

        public string getOutFundsGateId() {
            return outFundsGateId;
        }

        public void setOutFundsGateId(string outFundsGateId) {
            this.outFundsGateId = outFundsGateId;
        }


    }
}
