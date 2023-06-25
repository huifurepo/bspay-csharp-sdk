using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 上传电子小票图片 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeElectronReceiptsUploadRequestDemo
    {

        public static void V2TradeElectronReceiptsUploadRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeElectronReceiptsUploadRequest request = new V2TradeElectronReceiptsUploadRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付Id
            request.setHuifuId("6666000103334211");
            // 原请求日期
            request.setOrgReqDate("20230517");
            // 原请求流水号原请求流水号、原交易返回的全局流水号至少要送其中一项；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665001&lt;/font&gt;
            request.setOrgReqSeqId("20230517111710E83514");
            // 汇付全局流水号原请求流水号、原交易返回的全局流水号至少要送其中一项；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00290TOP1GR210919004230P853ac13262200000&lt;/font&gt;
            request.setOrgHfSeqId("0036000topB230517111710P034c0a8304100000");
            // 票据信息
            request.setReceiptData(getReceiptDataRucan());
            // 文件名称
            request.setFileName("电子小票1.jpg");
            // 图片内容
            request.setImageContent("/9j/4AAQSkZJRgABAQAASABIAUAf//Z……");

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

        private static object getMerchantContactInformation() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户售后咨询电话
            // obj.Add("consultation_phone_number", "");

            return obj;
        }
        private static object getWxReceiptDataRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户与商家的联系渠道
            obj.Add("merchant_contact_information", getMerchantContactInformation());

            return obj;
        }
        private static string getReceiptDataRucan() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 三方通道类型
            obj.Add("third_channel_type", "T");
            // 微信票据信息
            obj.Add("wx_receipt_data", getWxReceiptDataRucan());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
