using System;

namespace BasePaySdk.Request
{
    /**
     * 全渠道订单分账接收方查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2OcoOrderDetailListRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;
        /**
         * 分账数据源
         */
        private string busiSource;
        /**
         * 业务订单号
         */
        private string ocoOrderId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_OCO_ORDER_DETAIL_LIST;
        }

        public V2OcoOrderDetailListRequest() {
        }

        public V2OcoOrderDetailListRequest(string reqSeqId, string reqDate, string huifuId, string busiSource, string ocoOrderId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.busiSource = busiSource;
            this.ocoOrderId = ocoOrderId;
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

        public string getBusiSource() {
            return busiSource;
        }

        public void setBusiSource(string busiSource) {
            this.busiSource = busiSource;
        }

        public string getOcoOrderId() {
            return ocoOrderId;
        }

        public void setOcoOrderId(string ocoOrderId) {
            this.ocoOrderId = ocoOrderId;
        }


    }
}
