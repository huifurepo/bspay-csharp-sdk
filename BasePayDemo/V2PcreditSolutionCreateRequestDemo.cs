using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 创建花呗分期方案 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2PcreditSolutionCreateRequestDemo
    {

        public static void V2PcreditSolutionCreateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2PcreditSolutionCreateRequest request = new V2PcreditSolutionCreateRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000003084836");
            // 花呗分期商家贴息活动名称
            request.setActivityName("花呗分期商家贴息活动名称");
            // 活动开始时间
            request.setStartTime("2019-07-08 00:00:00");
            // 活动结束时间
            request.setEndTime("2039-07-10 00:00:00");
            // 免息金额下限(元)
            request.setMinMoneyLimit("1000");
            // 免息金额上限(元)
            request.setMaxMoneyLimit("3000");
            // 花呗分期贴息预算金额
            request.setAmountBudget("60000");
            // 花呗分期数集合
            request.setInstallNumStrList("3");
            // 预算提醒金额(元)
            request.setBudgetWarningMoney("58000");
            // 预算提醒邮件列表
            request.setBudgetWarningMailList("111@alipay.com");
            // 预算提醒手机号列表
            request.setBudgetWarningMobileNoList("13940001100");
            // 子门店信息集合
            request.setSubShopInfoList(getSubShopInfoList());

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
            // 开发者的应用ID
            extendInfoMap.Add("app_id", "");
            return extendInfoMap;
        }

        private static string getSubShopInfoList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 二级商户号
            obj.Add("sub_mer_id", "A4854135335181517376");
            // 二级商户名
            obj.Add("sub_mer_name", "预二人");
            // 费率
            obj.Add("fee_type", "02");
            // 店铺名称
            obj.Add("mer_name", "盈盈超市");
            // 省份
            obj.Add("province", "浙江省");
            // 市名
            obj.Add("city", "杭州市");
            // 区、县
            obj.Add("county", "西湖区");
            // 地址详情
            obj.Add("detail", "古荡街道西溪路556号蚂蚁Z空间");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
