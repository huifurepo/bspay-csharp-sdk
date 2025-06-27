using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * E账户账务明细查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePaymentZxeAcctdetailQueryRequestDemo
    {

        public static void V2TradePaymentZxeAcctdetailQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePaymentZxeAcctdetailQueryRequest request = new V2TradePaymentZxeAcctdetailQueryRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号/用户号
            request.setHuifuId("6666000107941250");
            // 交易日期
            request.setTransDate("20231227");
            // 交易类型
            request.setTransType("03");

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
            // 登记薄类型
            // extendInfoMap.Add("register_type", "");
            // 页码
            extendInfoMap.Add("page_num", "1");
            return extendInfoMap;
        }

    }
}
