using System;

namespace BasePaySdk.Request
{
    /**
     * 商户业务开通修改
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiModifyRequest : BaseRequest
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
         * *线上业务类型编码*开通快捷、网银、余额支付Pro版、银行大额转账、分账比例&gt;30%、代扣必填；参见[线上业务类型编码及补充材料说明](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/kyc/KYC-%E7%BA%BF%E4%B8%8A%E4%B8%9A%E5%8A%A1%E7%B1%BB%E5%9E%8B%E7%BC%96%E7%A0%81%E5%8F%8A%E8%A1%A5%E5%85%85%E6%9D%90%E6%96%99%E8%AF%B4%E6%98%8E.xlsx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：H7999AL&lt;/font&gt;
         */
        private string onlineBusiType;
        /**
         * 签约人jsonObject字符串；agreement_info中选择电子签约时必填；个人商户填本人信息。
         */
        private string signUserInfo;
        /**
         * 代扣场景withhold_flag开通需填写 1:权益投流(订阅),2:非权益投流(订阅),3:保险缴纳,4:道路通行费(ETC),5:公共事业(水电煤)缴费,6:物业缴费
         */
        private string withholdPayScene;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_MODIFY;
        }

        public V2MerchantBusiModifyRequest() {
        }

        public V2MerchantBusiModifyRequest(string reqSeqId, string reqDate, string huifuId, string onlineBusiType, string signUserInfo, string withholdPayScene) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.onlineBusiType = onlineBusiType;
            this.signUserInfo = signUserInfo;
            this.withholdPayScene = withholdPayScene;
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

        public string getOnlineBusiType() {
            return onlineBusiType;
        }

        public void setOnlineBusiType(string onlineBusiType) {
            this.onlineBusiType = onlineBusiType;
        }

        public string getSignUserInfo() {
            return signUserInfo;
        }

        public void setSignUserInfo(string signUserInfo) {
            this.signUserInfo = signUserInfo;
        }

        public string getWithholdPayScene() {
            return withholdPayScene;
        }

        public void setWithholdPayScene(string withholdPayScene) {
            this.withholdPayScene = withholdPayScene;
        }


    }
}
