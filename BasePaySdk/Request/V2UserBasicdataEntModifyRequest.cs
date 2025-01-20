using System;

namespace BasePaySdk.Request
{
    /**
     * 企业用户基本信息修改
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBasicdataEntModifyRequest : BaseRequest
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
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 法人国籍法人的证件类型为外国人居留证时，必填，参见《[国籍编码](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/area/%E5%9B%BD%E7%B1%8D.xlsx)》&lt;font color&#x3D;&quot;green&quot;&gt;示例值：CHN&lt;/font&gt;
         */
        private string legalCertNationality;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_USER_BASICDATA_ENT_MODIFY;
        }

        public V2UserBasicdataEntModifyRequest() {
        }

        public V2UserBasicdataEntModifyRequest(string reqDate, string reqSeqId, string huifuId, string legalCertNationality) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.legalCertNationality = legalCertNationality;
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

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getLegalCertNationality() {
            return legalCertNationality;
        }

        public void setLegalCertNationality(string legalCertNationality) {
            this.legalCertNationality = legalCertNationality;
        }


    }
}
