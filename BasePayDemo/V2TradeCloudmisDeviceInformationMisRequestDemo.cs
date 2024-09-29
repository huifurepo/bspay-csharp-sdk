using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 终端云MIS接入 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeCloudmisDeviceInformationMisRequestDemo
    {

        public static void V2TradeCloudmisDeviceInformationMisRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeCloudmisDeviceInformationMisRequest request = new V2TradeCloudmisDeviceInformationMisRequest();
            // 终端设备号
            request.setDeviceId("310000011015000063677");
            // 商户号
            request.setHuifuId("6666000141203565");
            // 交易信息
            request.setJsonData("{\"transAmount\":\"11\",\"interfaceType\":\"SALE\",\"bgRetUrl\":\"virgo://https://shop.91lpp.com/api/common/huifu/posCallback\",\"thirdOrderId\":\"20240313115926539uf7cqcmwxl30\" }");

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
            return extendInfoMap;
        }

    }
}
