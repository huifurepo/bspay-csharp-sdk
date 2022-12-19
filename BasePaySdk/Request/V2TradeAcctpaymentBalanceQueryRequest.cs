using System;

namespace BasePaySdk.Request
{
    /**
     * 账户余额信息查询接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeAcctpaymentBalanceQueryRequest : BaseRequest
    {

        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 商户号
         */
        private string huifuId;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ACCTPAYMENT_BALANCE_QUERY;
        }

        public V2TradeAcctpaymentBalanceQueryRequest() {
        }

        public V2TradeAcctpaymentBalanceQueryRequest(string reqDate, string huifuId) {
            this.reqDate = reqDate;
            this.huifuId = huifuId;
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
