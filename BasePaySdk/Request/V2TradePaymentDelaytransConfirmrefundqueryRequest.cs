using System;

namespace BasePaySdk.Request
{
    /**
     * 交易确认退款查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentDelaytransConfirmrefundqueryRequest : BaseRequest
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
         * 原交易请求流水号指交易确认请求流水号，org_req_seq_id和org_hf_seq_id二选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665002&lt;/font&gt;
         */
        private string orgReqSeqId;
        /**
         * 原退款全局流水号原交易确认退款全局流水号。org_req_seq_id和org_hf_seq_id二选一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：003500TOP2B211021163242P447ac132fd200000&lt;/font&gt;
         */
        private string orgHfSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_DELAYTRANS_CONFIRMREFUNDQUERY;
        }

        public V2TradePaymentDelaytransConfirmrefundqueryRequest() {
        }

        public V2TradePaymentDelaytransConfirmrefundqueryRequest(string huifuId, string orgReqDate, string orgReqSeqId, string orgHfSeqId) {
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.orgHfSeqId = orgHfSeqId;
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

        public string getOrgHfSeqId() {
            return orgHfSeqId;
        }

        public void setOrgHfSeqId(string orgHfSeqId) {
            this.orgHfSeqId = orgHfSeqId;
        }


    }
}
