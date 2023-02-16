using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信直连-微信关注配置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectWechatSubscribeConfigRequestDemo
    {

        public static void V2MerchantDirectWechatSubscribeConfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantDirectWechatSubscribeConfigRequest request = new V2MerchantDirectWechatSubscribeConfigRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付ID
            request.setHuifuId("6666000003099420");
            // 开发者的应用ID
            request.setAppId("wx3767c5bd01df5061");
            // 商户号
            request.setMchId("1552470931");
            // 特约商户号
            request.setSubMchid("10888880");

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
            // 绑定APPID配置
            extendInfoMap.Add("bind_app_id_conf_list", getBindAppIdConfList());
            // 关注配置
            extendInfoMap.Add("subscribe_conf_list", getSubscribeConfList());
            // 支付目录配置
            extendInfoMap.Add("pay_path_conf_list", getPayPathConfList());
            return extendInfoMap;
        }

        private static string getBindAppIdConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 关联APPID
            obj.Add("sub_appid", "oQOa46X2FxRqEy6F4YmwIRCrA7Mk");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getSubscribeConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 关联APPID
            obj.Add("sub_appid", "wx5934540532");
            // 推荐关注APPID服务商的公众号APPID；与receipt_appid二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx5934540532&lt;/font&gt;
            obj.Add("subscribe_appid", "oQOa46X2FxRqEy6F4YmwIRCrA7Mk");
            // 支付凭证推荐小程序appid需为通过微信认证的小程序appid，且认证主体与服务商主体一致；与subscribe_appid二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx852a790f100000fe&lt;/font&gt;
            obj.Add("receipt_appid", "wx852a790f100000fe");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getPayPathConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 授权目录
            obj.Add("jsapi_path", "http://www.dsf.com/init");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
