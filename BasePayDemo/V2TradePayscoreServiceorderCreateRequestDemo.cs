using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 创建支付分订单 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscoreServiceorderCreateRequestDemo
    {

        public static void V2TradePayscoreServiceorderCreateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePayscoreServiceorderCreateRequest request = new V2TradePayscoreServiceorderCreateRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户申请单号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 汇付商户号
            request.setHuifuId("6666000108854952");
            // 服务信息
            // request.setServiceIntroduction("test");
            // 服务风险金
            // request.setRiskFund(getRiskFund());
            // 服务时间
            // request.setTimeRange(getTimeRange());
            // 商户回调地址
            // request.setNotifyUrl("test");

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
            // 服务ID
            // extendInfoMap.Add("service_id", "");
            // 子商户公众号ID
            // extendInfoMap.Add("sub_appid", "");
            // 场景类型
            // extendInfoMap.Add("trade_scene", "");
            // 费率类型
            // extendInfoMap.Add("pay_scene", "");
            // 从业机构公众号下的用户标识
            // extendInfoMap.Add("openid", "");
            // 子商户公众号下的用户标识
            // extendInfoMap.Add("sub_openid", "");
            // 后付费项目
            // extendInfoMap.Add("post_payments", getPostPayments());
            // 商户优惠
            // extendInfoMap.Add("post_discounts", getPostDiscounts());
            // 服务位置
            // extendInfoMap.Add("location", getLocation());
            // 附加数据
            // extendInfoMap.Add("attach", "");
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
        private static string getRiskFund() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 风险名称
            // obj.Add("name", "");
            // 风险金额
            // obj.Add("amount", "");
            // 风险说明
            // obj.Add("description", "");

            return JsonConvert.SerializeObject(obj);
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
