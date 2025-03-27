using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 账务流水查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeAcctpaymentAcctlogQueryRequestDemo
    {

        public static void V2TradeAcctpaymentAcctlogQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeAcctpaymentAcctlogQueryRequest request = new V2TradeAcctpaymentAcctlogQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 渠道/代理/商户/用户编号
            request.setHuifuId("6666000108854952");
            // 账务日期
            request.setAcctDate("20220816");

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
            // 每页条数
            extendInfoMap.Add("page_size", "10");
            // 分页页码
            extendInfoMap.Add("page_num", "1");
            // 账户号
            // extendInfoMap.Add("acct_id", "");
            // 账户类型
            extendInfoMap.Add("acct_type", "01");
            return extendInfoMap;
        }

    }
}
