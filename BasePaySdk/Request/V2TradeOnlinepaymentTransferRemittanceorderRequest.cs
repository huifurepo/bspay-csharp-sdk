using System;

namespace BasePaySdk.Request
{
    /**
     * 汇付入账查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferRemittanceorderRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 原请求开始日期
         */
        private string orgReqStartDate;
        /**
         * 原请求结束日期
         */
        private string orgReqEndDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_TRANSFER_REMITTANCEORDER;
        }

        public V2TradeOnlinepaymentTransferRemittanceorderRequest() {
        }

        public V2TradeOnlinepaymentTransferRemittanceorderRequest(string huifuId, string orgReqStartDate, string orgReqEndDate) {
            this.huifuId = huifuId;
            this.orgReqStartDate = orgReqStartDate;
            this.orgReqEndDate = orgReqEndDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getOrgReqStartDate() {
            return orgReqStartDate;
        }

        public void setOrgReqStartDate(string orgReqStartDate) {
            this.orgReqStartDate = orgReqStartDate;
        }

        public string getOrgReqEndDate() {
            return orgReqEndDate;
        }

        public void setOrgReqEndDate(string orgReqEndDate) {
            this.orgReqEndDate = orgReqEndDate;
        }


    }
}
