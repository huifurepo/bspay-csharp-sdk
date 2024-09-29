using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 企业账单状态变更 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2BillEntChangestatRequestDemo
    {

        public static void V2BillEntChangestatRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2BillEntChangestatRequest request = new V2BillEntChangestatRequest();
            // 请求流水号
            // request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            // request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            // request.setHuifuId("test");
            // 账单编号
            request.setBillNo("ZD2024082686348233");
            // 变更状态
            // request.setBillStat("test");

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
            // 变更原因
            extendInfoMap.Add("remark", "测试");
            return extendInfoMap;
        }

    }
}
