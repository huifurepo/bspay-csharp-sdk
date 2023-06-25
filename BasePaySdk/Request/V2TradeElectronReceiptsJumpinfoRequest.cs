using System;

namespace BasePaySdk.Request
{
    /**
     * 跳转电子小票页面
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeElectronReceiptsJumpinfoRequest : BaseRequest
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
         * 商户汇付Id
         */
        private string huifuId;
        /**
         * 原请求日期
         */
        private string orgReqDate;
        /**
         * 原请求流水号原请求流水号、原交易返回的全局流水号至少要送其中一项；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665001&lt;/font&gt;
         */
        private string orgReqSeqId;
        /**
         * 汇付全局流水号原请求流水号、原交易返回的全局流水号至少要送其中一项；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00290TOP1GR210919004230P853ac13262200000&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 票据信息
         */
        private string receiptData;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ELECTRON_RECEIPTS_JUMPINFO;
        }

        public V2TradeElectronReceiptsJumpinfoRequest() {
        }

        public V2TradeElectronReceiptsJumpinfoRequest(string reqSeqId, string reqDate, string huifuId, string orgReqDate, string orgReqSeqId, string orgHfSeqId, string receiptData) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.orgHfSeqId = orgHfSeqId;
            this.receiptData = receiptData;
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

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }

        public string getOrgReqSeqId() {
            return orgReqSeqId;
        }

        public void setOrgReqSeqId(string orgReqSeqId) {
            this.orgReqSeqId = orgReqSeqId;
        }

        public string getOrgHfSeqId() {
            return orgHfSeqId;
        }

        public void setOrgHfSeqId(string orgHfSeqId) {
            this.orgHfSeqId = orgHfSeqId;
        }

        public string getReceiptData() {
            return receiptData;
        }

        public void setReceiptData(string receiptData) {
            this.receiptData = receiptData;
        }


    }
}
