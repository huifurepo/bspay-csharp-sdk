using System;

namespace BasePaySdk.Request
{
    /**
     * 新增绑定卡
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletCardAddRequest : BaseRequest
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
         * 商户号
         */
        private string huifuId;
        /**
         * 钱包用户ID
         */
        private string userHuifuId;
        /**
         * 跳转地址
         */
        private string frontUrl;
        /**
         * 设备信息域
         */
        private string trxDeviceInfo ;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_WALLET_CARD_ADD;
        }

        public V2WalletCardAddRequest() {
        }

        public V2WalletCardAddRequest(string reqSeqId, string reqDate, string huifuId, string userHuifuId, string frontUrl, string trxDeviceInfo ) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.userHuifuId = userHuifuId;
            this.frontUrl = frontUrl;
            this.trxDeviceInfo  = trxDeviceInfo ;
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

        public string getUserHuifuId() {
            return userHuifuId;
        }

        public void setUserHuifuId(string userHuifuId) {
            this.userHuifuId = userHuifuId;
        }

        public string getFrontUrl() {
            return frontUrl;
        }

        public void setFrontUrl(string frontUrl) {
            this.frontUrl = frontUrl;
        }

        public string getTrxDeviceInfo () {
            return trxDeviceInfo ;
        }

        public void setTrxDeviceInfo (string trxDeviceInfo ) {
            this.trxDeviceInfo  = trxDeviceInfo ;
        }


    }
}
