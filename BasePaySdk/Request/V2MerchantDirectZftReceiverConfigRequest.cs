using System;

namespace BasePaySdk.Request
{
    /**
     * 直付通分账关系绑定解绑
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectZftReceiverConfigRequest : BaseRequest
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
         * 分账开关
         */
        private string splitFlag;
        /**
         * 分账接收方列表
         */
        private string zftSplitReceiverList;
        /**
         * 状态
         */
        private string status;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_DIRECT_ZFT_RECEIVER_CONFIG;
        }

        public V2MerchantDirectZftReceiverConfigRequest() {
        }

        public V2MerchantDirectZftReceiverConfigRequest(string reqSeqId, string reqDate, string huifuId, string appId, string splitFlag, string zftSplitReceiverList, string status) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.appId = appId;
            this.splitFlag = splitFlag;
            this.zftSplitReceiverList = zftSplitReceiverList;
            this.status = status;
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

        public string getSplitFlag() {
            return splitFlag;
        }

        public void setSplitFlag(string splitFlag) {
            this.splitFlag = splitFlag;
        }

        public string getZftSplitReceiverList() {
            return zftSplitReceiverList;
        }

        public void setZftSplitReceiverList(string zftSplitReceiverList) {
            this.zftSplitReceiverList = zftSplitReceiverList;
        }

        public string getStatus() {
            return status;
        }

        public void setStatus(string status) {
            this.status = status;
        }


    }
}
