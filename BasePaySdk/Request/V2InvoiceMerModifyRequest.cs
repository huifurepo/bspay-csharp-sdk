using System;

namespace BasePaySdk.Request
{
    /**
     * 商户注册信息修改
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceMerModifyRequest : BaseRequest
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
         * 开票方汇付ID
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_MER_MODIFY;
        }

        public V2InvoiceMerModifyRequest() {
        }

        public V2InvoiceMerModifyRequest(string reqSeqId, string reqDate, string huifuId) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
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


    }
}
