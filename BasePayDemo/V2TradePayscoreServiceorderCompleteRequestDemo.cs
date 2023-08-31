using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 完结支付分订单 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscoreServiceorderCompleteRequestDemo
    {

        public static void V2TradePayscoreServiceorderCompleteRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePayscoreServiceorderCompleteRequest request = new V2TradePayscoreServiceorderCompleteRequest();
            // 汇付商户号
            request.setHuifuId("6666000108854952");
            // 汇付订单号
            // request.setOutOrderNo("test");
            // 完结金额
            // request.setOrdAmt("test");
            // 服务时间
            // request.setTimeRange(getTimeRange());

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
            // 创建服务订单返回的汇付全局流水号
            // extendInfoMap.Add("org_hf_seq_id", "");
            // 服务订单创建请求流水号
            // extendInfoMap.Add("org_req_seq_id", "");
            // 后付费项目
            // extendInfoMap.Add("post_payments", getPostPayments());
            // 商户优惠
            // extendInfoMap.Add("post_discounts", getPostDiscounts());
            // 服务位置
            // extendInfoMap.Add("location", getLocation());
            // 完结服务时间
            // extendInfoMap.Add("complete_time", "");
            return extendInfoMap;
        }

        private static string getPostPayments() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 付费名称
            // obj.Add("name", "");
            // 付费金额
            // obj.Add("amount", "");
            // 付费说明
            // obj.Add("description", "");
            // 付费数量
            // obj.Add("count", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getPostDiscounts() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 优惠名称
            // obj.Add("name", "");
            // 优惠金额
            // obj.Add("amount", "");
            // 优惠说明
            // obj.Add("description", "");
            // 优惠数量
            // obj.Add("count", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getTimeRange() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 服务开始时间
            // obj.Add("start_time", "");
            // 服务结束时间
            // obj.Add("end_time", "");
            // 服务开始时间备注
            // obj.Add("start_time_remark", "");
            // 服务结束时间备注
            // obj.Add("end_time_remark", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getLocation() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 服务开始地点
            // obj.Add("start_location", "");
            // 服务结束地点
            // obj.Add("end_location", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
