using System;

namespace BasePaySdk.Request
{
    /**
     * 全渠道订单分账明细操作
     *
     * @author sdk-generator
     * @Description
     */
    public class V2OcoOrderDetailOperateRequest : BaseRequest
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
        /**
         * 操作类型
         */
        private string operateType;
        /**
         * 支付方式枚举：BALANCE-余额支付 EFP-全域资金付款；备注：当operate_type&#x3D;SPLIT 立即分账时，pay_type必填，且若为退款，按原交易类型原路返回；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：BALANCE&lt;/font&gt;
         */
        private string payType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_OCO_ORDER_DETAIL_OPERATE;
        }

        public V2OcoOrderDetailOperateRequest() {
        }

        public V2OcoOrderDetailOperateRequest(string reqSeqId, string reqDate, string huifuId, string busiSource, string ocoOrderId, string operateType, string payType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.busiSource = busiSource;
            this.ocoOrderId = ocoOrderId;
            this.operateType = operateType;
            this.payType = payType;
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

        public string getOperateType() {
            return operateType;
        }

        public void setOperateType(string operateType) {
            this.operateType = operateType;
        }

        public string getPayType() {
            return payType;
        }

        public void setPayType(string payType) {
            this.payType = payType;
        }


    }
}
