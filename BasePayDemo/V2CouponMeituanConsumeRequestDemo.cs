using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 美团卡券核销 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponMeituanConsumeRequestDemo
    {

        public static void V2CouponMeituanConsumeRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2CouponMeituanConsumeRequest request = new V2CouponMeituanConsumeRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付商户号
            request.setHuifuId("6666000106057033");
            // 门店绑定流水号
            request.setBindId("9c2d91f68ba045a998df46ffe395a9ca");
            // 核销券
          
            // 登录账号
            request.setAppShopAccount("123");
            // 登录用户名
            request.setAppShopAccountName("12345");

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
            // 机具id
            // extendInfoMap.Add("device_id", "");
            // 操作人id
            // extendInfoMap.Add("operator_id", "");
            // 操作人姓名
            // extendInfoMap.Add("operator_name", "");
            return extendInfoMap;
        }

        private static object getBa1324ef265e44d99bc21f7e0e9846c1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 券码
            obj.Add("receipt_code", "5729740654");
            // 核销张数
            obj.Add("num", "1");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
    }
}
