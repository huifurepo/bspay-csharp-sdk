using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 支付宝实名申请提交 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiAliRealnameApplyRequestDemo
    {

        public static void V2MerchantBusiAliRealnameApplyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBusiAliRealnameApplyRequest request = new V2MerchantBusiAliRealnameApplyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付ID
            request.setHuifuId("6666000105418240");
            // 联系人信息
            request.setContactPersonInfo(getContactPersonInfo());
            // 主体信息
            request.setAuthIdentityInfo(getAuthIdentityInfo());

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
            // 子渠道号
            extendInfoMap.Add("pay_channel_id", "10000001");
            // 业务开通类型
            extendInfoMap.Add("pay_scene", "1");
            // 法人身份信息
            extendInfoMap.Add("legal_person_info", getLegalPersonInfo());
            // 受益人信息
            extendInfoMap.Add("ubo_info", getUboInfo());
            return extendInfoMap;
        }

        private static string getContactPersonInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 联系人身份证号码
            obj.Add("id_card_number", "120103198507275017");
            // 联系人姓名
            obj.Add("name", "谢季");
            // 联系人手机号
            obj.Add("mobile", "18900400032");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getLegalPersonInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 证件持有人类型
            obj.Add("legal_type", "SUPER");
            // 证件类型
            obj.Add("card_type", "00");
            // 法人姓名
            obj.Add("person_name", "李四");
            // 证件号码
            obj.Add("card_no", "110101199909291419");
            // 证件生效时间
            obj.Add("effect_time", "19990101");
            // 证件过期时间
            obj.Add("expire_time", "长期");
            // 证件正面照
            obj.Add("card_front_img", "afce08c5-1548-30f8-bf70-1752c3012f66");
            // 证件反面照
            obj.Add("card_back_img", "51dd13bb-6268-36d0-ac84-c4cdc19eccba");
            // 授权函照片
            obj.Add("auth_letter_img", "51dd13bb-6268-36d0-ac84-c4cdc19eccba");
            // 是否为受益人
            obj.Add("is_benefit_person", "N");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCertificateInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 登记证书类型**证照类型为登记证书时(certificate_type&#x3D;REGISTER_CERT)必填**。枚举：&lt;br/&gt;统一社会信用代码证书(CERTIFICATE_TYPE_2389)&lt;br/&gt;慈善组织公开募捐资格证书(CERTIFICATE_TYPE_2397)&lt;br/&gt;社会团体法人登记证书(CERTIFICATE_TYPE_2394)&lt;br/&gt;民办非企业单位登记证书(CERTIFICATE_TYPE_2395)&lt;br/&gt;基金会法人登记证书(CERTIFICATE_TYPE_2396)&lt;br/&gt;农民专业合作社法人营业执照(CERTIFICATE_TYPE_2398)&lt;br/&gt;宗教活动场所登记证(CERTIFICATE_TYPE_2399)&lt;br/&gt;其他证书/批文/证明(CERTIFICATE_TYPE_2400)&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：CERTIFICATE_TYPE_2389&lt;/font&gt;
            obj.Add("cert_type", "CERTIFICATE_TYPE_2389");
            // 证照编号
            obj.Add("cert_number", "9111000071093465XC");
            // 证照图片
            obj.Add("cert_copy", "afce08c5-1548-30f8-bf70-1752c3012f66");
            // 证照商户名称
            obj.Add("cert_merchant_name", "新新饭店");
            // 证照法人姓名
            obj.Add("cert_legal_person", "李四");
            // 证照注册地址
            obj.Add("cert_company_address", "浙江省杭州市西湖区1街道10号");
            // 证照生效时间
            obj.Add("effect_time", "19990101");
            // 证照过期时间
            obj.Add("expire_time", "长期");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getSupportCredentials() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 小微经营类型
            obj.Add("micro_biz_type", "MICRO_TYPE_STORE");
            // 门店名称
            obj.Add("store_name", "张三");
            // 门店省市编码
            obj.Add("province_code", "310000");
            // 门店省份
            obj.Add("province", "上海");
            // 门店市行政区号
            obj.Add("city_code", "310100");
            // 门店城市
            obj.Add("city", "上海市");
            // 门店街道区号
            obj.Add("district_code", "310107");
            // 门店街道
            obj.Add("district", "普陀区");
            // 门店场所填写门店详细地址
            obj.Add("store_address", "消息路");
            // 门店门头照信息或摊位照
            obj.Add("store_door_img", "afce08c5-1548-30f8-bf70-1752c3012f66");
            // 门店店内照片或者摊位照侧面
            obj.Add("store_inner_img", "51dd13bb-6268-36d0-ac84-c4cdc19eccba");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getQualificationInfoList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 行业类目id
            obj.Add("mcc_code", "2015050700000000");
            // 行业经营许可证资质照片
            obj.Add("image_list", "a5d373f6-3e79-405f-9993-fb7ea051c372");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getAuthIdentityInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 主体类型
            obj.Add("business_type", "2");
            // 是否金融机构
            obj.Add("finance_institution_flag", "N");
            // 金融机构类型
            obj.Add("financial_type", "INST");
            // 金融机构许可证图片
            obj.Add("finance_license_pics", "a5d373f6-3e79-405f-9993-fb7ea051c372");
            // 证照类型
            obj.Add("certificate_type", "BUSINESS_CERT");
            // 登记证书信息
            obj.Add("certificate_info", getCertificateInfo());
            // 单位证明函照片
            obj.Add("company_prove_copy", "71da066c-5d15-3658-a86d-4e85ee67808a");
            // 辅助证明材料信息
            obj.Add("support_credentials", getSupportCredentials());
            // 经营许可证
            obj.Add("qualification_info_list", getQualificationInfoList());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getUboInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 证件姓名
            obj.Add("ubo_id_doc_name", "消化");
            // 证件类型
            obj.Add("ubo_id_doc_type", "00");
            // 证件号码
            obj.Add("ubo_id_doc_number", "110101199909291419");
            // 证件有效期开始时间
            obj.Add("ubo_period_begin", "19990101");
            // 证件有效期结束时间
            obj.Add("ubo_period_end", "20260606");
            // 证件正面照片
            obj.Add("ubo_id_doc_copy", "afce08c5-1548-30f8-bf70-1752c3012f66");
            // 证件反面照片
            obj.Add("ubo_id_doc_copy_back", "51dd13bb-6268-36d0-ac84-c4cdc19eccba");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
