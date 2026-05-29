using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 防断链入驻 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantAtpreventApplyRequestDemo
    {

        public static void V2MerchantAtpreventApplyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantAtpreventApplyRequest request = new V2MerchantAtpreventApplyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付Id
            request.setHuifuId("6666000108460751");

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
            // 异步通知地址
            extendInfoMap.Add("async_url", "http://service.example.com/to/path");
            // 微信开通明细
            extendInfoMap.Add("wx_open_list", get4ee5a21dCd974031Aaff86bc6a77ad6e());
            // 支付宝开通明细
            extendInfoMap.Add("ali_open_list", getAf3f6e6aB58f47f99761E0107d9733be());
            return extendInfoMap;
        }

        private static object get4ee5a21dCd974031Aaff86bc6a77ad6e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 渠道号
            obj.Add("pay_channel_id", "10000001");
            // 线上开通数
            obj.Add("online_open_count", "1");
            // 线下开通数
            obj.Add("offline_open_count", "1");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object getAf3f6e6aB58f47f99761E0107d9733be() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 渠道号
            obj.Add("pay_channel_id", "10000001");
            // 线上开通数
            obj.Add("online_open_count", "1");
            // 线下开通数
            obj.Add("offline_open_count", "1");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
    }
}
