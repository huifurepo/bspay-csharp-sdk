using System;

namespace BasePaySdk.Request
{
    /**
     * 提现记录查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LlaDywithdrawQueryRequest : BaseRequest
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
         * 代运营汇付id
         */
        private string agencyHuifuId;
        /**
         * 商家汇付id
         */
        private string merchantHuifuId;
        /**
         * 平台
         */
        private string platformType;
        /**
         * 提现发起开始日期
         */
        private string startDate;
        /**
         * 查询游标
         */
        private string cursor;
        /**
         * 页大小
         */
        private string size;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_LLA_DYWITHDRAW_QUERY;
        }

        public V2LlaDywithdrawQueryRequest() {
        }

        public V2LlaDywithdrawQueryRequest(string reqSeqId, string reqDate, string agencyHuifuId, string merchantHuifuId, string platformType, string startDate, string cursor, string size) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.agencyHuifuId = agencyHuifuId;
            this.merchantHuifuId = merchantHuifuId;
            this.platformType = platformType;
            this.startDate = startDate;
            this.cursor = cursor;
            this.size = size;
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

        public string getAgencyHuifuId() {
            return agencyHuifuId;
        }

        public void setAgencyHuifuId(string agencyHuifuId) {
            this.agencyHuifuId = agencyHuifuId;
        }

        public string getMerchantHuifuId() {
            return merchantHuifuId;
        }

        public void setMerchantHuifuId(string merchantHuifuId) {
            this.merchantHuifuId = merchantHuifuId;
        }

        public string getPlatformType() {
            return platformType;
        }

        public void setPlatformType(string platformType) {
            this.platformType = platformType;
        }

        public string getStartDate() {
            return startDate;
        }

        public void setStartDate(string startDate) {
            this.startDate = startDate;
        }

        public string getCursor() {
            return cursor;
        }

        public void setCursor(string cursor) {
            this.cursor = cursor;
        }

        public string getSize() {
            return size;
        }

        public void setSize(string size) {
            this.size = size;
        }


    }
}
