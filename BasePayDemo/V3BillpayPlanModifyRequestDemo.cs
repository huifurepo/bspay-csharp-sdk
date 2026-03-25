using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 账单计划变更 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayPlanModifyRequestDemo
    {

        public static void V3BillpayPlanModifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3BillpayPlanModifyRequest request = new V3BillpayPlanModifyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000123123123");
            // 账单计划编号
            request.setPlanNo("BP202412270001");

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
            // 账单计划有效期
            extendInfoMap.Add("plan_expire_date", "20251231");
            // 是否发送代扣前短信通知
            extendInfoMap.Add("sms_notify_flag", "Y");
            // 账单计划状态
            extendInfoMap.Add("plan_status", "PROGRESS");
            return extendInfoMap;
        }

    }
}
