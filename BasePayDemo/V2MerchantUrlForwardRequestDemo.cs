using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户统一进件（页面版） - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantUrlForwardRequestDemo
    {

        public static void V2MerchantUrlForwardRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantUrlForwardRequest request = new V2MerchantUrlForwardRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 渠道商号
            request.setUpperHuifuId("6666000108290240");
            // 门店号
            request.setStoreId("store128");

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
            // 手机号
            extendInfoMap.Add("phone", "13917352618");
            // 跳转地址失效时间
            extendInfoMap.Add("expires", "50000");
            // 返回页面URL
            // extendInfoMap.Add("back_page_url", "");
            // 异步接收URL
            // extendInfoMap.Add("async_receive_url", "");
            // 模版编号
            extendInfoMap.Add("template_id", "155625");
            return extendInfoMap;
        }

    }
}
