using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 抖音卡券撤销 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponDouyinCancelRequestDemo
    {

        public static void V2CouponDouyinCancelRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2CouponDouyinCancelRequest request = new V2CouponDouyinCancelRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付商户号
            request.setHuifuId("6666000107767088");
            // 门店绑定流水号
            request.setBindId("88fd7c9b63e84a259dfe3eecb811fce8");
            // 加密抖音券码
            request.setEncryptedCode("5584192259");
            // 核销标识
            request.setVerifyId("3435");

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
            // 取消核销总次数
            // extendInfoMap.Add("times_card_cancel_count", "");
            // 撤销核销幂等
            // extendInfoMap.Add("cancel_token", "");
            return extendInfoMap;
        }

    }
}
