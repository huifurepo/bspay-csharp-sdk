using System;

namespace BasePaySdk.Request
{
    /**
     * 代扣绑卡页面版
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleWithholdPageGetRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求时间
         */
        private string reqDate;
        /**
         * 汇付Id
         */
        private string huifuId;
        /**
         * 订单号
         */
        private string orderId;
        /**
         * 订单日期
         */
        private string orderDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_QUICKBUCKLE_WITHHOLD_PAGE_GET;
        }

        public V2QuickbuckleWithholdPageGetRequest() {
        }

        public V2QuickbuckleWithholdPageGetRequest(string reqSeqId, string reqDate, string huifuId, string orderId, string orderDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.orderId = orderId;
            this.orderDate = orderDate;
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

        public string getOrderId() {
            return orderId;
        }

        public void setOrderId(string orderId) {
            this.orderId = orderId;
        }

        public string getOrderDate() {
            return orderDate;
        }

        public void setOrderDate(string orderDate) {
            this.orderDate = orderDate;
        }


    }
}
