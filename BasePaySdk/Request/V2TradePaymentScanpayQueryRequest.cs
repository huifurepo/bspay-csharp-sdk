using System;

namespace BasePaySdk.Request
{
    /**
     * 交易查询接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentScanpayQueryRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 汇付服务订单号out_order_no,org_hf_seq_id,org_req_seq_id 必填其一；汇付生成的服务订单号；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1234323JKHDFE1243252&lt;/font&gt;
         */
        private string outOrderNo;
        /**
         * 创建服务订单返回的汇付全局流水号out_order_no,org_hf_seq_id,org_req_seq_id 必填其一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00290TOP1GR210919004230P853ac13262200000&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 服务订单创建请求流水号out_order_no,org_hf_seq_id,org_req_seq_id 必填其一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：202110210012100005&lt;/font&gt;
         */
        private string orgReqSeqId;
        /**
         * 原机构请求日期
         */
        private string orgReqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_SCANPAY_QUERY;
        }

        public V2TradePaymentScanpayQueryRequest() {
        }

        public V2TradePaymentScanpayQueryRequest(string huifuId, string outOrderNo, string orgHfSeqId, string orgReqSeqId, string orgReqDate) {
            this.huifuId = huifuId;
            this.outOrderNo = outOrderNo;
            this.orgHfSeqId = orgHfSeqId;
            this.orgReqSeqId = orgReqSeqId;
            this.orgReqDate = orgReqDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getOutOrderNo() {
            return outOrderNo;
        }

        public void setOutOrderNo(string outOrderNo) {
            this.outOrderNo = outOrderNo;
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

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }


    }
}
