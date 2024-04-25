using System;

namespace BasePaySdk.Request
{
    /**
     * 银行大额支付差错申请查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferBankmistakeApplyqueryRequest : BaseRequest
    {

        /**
         * 商户号
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
        /**
         * 订单类型
         */
        private string orderType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_TRANSFER_BANKMISTAKE_APPLYQUERY;
        }

        public V2TradeOnlinepaymentTransferBankmistakeApplyqueryRequest() {
        }

        public V2TradeOnlinepaymentTransferBankmistakeApplyqueryRequest(string huifuId, string orgReqDate, string orgReqSeqId, string orderType) {
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.orderType = orderType;
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

        public string getOrderType() {
            return orderType;
        }

        public void setOrderType(string orderType) {
            this.orderType = orderType;
        }


    }
}
