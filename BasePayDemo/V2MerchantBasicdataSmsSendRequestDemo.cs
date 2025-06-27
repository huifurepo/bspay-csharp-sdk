using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户短信发送 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBasicdataSmsSendRequestDemo
    {

        public static void V2MerchantBasicdataSmsSendRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBasicdataSmsSendRequest request = new V2MerchantBasicdataSmsSendRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付Id
            request.setHuifuId("6666000105013599");
            // 手机号verify_type&#x3D;&#39;elecAcctSign&#39;时，手机号为空，系统自动取联系人手机号; &lt;font color&#x3D;&quot;green&quot;&gt;示例值：13911111111&lt;/font&gt;
            request.setPhone("13917111111");
            // 验证类型
            request.setVerifyType("settleBankChange");
            // 操作类型verify_type&#x3D;&#39;elecAcctSign&#39;时必填；枚举值：sendSmsCode-发送验证码；identitySmsCode-验证码核实；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：sendSmsCode&lt;/font&gt;
            // request.setOperationType("test");
            // 验证码verify_type&#x3D;&#39;elecAcctSign&#39;且operation_type&#x3D;&#39;identitySmsCode&#39;时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：123456&lt;/font&gt;
            // request.setVerifyCode("test");
            // 中信签约流水号verify_type&#x3D;&#39;elecAcctSign&#39;且operation_type&#x3D;&#39;identitySmsCode&#39;时必填；值为中信E管家签约发送短信时返回值；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：EMSSBPG2504284593690058431260676&lt;/font&gt;
            // request.setElecAcctSignSeqId("test");

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
            return extendInfoMap;
        }

    }
}
