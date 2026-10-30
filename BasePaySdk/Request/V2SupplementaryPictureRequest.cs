using System;

namespace BasePaySdk.Request
{
    /**
     * 图片上传
     *
     * @author sdk-generator
     * @Description
     */
    public class V2SupplementaryPictureRequest : BaseRequest
    {

        /**
         * 业务请求流水号
         */
        private string reqSeqId;
        /**
         * 业务请求日期
         */
        private string reqDate;
        /**
         * 图片类型
         */
        private string fileType;
        /**
         * 文件url链接文件url链接与file文件流不能同时上传；文件支持类型：JPG,BMP,PNG；单个图片最大支持2M；除去图片外其他类型文件支持10M&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：[https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/imgs/guide/jinjian/%E8%90%A5%E4%B8%9A%E6%89%A7%E7%85%A71-2.png](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/imgs/guide/jinjian/%E8%90%A5%E4%B8%9A%E6%89%A7%E7%85%A71-2.png)
         */
        private string fileUrl;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_SUPPLEMENTARY_PICTURE;
        }

        public V2SupplementaryPictureRequest() {
        }

        public V2SupplementaryPictureRequest(string reqSeqId, string reqDate, string fileType, string fileUrl) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.fileType = fileType;
            this.fileUrl = fileUrl;
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

        public string getFileType() {
            return fileType;
        }

        public void setFileType(string fileType) {
            this.fileType = fileType;
        }

        public string getFileUrl() {
            return fileUrl;
        }

        public void setFileUrl(string fileUrl) {
            this.fileUrl = fileUrl;
        }


    }
}
