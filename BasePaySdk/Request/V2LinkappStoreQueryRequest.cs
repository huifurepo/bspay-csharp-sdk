using System;

namespace BasePaySdk.Request
{
    /**
     * 门店绑定列表查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LinkappStoreQueryRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 汇付商户号
         */
        private string huifuId;
        /**
         * 平台类型
         */
        private string platformType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_LINKAPP_STORE_QUERY;
        }

        public V2LinkappStoreQueryRequest() {
        }

        public V2LinkappStoreQueryRequest(string reqSeqId, string reqDate, string huifuId, string platformType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.platformType = platformType;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getPlatformType() {
            return platformType;
        }

        public void setPlatformType(string platformType) {
            this.platformType = platformType;
        }


    }
}
