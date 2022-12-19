using System;

namespace BasePaySdk.Request
{
    /**
     * 线上交易查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentQueryRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 原交易请求日期
         */
        private string orgReqDate;
        /**
         * 原交易返回的全局流水号原交易请求流水号、原交易返回的全局流水号至少要送其中一项；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00290TOP1GR210919004230P853ac13262200000&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 原交易请求流水号原交易请求流水号、原交易返回的全局流水号至少要送其中一项；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665001&lt;/font&gt;
         */
        private string orgReqSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ONLINEPAYMENT_QUERY;
        }

        public V2TradeOnlinepaymentQueryRequest() {
        }

        public V2TradeOnlinepaymentQueryRequest(string huifuId, string orgReqDate, string orgHfSeqId, string orgReqSeqId) {
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
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
