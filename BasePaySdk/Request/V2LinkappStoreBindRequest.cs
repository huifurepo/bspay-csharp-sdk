using System;

namespace BasePaySdk.Request
{
    /**
     * 三方门店绑定（二阶段）
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LinkappStoreBindRequest : BaseRequest
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
        /**
         * 门店ID
         */
        private string openShopUuid;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_LINKAPP_STORE_BIND;
        }

        public V2LinkappStoreBindRequest() {
        }

        public V2LinkappStoreBindRequest(string reqSeqId, string reqDate, string huifuId, string platformType, string openShopUuid) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.platformType = platformType;
            this.openShopUuid = openShopUuid;
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

        public string getOpenShopUuid() {
            return openShopUuid;
        }

        public void setOpenShopUuid(string openShopUuid) {
            this.openShopUuid = openShopUuid;
        }


    }
}
