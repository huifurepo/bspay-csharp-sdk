using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 创建账单计划 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3BillpayPlanAddRequestDemo
    {

        public static void V3BillpayPlanAddRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3BillpayPlanAddRequest request = new V3BillpayPlanAddRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000123123123");
            // 账单项目编号
            // request.setProjectNo("test");
            // 账单周期
            request.setPlanCycle("MONTH");
            // 账单日
            request.setBillDay("15");
            // 补发当前周期账单标志枚举:Y-是、N-否；指定账单日时，必填；若填写是，则立即生成当前系统时间所在周期的账单； 滚动账单日时，此字段无效
            request.setReissueBillFlag("Y");
            // 代扣信息jsonObject格式；账单计划需自动代扣时必填
            request.setWithholdInfoData(getE99cbc55Ce184380A307475a77220ad4());
            // 用户资料信息列表
            request.setUserDocInfoList(getFe462f13Ed914741B68b51220c62772f());
            // 账单收费项信息列表
            request.setPaymentInfoList(get429cef58C12b49b7B98dAa9a14b2a395());

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
            return extendInfoMap;
        }

        private static string getE99cbc55Ce184380A307475a77220ad4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡令牌
            obj.Add("token_no", "CT202412270001");
            // 是否发送代扣前短信通知
            obj.Add("sms_notify_flag", "Y");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getFe462f13Ed914741B68b51220c62772f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 账单表单字段属性ID
            obj.Add("key_no", "userName");
            // 账单表单字段属性值
            obj.Add("key_value", "张三");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get429cef58C12b49b7B98dAa9a14b2a395() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 账单表单字段属性ID
            obj.Add("key_no", "propertyFee");
            // 账单表单字段属性值
            obj.Add("key_value", "500.00");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
