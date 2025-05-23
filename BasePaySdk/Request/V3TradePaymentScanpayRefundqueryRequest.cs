using System;

namespace BasePaySdk.Request
{
    /**
     * 扫码交易退款查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradePaymentScanpayRefundqueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 退款请求日期退款发生的日期，格式为yyyyMMdd，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220925&lt;/font&gt;；&lt;/br&gt;传入退款全局流水号时，非必填，其他场景必填；
         */
        private string orgReqDate;
        /**
         * 退款全局流水号退款请求流水号,退款全局流水号,终端订单号三选一不能都为空；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0030default220825182711P099ac1f343f00000&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 退款请求流水号退款请求流水号,退款全局流水号,终端订单号三选一不能都为空；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：202110210012100005&lt;/font&gt;
         */
        private string orgReqSeqId;
        /**
         * 终端订单号退款请求流水号,退款全局流水号,终端订单号三选一不能都为空；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：16672670833524393&lt;/font&gt;
         */
        private string merOrdId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_TRADE_PAYMENT_SCANPAY_REFUNDQUERY;
        }

        public V3TradePaymentScanpayRefundqueryRequest() {
        }

        public V3TradePaymentScanpayRefundqueryRequest(string huifuId, string orgReqDate, string orgHfSeqId, string orgReqSeqId, string merOrdId) {
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.orgHfSeqId = orgHfSeqId;
            this.orgReqSeqId = orgReqSeqId;
            this.merOrdId = merOrdId;
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

        public string getOrgHfSeqId() {
            return orgHfSeqId;
        }

        public void setOrgHfSeqId(string orgHfSeqId) {
            this.orgHfSeqId = orgHfSeqId;
        }

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getMerOrdId() {
            return merOrdId;
        }

        public void setMerOrdId(string merOrdId) {
            this.merOrdId = merOrdId;
        }


    }
}
