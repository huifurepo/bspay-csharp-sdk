using System;

namespace BasePaySdk.Request
{
    /**
     * 微信支付宝入驻信息修改
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiAtModifyRequest : BaseRequest
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
         * AT信息修改列表
         */
        private string atRegList;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_AT_MODIFY;
        }

        public V2MerchantBusiAtModifyRequest() {
        }

        public V2MerchantBusiAtModifyRequest(string reqSeqId, string reqDate, string atRegList) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.atRegList = atRegList;
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

        public string getAtRegList() {
            return atRegList;
        }

        public void setAtRegList(string atRegList) {
            this.atRegList = atRegList;
        }


    }
}
