using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 个人签约发起 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2HycPersonsignCreateRequestDemo
    {

        public static void V2HycPersonsignCreateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2HycPersonsignCreateRequest request = new V2HycPersonsignCreateRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 用户汇付id
            request.setHuifuId("6666000145962643");
            // 落地公司机构号
            request.setMinorAgentId("L20231113140106443");
            // 乐接活请求参数jsonObject格式 合作平台为乐接活时必传
            // request.setLjhData(get994c979bC5cb4a098e051ddeb2fdcf26());

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
            // 合作平台
            // extendInfoMap.Add("lg_platform_type", "");
            // 是否发送签约短信
            extendInfoMap.Add("send_sms_flag", "Y");
            // 签约结果通知地址
            extendInfoMap.Add("asyn_url", "");
            return extendInfoMap;
        }

        private static string get994c979bC5cb4a098e051ddeb2fdcf26() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 合同模板id合作平台为乐接活时必填 数字格式
            // obj.Add("contract_template_id", "test");
            // 任务模板id合作平台为乐接活时必填 数字格式
            // obj.Add("task_template_id", "test");
            // 税源地id合作平台为乐接活时必填 数字格式
            // obj.Add("tax_area_id", "test");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
