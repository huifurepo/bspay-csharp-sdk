using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 汇付入账查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferRemittanceorderRequestDemo
    {

        public static void V2TradeOnlinepaymentTransferRemittanceorderRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentTransferRemittanceorderRequest request = new V2TradeOnlinepaymentTransferRemittanceorderRequest();
            // 商户号
            request.setHuifuId("6666000003100615");
            // 原请求开始日期
            request.setOrgReqStartDate("20230110");
            // 原请求结束日期
            request.setOrgReqEndDate("20230110");

            // 设置非必填字段
            Dictionary<string, object> extendInfoMap = getExtendInfos();
            request.setExtendInfo(extendInfoMap);

            try {
                // 3. 发起API调用
                // 调用接口,使用默认商户配置时可省略配置key
                Dictionary<string, Object> result = null;
                result = BasePayClient.postRequest(request,null);
                // 使用指定配置调用接口
                // result = BasePayClient.postRequest(request,null,"merchantKey2");
                Console.WriteLine(JsonConvert.SerializeObject(result));
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        /**
         * 非必填字段
         * @return
         */
        private static Dictionary<string, object> getExtendInfos() {
            // 设置非必填字段
            Dictionary<string, object> extendInfoMap = new Dictionary<string, object>();
            // 原请求流水号
            extendInfoMap.Add("org_req_seq_id", "20230110155433defaultit655128593");
            // 原请求日期
            extendInfoMap.Add("org_req_date", "20230110");
            // 原汇款订单号
            extendInfoMap.Add("org_remittance_order_id", "20230110155433defaultit655128591");
            // 每页条数
            extendInfoMap.Add("page_size", "1");
            // 分页页码
            extendInfoMap.Add("page_no", "1");
            return extendInfoMap;
        }

    }
}
