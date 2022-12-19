using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 手续费试算 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeFeecalcRequestDemo
    {

        public static void V2TradeFeecalcRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeFeecalcRequest request = new V2TradeFeecalcRequest();
            // 商户号
            request.setHuifuId("6666000116584429");
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 交易类型
            request.setTradeType("ENCASHMENT");
            // 交易金额
            request.setTransAmt("1000.00");

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
            // 网银交易类型
            extendInfoMap.Add("online_trans_type", "");
            // 付款方银行编号
            extendInfoMap.Add("bank_id", "01020000");
            // 卡类型
            extendInfoMap.Add("card_type", "D");
            // 渠道号
            extendInfoMap.Add("channel_no", "10000001");
            // 数字货币银行编号
            extendInfoMap.Add("digital_bank_no", "01002");
            // 取现到账类型
            extendInfoMap.Add("encash_type", "T0");
            // 场景类型
            extendInfoMap.Add("pay_scene", "01");
            return extendInfoMap;
        }

    }
}
