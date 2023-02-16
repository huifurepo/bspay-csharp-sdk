using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银联活动报名 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantActivityUnionpaySignRequestDemo
    {

        public static void V2MerchantActivityUnionpaySignRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantActivityUnionpaySignRequest request = new V2MerchantActivityUnionpaySignRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000103391467");
            // 活动编号
            request.setActivityId("306530984470249472");
            // 银联活动商户号
            request.setMerNo("MH20220707155729AFIIZ");

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
            // 报名补充说明
            extendInfoMap.Add("remark", "报名补充说明");
            // 报名文本材料
            extendInfoMap.Add("enlist_txt_makings", getEnlistTxtMakings());
            // 报名图片材料
            extendInfoMap.Add("enlist_img_makings", getEnlistImgMakings());
            return extendInfoMap;
        }

        private static string getEnlistTxtMakings() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 活动材料编号
            obj.Add("makings_id", "17");
            // 活动材料类型
            obj.Add("makings_type", "TXT");
            // 活动材料名称
            obj.Add("makings_name", "银联云闪付商户号");
            // 材料值
            obj.Add("makings_value", "82339SP5411019L");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getEnlistImgMakings() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 活动材料编号
            obj.Add("makings_id", "18");
            // 活动材料类型
            obj.Add("makings_type", "IMG");
            // 活动材料名称
            obj.Add("makings_name", "门头照片");
            // 材料值
            obj.Add("makings_value", "42204258-967e-373c-88d2-1afa4c7bb8ef");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
