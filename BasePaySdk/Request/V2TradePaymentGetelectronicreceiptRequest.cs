using System;

namespace BasePaySdk.Request
{
    /**
     * 电子回单查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentGetelectronicreceiptRequest : BaseRequest
    {

        /**
         * 商户号
         */
        private string huifuId;
        /**
         * 是否展示手续费0:不展示手续费，1:展示手续费；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0&lt;/font&gt;&lt;br/&gt;模板类型1或2时必填；
         */
        private string showFeemat;
        /**
         * 交易返回的全局流水号1、交易类返回的全局流水号。org_hf_seq_id与（org_req_seq_id、org_req_date、pay_type） 不能同时为空；&lt;br/&gt;2、结算（SETTLE）返回的结算流水编号&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：003500TOP2B211021163242P447ac132fd200000&lt;/font&gt;
         */
        private string orgHfSeqId;
        /**
         * 原交易请求日期格式:yyyyMMdd；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20221022&lt;/font&gt;
         */
        private string orgReqDate;
        /**
         * 原交易请求流水号org_hf_seq_id与（org_req_seq_id、org_req_date、pay_type） 不能同时为空；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2022012614120615001&lt;/font&gt;
         */
        private string orgReqSeqId;
        /**
         * 支付类型BALANCE_PAY：余额支付，&lt;br/&gt;CASHOUT：取现，&lt;br/&gt;QUICK_PAY：快捷支付，&lt;br/&gt;ONLINE_PAY：网银，&lt;br/&gt;SURROGATE：代发&lt;br/&gt;WITHHOLD_PAY：代扣&lt;br/&gt;WAP_PAY：手机WAP&lt;br/&gt;PAY_CONFIRM：交易确认&lt;br/&gt;TRANSFER_ACCT：大额转账(指[银行大额转账](https://paas.huifu.com/open/doc/api/#/dejy/api_dejy_yhdezz)交易)&lt;br/&gt;T_MICROPAY: 微信反扫&lt;br/&gt;A_MICROPAY: 支付宝反扫&lt;br/&gt;T_JSAPI: 微信公众号支付&lt;br/&gt;T_MINIAPP: 微信小程序支付&lt;br/&gt;T_APP：微信APP支付&lt;br/&gt;A_JSAPI: 支付宝JS支付&lt;br/&gt;A_NATIVE: 支付宝正扫支付&lt;br/&gt;T_H5：微信直连H5支付&lt;br/&gt;SETTLE：结算&lt;br/&gt;JDBT：京东白条&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：ONLINE_PAY&lt;/font&gt;&lt;br/&gt;注意：支付类型有值，原交易请求流水号不为空必填； &lt;br/&gt;选择交易确认类型时：请传入交易确认的请求流水号或全局流水号。&lt;br/&gt;模板类型为3、4时，忽略支付类型取值；
         */
        private string payType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_PAYMENT_GETELECTRONICRECEIPT;
        }

        public V2TradePaymentGetelectronicreceiptRequest() {
        }

        public V2TradePaymentGetelectronicreceiptRequest(string huifuId, string showFeemat, string orgHfSeqId, string orgReqDate, string orgReqSeqId, string payType) {
            this.huifuId = huifuId;
            this.showFeemat = showFeemat;
            this.orgHfSeqId = orgHfSeqId;
            this.orgReqDate = orgReqDate;
            this.orgReqSeqId = orgReqSeqId;
            this.payType = payType;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getShowFeemat() {
            return showFeemat;
        }

        public void setShowFeemat(string showFeemat) {
            this.showFeemat = showFeemat;
        }

        public string getOrgHfSeqId() {
            return orgHfSeqId;
        }

        public void setOrgHfSeqId(string orgHfSeqId) {
            this.orgHfSeqId = orgHfSeqId;
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

        public string getPayType() {
            return payType;
        }

        public void setPayType(string payType) {
            this.payType = payType;
        }


    }
}
