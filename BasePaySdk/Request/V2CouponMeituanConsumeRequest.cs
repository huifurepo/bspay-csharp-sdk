using System;

namespace BasePaySdk.Request
{
    /**
     * 美团卡券核销
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponMeituanConsumeRequest : BaseRequest
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
         * 核销券
         */
        private string receiptCodeInfos;
        /**
         * 登录账号
         */
        private string appShopAccount;
        /**
         * 登录用户名
         */
        private string appShopAccountName;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_COUPON_MEITUAN_CONSUME;
        }

        public V2CouponMeituanConsumeRequest() {
        }

        public V2CouponMeituanConsumeRequest(string reqSeqId, string reqDate, string huifuId, string bindId, string receiptCodeInfos, string appShopAccount, string appShopAccountName) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.bindId = bindId;
            this.receiptCodeInfos = receiptCodeInfos;
            this.appShopAccount = appShopAccount;
            this.appShopAccountName = appShopAccountName;
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

        public string getReceiptCodeInfos() {
            return receiptCodeInfos;
        }

        public void setReceiptCodeInfos(string receiptCodeInfos) {
            this.receiptCodeInfos = receiptCodeInfos;
        }

        public string getAppShopAccount() {
            return appShopAccount;
        }

        public void setAppShopAccount(string appShopAccount) {
            this.appShopAccount = appShopAccount;
        }

        public string getAppShopAccountName() {
            return appShopAccountName;
        }

        public void setAppShopAccountName(string appShopAccountName) {
            this.appShopAccountName = appShopAccountName;
        }


    }
}
