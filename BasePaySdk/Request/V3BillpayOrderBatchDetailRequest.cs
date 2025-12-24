using System;

namespace BasePaySdk.Request
{
    /**
     * 查询批量账单数据
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayOrderBatchDetailRequest : BaseRequest
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
         * 账单编号与原创建批量账单数据请求流水号二选一必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：BN2025091279190693&lt;/font&gt;;
         */
        private string billNo;
        /**
         * 原创建批量账单数据请求流水号原创建批量账单数据请求流水号，同一商户号当天唯一；与帐单编号二选一必填
         */
        private string oriReqSeqId;
        /**
         * 原创建批量账单数据请求日期原创建批量账单数据日期格式：yyyyMMdd，以北京时间为准；与帐单编号二选一必填
         */
        private string oriReqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V3_BILLPAY_ORDER_BATCH_DETAIL;
        }

        public V3BillpayOrderBatchDetailRequest() {
        }

        public V3BillpayOrderBatchDetailRequest(string reqSeqId, string reqDate, string huifuId, string billNo, string oriReqSeqId, string oriReqDate) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.billNo = billNo;
            this.oriReqSeqId = oriReqSeqId;
            this.oriReqDate = oriReqDate;
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

        public string getBillNo() {
            return billNo;
        }

        public void setBillNo(string billNo) {
            this.billNo = billNo;
        }

        public string getOriReqSeqId() {
            return oriReqSeqId;
        }

        public void setOriReqSeqId(string oriReqSeqId) {
            this.oriReqSeqId = oriReqSeqId;
        }

        public string getOriReqDate() {
            return oriReqDate;
        }

        public void setOriReqDate(string oriReqDate) {
            this.oriReqDate = oriReqDate;
        }


    }
}
