using System;

namespace BasePaySdk.Request
{
    /**
     * 新增归集配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettleCollectionRuleAddRequest : BaseRequest
    {

        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 转入方商户号
         */
        private string inHuifuId;
        /**
         * 转出方商户号
         */
        private string outHuifuId;
        /**
         * 签约人手机号协议类型为电子协议时必填，必须为法人手机号。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：13911111111&lt;/font&gt;
         */
        private string signUserMobileNo;
        /**
         * 协议文件Id协议类型为纸质协议时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;
         */
        private string fileId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_SETTLE_COLLECTION_RULE_ADD;
        }

        public V2TradeSettleCollectionRuleAddRequest() {
        }

        public V2TradeSettleCollectionRuleAddRequest(string reqDate, string reqSeqId, string inHuifuId, string outHuifuId, string signUserMobileNo, string fileId) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.inHuifuId = inHuifuId;
            this.outHuifuId = outHuifuId;
            this.signUserMobileNo = signUserMobileNo;
            this.fileId = fileId;
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

        public string getInHuifuId() {
            return inHuifuId;
        }

        public void setInHuifuId(string inHuifuId) {
            this.inHuifuId = inHuifuId;
        }

        public string getOutHuifuId() {
            return outHuifuId;
        }

        public void setOutHuifuId(string outHuifuId) {
            this.outHuifuId = outHuifuId;
        }

        public string getSignUserMobileNo() {
            return signUserMobileNo;
        }

        public void setSignUserMobileNo(string signUserMobileNo) {
            this.signUserMobileNo = signUserMobileNo;
        }

        public string getFileId() {
            return fileId;
        }

        public void setFileId(string fileId) {
            this.fileId = fileId;
        }


    }
}
