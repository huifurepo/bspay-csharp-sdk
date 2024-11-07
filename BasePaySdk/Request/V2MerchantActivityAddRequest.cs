using System;

namespace BasePaySdk.Request
{
    /**
     * 商户活动报名
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantActivityAddRequest : BaseRequest
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
         * 营业执照图片调用[图片上传接口](http://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)获取jfile文件id；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;&lt;br/&gt;活动类型为支付宝谷雨活动时无需填写任何资料
         */
        private string blPhoto;
        /**
         * 店内环境图片参加教育食堂、非校园餐饮、非盈利、停车缴费行业时必传；调用[图片上传接口](http://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)获取jfile文件id；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;&lt;br/&gt;活动类型为支付宝谷雨活动时无需填写任何资料
         */
        private string dhPhoto;
        /**
         * 手续费类型
         */
        private string feeType;
        /**
         * 整体门面图片（门头照）参加教育食堂行业、非校园餐饮、非盈利、线下教培、公办医院、商业医疗时必传；调用[图片上传接口](http://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)获取jfile文件id；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;&lt;br/&gt;活动类型为支付宝谷雨活动时无需填写任何资料
         */
        private string mmPhoto;
        /**
         * 收银台照片参加教育食堂行业、线下教培、公办医院时必传；调用[图片上传接口](http://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)获取jfile文件id；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;&lt;br/&gt;活动类型为支付宝谷雨活动时无需填写任何资料
         */
        private string sytPhoto;
        /**
         * 支付通道
         */
        private string payWay;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_ACTIVITY_ADD;
        }

        public V2MerchantActivityAddRequest() {
        }

        public V2MerchantActivityAddRequest(string reqDate, string reqSeqId, string huifuId, string blPhoto, string dhPhoto, string feeType, string mmPhoto, string sytPhoto, string payWay) {
            this.reqDate = reqDate;
            this.reqSeqId = reqSeqId;
            this.huifuId = huifuId;
            this.blPhoto = blPhoto;
            this.dhPhoto = dhPhoto;
            this.feeType = feeType;
            this.mmPhoto = mmPhoto;
            this.sytPhoto = sytPhoto;
            this.payWay = payWay;
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

        public string getBlPhoto() {
            return blPhoto;
        }

        public void setBlPhoto(string blPhoto) {
            this.blPhoto = blPhoto;
        }

        public string getDhPhoto() {
            return dhPhoto;
        }

        public void setDhPhoto(string dhPhoto) {
            this.dhPhoto = dhPhoto;
        }

        public string getFeeType() {
            return feeType;
        }

        public void setFeeType(string feeType) {
            this.feeType = feeType;
        }

        public string getMmPhoto() {
            return mmPhoto;
        }

        public void setMmPhoto(string mmPhoto) {
            this.mmPhoto = mmPhoto;
        }

        public string getSytPhoto() {
            return sytPhoto;
        }

        public void setSytPhoto(string sytPhoto) {
            this.sytPhoto = sytPhoto;
        }

        public string getPayWay() {
            return payWay;
        }

        public void setPayWay(string payWay) {
            this.payWay = payWay;
        }


    }
}
