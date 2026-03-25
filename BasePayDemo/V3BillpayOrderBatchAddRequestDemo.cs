using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 创建批量账单数据 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayOrderBatchAddRequestDemo
    {

        public static void V3BillpayOrderBatchAddRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3BillpayOrderBatchAddRequest request = new V3BillpayOrderBatchAddRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000123123123");
            // 账单项目编号
            request.setProjectNo("BN2025091279190693");
            // 用户资料信息列表
            // request.setUserDocInfoList(getC2e8906531d04dc8981304f7acdb9361());
            // 账单收费项信息列表
            // request.setPaymentInfoList(getAfd400dc0f48495881a97bc3c0f33fed());

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
            // 是否生效
            // extendInfoMap.Add("effective_flag", "");
            return extendInfoMap;
        }

        private static string getC2e8906531d04dc8981304f7acdb9361() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 账单表单字段属性ID
            // obj.Add("key_no", "test");
            // 账单表单字段属性值
            // obj.Add("key_value", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getAfd400dc0f48495881a97bc3c0f33fed() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 账单表单字段属性ID
            // obj.Add("key_no", "test");
            // 账单表单字段属性值
            // obj.Add("key_value", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
