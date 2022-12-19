using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银联活动报名进度查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantActivityUnionpaySignStatusRequestDemo
    {

        public static void V2MerchantActivityUnionpaySignStatusRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantActivityUnionpaySignStatusRequest request = new V2MerchantActivityUnionpaySignStatusRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000103299185");
            // 报名编号与serialNumber二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：521724026796785664&lt;/font&gt;
            request.setEnlistId("521724026796785664");
            // 报名请求流水号报名时传递的reqSysId；与enlistId二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：ZDTESTrQ202011054108473959671&lt;/font&gt;
            request.setSerialNumber("ZDTESTrQ202011054108473959671");

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
