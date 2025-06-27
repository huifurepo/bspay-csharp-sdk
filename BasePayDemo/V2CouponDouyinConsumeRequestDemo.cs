using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 抖音卡券核销 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponDouyinConsumeRequestDemo
    {

        public static void V2CouponDouyinConsumeRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2CouponDouyinConsumeRequest request = new V2CouponDouyinConsumeRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付商户号
            request.setHuifuId("6666000107767088");
            // 门店绑定流水号
            request.setBindId("88fd7c9b63e84a259dfe3eecb811fce8");
            // 加密抖音券码列表
            request.setEncryptedCodes("[\"2343\",\"5462\"]");
            // 校验标识
            request.setVerifyToken("EfdAdS3");

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
            // 核销额外参数
            // extendInfoMap.Add("verify_extra", getFb7a9cffD3d449df99461036235bce4c());
            return extendInfoMap;
        }

        private static object getFb7a9cffD3d449df99461036235bce4c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开台时间（秒）
            // obj.Add("biz_time", "test");
            // 实际抵扣金额（分））
            // obj.Add("actual_deduction_amount", "test");

            return obj;
        }
    }
}
