using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 直付通商户入驻 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectZftRegRequestDemo
    {

        public static void V2MerchantDirectZftRegRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantDirectZftRegRequest request = new V2MerchantDirectZftRegRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付ID
            request.setHuifuId("6666000108942745");
            // 进件的二级商户名称
            request.setName("雷均一");
            // 商家类型
            request.setMerchantType("0");
            // 商户经营类目
            request.setMcc("5331");
            // 商户证件类型
            request.setCertType("100");
            // 商户证件编号
            request.setCertNo("120101199003071300");
            // 证件名称目前只有个体工商户商户类型要求填入本字段，填写值为个体工商户营业执照上的名称。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：xxxx小卖铺&lt;/font&gt;
            request.setCertName("I_cert_name");
            // 法人名称仅个人商户非必填，其他必填。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：张三&lt;/font&gt;
            request.setLegalName("雷均一");
            // 法人证件号码仅个人商户非必填，其他必填。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：3209261975120284333&lt;/font&gt;
            request.setLegalCertNo("120101199003071300");
            // 客服电话
            request.setServicePhone("10086");
            // 经营省
            request.setProvId("310000");
            // 经营市
            request.setAreaId("310100");
            // 经营区
            request.setDistrictId("310104");
            // 经营详细地址
            request.setDetailAddr("上海市徐汇区");
            // 联系人姓名
            request.setContactName("张三");
            // 商户联系人业务标识
            request.setContactTag("02");
            // 联系人类型
            request.setContactType("LEGAL_PERSON");
            // 联系人手机号
            request.setContactMobileNo("13576266246");
            // 商户结算卡信息jsonArray格式。本业务当前只允许传入一张结算卡。与支付宝账号字段二选一必填
            request.setZftCardInfoList(get89b50602766148fd8b78E5b1178b7e6d());
            // 商户支付宝账号商户支付宝账号，用作结算账号。与银行卡对象字段二选一必填。&lt;br/&gt;本字段要求支付宝账号的名称与商户名称mch_name同名，且是实名认证过的支付宝账户。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：test@huifu.com&lt;/font&gt;
            request.setAlipayLogonId("13576266246");
            // 商户行业资质类型当商户是特殊行业时必填，具体取值[参见表格](https://mif-pub.alipayobjects.com/QualificationType.xlsx)。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：310&lt;/font&gt;
            request.setIndustryQualificationType("");
            // 商户使用服务
            request.setService("2");
            // 商户与服务商的签约时间
            request.setSignTimeWithIsv("2021-01-27");
            // 商户支付宝账户用于协议确认。目前商业场景（除医疗、中小学教育等）下必填。本字段要求上送的支付宝账号的名称与商户名称name同名，且是实名认证支付宝账户。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：test@huifu.com&lt;/font&gt;
            request.setBindingAlipayLogonId("13576266246");
            // 默认结算类型
            request.setDefaultSettleType("alipayAccount");
            // 文件列表
            request.setFileList(getDa4424ccD76c449aAd0f0a6cf846ae87());

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
            // 渠道商汇付ID
            extendInfoMap.Add("upper_huifu_id", "6666000108290240");
            // 商户别名
            extendInfoMap.Add("alias_name", "哈市盈超市");
            // 法人证件类型
            extendInfoMap.Add("legal_cert_type", "100");
            // 联系人身份证号
            extendInfoMap.Add("contact_id_card_no", "120101199003071300");
            // 联系人电话
            extendInfoMap.Add("contact_phone", "13576266246");
            // 联系人电子邮箱
            extendInfoMap.Add("contact_email", "a066545074@qq.com");
            // 商户站点信息
            extendInfoMap.Add("zft_site_info_list", get74e88be88f46423bB56343dda05a086f());
            // 审核结果异步通知地址
            extendInfoMap.Add("async_return_url", "http://192.168.85.157:30031/sspm/testVirgo");
            // 直付通退款不退手续费开关
            extendInfoMap.Add("no_refund_flag", "N");
            return extendInfoMap;
        }



        private static String get89b50602766148fd8b78E5b1178b7e6d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡类型
            obj.Add("card_type", "1");
            // 卡借贷类型
            obj.Add("card_flag", "D");
            // 户名
            obj.Add("card_name", "雷均一");
            // 卡号
            obj.Add("card_no", "6228480123456789");
            // 银行所在省
            obj.Add("prov_id", "310000");
            // 银行所在市
            obj.Add("area_id", "310100");
            // 银行号
            obj.Add("bank_code", "01030000");
            // 银行名称
            obj.Add("bank_name", "中国农业银行");
            // 联行号
            obj.Add("branch_code", "103290076178");
            // 支行名称
            obj.Add("branch_name", "中国农业银行股份有限公司上海徐汇支行");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object get74e88be88f46423bB56343dda05a086f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 站点类型
            obj.Add("site_type", "02");
            // 站点地址
            obj.Add("site_url", "站点地址");
            // 站点名称
            obj.Add("site_name", "站点名称");
            // 测试账号
            obj.Add("account", "");
            // 测试密码
            obj.Add("password", "测试密码");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static String getDa4424ccD76c449aAd0f0a6cf846ae87() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            obj.Add("file_type", "F41");
            // 文件ID
            obj.Add("file_id", "c679752a-9abc-326d-bb02-8cf770f56d12");
            // 文件名称
            obj.Add("file_name", "身份证国徽面");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
