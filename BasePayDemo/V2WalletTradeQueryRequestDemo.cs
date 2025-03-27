using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 钱包交易查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradeQueryRequestDemo
    {

        public static void V2WalletTradeQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2WalletTradeQueryRequest request = new V2WalletTradeQueryRequest();
            // 商户号
            request.setHuifuId("6666000135653240");
            // 原交易请求日期
            request.setOrgReqDate("20230803");
            // 原交易请求流水号
            request.setOrgReqSeqId("2023080325123001");
            // 交易类型
            request.setTransType("WALLET_PAY");

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
