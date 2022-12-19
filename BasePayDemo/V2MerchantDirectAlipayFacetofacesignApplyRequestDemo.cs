using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 支付宝直连-申请当面付代签约 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectAlipayFacetofacesignApplyRequestDemo
    {

        public static void V2MerchantDirectAlipayFacetofacesignApplyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantDirectAlipayFacetofacesignApplyRequest request = new V2MerchantDirectAlipayFacetofacesignApplyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000003080750");
            // 上级主体ID
            request.setUpperHuifuId("6666000003078903");
            // 支付宝经营类目
            request.setDirectCategory("A_A01_4119");
            // 开发者的应用ID
            request.setAppId("AE150003019");
            // 联系人姓名
            request.setContactName("hqqTEST");
            // 联系人手机号
            request.setContactMobileNo("15800718101");
            // 联系人电子邮箱
            request.setContactEmail("24324@qq.com");
            // 商户账号
            request.setAccount("288000000345345");
            // 服务费率（%）0.38~3之间，精确到0.01。当签约且授权sign_and_auth&#x3D;Y时，必填。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.38&lt;/font&gt;
            request.setRate("0.38");
            // 文件列表
            request.setFileList(getFileList());

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
            // 订单授权凭证
            extendInfoMap.Add("order_ticket", "werwe234234234");
            // 签约且授权标识
            extendInfoMap.Add("sign_and_auth", "Y");
            // 应用授权令牌
            extendInfoMap.Add("app_auth_token", "test0004");
            // 营业执照编号
            extendInfoMap.Add("license_code", "");
            // 营业执照有效期类型
            extendInfoMap.Add("license_validity_type", "0");
            // 营业执照有效期开始日期
            extendInfoMap.Add("license_begin_date", "20200429");
            // 营业执照有效期截止日期
            extendInfoMap.Add("license_end_date", "29200429");
            return extendInfoMap;
        }

        private static string getFileList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            obj.Add("file_type", "F50");
            // 文件jfileID
            obj.Add("file_id", "b53e18b3-f933-357f-9a6f-952c6a021ba5");
            // 文件名称
            obj.Add("file_name", "360huxi.jpg");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
