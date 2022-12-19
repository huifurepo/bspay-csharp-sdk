using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 服务商终端列表查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TerminaldeviceManageQueryRequestDemo
    {

        public static void V2TerminaldeviceManageQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TerminaldeviceManageQueryRequest request = new V2TerminaldeviceManageQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));

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
            // 渠道商号
            extendInfoMap.Add("upper_huifu_id", "6666000104633228");
            // 终端号
            // extendInfoMap.Add("deviceId", "");
            // 绑定状态
            extendInfoMap.Add("is_bind", "Y");
            // 当前页码
            extendInfoMap.Add("page_num", "1");
            // 每页条数
            extendInfoMap.Add("page_size", "1");
            return extendInfoMap;
        }

    }
}
