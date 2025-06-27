using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 支付分扣款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscorePayPayscorepayRequestDemo
    {

        public static void V2TradePayscorePayPayscorepayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePayscorePayPayscorepayRequest request = new V2TradePayscorePayPayscorepayRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000141569791");
            // 扣款登记创建请求流水号deduct_req_seq_id与deduct_hf_seq_id二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2022012614120615001&lt;/font&gt;
            request.setDeductReqSeqId("1726841301594394626");
            // 扣款登记返回的汇付全局流水号deduct_req_seq_id与deduct_hf_seq_id二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00470topo1A211015160805P090ac132fef00000&lt;/font&gt;
            // request.setDeductHfSeqId("test");
            // 微信扣款单号
            request.setOutTradeNo("03212311224952047516172");
            // 商品描述
            request.setGoodsDesc("bp充电");
            // 安全信息
            request.setRiskCheckData(get52d96afbF87746fd9cb2Beb3e46d7bd5());

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
            // 聚合反扫微信参数集合
            // extendInfoMap.Add("wx_data", get2678bcc52a4848679dc2413aa3da407f());
            // 是否延迟交易
            // extendInfoMap.Add("delay_acct_flag", "");
            // 分账对象
            // extendInfoMap.Add("acct_split_bunch", get19a634c3D0034464Bcc050d33458448f());
            // 设备信息
            // extendInfoMap.Add("terminal_device_info", get471b78176649480eAacf4528fabca41b());
            // 交易备注
            // extendInfoMap.Add("remark", "");
            // 商户回调地址
            // extendInfoMap.Add("notify_url", "");
            return extendInfoMap;
        }

        private static string get2678bcc52a4848679dc2413aa3da407f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 子商户用户标识
            // obj.Add("sub_openid", "test");
            // 子商户公众账号id
            // obj.Add("sub_appid", "");
            // 用户标识
            // obj.Add("openid", "");
            // 设备号
            // obj.Add("device_info", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getE3905e1c9bd4475c81bcEa7a29aa75f8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            // obj.Add("div_amt", "test");
            // 分账接收方ID
            // obj.Add("huifu_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get19a634c3D0034464Bcc050d33458448f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            // obj.Add("acct_infos", getE3905e1c9bd4475c81bcEa7a29aa75f8());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get52d96afbF87746fd9cb2Beb3e46d7bd5() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // ip地址
            obj.Add("ip_address", "127.0.0.1");
            // 基站地址
            // obj.Add("base_station", "");
            // 纬度
            // obj.Add("latitude", "");
            // 经度
            // obj.Add("longitude", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get471b78176649480eAacf4528fabca41b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 设备类型
            // obj.Add("device_type", "");
            // 交易设备IP
            // obj.Add("device_ip", "");
            // 交易设备MAC
            // obj.Add("device_mac", "");
            // 交易设备IMEI
            // obj.Add("device_imei", "");
            // 交易设备IMSI
            // obj.Add("device_imsi", "");
            // 交易设备ICCID
            // obj.Add("device_icc_id", "");
            // 交易设备WIFIMAC
            // obj.Add("device_wifi_mac", "");
            // 交易设备GPS
            // obj.Add("device_gps", "");
            // 商户终端应用程序版
            // obj.Add("app_version", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
