using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 直付通分账关系绑定解绑 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectZftReceiverConfigRequestDemo
    {

        public static void V2MerchantDirectZftReceiverConfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantDirectZftReceiverConfigRequest request = new V2MerchantDirectZftReceiverConfigRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付ID
            request.setHuifuId("6666000103886183");
            // 开发者的应用ID
            request.setAppId("2021002171607880");
            // 分账开关
            request.setSplitFlag("1");
            // 分账接收方列表
            request.setZftSplitReceiverList(getZftSplitReceiverList());
            // 状态
            request.setStatus("0");

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

        private static string getZftSplitReceiverList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账接收方方类型
            obj.Add("split_type", "loginName");
            // 分账接收方账号
            obj.Add("account", "739100190@qq.com");
            // 分账接收方真实姓名新增分账关系时必填。解绑分账关系时非必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：张三&lt;/font&gt;
            obj.Add("name", "邵文");
            // 分账关系描述
            obj.Add("memo", "M20220820032239499098320");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
