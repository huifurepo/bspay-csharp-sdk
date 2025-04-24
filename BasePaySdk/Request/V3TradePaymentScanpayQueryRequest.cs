using System;

namespace BasePaySdk.Request
{
    /**
     * 扫码交易查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradePaymentScanpayQueryRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 原机构请求日期格式为yyyyMMdd，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;；&lt;/br&gt;传入org_hf_seq_id时非必填，其他场景必填；
         */
        private string orgReqDate;
        /**
         * 汇付服务订单号out_ord_id,org_hf_seq_id,org_req_seq_id 必填其一；汇付生成的服务订单号；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1234323JKHDFE1243252&lt;/font&gt;
         */
        private string outOrdId;
        /**
         * 创建服务订单返回的汇付全局流水号out_ord_id,org_hf_seq_id,org_req_seq_id 必填其一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00290TOP1GR210919004230P853ac13262200000&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 服务订单创建请求流水号out_ord_id,org_hf_seq_id,org_req_seq_id 必填其一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：202110210012100005&lt;/font&gt;
         */
        private string orgReqSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_TRADE_PAYMENT_SCANPAY_QUERY;
        }

        public V3TradePaymentScanpayQueryRequest() {
        }

        public V3TradePaymentScanpayQueryRequest(string huifuId, string orgReqDate, string outOrdId, string orgHfSeqId, string orgReqSeqId) {
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.outOrdId = outOrdId;
            this.orgHfSeqId = orgHfSeqId;
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

        public string getOutOrdId() {
            return outOrdId;
        }

        public void setOutOrdId(string outOrdId) {
            this.outOrdId = outOrdId;
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


    }
}
