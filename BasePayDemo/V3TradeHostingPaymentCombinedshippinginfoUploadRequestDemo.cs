using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 发货信息合单录入 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradeHostingPaymentCombinedshippinginfoUploadRequestDemo
    {

        public static void V3TradeHostingPaymentCombinedshippinginfoUploadRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3TradeHostingPaymentCombinedshippinginfoUploadRequest request = new V3TradeHostingPaymentCombinedshippinginfoUploadRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000103334211");
            // 订单信息
            request.setOrderKey(getAa22aa8e4421431bBcbb03bf9ea6b08d());
            // 上传时间
            request.setUploadTime("20231112200913");
            // 支付者
            request.setPayer(getAeaf17f6D3934753A5f70c39ebdf7f85());

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
            // 子单物流详情
            extendInfoMap.Add("sub_orders", get3614704a5b104be1906399e5c7076590());
            return extendInfoMap;
        }

        private static string getAa22aa8e4421431bBcbb03bf9ea6b08d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 订单单号类型
            obj.Add("order_number_type", "1");
            // 原支付交易对应的微信订单号
            // obj.Add("transaction_id", "");
            // 支付下单商户的商户号
            obj.Add("mchid", "fake-mchid-123");
            // 商户系统内部订单号
            obj.Add("out_trade_no", "fake-tradeno-20221214190427-0");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAeaf17f6D3934753A5f70c39ebdf7f85() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 用户标识
            obj.Add("openid", "ogqztkPsejM9MQAFfwCQSCi4oNg3");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getFc965ab6287d405dAb325c90241f7b70() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 订单单号类型
            obj.Add("order_number_type", "1");
            // 原支付交易对应的微信订单号
            // obj.Add("transaction_id", "");
            // 支付下单商户的商户号
            obj.Add("mchid", "fake-mchid-123");
            // 商户系统内部订单号
            obj.Add("out_trade_no", "fake-tradeno-20221214190427-01");

            return obj;
        }
        private static object getAfc3fe0753a949889a8b3bac0ed4196a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 寄件人联系方式
            obj.Add("consignor_contact", "021-**34-12");
            // 收件人联系方式
            // obj.Add("receiver_contact", "");

            return obj;
        }
        private static object getCc61a8ed21154bdd8231E4e48a2ae31a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品信息
            obj.Add("item_desc", "微信气泡狗零钱包*1");
            // 物流单号
            obj.Add("tracking_no", "fake-trackingno-202212141904271");
            // 物流公司编码
            obj.Add("express_company", "YD");
            // 联系方式
            obj.Add("contact", getAfc3fe0753a949889a8b3bac0ed4196a());

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get3614704a5b104be1906399e5c7076590() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 需要上传物流详情的子单订单，订单类型与合单订单保持一致
            obj.Add("order_key", getFc965ab6287d405dAb325c90241f7b70());
            // 物流模式
            obj.Add("logistics_type", "1");
            // 发货模式
            obj.Add("delivery_mode", "2");
            // 是否已全部发货完成
            obj.Add("is_all_delivered", "true");
            // 子单物流信息列表
            obj.Add("shipping_list", getCc61a8ed21154bdd8231E4e48a2ae31a());

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
