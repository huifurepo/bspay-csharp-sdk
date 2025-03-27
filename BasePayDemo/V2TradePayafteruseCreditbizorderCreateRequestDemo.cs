using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 服务单创建 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayafteruseCreditbizorderCreateRequestDemo
    {

        public static void V2TradePayafteruseCreditbizorderCreateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePayafteruseCreditbizorderCreateRequest request = new V2TradePayafteruseCreditbizorderCreateRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000108281250");
            // 订单总金额
            request.setTransAmt("0.01");
            // 支付宝用户ID
            request.setBuyerId("2088000000000000");
            // 订单标题
            request.setTitle("测试001");
            // 订单类型
            request.setMerchantBizType("INDIRECT_CHARGE_WITHHOLD");
            // 订单详情地址
            request.setPath("https://www.baidu.com/");
            // 芝麻信用服务ID
            request.setZmServiceId("2024081500001003000081751200");
            // 商品详细信息
            request.setItemInfos(get864f5a50D5064cea9423A5f3ca9e73a7());

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
            extendInfoMap.Add("notify_url", "https://mock.uutool.cn/4pga0jqv8vv0");
            // 追踪ID
            extendInfoMap.Add("source_id", "MjA4ODcwMjY5OTkwODI1N3wyMDIxMDAzMTUwNjM4MTE2fDE3Mjg1NDk3OTU0OTl8ZmFsc2V8VE9LRU5fSVNfTlVMTA==");
            // 支付宝交易号
            extendInfoMap.Add("trade_no", "2024092722001408251414114417");
            // 代扣协议签约场景
            extendInfoMap.Add("deduct_sign_scene", "INDUSTRY|XIANXIANG_BIKE_CHARGE");
            // 芝麻信用外部类⽬
            extendInfoMap.Add("zm_category_id", "credit_pay_for_battery_charging");
            // 是否不需要核身
            // extendInfoMap.Add("no_need_verify_identity", "");
            // 开通成功后跳转地址
            // extendInfoMap.Add("acceptance_jump_url", "");
            return extendInfoMap;
        }

        private static object get1efd507a9385411f80f998b1c37876d9() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 总分期数
            obj.Add("period_num", 1);
            // 每期最大金额
            obj.Add("period_max_price", 0.30);
            // 每期金额
            // obj.Add("period_price", "");

            return obj;
        }
        private static string get864f5a50D5064cea9423A5f3ca9e73a7() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户商品ID
            obj.Add("out_item_id", "1234567");
            // 商品名称
            obj.Add("goods_name", "快充");
            // 商品数量
            obj.Add("item_cnt", "1");
            // 商品单价
            obj.Add("sale_price", "0.30");
            // 商品的编号
            obj.Add("goods_id", "Ldkc00001");
            // 商品分期信息
            obj.Add("item_installment_info", get1efd507a9385411f80f998b1c37876d9());

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
