using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 抖音券状态批量查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponDouyinCertificateQueryRequestDemo
    {

        public static void V2CouponDouyinCertificateQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2CouponDouyinCertificateQueryRequest request = new V2CouponDouyinCertificateQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付商户号
            request.setHuifuId("6666000132473423");
            // 门店绑定流水号
            request.setBindId("7123fc6e9337a5");
            // 验券准备接口返回的加密券码encrypted_code和order_id二选一必传，encrypted_code和order_id不能同时传入
            request.setEncryptedCode("0");
            // 订单id验券准备等接口获得，encrypted_code和order_id二选一必传，encrypted_code和order_id不能同时传入
            // request.setOrderId("test");

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

    }
}
