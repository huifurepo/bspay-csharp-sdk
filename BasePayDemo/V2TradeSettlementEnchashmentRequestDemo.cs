using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 取现接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettlementEnchashmentRequestDemo
    {

        public static void V2TradeSettlementEnchashmentRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeSettlementEnchashmentRequest request = new V2TradeSettlementEnchashmentRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 取现金额
            request.setCashAmt("0.01");
            // 商户号
            request.setHuifuId("6666000021291985");
            // 到账日期类型
            request.setIntoAcctDateType("T0");
            // 取现卡序列号
            request.setTokenNo("10004053462");

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
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.gangcai.com");
            // 备注
            // extendInfoMap.Add("remark", "");
            // 账户号
            // extendInfoMap.Add("acct_id", "");
            return extendInfoMap;
        }

    }
}
