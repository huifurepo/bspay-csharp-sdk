using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 抖音卡券校验 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponDouyinPrepareRequestDemo
    {

        public static void V2CouponDouyinPrepareRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2CouponDouyinPrepareRequest request = new V2CouponDouyinPrepareRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付商户号
            request.setHuifuId("6666000107767088");
            // 门店绑定流水号
            request.setBindId("88fd7c9b63e84a259dfe3eecb811fce8");

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
            // 抖音团购券码
            extendInfoMap.Add("coupon_code", "5729740654");
            // 从二维码解析出来的标识（传参前需要先进行URL编码，注意不要有空格)
            // extendInfoMap.Add("encrypted_data", "");
            return extendInfoMap;
        }

    }
}
