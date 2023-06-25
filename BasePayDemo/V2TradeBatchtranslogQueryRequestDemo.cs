using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 批量出金交易查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeBatchtranslogQueryRequestDemo
    {

        public static void V2TradeBatchtranslogQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeBatchtranslogQueryRequest request = new V2TradeBatchtranslogQueryRequest();
            // 商户号
            request.setHuifuId("6666000000041651");
            // 开始日期
            request.setBeginDate("20230315");
            // 结束日期
            request.setEndDate("20230316");

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
            // 交易类型
            extendInfoMap.Add("batch_trans_type", "");
            // 分页页码
            extendInfoMap.Add("page_num", "1");
            // 分页条数
            extendInfoMap.Add("page_size", "10");
            return extendInfoMap;
        }

    }
}
