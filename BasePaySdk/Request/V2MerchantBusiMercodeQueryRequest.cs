using System;

namespace BasePaySdk.Request
{
    /**
     * 商户微信支付宝ID查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiMercodeQueryRequest : BaseRequest
    {

        /**
         * 汇付ID
         */
        private string huifuId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 入驻通道类型
         */
        private string payWay;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_MERCODE_QUERY;
        }

        public V2MerchantBusiMercodeQueryRequest() {
        }

        public V2MerchantBusiMercodeQueryRequest(string huifuId, string reqDate, string reqSeqId, string payWay) {
            this.huifuId = huifuId;
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.payWay = payWay;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
        }

        public string getPayWay() {
            return payWay;
        }

        public void setPayWay(string payWay) {
            this.payWay = payWay;
        }


    }
}
