using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银行卡分期支持银行查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeBankinstallmentinfoQueryRequestDemo
    {

        public static void V2TradeBankinstallmentinfoQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeBankinstallmentinfoQueryRequest request = new V2TradeBankinstallmentinfoQueryRequest();
            // 页码
            request.setPageNum("3");
            // 每页条数
            request.setPageSize("1");
            // 产品号
            // request.setProductId("test");

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
            // 银行编码
            extendInfoMap.Add("bank_code", "");
            // 银行名称
            extendInfoMap.Add("bank_name", "");
            // 是否启用
            extendInfoMap.Add("bank_enable", "");
            return extendInfoMap;
        }

    }
}
