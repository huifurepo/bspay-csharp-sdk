using System;

namespace BasePaySdk.Request
{
    /**
     * 银行大额支付绑卡查询
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LargeamtBindcardQueryRequest : BaseRequest
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
         * 银行卡号密文
         */
        private string cardNo;
        /**
         * 每页条数
         */
        private string pageSize;
        /**
         * 分页页码
         */
        private string pageNum;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_LARGEAMT_BINDCARD_QUERY;
        }

        public V2LargeamtBindcardQueryRequest() {
        }

        public V2LargeamtBindcardQueryRequest(string reqSeqId, string reqDate, string huifuId, string cardNo, string pageSize, string pageNum) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.cardNo = cardNo;
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

        public string getCardNo() {
            return cardNo;
        }

        public void setCardNo(string cardNo) {
            this.cardNo = cardNo;
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
