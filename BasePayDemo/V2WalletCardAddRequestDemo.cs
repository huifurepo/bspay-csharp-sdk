using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 新增绑定卡 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletCardAddRequestDemo
    {

        public static void V2WalletCardAddRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2WalletCardAddRequest request = new V2WalletCardAddRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000103423237");
            // 钱包用户ID
            request.setUserHuifuId("6666000103423833");
            // 跳转地址
            request.setFrontUrl("https://www.huifu.com/products-services/");
            // 设备信息域
            // request.setTrxDeviceInfo (getBbe177cf039a4567A0891ce62fea3820());

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
            // 请求失效时间
            extendInfoMap.Add("time_expired", "");
            // 钱包绑定卡信息
            // extendInfoMap.Add(" bind_card_info", getBd56beb5B3424befBeff624685462a90());
            // 密码页面类型
            extendInfoMap.Add("request_type", "M");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "https://bspay-stag.cloudpnr.com/sw/manager/callback/store");
            // 风控信息
            // extendInfoMap.Add("risk_info ", get52dc979d32ba4938Be366011f7b0b5ff());
            return extendInfoMap;
        }

        private static string getBd56beb5B3424befBeff624685462a90() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行卡号
            // obj.Add("card_no", "test");
            // 银行卡绑定手机号
            // obj.Add("card_mobile", "test");
            // CVV2银联卡类型为&quot;C&quot;信用卡时，该字段必传。需要密文传输，请参考[加密解密说明](https://paas.huifu.com/open/doc/guide/#/api_jiami_jiemi)使用汇付RSA公钥加密。  &lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：17BTTQrV8whfiVXSo1LKjLS4jesm182OJSmz5fZ3&lt;/font&gt;
            // obj.Add("vip_code", "test");
            // 卡有效期银联卡类型为&quot;C&quot;信用卡时，该字段必传。格式：MMYY。 &lt;br/&gt;需要密文传输，使用汇付RSA公钥加密(加密前4位，加密后99999）需要密文传输，请参考[加密解密说明](https://paas.huifu.com/open/doc/guide/#/api_jiami_jiemi)使用汇付RSA公钥加密。  &lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：5TuPJzmSz3Nl36wWVruekAamrv0W7o0PqmPOIOQIyq&lt;/font&gt;
            // obj.Add("expiration", "test");
            // 身份证照片人像面首次绑定银行卡时，需上传身份证照片。文件类型：F40  &lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;
            // obj.Add("cert_img_portrait", "test");
            // 身份证照片国徽面首次绑定银行卡时，需上传身份证照片。文件类型：F41  &lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;
            // obj.Add("cert_img_emblem", "test");
            // 银行卡类型
            // obj.Add("dc_type", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getBbe177cf039a4567A0891ce62fea3820() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行预留手机号
            // obj.Add("trx_mobile_num", "test");
            // 设备类型
            // obj.Add("trx_device_type", "test");
            // 交易设备IP
            // obj.Add("trx_device_ip", "test");
            // 交易设备MAC
            // obj.Add("trx_device_mac", "test");
            // 交易设备IMEI
            // obj.Add("trx_device_imei", "test");
            // 交易设备IMSI
            // obj.Add("trx_device_imsi", "test");
            // 交易设备ICCID
            // obj.Add("trx_device_icc_id", "test");
            // 交易设备WIFIMAC
            // obj.Add("trx_device_wfifi_mac", "test");
            // 交易设备GPS
            // obj.Add("trx_device_gps", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get52dc979d32ba4938Be366011f7b0b5ff() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // IP类型
            // obj.Add("ip_type", "test");
            // IP值
            // obj.Add("source_ip", "test");
            // 设备标识
            // obj.Add("device_id", "");
            // 设备类型
            // obj.Add("device_type", "");
            // 银行预留手机号
            // obj.Add("mobile", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
