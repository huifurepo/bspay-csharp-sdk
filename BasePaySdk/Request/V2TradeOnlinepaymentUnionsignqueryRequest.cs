using System;

namespace BasePaySdk.Request
{
    /**
     * 银联统一在线收银台签解约查询接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentUnionsignqueryRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 原请求日期
         */
        private string orgReqDate;
        /**
         * 原请求流水号
         */
        private string orgReqSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_UNIONSIGNQUERY;
        }

        public V2TradeOnlinepaymentUnionsignqueryRequest() {
        }

        public V2TradeOnlinepaymentUnionsignqueryRequest(string huifuId, string orgReqDate, string orgReqSeqId) {
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }


    }
}
