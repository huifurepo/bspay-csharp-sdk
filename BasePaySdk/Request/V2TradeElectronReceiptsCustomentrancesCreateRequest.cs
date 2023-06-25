using System;

namespace BasePaySdk.Request
{
    /**
     * 创建修改小票自定义入口
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeElectronReceiptsCustomentrancesCreateRequest : BaseRequest
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
         * 操作类型
         */
        private string operateType;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_TRADE_ELECTRON_RECEIPTS_CUSTOMENTRANCES_CREATE;
        }

        public V2TradeElectronReceiptsCustomentrancesCreateRequest() {
        }

        public V2TradeElectronReceiptsCustomentrancesCreateRequest(string reqSeqId, string reqDate, string huifuId, string operateType) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.operateType = operateType;
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

        public string getOperateType() {
            return operateType;
        }

        public void setOperateType(string operateType) {
            this.operateType = operateType;
        }


    }
}
