using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户业务开通 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiOpenRequestDemo
    {

        public static void V2MerchantBusiOpenRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBusiOpenRequest request = new V2MerchantBusiOpenRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000104778898");
            // 直属渠道号
            request.setUpperHuifuId("6666000003080000");
            // 签约人jsonObject字符串；agreement_info中选择电子签约时必填；个人商户填本人信息。
            // request.setSignUserInfo(get2a2149bfAf854643B51c7f1b9da01424());
            // 线上业务类型编码基本信息入驻接口中scene_type&#x3D;ONLINE/ALL时必填；&lt;br/&gt;开通以下业务快捷、网银、余额支付Pro版、银行大额转账、分账比例&gt;30%、代扣需要提供补充材料，参见[线上业务类型编码及补充材料说明](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/kyc/KYC-%E7%BA%BF%E4%B8%8A%E4%B8%9A%E5%8A%A1%E7%B1%BB%E5%9E%8B%E7%BC%96%E7%A0%81%E5%8F%8A%E8%A1%A5%E5%85%85%E6%9D%90%E6%96%99%E8%AF%B4%E6%98%8E.xlsx)；材料通过[图片上传接口](https://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)上传&lt;font color&#x3D;&quot;green&quot;&gt;示例值：H7999AL&lt;/font&gt;
            // request.setOnlineBusiType("test");
            // *协议信息实体*jsonObject字符串；[签约协议材料说明](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/kyc/KYC-%E5%95%86%E6%88%B7%E5%90%88%E5%90%8C%E7%AD%BE%E7%BA%A6%E8%A7%84%E5%88%99.xlsx) &lt;br/&gt;若未签署过协议的情况下，调用该接口时必填；&lt;br/&gt;若已签署过纸质或电子协议下，调用该接口时必填，且只可以选择纸质或电子协议；&lt;br/&gt;若已签署过挂网协议下，调用该接口时，选填。
            request.setAgreementInfo(getA0c326fbD2684e10A91fFe6502b671f7());
            // 代扣场景withhold_flag开通需填写 1:权益投流(订阅),2:非权益投流(订阅),3:保险缴纳,4:道路通行费(ETC),5:公共事业(水电煤)缴费,6:物业缴费
            // request.setWithholdPayScene("test");

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
            // 微信支付宝商户简称
            extendInfoMap.Add("short_name", "简称");
            // 是否开通网银
            extendInfoMap.Add("online_flag", "Y");
            // 是否开通快捷
            extendInfoMap.Add("quick_flag", "Y");
            // 是否开通代扣
            extendInfoMap.Add("withhold_flag", "Y");
            // 商户业务类型
            // extendInfoMap.Add("mer_bus_type", "");
            // 是否交易手续费外扣
            extendInfoMap.Add("out_fee_flag", "2");
            // 交易手续费外扣汇付ID
            extendInfoMap.Add("out_fee_huifuid", "");
            // 交易手续费外扣时的账户类型
            extendInfoMap.Add("out_fee_acct_type", "");
            // 支付宝配置对象
            extendInfoMap.Add("ali_conf_list", get478799cd11084bc08ed485f3a249ca6a());
            // 支付宝直连配置对象
            // extendInfoMap.Add("ali_zl_conf", get634ed7c84eca4ad0Bb8421c67e824303());
            // 开通支付宝预授权
            extendInfoMap.Add("alipay_pre_auth_flag", "N");
            // 微信配置对象
            extendInfoMap.Add("wx_conf_list", get09f8037593ee4eac9570Ba9ddc1612ad());
            // 微信直连配置对象
            // extendInfoMap.Add("wx_zl_conf", get319b652307344ce79d45307f2d114a68());
            // 开通微信预授权
            extendInfoMap.Add("wechatpay_pre_auth_flag", "N");
            // 银联二维码配置
            extendInfoMap.Add("union_conf_list", get60616eb26e03439f81239fb8318ed62f());
            // 银行卡业务配置
            extendInfoMap.Add("bank_card_conf", getDeea5d3d4d29471bB7b29439f1d0e07f());
            // 线上费率配置
            // extendInfoMap.Add("online_fee_conf_list", get2bc56ce2B064446fA95a9832dad239f0());
            // 线上手续费承担方配置
            // extendInfoMap.Add("online_pay_fee_conf_list", get3b35e04908e947e78769A1e5f2f0ed74());
            // 运营媒介
            // extendInfoMap.Add("online_media_info_list", getFa5274c3A5ea48f6A5467a586e8ea582());
            // *余额支付配置*
            extendInfoMap.Add("balance_pay_config", getF56330e7Fc644efbB753F7b0f8a9b6e1());
            // 全域资金管理配置(华通银行)
            // extendInfoMap.Add("out_order_funds_config", getEab35e389c13461fA6edAc767aed351b());
            // 补贴支付
            extendInfoMap.Add("combine_pay_config", getA9f5c1e22a994d8f90206da940897690());
            // 花呗分期费率配置
            extendInfoMap.Add("hb_fq_fee_config", get1ad8faaeE63645969b3413b8681e4638());
            // 分账配置信息
            // extendInfoMap.Add("split_conf_info", getEfbd03dfC75a4afa8ac76f4d0f398331());
            // 延迟入账开关
            extendInfoMap.Add("delay_flag", "Y");
            // 商户开通强制延迟标记
            extendInfoMap.Add("forced_delay_flag", "Y");
            // 使用上级微信、支付宝商户号发起交易
            // extendInfoMap.Add("use_chains_flag", "");
            // *补充文件信息*
            // extendInfoMap.Add("extended_material_list", getAef40e3c790348dbB940468f1aabc693());
            // 开户费用值(元)
            // extendInfoMap.Add("enter_fee", "");
            // 开户费用类型
            // extendInfoMap.Add("enter_fee_flag", "");
            // 是否开通在线退款
            // extendInfoMap.Add("online_refund", "");
            // 是否支持平台退款
            // extendInfoMap.Add("platform_refund", "");
            // 是否支持撤销
            // extendInfoMap.Add("support_revoke", "");
            // 异步消息接收地址
            extendInfoMap.Add("async_return_url", "http://192.168.85.157:30031/sspm/testVirgo");
            // 业务开通结果异步消息接收地址
            extendInfoMap.Add("busi_async_return_url", "");
            // 交易异步应答地址
            extendInfoMap.Add("recon_resp_addr", "http://192.168.85.157:30031/sspm/testVirgo");
            // 银联线上收银台
            // extendInfoMap.Add("uni_app_payment_config", get0e8626b0D6ff4e189d0b94738e302de9());
            // 资金归集开通标记
            // extendInfoMap.Add("fund_collection_flag", "");
            // 代发配置
            // extendInfoMap.Add("surrogate_config_list", get813386b7B20640ebBf098997c6ed1cf3());
            // 大额支付配置
            // extendInfoMap.Add("large_amt_pay_config", get323ec72fF7404f0fA5c50ecc9d190984());
            // 统一收银台开关
            // extendInfoMap.Add("half_pay_host_flag", "");
            // 代发复核配置
            // extendInfoMap.Add("agent_recheck_config", get3b97fbcbC6de4a4c9e68Eed1e77df906());
            // 商户开通网银充值开关
            // extendInfoMap.Add("online_recharge_flag", "");
            // 是否开通垫资退款
            // extendInfoMap.Add("refund_mend_open_flag", "");
            // 捷行付配置
            // extendInfoMap.Add("jxf_conf_info", getCe1839a2C3ac42bf9cef719131bec63f());
            // 合单支付配置信息
            // extendInfoMap.Add("merge_pay_config_info", get1a36010d242b46c3B1ea818fca738eed());
            // 是否开通账单支付
            // extendInfoMap.Add("bill_payment_flag", "");
            // 交易应答返回推送系统号
            // extendInfoMap.Add("recon_resp_sys_id", "");
            return extendInfoMap;
        }

        private static string get2a2149bfAf854643B51c7f1b9da01424() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 签约人类型
            // obj.Add("type", "test");
            // 姓名签约人类型&#x3D;其他，必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：张三&lt;/font&gt;
            // obj.Add("name", "test");
            // 身份证签约人类型&#x3D;联系人/其他，必填 ；注意：**签约人会做姓名+身份证+手机号验证，请正确填写**；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：320946195712025082&lt;/font&gt;
            // obj.Add("cert_no", "test");
            // 手机号签约人类型&#x3D;法人/其他 ，必填；注意：**签约人会做姓名+身份证+手机号验证，请正确填写**；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：13917463536&lt;/font&gt;
            // obj.Add("mobile_no", "test");
            // 邮箱
            // obj.Add("email", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getDc710134049547279fb86ddf6e01a8b4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 联系人身份证号码
            // obj.Add("id_card_number", "test");
            // 联系人姓名
            // obj.Add("name", "");
            // 联系人手机号
            // obj.Add("mobile", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getA08df1f978214d45880bA4689292cd7b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 证件持有人类型
            // obj.Add("legal_type", "");
            // 证件类型
            // obj.Add("card_type", "");
            // 姓名
            // obj.Add("person_name", "");
            // 证件号码
            // obj.Add("card_no", "");
            // 证件生效时间
            // obj.Add("effect_time", "");
            // 证件过期时间
            // obj.Add("expire_time", "");
            // 证件正面照
            // obj.Add("card_front_img", "");
            // 证件反面照
            // obj.Add("card_back_img", "");
            // 授权函照片
            // obj.Add("auth_letter_img", "");
            // 是否为受益人
            // obj.Add("is_benefit_person", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getD7503dc89d9142b388787e0fa8d34b96() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否金融机构
            // obj.Add("finance_institution_flag", "");
            // 金融机构类型
            // obj.Add("finance_type", "");
            // 证书类型
            // obj.Add("cert_type", "");
            // 小微经营类型
            // obj.Add("micro_biz_type", "");
            // 特殊行业id
            // obj.Add("special_category_id", "");
            // 联系人信息对象
            // obj.Add("contact_person_info", getDc710134049547279fb86ddf6e01a8b4());
            // 法人身份信息
            // obj.Add("legal_person_info", getA08df1f978214d45880bA4689292cd7b());

            return obj;
        }
        private static string get478799cd11084bc08ed485f3a249ca6a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            obj.Add("pay_scene", "1");
            // 手续费（%）
            obj.Add("fee_rate", "0.38");
            // 子渠道号
            obj.Add("pay_channel_id", "JQF00001");
            // 最低收取手续费（元）
            // obj.Add("fee_min_amt", "");
            // 是否需要实名认证
            // obj.Add("is_check_real_name", "");
            // 实名认证信息
            // obj.Add("al_real_name_info", getD7503dc89d9142b388787e0fa8d34b96());
            // *商户经营类目*
            obj.Add("mcc", "2015091000052157");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object get58acf53807e44c16B72605774e47900b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get634ed7c84eca4ad0Bb8421c67e824303() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 申请类型
            // obj.Add("apply_type", "test");
            // 商户支付宝账号
            // obj.Add("account", "test");
            // 服务费率仅支持渠道商。平台商户调用不支持该字段服务费率（%），0.38~3之间，精确到0.01。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.06&lt;/font&gt;
            // obj.Add("fee_rate", "test");
            // 文件列表
            // obj.Add("file_list", get58acf53807e44c16B72605774e47900b());
            // 联系人姓名
            // obj.Add("contact_name", "");
            // 联系人手机号
            // obj.Add("contact_mobile_no", "");
            // 联系人电子邮箱
            // obj.Add("contact_email", "");
            // 订单授权凭证
            // obj.Add("order_ticket", "");
            // 营业执照编号
            // obj.Add("license_code", "");
            // 营业执照有效期类型
            // obj.Add("license_validity_type", "");
            // 营业执照有效期开始日期
            // obj.Add("license_begin_date", "");
            // 营业执照有效期截止日期
            // obj.Add("license_end_date", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get36c6da20338643bbBa7c2f31aa510aff() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 联系人姓名联系人类型contact_type&#x3D;SUPER时必填。示例值：张三
            // obj.Add("name", "test");
            // 联系人手机号联系人类型contact_type&#x3D;SUPER时必填。示例值：13917364538
            // obj.Add("mobile", "test");
            // 联系人证件类型联系人类型contact_type&#x3D;SUPER时必填。&lt;br/&gt;枚举值参见《自然人证件类型》说明，示例值：00&lt;br/&gt;个体户/企业/事业单位/社会组织：可选择任一证件类型，政府机关仅支持身份证类型。
            // obj.Add("contact_id_doc_type", "test");
            // 联系人证件号码联系人类型contact_type&#x3D;SUPER时必填。示例值：320936198512035017
            // obj.Add("id_card_number", "test");
            // 联系人证件有效期开始时间联系人类型contact_type&#x3D;SUPER时必填&lt;br/&gt;格式：yyyy-MM-dd；示例值：2019-06-06
            // obj.Add("contact_period_begin", "test");
            // 联系人证件有效期结束时间联系人类型contact_type&#x3D;SUPER时必填&lt;br/&gt;格式：yyyy-MM-dd；示例值：2029-06-06&lt;br/&gt;结束时间大于开始时间;若证件有效期为长期，请填写：长期
            // obj.Add("contact_period_end", "test");
            // 是否金融机构
            // obj.Add("finance_institution_flag", "");
            // 金融机构类型
            // obj.Add("finance_type", "");
            // 证书类型
            // obj.Add("cert_type", "");
            // 小微经营类型
            // obj.Add("micro_biz_type", "");
            // 特殊行业id
            // obj.Add("special_category_id", "");
            // 联系人类型
            // obj.Add("contact_type", "");

            return obj;
        }
        private static string get09f8037593ee4eac9570Ba9ddc1612ad() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            obj.Add("pay_scene", "1");
            // 手续费（%）
            obj.Add("fee_rate", "0.38");
            // *商户经营类目*
            obj.Add("mcc", "111");
            // 费率规则号
            obj.Add("fee_rule_id", "758");
            // 子渠道号
            obj.Add("pay_channel_id", "JP00001");
            // 最低收取手续费（元）
            // obj.Add("fee_min_amt", "");
            // 是否需要实名认证
            // obj.Add("is_check_real_name", "");
            // 实名认证信息
            // obj.Add("wx_real_name_info", get36c6da20338643bbBa7c2f31aa510aff());

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object get320f0de00b3b4710825559b061567546() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            return obj;
        }
        private static object get78f624039b2449b38d76E5508f04c84b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 联系人类型
            // obj.Add("contact_type", "test");
            // 联系人姓名联系人类型为经办人时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：张三&lt;/font&gt;
            // obj.Add("contact_name", "test");
            // 联系人证件类型联系人类型为经办人时必填；00：身份证01:护照11：港澳台同胞通行证12：外国人居留证13：港澳居民证14：台湾居民证&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00&lt;/font&gt;；
            // obj.Add("cert_type", "test");
            // 联系人证件号码联系人类型为经办人时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：32090297512026402&lt;/font&gt;
            // obj.Add("contact_cert_no", "test");
            // 联系人手机号
            // obj.Add("contact_mobile_no", "test");
            // 联系人电子邮箱
            // obj.Add("contact_email", "test");
            // 联系人资料联系人类型为经办人时必填F28-联系人身份证国徽面   F29-联系人身份证人像面F227-微信业务办理授权函&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：&lt;/font&gt;
            // obj.Add("contact_file_list", get320f0de00b3b4710825559b061567546());
            // 证件有效期类型
            // obj.Add("contact_cert_validity_type", "test");
            // 证件有效期开始日期
            // obj.Add("contact_cert_begin_date", "test");
            // 证件有效期截止日期
            // obj.Add("contact_cert_end_date", "");

            return obj;
        }
        private static object getEd2ea2f2A51b42e3842497f1ae54b8f3() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get0b0fe85fCdad4e49B992Cbfa72fbf901() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 证件类型
            // obj.Add("ubo_cert_type", "test");
            // 证件号码
            // obj.Add("ubo_cert_no", "test");
            // 姓名
            // obj.Add("ubo_name", "test");
            // 受益人证件居住地址
            // obj.Add("ubo_cert_doc_address", "test");
            // 证件有效类型
            // obj.Add("ubo_cert_validity_type", "test");
            // 证件有效期开始日期
            // obj.Add("ubo_cert_begin_date", "test");
            // 文件列表
            // obj.Add("ubo_file_list", getEd2ea2f2A51b42e3842497f1ae54b8f3());
            // 证件有效期截止日期
            // obj.Add("ubo_cert_end_date", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get64dfc222C69047f5A10e7eab12dc12e1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 经营者/法人是否为受益人
            // obj.Add("ubo_type", "test");
            // 受益人信息列表jsonArray格式,当ubo_type为Y时可不填
            // obj.Add("ubo_info_list", get0b0fe85fCdad4e49B992Cbfa72fbf901());

            return obj;
        }
        private static object get6f12a4f38ce74bd39b80B3a95031b563() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            return obj;
        }
        private static object getC45fb266083a4a3fB1225dd52b1dbcfc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 经营场景类型
            // obj.Add("sales_scenes_type", "test");
            // 功能费率仅支持渠道商传入该字段。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.06&lt;/font&gt;平台商户为子商户开通微信直连支付时，不支持该字段，取平台商户费率上送微信。
            // obj.Add("fee_rate", "test");
            // 线下场所对应的商家公众号APPID开通线下门店场景时，填入。都填入时，取公众号的上送微信。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx51aa91a575359ff5&lt;/font&gt;
            // obj.Add("biz_sub_jsapi_app_id", "test");
            // 线下场所对应的商家小程序APPID开通线下门店场景时，填入。都填入时，取公众号的上送微信。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wxea9c30a90fs8d3fe&lt;/font&gt;
            // obj.Add("biz_sub_mini_app_id", "test");
            // 服务商公众号 ID开通公众号场景时，直连服务商和商户的公众号 APP ID，二选一填入。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx51aa91a575359ff5&lt;/font&gt;
            // obj.Add("jsapi_app_id", "test");
            // 商家公众号APPID开通公众号场景时，直连服务商和商户的公众号 APP ID，二选一填入。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wxea9c30a90fs8d3fe&lt;/font&gt;
            // obj.Add("jsapi_sub_app_id", "test");
            // 服务商小程序APPID开通小程序场景时，直连服务商和商户的小程序 APP ID，二选一填入。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx51aa91a575359ff5&lt;/font&gt;
            // obj.Add("mini_app_id", "test");
            // 商家小程序APPID开通小程序场景时，直连服务商和商户的小程序 APP ID，二选一填入。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx51aa91a575359ff5&lt;/font&gt;
            // obj.Add("mini_sub_app_id", "test");
            // 服务商应用APPID开通 APP 场景时，直连服务商和商户的 APP ID，二选一填入。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx51aa91a575359ff5&lt;/font&gt;
            // obj.Add("app_app_id", "test");
            // 商家应用APPID开通 APP 场景时，直连服务商和商户的 APP ID，二选一填入。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx51aa91a575359ff5&lt;/font&gt;
            // obj.Add("app_sub_app_id", "test");
            // 互联网网站域名开通互联网场景时填入；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：huifu.com&lt;/font&gt;
            // obj.Add("web_domain", "test");
            // 互联网网站对应的商家APPID开通互联网场景时填入；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：wx51aa91a575359ff5&lt;/font&gt;
            // obj.Add("web_app_id", "test");
            // 商家企业微信CorpID开通企业微信场景时填入；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：xxxxx&lt;/font&gt;
            // obj.Add("sub_corp_id", "test");
            // 文件列表
            // obj.Add("sales_scenes_file_list", get6f12a4f38ce74bd39b80B3a95031b563());
            // 文件列表
            // obj.Add("fee_rate_file_list", "");
            // 门店名称
            // obj.Add("biz_store_name", "");
            // 门店省市编码
            // obj.Add("biz_address_code", "");
            // 门店地址
            // obj.Add("biz_store_address", "");

            return obj;
        }
        private static object getE67eebf9E29847ce8ff76640f4321a74() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object getF58e55d153ae4670889324133cde20cc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 登记证书类型
            // obj.Add("cert_type", "test");
            // 证书号
            // obj.Add("cert_no", "test");
            // 证书商户名称
            // obj.Add("cert_mer_name", "test");
            // 注册地址
            // obj.Add("reg_detail", "test");
            // 法人姓名
            // obj.Add("legal_name", "test");
            // 证书有效期类型
            // obj.Add("cert_validity_type", "test");
            // 证书有效期开始日期
            // obj.Add("cert_begin_date", "test");
            // 文件列表
            // obj.Add("cert_file_list", getE67eebf9E29847ce8ff76640f4321a74());
            // 证书有效期截止日期
            // obj.Add("cert_end_date", "");

            return obj;
        }
        private static object get8f45ecc572224de89d24B33c95e03414() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 账户类型
            // obj.Add("card_type", "test");
            // 开户名称
            // obj.Add("card_name", "test");
            // 开户银行
            // obj.Add("bank_code", "test");
            // 开户银行省编码
            // obj.Add("prov_id", "test");
            // 开户银行市编码
            // obj.Add("area_id", "test");
            // 开户银行联行号开户银行联行号与开户银行全称（含支行)二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：102290026507&lt;/font&gt;
            // obj.Add("branch_code", "test");
            // 开户银行全称（含支行)开户银行联行号与开户银行全称（含支行)二选一；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：中国工商银行股份有限公司上海市中山北路支行&lt;/font&gt;
            // obj.Add("branch_name", "test");
            // 银行账号
            // obj.Add("card_no", "test");

            return obj;
        }
        private static object getF62fbb8f44914cbd96afE8f2c9dd0412() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 申请服务
            // obj.Add("service_code", "test");
            // 功能服务appid
            // obj.Add("sub_app_id", "test");
            // 功能开关
            // obj.Add("switch_state", "test");
            // 功能费率(%)
            // obj.Add("fee_rate", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get2844bc2687cf4686A0e49a1f80be81c3() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get319b652307344ce79d45307f2d114a68() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 微信子商户号微信支付分配的子商户号；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1632157057&lt;/font&gt;
            // obj.Add("sub_mch_id", "test");
            // 联系人信息jsonObject字符串,新增时必填
            // obj.Add("contact_info", get78f624039b2449b38d76E5508f04c84b());
            // 最终受益人信息jsonObject字符串，商户类型为企业时，微信侧必填。（如果基本信息里有的话，可以不传取 huifu_id 对应的信息）。新增时填入
            // obj.Add("ubo_info", get64dfc222C69047f5A10e7eab12dc12e1());
            // 经营场景jsonObject字符串，新增时填入
            // obj.Add("sales_info", getC45fb266083a4a3fB1225dd52b1dbcfc());
            // 特殊主体登记证书jsonObject字符串，商户营业执照类型为政府机关/事业单位/其他组织时，传入相应信息。新增时需填入
            // obj.Add("certificate_info", getF58e55d153ae4670889324133cde20cc());
            // 银行账户信息jsonObject字符串，该字段不填时，取商户在汇付系统录入的结算账号信息。新增或修改时填入，修改时必填
            // obj.Add("wx_card_info", get8f45ecc572224de89d24B33c95e03414());
            // 配置集合对指定的sub_mch_id做配置
            // obj.Add("wx_zl_pay_conf_list", getF62fbb8f44914cbd96afE8f2c9dd0412());
            // 操作类型ADD-新增， UPDATE-修改， 默认新增；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：ADD&lt;/font&gt;
            // obj.Add("operate_type", "test");
            // 补充说明信息
            // obj.Add("business_addition_msg", "");
            // 补充说明文件列表
            // obj.Add("addition_file_list", get2844bc2687cf4686A0e49a1f80be81c3());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get60616eb26e03439f81239fb8318ed62f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 借记卡手续费（%）
            // obj.Add("debit_fee_rate", "test");
            // 贷记卡手续费1000以上（%）
            obj.Add("credit_fee_rate_up", "0.56");
            // 贷记卡手续费1000及以下（%）
            obj.Add("credit_fee_rate_down", "0.38");
            // 银联业务手续费类型
            obj.Add("charge_cate_code", "03");
            // 商户经营类目
            obj.Add("mcc", "5411");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getDeea5d3d4d29471bB7b29439f1d0e07f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 借记卡手续费（%）
            obj.Add("debit_fee_rate", "0.38");
            // 贷记卡手续费（%）
            obj.Add("credit_fee_rate", "0.39");
            // *商户经营类目*
            obj.Add("mcc", "5411");
            // 银行业务手续费类型
            obj.Add("charge_cate_code", "02");
            // 借记卡封顶值
            obj.Add("debit_fee_limit", "0.56");
            // 是否开通小额双免
            obj.Add("is_open_small_flag", "0");
            // 小额双免单笔限额(元)
            obj.Add("small_free_amt", "1000");
            // 小额双免手续费（%）
            obj.Add("small_fee_amt", "0.33");
            // 云闪付开通状态
            // obj.Add("is_open_cloud_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get2bc56ce2B064446fA95a9832dad239f0() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            // obj.Add("fee_type", "test");
            // 银行编码
            // obj.Add("bank_id", "test");
            // 功能开关状态
            // obj.Add("stat_flag", "test");
            // 借贷标志
            // obj.Add("dc_flag", "test");
            // 银行名称
            // obj.Add("bank_name", "");
            // 银行中文简称
            // obj.Add("bank_short_chn", "");
            // 手续费（固定/元）
            // obj.Add("fix_amt", "");
            // 费率（%）
            // obj.Add("fee_rate", "");
            // 手续费最小值（元）
            // obj.Add("fee_min_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get3b35e04908e947e78769A1e5f2f0ed74() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            // obj.Add("pay_type", "");
            // 手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getFa5274c3A5ea48f6A5467a586e8ea582() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // *运营媒介类型*
            // obj.Add("media_type", "test");
            // *媒介名称*PC网站域名／APP名称／小程序名称／公众号名称；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：汇付服务&lt;/font&gt;&lt;br/&gt;运营媒介类型为 ：S1/S2/S3/S4时，必填；
            // obj.Add("media_name", "test");
            // ICP备案/许可证号运营媒介类型为 ：S1时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：沪ICP备06046402号-28&lt;/font&gt;
            // obj.Add("mer_icp", "test");
            // *其他有效信息*其他有效信息或链接地址/APP下载地址；类型为S5或S2必填&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：http://download.huifu.com&lt;/font&gt;
            // obj.Add("other_info", "test");
            // *媒介主体与商户主体是否一致*Y/N；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：Y&lt;/font&gt;&lt;br/&gt;运营媒介为S1、S2、S3、S4且企业商户开通快捷或网银，或大额转账，或余额支付或分账业务（20%（不含）-100%），或为个人商户开通分账业务（10%（不含）-100%），必填&lt;br/&gt;若不一致，则需提供ICP备案/APP/微信公众号/小程序主体与商户的使用授权或开发证明材料；
            // obj.Add("media_mer_common_flag", "test");
            // *授权或开发证明材料*运营媒介为S1、S2、S3、S4且媒介主体与商户主体不一致时，且企业商户开通快捷或网银，或大额转账，或余额支付或分账业务（20%（不含）-100%），或为个人商户开通分账业务（10%（不含）-100%），必填&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // obj.Add("authorize_materials", "test");
            // 微信APP补充材料运营媒介为S2且开通微信下app支付时选填，具体见[图片上传接口](https://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)
            // obj.Add("other_material", "test");
            // appId运营媒介为S2且开通微信下app支付时必填
            // obj.Add("app_id", "test");
            // appId认证主体名称运营媒介为S2且开通微信下app支付时必填
            // obj.Add("app_name", "test");
            // 补充说明运营媒介为S2且开通微信下app支付时选填
            // obj.Add("supplement", "test");
            // *测试账号*
            // obj.Add("test_account", "");
            // *测试密码*
            // obj.Add("test_secret", "");
            // *运营媒介-首页*
            // obj.Add("media_front_page", "");
            // *运营媒介-服务/商品明细页面*
            // obj.Add("media_service_page", "");
            // *运营媒介-下单场景页面*
            // obj.Add("media_order_page", "");
            // *运营媒介-支付页面*
            // obj.Add("media_pay_page", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object getA40c082d6276428aB27a6e976fcba2ae() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // *业务模式说明*请详细说明商户的业务模式，包括不限于（业务参与方、各方的权利及义务关系等）。最大500个汉字，仅Pro版时必填&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：商户向企业采购产品，并将其展示在其电商平台上，用户注册后购买其产品，产品主要有家电、服饰、鞋帽等，用户购买产品的资金作为商户所得，商户根据订单情况进行物流配送。&lt;/font&gt;
            // obj.Add("busi_instruction", "test");
            // *资金流向说明*请详细说明商户的资金流向，包括但不限于（交易所涉及的各方账户、资金流入流出过程等）。最大500个汉字，仅Pro版时必填&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：用户选购产品后根据订单支付给商户，商户根据结算周期，结算到对公账户。&lt;/font&gt;
            // obj.Add("capital_instruction", "test");
            // *功能开通用途说明*请详述所申请功能的原因、场景、涉及对象类型。最大500个汉字，仅Pro版时必填&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：企业工资代发&lt;/font&gt;
            // obj.Add("function_instruction", "test");

            return obj;
        }
        private static string getF56330e7Fc644efbB753F7b0f8a9b6e1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // *业务模式*
            // obj.Add("balance_model", "test");
            // 业务情况说明
            // obj.Add("description_info", getA40c082d6276428aB27a6e976fcba2ae());
            // 手续费(%)
            obj.Add("fee_rate", "2");
            // 手续费（固定/元）
            obj.Add("fee_fix_amt", "1");
            // 手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");
            // 扣费模式
            // obj.Add("charge_mode", "");
            // 余额支付模式
            // obj.Add("pay_mode", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getEe350cc29338400a84451596d904827c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支行联行号card_type为0时必填，参考：[银行支行编码](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_yhzhbm)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：102290026507&lt;/font&gt;
            // obj.Add("branch_code", "test");
            // 支行名称card_type为0时必填 ,参考：[银行支行编码](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_yhzhbm)；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：中国工商银行上海市中山北路支行&lt;/font&gt;
            // obj.Add("branch_name", "test");
            // 结算账户名
            // obj.Add("card_name", "test");
            // 银行卡号
            // obj.Add("card_no", "test");
            // 卡类型
            // obj.Add("card_type", "test");
            // 持卡人证件类型00:身份证；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00&lt;/font&gt;；card_type为1时选填。
            // obj.Add("cert_type", "test");
            // 持卡人证件有效期（起始）card_type为1时选填；格式：yyyyMMdd，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20210830&lt;/font&gt;；&lt;br/&gt;若填写cert_no，cert_validity_type，cert_type需同时填写。
            // obj.Add("cert_begin_date", "test");
            // 持卡人证件有效期（截止）cert_validity_type变更为0时必填，格式：yyyyMMdd；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20210830&lt;/font&gt;
            // obj.Add("cert_end_date", "test");
            // 持卡人证件号码card_type为1时选填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：310112200001018888&lt;/font&gt;；
            // obj.Add("cert_no", "test");
            // 银行卡绑定手机号
            // obj.Add("mp", "test");
            // 开户许可证核准号
            // obj.Add("open_licence_no", "test");
            // 银行所在省
            // obj.Add("prov_id", "");
            // 银行所在市
            // obj.Add("area_id", "");
            // 银行编码
            // obj.Add("bank_code", "");
            // 持卡人证件有效期类型
            // obj.Add("cert_validity_type", "");

            return obj;
        }
        private static object get80aebe804e89490d839428fdc8fb94ad() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开户手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 开户手续费外扣时的账户类型01-基本户，05-充值户，09-营销户，不填默认01；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01&lt;/font&gt;&lt;br/&gt;注：fee_fix_amt：开户手续费大于0时必填
            // obj.Add("out_fee_acct_type", "test");
            // 开户手续费外扣汇付ID开通手续费外扣业务时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812123&lt;/font&gt;&lt;br/&gt;注：fee_fix_amt：开户手续费大于0时必填
            // obj.Add("out_fee_huifuid", "test");

            return obj;
        }
        private static string getEab35e389c13461fA6edAc767aed351b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 自动入账开关
            // obj.Add("out_order_auto_acct_flag", "test");
            // 全渠道资金管理补充材料涉及文件类型：F504-全渠道资金管理补充材料；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;
            // obj.Add("other_payment_institutions_pic", "test");
            // 支付手续费(%)
            // obj.Add("fee_rate", "");
            // 手续费最小值(元)
            // obj.Add("fee_min_amt", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣标记
            // obj.Add("out_fee_flag", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 全域资金开户银行卡信息
            // obj.Add("out_order_acct_card", getEe350cc29338400a84451596d904827c());
            // 全域资金开户手续费
            // obj.Add("out_order_acct_open_fees", get80aebe804e89490d839428fdc8fb94ad());
            // 全域支付业务模式
            // obj.Add("business_model", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getA9f5c1e22a994d8f90206da940897690() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "test");
            // 手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "test");
            // 手续费(%)
            obj.Add("fee_rate", "10");
            // 手续费（固定/元）
            obj.Add("fee_fix_amt", "5");
            // 手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get1ad8faaeE63645969b3413b8681e4638() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 花呗收单分期3期（%）分期费率不为空时，收单费率必填，大于0，保留2位小数，不小于渠道商成本；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.0&lt;/font&gt;代表费率为1.00%
            obj.Add("acq_three_period", "1.30");
            // 花呗收单分期6期（%）分期费率不为空时，收单费率必填，大于0，保留2位小数，不小于渠道商成本；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.0&lt;/font&gt;代表费率为1.00%
            obj.Add("acq_six_period", "4.60");
            // 花呗收单分期12期（%）分期费率不为空时，收单费率必填，大于0，保留2位小数，不小于渠道商成本；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.0&lt;/font&gt;代表费率为1.00%
            obj.Add("acq_twelve_period", "9.12");
            // 花呗收单分期24期（%）分期费率不为空时，收单费率必填，大于0，保留2位小数，不小于渠道商成本；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.0&lt;/font&gt;代表费率为1.00%
            // obj.Add("acq_twentyfour_period", "test");
            // 花呗分期3期（%）
            obj.Add("three_period", "1.80");
            // 花呗分期6期（%）
            obj.Add("six_period", "4.60");
            // 花呗分期12期（%）
            obj.Add("twelve_period", "9.12");
            // 商户经营类目
            obj.Add("ali_mcc", "5411");
            // 支付场景
            obj.Add("pay_scene", "1");
            // 花呗分期24期（%）
            // obj.Add("twentyfour_period", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getBc37c628853c4916Bb305bbe29cf732b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账比例
            // obj.Add("fee_rate", "test");
            // 汇付Id
            // obj.Add("huifu_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get055625312aef4e4a9519Bd5c7bc551af() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // *业务模式说明*
            // obj.Add("busi_instruction", "test");
            // *资金流向说明*
            // obj.Add("capital_instruction", "test");
            // *功能开通用途说明*
            // obj.Add("function_instruction", "test");

            return obj;
        }
        private static string getEfbd03dfC75a4afa8ac76f4d0f398331() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账开关
            // obj.Add("div_flag", "test");
            // 分账规则来源
            // obj.Add("rule_origin", "test");
            // 最大分账比例%
            // obj.Add("apply_ratio", "test");
            // 分账模式
            // obj.Add("scene", "test");
            // 分账明细
            // obj.Add("acct_split_bunch_list", getBc37c628853c4916Bb305bbe29cf732b());
            // 生效类型
            // obj.Add("start_type", "");
            // 手续费外扣开关
            // obj.Add("out_fee_flag", "");
            // 手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 手续费%
            // obj.Add("split_fee_rate", "");
            // 固定手续费
            // obj.Add("per_amt", "");
            // 业务情况说明
            // obj.Add("split_ext_info", get055625312aef4e4a9519Bd5c7bc551af());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAef40e3c790348dbB940468f1aabc693() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // *文件id*
            // obj.Add("file_id", "test");
            // *文件类型*
            // obj.Add("file_type", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getA0c326fbD2684e10A91fFe6502b671f7() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // *协议类型*
            obj.Add("agreement_type", "0");
            // *挂网协议地址*挂网协议必填；**必须按示例值填写**，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/PaymentServiceAgreement.htm&lt;/font&gt;；
            // obj.Add("agreement_url", "test");
            // 纸质协议开始日期
            obj.Add("agree_begin_date", "20200325");
            // 纸质协议结束日期
            obj.Add("agree_end_date", "20400325");
            // 电子协议签约短信发送标识
            // obj.Add("message_send_type", "");
            // 电子协议异步通知地址
            // obj.Add("agreement_async_return_url", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get0e8626b0D6ff4e189d0b94738e302de9() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 借记手续费（%）借记卡费率与贷记卡费率不能同时为空;保留2位小数，最大值100.00，最小值0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.02&lt;/font&gt;
            // obj.Add("debit_fee_rate", "test");
            // 贷记手续费（%）借记卡费率与贷记卡费率不能同时为空;保留2位小数，最大值100.00，最小值0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.06&lt;/font&gt;
            // obj.Add("credit_fee_rate", "test");
            // 状态开关
            // obj.Add("switch_state", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 云闪付免密支付开通标识
            // obj.Add("cloud_quick_pass_secret_free_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get813386b7B20640ebBf098997c6ed1cf3() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 代发业务类型
            // obj.Add("surrogate_type", "test");
            // 手续费（固定/元）手续费（固定/元），保留小数点后两位；fee_formula_type为05，06时必填 &lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;
            // obj.Add("fix_amt", "test");
            // 手续费（百分比/%）手续费（百分比/%），保留小数点后两位；取值范围[0.00,100.00]；fee_formula_type为01，02，03，06时必填 &lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;
            // obj.Add("fee_rate", "test");
            // 手续费封顶值（固定/元）手续费封顶值（固定/元），保留小数点后两位；fee_formula_type为03时必填 &lt;font color&#x3D;&quot;green&quot;&gt;示例值：100.00&lt;/font&gt;
            // obj.Add("fee_max_amt", "test");
            // 手续费保底值（固定/元）手续费保底值（固定/元），保留小数点后两位；fee_formula_type为02时必填 &lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;
            // obj.Add("fee_min_amt", "test");
            // 是否交手续费外扣标记
            // obj.Add("out_fee_flag", "");
            // 交易手续费外扣时账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifu_id", "");
            // 是否允许对私代发
            // obj.Add("surrogate_private_flag", "");
            // 代发手续费计费模式
            // obj.Add("fee_formula_type", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object get446d884cEc624539A2b8D74916efc7b1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 大额支付业务模式
            // obj.Add("business_model", "test");
            // 费率（%）开通大额业务时必须填写一种收费方式；大于0,保留2位小数；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;
            // obj.Add("fee_rate", "test");
            // 交易手续费（固定/元）开通大额业务时必须填写一种收费方式；大于0,保留2位小数；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：10.00&lt;/font&gt;
            // obj.Add("fee_fix_amt", "test");
            // 功能开关
            // obj.Add("switch_state", "");
            // 大额调账标识申请类型
            // obj.Add("biz_type", "");
            // 是否允许绑卡支付
            // obj.Add("mer_same_card_recharge_flag", "");
            // 是否允许用户入账
            // obj.Add("allow_user_deposit_flag", "");
            // 备付金固定账号模式自动退款
            // obj.Add("provisions_auto_refund_flag", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get323ec72fF7404f0fA5c50ecc9d190984() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 大额支付配置列表
            // obj.Add("large_amt_pay_config_info_list", get446d884cEc624539A2b8D74916efc7b1());
            // 交易手续费外扣huifuId交易手续费外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000108854952&lt;/font&gt;
            // obj.Add("out_fee_huifu_id", "test");
            // 交易手续费外扣账户号交易手续费外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：F00598602&lt;/font&gt;
            // obj.Add("out_fee_acct_id", "test");
            // 交易手续费外扣标记
            // obj.Add("out_fee_flag", "");
            // 商户付款方卡类型
            // obj.Add("mer_payer_card_type", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get3b97fbcbC6de4a4c9e68Eed1e77df906() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 代发复核开关
            // obj.Add("agent_recheck_flag", "");
            // 复核授权商户号
            // obj.Add("agent_recheck_huifu_id", "");
            // 复核类型
            // obj.Add("agent_recheck_type", "");

            return obj;
        }
        private static object getD6094c6820ef4f098115Ed78e62302c8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 操作人姓名
            // obj.Add("user_name", "test");
            // 操作人手机号
            // obj.Add("operator_phone", "test");
            // 付款方账号
            // obj.Add("acct_no", "test");
            // 付款方账户名称
            // obj.Add("acct_name", "test");
            // 开户行联行号
            // obj.Add("bank_branch_code", "test");
            // 开户行行名
            // obj.Add("bank_branch_name", "test");
            // 签约申请生效日期
            // obj.Add("sign_start_date", "test");
            // 签约申请失效日期
            // obj.Add("sign_end_date", "test");
            // 机构编码
            // obj.Add("org_code", "test");
            // 付款方账户类型
            // obj.Add("acct_type", "");
            // 附言
            // obj.Add("remark", "");

            return obj;
        }
        private static object getCe1839a2C3ac42bf9cef719131bec63f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 账户类型
            // obj.Add("acct_type", "test");
            // 银行账户信息当账户类型为银行账户时必填
            // obj.Add("jxf_bank_info", getD6094c6820ef4f098115Ed78e62302c8());

            return obj;
        }
        private static object getF1e27f53D58f46b785d7B759ddd6e3a8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 合单支付模式
            // obj.Add("merge_pay_mode", "test");

            return obj;
        }
        private static object get1a36010d242b46c3B1ea818fca738eed() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 合单支付开关
            // obj.Add("merge_pay_flag", "test");
            // 合单支付配置合单支付配置 （当合单支付开关为开时必填）
            // obj.Add("merge_pay_config", getF1e27f53D58f46b785d7B759ddd6e3a8());

            return obj;
        }
    }
}
