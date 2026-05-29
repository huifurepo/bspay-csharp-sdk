using System;

namespace BasePaySdk.Request
{
    /**
     * 开票员查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceClerkListQueryRequest : BaseRequest
    {

        /**
         * 汇付商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_INVOICE_CLERK_LIST_QUERY;
        }

        public V2InvoiceClerkListQueryRequest() {
        }

        public V2InvoiceClerkListQueryRequest(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }


    }
}
