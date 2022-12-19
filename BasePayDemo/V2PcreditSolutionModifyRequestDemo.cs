using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 更新花呗分期方案 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2PcreditSolutionModifyRequestDemo
    {

        public static void V2PcreditSolutionModifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2PcreditSolutionModifyRequest request = new V2PcreditSolutionModifyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000110468104");
            // 创建成功后返回的贴息活动方案id
            request.setSolutionId("1515");

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
            // 开发者的应用ID
            extendInfoMap.Add("app_id", "2019090666961966");
            // 花呗分期商家贴息活动名称
            // extendInfoMap.Add("activity_name", "");
            // 活动开始时间
            extendInfoMap.Add("start_time", "2019-07-08 00:00:00");
            // 活动结束时间
            extendInfoMap.Add("end_time", "2029-07-10 00:00:00");
            return extendInfoMap;
        }

    }
}
