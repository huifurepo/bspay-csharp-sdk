using System;

namespace BasePaySdk.Request
{
    /**
     * 抖音券状态批量查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponDouyinCertificateQueryRequest : BaseRequest
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
         * 门店绑定流水号
         */
        private string bindId;
        /**
         * 验券准备接口返回的加密券码encrypted_code和order_id二选一必传，encrypted_code和order_id不能同时传入
         */
        private string encryptedCode;
        /**
         * 订单id验券准备等接口获得，encrypted_code和order_id二选一必传，encrypted_code和order_id不能同时传入
         */
        private string orderId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_COUPON_DOUYIN_CERTIFICATE_QUERY;
        }

        public V2CouponDouyinCertificateQueryRequest() {
        }

        public V2CouponDouyinCertificateQueryRequest(string reqSeqId, string reqDate, string huifuId, string bindId, string encryptedCode, string orderId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.bindId = bindId;
            this.encryptedCode = encryptedCode;
            this.orderId = orderId;
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

        public string getBindId() {
            return bindId;
        }

        public void setBindId(string bindId) {
            this.bindId = bindId;
        }

        public string getEncryptedCode() {
            return encryptedCode;
        }

        public void setEncryptedCode(string encryptedCode) {
            this.encryptedCode = encryptedCode;
        }

        public string getOrderId() {
            return orderId;
        }

        public void setOrderId(string orderId) {
            this.orderId = orderId;
        }


    }
}
