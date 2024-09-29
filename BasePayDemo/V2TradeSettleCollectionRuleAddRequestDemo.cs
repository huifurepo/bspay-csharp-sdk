using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 新增归集配置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettleCollectionRuleAddRequestDemo
    {

        public static void V2TradeSettleCollectionRuleAddRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeSettleCollectionRuleAddRequest request = new V2TradeSettleCollectionRuleAddRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 转入方商户号
            request.setInHuifuId("6666000143571659");
            // 转出方商户号
            request.setOutHuifuId("6666000152758213");
            // 签约人手机号协议类型为电子协议时必填，必须为法人手机号。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：13911111111&lt;/font&gt;
            request.setSignUserMobileNo("");
            // 协议文件Id协议类型为纸质协议时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;
            request.setFileId("f80a4c17-d7c5-3e31-9e70-daf2bd6be29e");

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
            // 转入方账户号
            extendInfoMap.Add("in_acct_id", "");
            // 转出方账户号
            extendInfoMap.Add("out_acct_id", "");
            // 转出方账户留存金额
            extendInfoMap.Add("remained_amt", "1.01");
            // 协议类型
            extendInfoMap.Add("agreement_type", "1");
            // 异步消息接收地址
            extendInfoMap.Add("async_return_url", "http://service.testexample.com/to/path");
            return extendInfoMap;
        }

    }
}
