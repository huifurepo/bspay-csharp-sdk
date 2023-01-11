using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 批量交易状态查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeTransstatQueryRequestDemo
    {

        public static void V2TradeTransstatQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeTransstatQueryRequest request = new V2TradeTransstatQueryRequest();
            // 商户号
            // request.setHuifuId("test");
            // 页码
            request.setPageNo("1");
            // 页大小
            request.setPageSize("4");
            // 请求日期
            // request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));

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
            // 请求订单
            extendInfoMap.Add("reqseqid_list", "[\"20221108104332293079\",\"20221108104817E93140\",\"20221108104800E93135\",\"20221108112153E93750\",\"20221108133737E96102\"]");
            return extendInfoMap;
        }

    }
}
