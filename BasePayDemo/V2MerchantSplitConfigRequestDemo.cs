using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户分账配置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantSplitConfigRequestDemo
    {

        public static void V2MerchantSplitConfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantSplitConfigRequest request = new V2MerchantSplitConfigRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付Id
            request.setHuifuId("6666000105582434");
            // 分账规则来源
            request.setRuleOrigin("02");
            // 分账是否支持撤销交易
            request.setRepealFlag("Y");
            // 分账是否支持退货交易
            request.setRefundFlag("Y");
            // 分账开关
            request.setDivFlag("Y");
            // 最大分账比例
            request.setApplyRatio("100");
            // 生效类型
            request.setStartType("0");

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
            // 分账明细
            extendInfoMap.Add("acct_split_bunch_list", getAcctSplitBunchList());
            // 交易手续费外扣开关
            extendInfoMap.Add("out_fee_flag", "1");
            // 交易手续费外扣时的账户类型
            extendInfoMap.Add("out_fee_acct_type", "01");
            // 交易手续费外扣汇付ID
            extendInfoMap.Add("out_fee_huifuid", "6666000105582434");
            // 固定手续费
            extendInfoMap.Add("split_fee_rate", "10.89");
            // 百分比手续费
            extendInfoMap.Add("per_amt", "99");
            // 异步地址
            extendInfoMap.Add("async_return_url", "http://192.168.85.157:30031/sspm/testVirgo");
            return extendInfoMap;
        }

        private static string getAcctSplitBunchList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账比例
            obj.Add("fee_rate", "100");
            // 汇付Id
            obj.Add("huifu_id", "6666000105582434");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
