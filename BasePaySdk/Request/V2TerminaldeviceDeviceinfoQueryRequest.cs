using System;

namespace BasePaySdk.Request
{
    /**
     * 绑定终端信息查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TerminaldeviceDeviceinfoQueryRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求时间
         */
        private string reqDate;
        /**
         * 汇付客户Id
         */
        private string huifuId;
        /**
         * 分页大小
         */
        private string pageSize;
        /**
         * 当前页码
         */
        private string pageNum;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TERMINALDEVICE_DEVICEINFO_QUERY;
        }

        public V2TerminaldeviceDeviceinfoQueryRequest() {
        }

        public V2TerminaldeviceDeviceinfoQueryRequest(string reqSeqId, string reqDate, string huifuId, string pageSize, string pageNum) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.pageSize = pageSize;
            this.pageNum = pageNum;
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

        public string getPageSize() {
            return pageSize;
        }

        public void setPageSize(string pageSize) {
            this.pageSize = pageSize;
        }

        public string getPageNum() {
            return pageNum;
        }

        public void setPageNum(string pageNum) {
            this.pageNum = pageNum;
        }


    }
}
