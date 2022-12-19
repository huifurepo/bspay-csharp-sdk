using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银联活动商户入驻 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantActivityUnionpayMerbaseinfoApplyRequestDemo
    {

        public static void V2MerchantActivityUnionpayMerbaseinfoApplyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantActivityUnionpayMerbaseinfoApplyRequest request = new V2MerchantActivityUnionpayMerbaseinfoApplyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000103391467");
            // 商户类型
            request.setMerType("MERCHANT_03");
            // 经营类型
            request.setDealType("01");
            // 所属行业（MCC）MERCHANT_01-自然人 需要传入，参考[银联MCC编码](https://paas.huifu.com/partners/api/#/csfl/api_csfl_ylmccbm) ；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：5311&lt;/font&gt;
            request.setMcc("");
            // 负责人手机号
            request.setLegalMobile("18900458938");
            // 联系人身份证号
            request.setContractIdNo("110101199003071874");

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
            // 文件列表
            extendInfoMap.Add("file_list", getFileList());
            return extendInfoMap;
        }

        private static string getFileList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            obj.Add("file_type", "F02");
            // 文件jfileID
            obj.Add("file_id", "e2113798-ee67-30ac-9981-9dd742510adb");
            // 文件名称
            obj.Add("file_name", "身份证正面照片");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
