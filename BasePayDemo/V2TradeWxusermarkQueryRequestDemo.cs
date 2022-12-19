using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信用户标识查询接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeWxusermarkQueryRequestDemo
    {

        public static void V2TradeWxusermarkQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeWxusermarkQueryRequest request = new V2TradeWxusermarkQueryRequest();
            // 商户号
            request.setHuifuId("6666000003100616");
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 支付授权码
            request.setAuthCode("130636925881320560");

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
            // 子商户公众账号ID
            extendInfoMap.Add("sub_appid", "oQOa46X2FxRqEy6F4YmwIRCrA7Mk");
            // 渠道号
            extendInfoMap.Add("channel_no", "");
            // 场景类型
            extendInfoMap.Add("pay_scene", "");
            return extendInfoMap;
        }

    }
}
