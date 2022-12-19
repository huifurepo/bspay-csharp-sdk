using System;

namespace BasePaySdk.Request
{
    /**
     * 出金交易查询接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettlementQueryRequest : BaseRequest
    {

        /**
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 原交易请求日期
         */
        private string orgReqDate;
        /**
         * 原交易返回的全局流水号原交易返回的全局流水号、原交易请求流水号二选一必填；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00470topo1A211015160805P090ac132fef00000&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 原交易请求流水号原交易返回的全局流水号、原交易请求流水号二选一必填；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：202109167745558220003&lt;/font&gt;
         */
        private string orgReqSeqId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_SETTLEMENT_QUERY;
        }

        public V2TradeSettlementQueryRequest() {
        }

        public V2TradeSettlementQueryRequest(string huifuId, string orgReqDate, string orgHfSeqId, string orgReqSeqId) {
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
