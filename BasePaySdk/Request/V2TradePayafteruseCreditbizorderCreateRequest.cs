using System;

namespace BasePaySdk.Request
{
    /**
     * 服务单创建
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayafteruseCreditbizorderCreateRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;
        /**
         * 订单总金额
         */
        private string transAmt;
        /**
         * 支付宝用户ID
         */
        private string buyerId;
        /**
         * 订单标题
         */
        private string title;
        /**
         * 订单类型
         */
        private string merchantBizType;
        /**
         * 订单详情地址
         */
        private string path;
        /**
         * 芝麻信用服务ID
         */
        private string zmServiceId;
        /**
         * 商品详细信息
         */
        private string itemInfos;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYAFTERUSE_CREDITBIZORDER_CREATE;
        }

        public V2TradePayafteruseCreditbizorderCreateRequest() {
        }

        public V2TradePayafteruseCreditbizorderCreateRequest(string reqSeqId, string reqDate, string huifuId, string transAmt, string buyerId, string title, string merchantBizType, string path, string zmServiceId, string itemInfos) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.transAmt = transAmt;
            this.buyerId = buyerId;
            this.title = title;
            this.merchantBizType = merchantBizType;
            this.path = path;
            this.zmServiceId = zmServiceId;
            this.itemInfos = itemInfos;
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

        public string getTransAmt() {
            return transAmt;
        }

        public void setTransAmt(string transAmt) {
            this.transAmt = transAmt;
        }

        public string getBuyerId() {
            return buyerId;
        }

        public void setBuyerId(string buyerId) {
            this.buyerId = buyerId;
        }

        public string getTitle() {
            return title;
        }

        public void setTitle(string title) {
            this.title = title;
        }

        public string getMerchantBizType() {
            return merchantBizType;
        }

        public void setMerchantBizType(string merchantBizType) {
            this.merchantBizType = merchantBizType;
        }

        public string getPath() {
            return path;
        }

        public void setPath(string path) {
            this.path = path;
        }

        public string getZmServiceId() {
            return zmServiceId;
        }

        public void setZmServiceId(string zmServiceId) {
            this.zmServiceId = zmServiceId;
        }

        public string getItemInfos() {
            return itemInfos;
        }

        public void setItemInfos(string itemInfos) {
            this.itemInfos = itemInfos;
        }


    }
}
