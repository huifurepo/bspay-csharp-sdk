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

        public V2TradeCloudmisOrderDetailRequest(string orgHuifuId, string orgDeviceId, string orgReqDate) {
            this.orgHuifuId = orgHuifuId;
            this.orgDeviceId = orgDeviceId;
            this.orgReqDate = orgReqDate;
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
