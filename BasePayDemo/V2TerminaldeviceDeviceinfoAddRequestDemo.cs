using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 新增终端报备 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TerminaldeviceDeviceinfoAddRequestDemo
    {

        public static void V2TerminaldeviceDeviceinfoAddRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TerminaldeviceDeviceinfoAddRequest request = new V2TerminaldeviceDeviceinfoAddRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000104575213");

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
            // 终端信息
            extendInfoMap.Add("terminal_info_list", getTerminalInfoList());
            return extendInfoMap;
        }

        private static string getTerminalInfoList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 终端硬件序列号
            obj.Add("sn", "433333");
            // 终端21号文编号
            obj.Add("tusn", "J434445679");
            // 终端型号代号
            obj.Add("dev_model_code", "01");
            // 终端布放地址
            obj.Add("terminal_address", "上海额的发");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
