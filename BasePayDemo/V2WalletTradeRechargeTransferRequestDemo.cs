using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 用户补贴 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletTradeRechargeTransferRequestDemo
    {

        public static void V2WalletTradeRechargeTransferRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2WalletTradeRechargeTransferRequest request = new V2WalletTradeRechargeTransferRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 出款方商户号
            request.setHuifuId("6666000107309462");
            // 收款方用户号
            request.setUserHuifuId("6666000187364826");
            // 转账金额
            request.setTransAmt("0.01");

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
            // 出款方账户
            extendInfoMap.Add("acct_id", "F00598600");
            // 转账描述
            extendInfoMap.Add("description", "用户补贴");
            // 备注
            extendInfoMap.Add("remark", "备注");
            return extendInfoMap;
        }

    }
}
