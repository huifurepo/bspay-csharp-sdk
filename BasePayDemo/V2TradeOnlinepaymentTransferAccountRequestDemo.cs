using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银行大额支付 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferAccountRequestDemo
    {

        public static void V2TradeOnlinepaymentTransferAccountRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentTransferAccountRequest request = new V2TradeOnlinepaymentTransferAccountRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 收款方商户号
            request.setHuifuId("6666000003100616");
            // 交易金额
            request.setTransAmt("10.00");
            // 商品描述
            request.setGoodsDesc("商品描述001");

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
            // 用户客户号
            extendInfoMap.Add("user_huifu_id", "6666000103905031");
            // 收款方账户号
            extendInfoMap.Add("acct_id", "A01199826");
            // 页面标识
            // extendInfoMap.Add("page_flag", "");
            // 付款方名称
            extendInfoMap.Add("certificate_name", "沈显龙");
            // 付款方银行卡号
            extendInfoMap.Add("bank_card_no", "Xmjm1RB4AAOaFYQ+PgjBlpugXbd8VAYAGB3J2zrbLfC42Bh5xiB47OOV1EdXyGpBq4H8je7mB/MlyEEs6O8PX6aoI4QHumr8VglrLM6uzbVNCIc3S5RPSmi2M+9+EdIQ6nlWd5+XQ7RJXX5Uvnegn74XzQBcN1d4gd04buwKbLpUPV3tWd1qjQwEE8w4gwEtH3L5AP75Mynz+wHFrUKJF3BTiW2/zJlcq5GJomOl06GEW52AZkXwn6U2suP3a0ySd0Rxbf1yQ1lj3SP56NeeEzuBaFLQWB7mEqJfZF3pE9MHNfi6tR1xwLdcxt98bdIqlteKdNAmgfQzcS13UcwH+w==");
            // 订单类型
            // extendInfoMap.Add("order_type", "");
            // 备注
            extendInfoMap.Add("remark", "标记123");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.huifu.com/getResp");
            // 入账模式
            // extendInfoMap.Add("acct_mode", "");
            // 银行模式
            // extendInfoMap.Add("bank_mode", "");
            // 延时标记
            // extendInfoMap.Add("delay_acct_flag", "");
            // 订单模式
            // extendInfoMap.Add("order_mode", "");
            // 原汇款订单号
            // extendInfoMap.Add("org_remittance_order_id", "");
            // 动态码标识
            // extendInfoMap.Add("dynamic_flag", "");
            // 订单失效时间
            // extendInfoMap.Add("time_expire", "");
            // 手续费扣款标志
            // extendInfoMap.Add("fee_flag", "");
            return extendInfoMap;
        }

    }
}
