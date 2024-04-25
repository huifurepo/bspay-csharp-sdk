using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 一键绑卡-工行卡号查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleBindCardinfoQueryRequestDemo
    {

        public static void V2QuickbuckleBindCardinfoQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2QuickbuckleBindCardinfoQueryRequest request = new V2QuickbuckleBindCardinfoQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付Id
            request.setHuifuId("6666000003078984");
            // 产品Id
            // request.setProductId("test");
            // 银行卡开户姓名
            request.setCardName("YTRf65hBDkH9UU1AwG16r4Nlc/X1rH6ejKbvmqT80exJ6whdHI1zB+izBtNBOJfhRNbIOhi1FrRuE5b7wnt/03Q+vwWQQLDGJXWZf92yp+eIRDHg8JdbjOgxKvF2q4Qw5704jbsjQm4UJW5fqRhzRPtnnAL9zzTSgVhuQ0KCwc8=");
            // 身份证类型
            request.setCertType("00");
            // 银行卡绑定身份证
            // request.setCertNo("test");
            // 银行卡绑定手机号
            // request.setCardMobile("test");
            // 回调地址
            // request.setNotifyUrl("test");

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
