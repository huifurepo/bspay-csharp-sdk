using System;

namespace BasePaySdk.Request
{
    /**
     * 直付通分账关系查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectZftReceiverQueryRequest : BaseRequest
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
         * 汇付ID
         */
        private string huifuId;
        /**
         * 开发者的应用ID
         */
        private string appId;
        /**
         * 每页数目
         */
        private string pageSize;
        /**
         * 页数
         */
        private string pageNum;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_ZFT_RECEIVER_QUERY;
        }

        public V2MerchantDirectZftReceiverQueryRequest() {
        }

        public V2MerchantDirectZftReceiverQueryRequest(string reqSeqId, string reqDate, string huifuId, string appId, string pageSize, string pageNum) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.appId = appId;
            this.pageSize = pageSize;
            this.pageNum = pageNum;
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

        public string getAppId() {
            return appId;
        }

        public void setAppId(string appId) {
            this.appId = appId;
        }

        public string getPageSize() {
            return pageSize;
        }

        public void setPageSize(string pageSize) {
            this.pageSize = pageSize;
        }

        public string getPageNum() {
            return pageNum;
        }

        public void setPageNum(string pageNum) {
            this.pageNum = pageNum;
        }


    }
}
