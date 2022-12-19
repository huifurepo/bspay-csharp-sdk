using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 支付宝直连-换取应用授权令牌 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectAlipayAppauthtokenExchangeRequestDemo
    {

        public static void V2MerchantDirectAlipayAppauthtokenExchangeRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantDirectAlipayAppauthtokenExchangeRequest request = new V2MerchantDirectAlipayAppauthtokenExchangeRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付ID
            request.setHuifuId("6666000103152205");
            // 开发者的应用ID
            request.setAppId("2021001153625042");
            // 操作类型
            request.setOperType("1");
            // 授权码授权码，操作类型为0-换取令牌时必填，其它选填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：123&lt;/font&gt;
            request.setAppAuthCode("123");
            // 应用授权令牌应用授权令牌，操作类型为1-刷新令牌时，且该字段有值，将与数据库值进行校验；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：202208200312104378&lt;/font&gt;
            request.setAppAuthToken("202210100408496759");

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
