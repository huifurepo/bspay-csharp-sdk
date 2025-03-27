using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 灵工微信代发 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeLgwxSurrogateRequestDemo
    {

        public static void V2TradeLgwxSurrogateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeLgwxSurrogateRequest request = new V2TradeLgwxSurrogateRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 出款方商户号
            request.setHuifuId("6666000107755175");
            // 支付金额(元)
            request.setCashAmt("0.11");
            // 代发模式
            request.setSalaryModleType("1");
            // 落地公司商户号
            request.setBmemberId("396117173653968220");
            // 子商户应用ID
            request.setSubAppid("123213");
            // 异步通知地址
            request.setNotifyUrl("virgo://http://www.gangcai.com");
            // 分账明细
            request.setAcctSplitBunch(get2cc87980007348a7A86e461ee467b2db());

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
            // 出款方账户号
            extendInfoMap.Add("acct_id", "C02418374");
            return extendInfoMap;
        }

        private static string get2cc87980007348a7A86e461ee467b2db() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 用户号
            obj.Add("huifu_id", "6666000107979716");
            // 分配金额(元)
            obj.Add("div_amt", "0.11");
            // 微信openid
            obj.Add("sub_openid", "13232");
            // 转账备注
            obj.Add("remark", "灵工代发1");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
