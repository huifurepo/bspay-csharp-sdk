using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 代运营佣金代扣退款 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LlaWithholdRefundRequestDemo
    {

        public static void V2LlaWithholdRefundRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2LlaWithholdRefundRequest request = new V2LlaWithholdRefundRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 原请求日期
            request.setOrgReqDate("20250822");
            // 原请求流水号org_hf_seq_id与org_req_seq_id二选一必填。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：2021091708126665001&lt;/font&gt;
            request.setOrgReqSeqId("");
            // 原全局流水号org_hf_seq_id与org_req_seq_id二选一必填。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00470topo1A221019132207P068ac1362af00000&lt;/font&gt;
            request.setOrgHfSeqId("00470topotB250827093537P979c0a8408100000");
            // 代运营汇付id
            request.setAgencyHuifuId("6666000108967194");
            // 退款金额
            request.setTransAmt("25.00");
            // 设备信息
            request.setTerminalDeviceData(get401cdbafBf0248b9Bd22Fc29c064ec90());
            // 安全信息
            request.setRiskCheckData(get5f9a6c9a2f274b58B08b898a909edb95());

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
            // 备注
            extendInfoMap.Add("remark", "部分退款看看");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.baidu.com");
            return extendInfoMap;
        }

        private static string get401cdbafBf0248b9Bd22Fc29c064ec90() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易设备类型
            obj.Add("device_type", "4");
            // 交易设备IP
            obj.Add("device_ip", "172.31.11.11");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get5f9a6c9a2f274b58B08b898a909edb95() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 经度
            // obj.Add("longitude", "");
            // 纬度
            // obj.Add("latitude", "");
            // 基站地址
            // obj.Add("base_station", "");
            // IP地址
            obj.Add("ip_addr", "172.31.11.11");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
