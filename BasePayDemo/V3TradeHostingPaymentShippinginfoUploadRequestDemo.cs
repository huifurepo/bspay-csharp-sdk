using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 发货信息录入 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradeHostingPaymentShippinginfoUploadRequestDemo
    {

        public static void V3TradeHostingPaymentShippinginfoUploadRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3TradeHostingPaymentShippinginfoUploadRequest request = new V3TradeHostingPaymentShippinginfoUploadRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000103334211");
            // 订单信息
            request.setOrderKey(get7c40df27Fc134b61B0c7Edce6d8f621b());
            // 物流模式
            request.setLogisticsType(1);
            // 发货模式
            request.setDeliveryMode(1);
            // 否已全部发货完成分拆发货模式时必填，用于标识分拆发货模式下是否已全部发货完成，只有全部发货完成的情况下才会向用户推送发货完成通知。&lt;br/&gt;枚举值: true，false&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：true&lt;/font&gt;
            // request.setIsAllDelivered("test");
            // 上传时间
            request.setUploadTime("20260831101212");

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
            // 物流信息列表
            extendInfoMap.Add("shipping_list", get12b9768650294e6cAafb18f939d1ae02());
            // 支付者
            extendInfoMap.Add("payer", getD4934e1e62bc4c09B037875617dbf057());
            return extendInfoMap;
        }

        private static string get7c40df27Fc134b61B0c7Edce6d8f621b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 订单单号类型
            obj.Add("order_number_type", 2);
            // 原支付交易对应的微信订单号
            obj.Add("transaction_id", "fake-transid-20221214190427-1");
            // 支付下单商户的商户号
            // obj.Add("mchid", "");
            // 商户系统内部订单号
            // obj.Add("out_trade_no", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getC48dfa9850104f4c83c360f466f5fb81() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 寄件人联系方式
            obj.Add("consignor_contact", "+86-177****1234");
            // 收件人联系方式
            // obj.Add("receiver_contact", "");

            return obj;
        }
        private static string get12b9768650294e6cAafb18f939d1ae02() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品信息
            obj.Add("item_desc", "微信气泡狗集线器*1");
            // 物流单号
            obj.Add("tracking_no", "fake-trackingno-2022121419042711");
            // 物流公司编码，快递公司ID
            obj.Add("express_company", "STO");
            // 联系方式
            obj.Add("contact", getC48dfa9850104f4c83c360f466f5fb81());

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getD4934e1e62bc4c09B037875617dbf057() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 用户标识
            obj.Add("openid", "ogqztkPsejM9MQAFfwCQSCi4oNg3");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
