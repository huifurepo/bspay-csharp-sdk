using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信商户配置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiConfigRequestDemo
    {

        public static void V2MerchantBusiConfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBusiConfigRequest request = new V2MerchantBusiConfigRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000108854952");
            // 业务开通类型
            request.setFeeType("02");
            // 公众号支付Appid条件必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx3767c5bd01df5061&lt;/font&gt; ；wx_woa_app_id 、wx_woa_path、micro_sub_appid和 wx_applet_app_id四者不能同时为空
            request.setWxWoaAppId("wx3767c5bd01df5061");
            // 微信公众号授权目录条件必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：https://paas.huifu.com/shouyintai/demo/h5/&lt;/font&gt;；wx_woa_app_id 、wx_woa_path、micro_sub_appid和 wx_applet_app_id四者不能同时为空
            request.setWxWoaPath("https://paas.huifu.com/shouyin/demo/h5/");
            // 微信小程序APPID条件必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx8523175fea790f10&lt;/font&gt; ；wx_woa_app_id 、wx_woa_path、micro_sub_appid和 wx_applet_app_id四者不能同时为空
            request.setWxAppletAppId("wx8523175fea790f10");

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
            // 微信公众号APPID对应的秘钥
            extendInfoMap.Add("wx_woa_secret", "64afb60bef3a22ac282aa7880cdaca98");
            // 微信插件类交易APPID
            // extendInfoMap.Add("micro_sub_appid", "");
            // 微信小程序APPID对应的秘钥
            extendInfoMap.Add("wx_applet_secret", "1323a4165a662d6e4f9f51b3f7a58e3f");
            // 渠道号
            extendInfoMap.Add("bank_channel_no", "JQF00001");
            // 异步消息接收地址
            // extendInfoMap.Add("async_return_url", "");
            return extendInfoMap;
        }

    }
}
