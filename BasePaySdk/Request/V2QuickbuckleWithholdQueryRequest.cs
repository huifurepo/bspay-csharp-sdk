using System;

namespace BasePaySdk.Request
{
    /**
     * 代扣绑卡查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleWithholdQueryRequest : BaseRequest
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
         * 客户系统用户id 
         */
        private string outCustId;
        /**
         * 绑卡订单号
         */
        private string orderId;
        /**
         * 绑卡订单日期
         */
        private string orderDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_QUICKBUCKLE_WITHHOLD_QUERY;
        }

        public V2QuickbuckleWithholdQueryRequest() {
        }

        public V2QuickbuckleWithholdQueryRequest(string reqSeqId, string reqDate, string huifuId, string outCustId, string orderId, string orderDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.outCustId = outCustId;
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

        public string getOutCustId() {
            return outCustId;
        }

        public void setOutCustId(string outCustId) {
            this.outCustId = outCustId;
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
