using System;

namespace BasePaySdk.Request
{
    /**
     * 云MIS订单详情查询接口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeCloudmisOrderDetailRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqId;
        /**
         * 原MIS请求的交易订单号
         */
        private string orgThirdOrderId;
        /**
         * 原MIS请求商户号
         */
        private string orgHuifuId;
        /**
         * 原MIS请求终端号
         */
        private string orgDeviceId;
        /**
         * 原MIS请求日期
         */
        private string orgReqDate;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_CLOUDMIS_ORDER_DETAIL;
        }

        public V2TradeCloudmisOrderDetailRequest() {
        }

        public V2TradeCloudmisOrderDetailRequest(string reqId, string orgThirdOrderId, string orgHuifuId, string orgDeviceId, string orgReqDate) {
            this.reqId = reqId;
            this.orgThirdOrderId = orgThirdOrderId;
            this.orgHuifuId = orgHuifuId;
            this.orgDeviceId = orgDeviceId;
            this.orgReqDate = orgReqDate;
        }

        public string getReqId() {
            return reqId;
        }

        public void setReqId(string reqId) {
            this.reqId = reqId;
        }

        public string getOrgThirdOrderId() {
            return orgThirdOrderId;
        }

        public void setOrgThirdOrderId(string orgThirdOrderId) {
            this.orgThirdOrderId = orgThirdOrderId;
        }

        public string getOrgHuifuId() {
            return orgHuifuId;
        }

        public void setOrgHuifuId(string orgHuifuId) {
            this.orgHuifuId = orgHuifuId;
        }

        public string getOrgDeviceId() {
            return orgDeviceId;
        }

        public void setOrgDeviceId(string orgDeviceId) {
            this.orgDeviceId = orgDeviceId;
        }

        public string getOrgReqDate() {
            return orgReqDate;
        }

        public void setOrgReqDate(string orgReqDate) {
            this.orgReqDate = orgReqDate;
        }


    }
}
