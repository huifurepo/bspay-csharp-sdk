using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 云MIS订单详情查询接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeCloudmisOrderDetailRequestDemo
    {

        public static void V2TradeCloudmisOrderDetailRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeCloudmisOrderDetailRequest request = new V2TradeCloudmisOrderDetailRequest();
            // 原MIS请求商户号
            request.setOrgHuifuId("6666000141203565");
            // 原MIS请求终端号
            request.setOrgDeviceId("310000011015000063677");
            // 原MIS请求日期
            request.setOrgReqDate("20240715");

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
            // 原MIS请求流水号
            extendInfoMap.Add("org_req_id", "reqId20240624091729005");
            // 原MIS请求jsonData中的三方单号
            extendInfoMap.Add("org_third_order_id", "20240313115926539uf7cqcmwxl30");
            return extendInfoMap;
        }

    }
}
