using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户注册 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceMerRegRequestDemo
    {

        public static void V2InvoiceMerRegRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2InvoiceMerRegRequest request = new V2InvoiceMerRegRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 开票方汇付ID
            request.setHuifuId("6666000149801800");
            // 纳税人识别号支付宝和微信乐企模式非必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：91510108MA7CQPFFO6&lt;/font&gt;
            request.setTaxPayerId("91310000795605184T");
            // 销方名称支付宝和微信乐企模式非必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：汇付数电测试&lt;/font&gt;
            request.setTaxPayerName("汇付网络技术（上海）有限公司");
            // 公司电话支付宝和微信乐企模式非必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：021-33323999&lt;/font&gt;
            request.setTelNo("021-33323999");
            // 公司地址支付宝和微信乐企模式非必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：徐汇宜山路700号C5栋&lt;/font&gt;
            request.setRegAddress("徐汇宜山路700号C5栋021-33323999");
            // 开户银行支付宝和微信乐企模式非必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：民生银行徐汇支行&lt;/font&gt;
            request.setBankName("民生银行徐汇支行");
            // 开户账户支付宝和微信乐企模式非必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0206014180001609&lt;/font&gt;
            request.setAccountNo("0206014180001609");
            // 联系人手机号支付宝和微信乐企模式非必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：18011212123&lt;/font&gt;
            request.setContactPhoneNo("17621100776");
            // 开票方式
            request.setOpenMode("2");
            // 所属省支付宝和微信乐企模式非必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：310000&lt;/font&gt;，参见[地区编码](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_dqbm)
            request.setProvId("310000");
            // 所属市支付宝和微信乐企模式非必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：310100&lt;/font&gt;，参见[地区编码](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_dqbm)
            request.setCityId("310100");

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
            // 联系人
            extendInfoMap.Add("contact", "王姗");
            // 联系人身份证号
            extendInfoMap.Add("id_card_no", "210123198702122747");
            // 开票模式
            extendInfoMap.Add("issue_mode", "LE_QI_LINK");
            // 区域代码
            // extendInfoMap.Add("area_code", "");
            // 协议附件
            // extendInfoMap.Add("net_url", "");
            // 签约商户名称
            // extendInfoMap.Add("mer_name", "");
            // 生效日期
            // extendInfoMap.Add("start_date", "");
            return extendInfoMap;
        }

    }
}
