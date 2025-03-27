using System;

namespace BasePaySdk.Request
{
    /**
     * 钱包交易查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradeQueryRequest : BaseRequest
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
         * 原交易请求流水号
         */
        private string orgReqSeqId;
        /**
         * 交易类型
         */
        private string transType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_TRADE_QUERY;
        }

        public V2WalletTradeQueryRequest() {
        }

        public V2WalletTradeQueryRequest(string huifuId, string orgReqDate, string orgReqSeqId, string transType) {
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.transType = transType;
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

        public string getTransType() {
            return transType;
        }

        public void setTransType(string transType) {
            this.transType = transType;
        }


    }
}
