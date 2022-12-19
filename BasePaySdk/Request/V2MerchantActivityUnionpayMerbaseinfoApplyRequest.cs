using System;

namespace BasePaySdk.Request
{
    /**
     * 银联活动商户入驻
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantActivityUnionpayMerbaseinfoApplyRequest : BaseRequest
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
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 商户类型
         */
        private string merType;
        /**
         * 经营类型
         */
        private string dealType;
        /**
         * 所属行业（MCC）MERCHANT_01-自然人 需要传入，参考[银联MCC编码](https://paas.huifu.com/partners/api/#/csfl/api_csfl_ylmccbm) ；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：5311&lt;/font&gt;
         */
        private string mcc;
        /**
         * 负责人手机号
         */
        private string legalMobile;
        /**
         * 联系人身份证号
         */
        private string contractIdNo;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_ACTIVITY_UNIONPAY_MERBASEINFO_APPLY;
        }

        public V2MerchantActivityUnionpayMerbaseinfoApplyRequest() {
        }

        public V2MerchantActivityUnionpayMerbaseinfoApplyRequest(string reqSeqId, string reqDate, string huifuId, string merType, string dealType, string mcc, string legalMobile, string contractIdNo) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.merType = merType;
            this.dealType = dealType;
            this.mcc = mcc;
            this.legalMobile = legalMobile;
            this.contractIdNo = contractIdNo;
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

        public string getMerType() {
            return merType;
        }

        public void setMerType(string merType) {
            this.merType = merType;
        }

        public string getDealType() {
            return dealType;
        }

        public void setDealType(string dealType) {
            this.dealType = dealType;
        }

        public string getMcc() {
            return mcc;
        }

        public void setMcc(string mcc) {
            this.mcc = mcc;
        }

        public string getLegalMobile() {
            return legalMobile;
        }

        public void setLegalMobile(string legalMobile) {
            this.legalMobile = legalMobile;
        }

        public string getContractIdNo() {
            return contractIdNo;
        }

        public void setContractIdNo(string contractIdNo) {
            this.contractIdNo = contractIdNo;
        }


    }
}
