using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 支付宝直连-查询申请状态 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectAlipayApplyorderstatusQueryRequestDemo
    {

        public static void V2MerchantDirectAlipayApplyorderstatusQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantDirectAlipayApplyorderstatusQueryRequest request = new V2MerchantDirectAlipayApplyorderstatusQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付Id
            request.setHuifuId("6666000003079710");
            // 开发者的应用ID
            request.setAppId("2019091967580486");

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
            // 事务编号
            extendInfoMap.Add("batch_no", "3123123");
            // 应用授权令牌
            extendInfoMap.Add("app_auth_token", "201912BBecafff3696694c6d889503949a6adD18");
            return extendInfoMap;
        }

    }
}
