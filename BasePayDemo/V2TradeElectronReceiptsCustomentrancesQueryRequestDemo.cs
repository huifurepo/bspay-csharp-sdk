using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 查询小票自定义入口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeElectronReceiptsCustomentrancesQueryRequestDemo
    {

        public static void V2TradeElectronReceiptsCustomentrancesQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeElectronReceiptsCustomentrancesQueryRequest request = new V2TradeElectronReceiptsCustomentrancesQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000103334211");

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
            // 票据信息
            extendInfoMap.Add("receipt_data", getReceiptDataRucan());
            return extendInfoMap;
        }

        private static object getWxReceiptDataRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 品牌ID
            obj.Add("brand_id", "11");

            return obj;
        }
        private static string getReceiptDataRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 三方通道类型
            obj.Add("third_channel_type", "T");
            // 微信票据信息
            obj.Add("wx_receipt_data", getWxReceiptDataRucan());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
