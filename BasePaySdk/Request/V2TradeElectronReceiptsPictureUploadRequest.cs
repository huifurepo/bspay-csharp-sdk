using System;

namespace BasePaySdk.Request
{
    /**
     * 图片上传
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeElectronReceiptsPictureUploadRequest : BaseRequest
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
         * 三方通道类型
         */
        private string thirdChannelType;
        /**
         * 文件名称
         */
        private string fileName;
        /**
         * 图片内容
         */
        private string imageContent;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ELECTRON_RECEIPTS_PICTURE_UPLOAD;
        }

        public V2TradeElectronReceiptsPictureUploadRequest() {
        }

        public V2TradeElectronReceiptsPictureUploadRequest(string reqSeqId, string reqDate, string huifuId, string thirdChannelType, string fileName, string imageContent) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.thirdChannelType = thirdChannelType;
            this.fileName = fileName;
            this.imageContent = imageContent;
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

        public string getThirdChannelType() {
            return thirdChannelType;
        }

        public void setThirdChannelType(string thirdChannelType) {
            this.thirdChannelType = thirdChannelType;
        }

        public string getFileName() {
            return fileName;
        }

        public void setFileName(string fileName) {
            this.fileName = fileName;
        }

        public string getImageContent() {
            return imageContent;
        }

        public void setImageContent(string imageContent) {
            this.imageContent = imageContent;
        }


    }
}
