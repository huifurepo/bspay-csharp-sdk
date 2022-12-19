using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信代发 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeTransWxSurrogateRequestDemo
    {

        public static void V2TradeTransWxSurrogateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeTransWxSurrogateRequest request = new V2TradeTransWxSurrogateRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 出账商户号
            request.setOutHuifuId("6666000000041651");
            // 代发金额
            request.setTransAmt("9.00");
            // 收款用户openid
            request.setOpenId("o-MYE42l80oelYMDE34nYD456Xoy");
            // 微信收款用户姓名
            request.setUserName("王大锤");
            // 代发备注
            request.setRemark("测试用");

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
            // 账户类型
            extendInfoMap.Add("out_acct_type", "05");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.gangcai.com");
            // 子商户号
            // extendInfoMap.Add("sub_mch_id", "");
            // 子商户应用Id
            // extendInfoMap.Add("sub_app_id", "");
            return extendInfoMap;
        }

    }
}
