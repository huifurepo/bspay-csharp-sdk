using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户统一变更接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantIntegrateUpdateRequestDemo
    {

        public static void V2MerchantIntegrateUpdateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantIntegrateUpdateRequest request = new V2MerchantIntegrateUpdateRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付ID
            request.setHuifuId("6666000105240784");
            // 渠道商汇付ID
            request.setUpperHuifuId("6666000105215341");
            // 业务处理类型
            request.setDealType("1");

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
            // 商户基本信息
            extendInfoMap.Add("basic_info", getBasicInfo());
            // 卡信息配置实体
            // extendInfoMap.Add("card_info", getCardInfo());
            // 协议信息实体
            // extendInfoMap.Add("agreement_info", getAgreementInfo());
            // 营销补贴
            // extendInfoMap.Add("combine_pay_config", getCombinePayConfig());
            // 取现配置列表
            // extendInfoMap.Add("cash_config", getCashConfig());
            // 结算配置实体
            // extendInfoMap.Add("settle_config", getSettleConfig());
            // 业务开关对象
            // extendInfoMap.Add("biz_conf", getBizConf());
            // 微信配置对象
            // extendInfoMap.Add("wx_conf_list", getWxConfList());
            // 实名认证信息
            // extendInfoMap.Add("wx_realname_info", getWxRealnameInfo());
            // 支付宝配置对象
            // extendInfoMap.Add("ali_conf_list", getAliConfList());
            // 银联小微入驻信息实体
            // extendInfoMap.Add("union_micro_info", getUnionMicroInfo());
            // 银联配置对象
            // extendInfoMap.Add("union_conf_list", getUnionConfList());
            // 银行卡业务配置实体
            // extendInfoMap.Add("bank_card_conf", getBankCardConf());
            // 余额支付配置实体
            // extendInfoMap.Add("balance_pay_config", getBalancePayConfig());
            // 花呗分期费率配置实体
            // extendInfoMap.Add("hb_fq_fee_config", getHbFqFeeConfig());
            // 商户业务类型
            // extendInfoMap.Add("mer_bus_type", "");
            // 线上费率配置
            // extendInfoMap.Add("online_fee_conf_list", getOnlineFeeConfList());
            // 线上手续费承担方配置
            // extendInfoMap.Add("online_pay_fee_conf_list", getOnlinePayFeeConfList());
            // 文件列表
            // extendInfoMap.Add("file_info", getFileInfo());
            // 异步消息接收地址(审核)
            extendInfoMap.Add("async_return_url", "");
            // 业务开通结果异步消息接收地址
            extendInfoMap.Add("busi_async_return_url", "");
            // 交易异步应答地址
            extendInfoMap.Add("recon_resp_addr", "");
            return extendInfoMap;
        }

        private static string getWxConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            // obj.Add("pay_scene", "test");
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 商户经营类目
            // obj.Add("mcc", "");
            // 子渠道号
            // obj.Add("pay_channel_id", "");
            // 费率规则id
            // obj.Add("fee_rule_id", "");
            // 公众号支付Appid
            // obj.Add("wx_woa_app_id", "");
            // 微信公众号授权目录
            // obj.Add("wx_woa_path", "");
            // 微信小程序APPID
            // obj.Add("wx_applet_app_id", "");
            // 微信公众号APPID对应的秘钥
            // obj.Add("wx_woa_secret", "");
            // 微信小程序APPID对应的秘钥
            // obj.Add("wx_applet_secret", "");
            // 申请服务 
            // obj.Add("service_codes", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getBankCardConf() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 借记卡手续费（%）
            // obj.Add("debit_fee_rate", "test");
            // 贷记卡手续费（%）
            // obj.Add("credit_fee_rate", "test");
            // 商户经营类目
            // obj.Add("mcc", "test");
            // 银行业务手续费类型
            // obj.Add("charge_cate_code", "");
            // 借记卡封顶值
            // obj.Add("debit_fee_limit", "");
            // 云闪付借记卡手续费1000以上（%）
            // obj.Add("cloud_debit_fee_rate_up", "");
            // 云闪付借记卡封顶1000以上(元)
            // obj.Add("cloud_debit_fee_limit_up", "");
            // 云闪付贷记卡手续费1000以上（%）
            // obj.Add("cloud_credit_fee_rate_up", "");
            // 云闪付借记卡手续费1000以下（%）
            // obj.Add("cloud_debit_fee_rate_down", "");
            // 云闪付借记卡封顶1000以下(元)
            // obj.Add("cloud_debit_fee_limit_down", "");
            // 云闪付贷记卡手续费1000以下（%）
            // obj.Add("cloud_credit_fee_rate_down", "");
            // 是否开通小额双免
            // obj.Add("is_open_small_flag", "");
            // 小额双免单笔限额(元)
            // obj.Add("small_free_amt", "");
            // 小额双免手续费（%）
            // obj.Add("small_fee_amt", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getLegalInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 法人姓名
            // obj.Add("legal_name", "test");
            // 法人证件类型
            // obj.Add("legal_cert_type", "test");
            // 法人证件号码
            // obj.Add("legal_cert_no", "test");
            // 法人证件有效期类型
            // obj.Add("legal_cert_validity_type", "test");
            // 法人证件有效期开始日期
            // obj.Add("legal_cert_begin_date", "test");
            // 法人证件有效期截止日期
            // obj.Add("legal_cert_end_date", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getUnionMicroInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银联商户类别
            // obj.Add("mchnt_type", "test");
            // 商户经度
            // obj.Add("mer_lng", "test");
            // 商户纬度
            // obj.Add("mer_lat", "test");
            // 店铺名称
            // obj.Add("shop_name", "test");
            // 商户经营类目
            // obj.Add("mcc", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCombinePayConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付手续费(%)
            // obj.Add("fee_rate", "");
            // 支付固定手续费(元)
            // obj.Add("fee_fix_amt", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAgreementInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 协议类型
            // obj.Add("agreement_type", "test");
            // 协议号
            // obj.Add("agreement_no", "");
            // 协议模板号
            // obj.Add("agreement_model", "");
            // 协议模板名称
            // obj.Add("agreement_name", "");
            // 签约日期
            // obj.Add("sign_date", "");
            // 协议开始日期
            // obj.Add("agree_begin_date", "");
            // 协议结束日期
            // obj.Add("agree_end_date", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getBizConf() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 延迟入账开关
            // obj.Add("delay_flag", "");
            // 商户开通强制延迟标记
            // obj.Add("forced_delay_flag", "");
            // 是否开通网银
            // obj.Add("online_flag", "");
            // 是否开通快捷
            // obj.Add("quick_flag", "");
            // 是否开通代扣
            // obj.Add("withhold_flag", "");
            // 是否开通微信预授权
            // obj.Add("wechatpay_pre_auth_flag", "");
            // 是否开通支付宝预授权
            // obj.Add("alipay_pre_auth_flag", "");
            // 是否开通营销补贴
            // obj.Add("combine_pay_flag", "");
            // 是否开通余额支付
            // obj.Add("balance_pay_flag", "");
            // 是否开通结算
            // obj.Add("settle_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCardInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算类型
            // obj.Add("card_type", "test");
            // 银行所在省
            // obj.Add("prov_id", "test");
            // 银行所在市
            // obj.Add("area_id", "test");
            // 结算账户名
            // obj.Add("card_name", "test");
            // 结算账号
            // obj.Add("card_no", "test");
            // 银行编码
            // obj.Add("bank_code", "");
            // 联行号
            // obj.Add("branch_code", "");
            // 支行名称
            // obj.Add("branch_name", "");
            // 持卡人证件有效期类型
            // obj.Add("cert_validity_type", "");
            // 持卡人证件有效期（起始）
            // obj.Add("cert_begin_date", "");
            // 持卡人证件有效期（截止）
            // obj.Add("cert_end_date", "");
            // 持卡人证件号码
            // obj.Add("cert_no", "");
            // 持卡人证件类型
            // obj.Add("cert_type", "");
            // 银行卡绑定手机号
            // obj.Add("mp", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getOnlineFeeConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            // obj.Add("fee_type", "test");
            // 银行编码
            // obj.Add("bank_id", "test");
            // 借贷标志
            // obj.Add("dc_flag", "test");
            // 费率状态
            // obj.Add("stat_flag", "test");
            // 手续费（固定/元）
            // obj.Add("fix_amt", "");
            // 费率（百分比/%）
            // obj.Add("fee_rate", "");
            // 银行名称
            // obj.Add("bank_name", "");
            // 银行中文简称
            // obj.Add("bank_short_chn", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getUnionConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 借记卡手续费1000以上（%）
            // obj.Add("debit_fee_rate_up", "test");
            // 银联二维码业务贷记卡手续费1000以上（%）
            // obj.Add("credit_fee_rate_up", "test");
            // 借记卡手续费1000以下（%）
            // obj.Add("debit_fee_rate_down", "test");
            // 银联二维码业务贷记卡手续费1000以下（%）
            // obj.Add("credit_fee_rate_down", "test");
            // 银联业务手续费类型
            // obj.Add("charge_cate_code", "");
            // 借记卡封顶1000以上（元）
            // obj.Add("debit_fee_limit_up", "");
            // 借记卡封顶1000以下（元）
            // obj.Add("debit_fee_limit_down", "");
            // 商户经营类目
            // obj.Add("mcc", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getCashConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否开通取现
            // obj.Add("switch_state", "test");
            // 业务类型
            // obj.Add("cash_type", "test");
            // 取现手续费率（%）fix_amt与fee_rate至少填写一项，单位%，需保留小数点后两位，取值范围[0.00,100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;&lt;br/&gt;注：如果fix_amt与fee_rate都填写了则手续费&#x3D;fix_amt+支付金额*fee_rate
            // obj.Add("fee_rate", "test");
            // 提现手续费（固定/元）
            // obj.Add("fix_amt", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");
            // 手续费承担方
            // obj.Add("out_fee_huifu_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getOnlinePayFeeConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            // obj.Add("pay_type", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getBalancePayConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付手续费(%)
            // obj.Add("fee_rate", "");
            // 支付固定手续费(元)
            // obj.Add("fee_fix_amt", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getFileInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // D1结算协议图片文件
            // obj.Add("settle_agree_pic", "");
            // 授权委托书
            // obj.Add("auth_enturst_pic", "");
            // 商务协议
            // obj.Add("ba_pic", "");
            // 公司照片一
            // obj.Add("store_header_pic", "");
            // 公司照片二
            // obj.Add("store_indoor_pic", "");
            // 公司照片三
            // obj.Add("store_cashier_desk_pic", "");
            // 法人身份证反面
            // obj.Add("legal_cert_back_pic", "");
            // 法人身份证正面
            // obj.Add("legal_cert_front_pic", "");
            // 营业执照图片
            // obj.Add("license_pic", "");
            // 组织机构代码证
            // obj.Add("org_code_pic", "");
            // 开户许可证
            // obj.Add("reg_acct_pic", "");
            // 结算卡反面
            // obj.Add("settle_card_back_pic", "");
            // 结算卡正面
            // obj.Add("settle_card_front_pic", "");
            // 结算人身份证反面
            // obj.Add("settle_cert_back_pic", "");
            // 结算人身份证正面
            // obj.Add("settle_cert_front_pic", "");
            // 税务登记证
            // obj.Add("tax_reg_pic", "");
            // 实名登记证书照片
            // obj.Add("cert_pic", "");
            // 个人商户身份证件正面照片
            // obj.Add("identification_front_pic", "");
            // 个人商户身份证件反面照片
            // obj.Add("identification_back_pic", "");
            // 单位证明函照片
            // obj.Add("company_prove_pic", "");
            // 金融机构许可证图片1
            // obj.Add("finance_license_pic1", "");
            // 金融机构许可证图片2
            // obj.Add("finance_license_pic2", "");
            // 金融机构许可证图片3
            // obj.Add("finance_license_pic3", "");
            // 金融机构许可证图片4
            // obj.Add("finance_license_pic4", "");
            // 金融机构许可证图片5
            // obj.Add("finance_license_pic5", "");
            // 联系人身份证正面照
            // obj.Add("contact_id_front_pic", "");
            // 联系人身份证反面照
            // obj.Add("contact_id_back_pic", "");
            // 联系人护照人像面
            // obj.Add("contact_passport_img_pic", "");
            // 联系人证件照正面
            // obj.Add("contact_cert_front_pic", "");
            // 联系人证件照反面
            // obj.Add("contact_cert_back_pic", "");
            // 微信业务办理授权函
            // obj.Add("contact_wx_busi_auth_pic", "");
            // 行业经营许可证资质照片一
            // obj.Add("industry_busi_license_pic1", "");
            // 行业经营许可证资质照片二
            // obj.Add("industry_busi_license_pic2", "");
            // 行业经营许可证资质照片三
            // obj.Add("industry_busi_license_pic3", "");
            // 行业经营许可证资质照片四
            // obj.Add("industry_busi_license_pic4", "");
            // 行业经营许可证资质照片五
            // obj.Add("industry_busi_license_pic5", "");
            // 行业经营许可证资质照片六
            // obj.Add("industry_busi_license_pic6", "");
            // 法人护照人像面
            // obj.Add("legal_passport_img_pic", "");
            // 法人港澳台通行证正面
            // obj.Add("legal_hk_aom_front_pic", "");
            // 法人其他证件照片
            // obj.Add("legal_other_cert_pic", "");
            // 持卡人身份证人像面
            // obj.Add("cert_front_pic", "");
            // 持卡人身份证国徽面
            // obj.Add("cert_back_pic", "");
            // 持卡人护照人像面
            // obj.Add("cert_passport_img_pic", "");
            // 持卡人港澳台通行证正面
            // obj.Add("cert_hk_aom_front_pic", "");
            // 持卡人其它证件照片
            // obj.Add("cert_other_pic", "");
            // 收银台照片
            // obj.Add("cashier_desk_pic", "");
            // 店铺内景照
            // obj.Add("indoor_pic", "");
            // 门头照
            // obj.Add("header_pic", "");
            // 变更申请表文件
            // obj.Add("modify_apply_pic", "");
            // 签约人身份证照片-人像面
            // obj.Add("sign_identity_front_file_id", "");
            // 签约人身份证照片-国徽面
            // obj.Add("sign_identity_back_file_id", "");
            // 签约人法人授权书
            // obj.Add("sign_auth_file_id", "");
            // 支付宝授权函照片
            // obj.Add("contact_ali_busi_auth_pic", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getWxRealnameInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            // obj.Add("pay_scene", "test");
            // 联系人姓名
            // obj.Add("name", "test");
            // 联系人手机号
            // obj.Add("mobile", "test");
            // 联系人证件号码
            // obj.Add("contact_id_card_number", "test");
            // 实名认证类型
            // obj.Add("realname_info_type", "");
            // 子渠道号
            // obj.Add("pay_channel_id", "");
            // 联系人类型
            // obj.Add("contact_type", "");
            // 联系人证件类型
            // obj.Add("contact_id_doc_type", "");
            // 联系人证件有效期开始时间
            // obj.Add("contact_period_begin_date", "");
            // 联系人证件有效期结束时间
            // obj.Add("contact_period_end_date", "");
            // 证书类型
            // obj.Add("cert_type", "");
            // 证书编号
            // obj.Add("cert_number", "");
            // 经营者/法人是否为受益人
            // obj.Add("owner", "");
            // 法人证件居住地址
            // obj.Add("legal_identification_address", "");
            // 小微经营类型
            // obj.Add("micro_biz_type", "");
            // 门店名称
            // obj.Add("store_name", "");
            // 门店省市编码
            // obj.Add("store_address_code", "");
            // 门店地址
            // obj.Add("store_address", "");
            // 特殊行业Id
            // obj.Add("category_id", "");
            // 是否金融机构
            // obj.Add("finance_institution_flag", "");
            // 金融机构类型
            // obj.Add("finance_type", "");
            // 受益人信息
            // obj.Add("ubo_info_list", getUboInfo());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getHbFqFeeConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 花呗收单分期3期（%）分期费率不为空时，收单费率必填，大于0，保留2位小数，不小于渠道商成本；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.0&lt;/font&gt;代表费率为1.00%
            // obj.Add("acq_three_period", "test");
            // 花呗收单分期6期（%）分期费率不为空时，收单费率必填，大于0，保留2位小数，不小于渠道商成本；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.0&lt;/font&gt;代表费率为1.00%
            // obj.Add("acq_six_period", "test");
            // 花呗收单分期12期（%）分期费率不为空时，收单费率必填，大于0，保留2位小数，不小于渠道商成本；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.0&lt;/font&gt;代表费率为1.00%
            // obj.Add("acq_twelve_period", "test");
            // 花呗分期3期（%）
            // obj.Add("three_period", "");
            // 花呗分期6期（%）
            // obj.Add("six_period", "");
            // 花呗分期12期（%）
            // obj.Add("twelve_period", "");
            // 商户经营类目
            // obj.Add("ali_mcc", "");
            // 支付场景
            // obj.Add("pay_scene", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAliConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            // obj.Add("pay_scene", "test");
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 商户经营类目
            // obj.Add("mcc", "");
            // 子渠道号
            // obj.Add("pay_channel_id", "");
            // 拟申请的间联商户等级
            // obj.Add("indirect_level", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getSettleConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算周期
            // obj.Add("settle_cycle", "test");
            // 节假日结算手续费率
            // obj.Add("fixed_ratio", "");
            // 起结金额
            // obj.Add("min_amt", "");
            // 结算手续费外扣时的账户类型
            // obj.Add("out_settle_acct_type", "");
            // 结算手续费外扣时的汇付ID
            // obj.Add("out_settle_huifuid", "");
            // 手续费外扣标记
            // obj.Add("out_settle_flag", "");
            // 留存金额
            // obj.Add("remained_amt", "");
            // 结算摘要
            // obj.Add("settle_abstract", "");
            // 结算批次号
            // obj.Add("settle_batch_no", "");
            // 结算方式
            // obj.Add("settle_pattern", "");
            // 是否优先到账
            // obj.Add("is_priority_receipt", "");
            // 自定义结算处理时间
            // obj.Add("settle_time", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getContactInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 联系人姓名
            // obj.Add("contact_name", "test");
            // 联系人手机号
            // obj.Add("contact_mobile_no", "test");
            // 联系人电子邮箱
            // obj.Add("contact_email", "test");
            // 联系人身份证号
            // obj.Add("contact_cert_no", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getBasicInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 经营简称
            obj.Add("short_name", "张三");
            // 小票名称
            obj.Add("receipt_name", "");
            // 商户英文名称
            obj.Add("mer_en_name", "");
            // 所属行业
            obj.Add("mcc", "");
            // 营业执照类型
            obj.Add("license_type", "");
            // 营业执照有效期开始日期
            obj.Add("license_begin_date", "");
            // 营业执照有效期截止日期
            obj.Add("license_end_date", "");
            // 营业执照有效期类型
            obj.Add("license_validity_type", "");
            // 注册详细地址
            obj.Add("reg_detail", "");
            // 注册省
            obj.Add("reg_prov_id", "");
            // 注册市
            obj.Add("reg_area_id", "");
            // 注册区
            obj.Add("reg_district_id", "");
            // 经营详细地址
            obj.Add("detail_addr", "");
            // 经营省
            obj.Add("prov_id", "");
            // 经营市
            obj.Add("area_id", "");
            // 经营区
            obj.Add("district_id", "");
            // 客服电话
            obj.Add("service_phone", "");
            // 商户主页URL
            obj.Add("mer_url", "");
            // 商户ICP备案编号
            obj.Add("mer_icp", "");
            // 开户许可证核准号
            obj.Add("open_licence_no", "");
            // 法人信息
            // obj.Add("legal_info", getLegalInfo());
            // 联系人信息
            // obj.Add("contact_info", getContactInfo());
            // 签约人
            // obj.Add("sign_user_info", getSignUserInfo());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getSignUserInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 签约人类型
            // obj.Add("type", "test");
            // 姓名
            // obj.Add("sign_name", "");
            // 手机号
            // obj.Add("sign_mobile_no", "");
            // 身份证
            // obj.Add("sign_cert_no", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getUboInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 证件类型
            // obj.Add("ubo_id_doc_type", "test");
            // 证件正面照片
            // obj.Add("ubo_id_doc_copy", "test");
            // 证件姓名
            // obj.Add("ubo_id_doc_name", "test");
            // 证件号码
            // obj.Add("ubo_id_doc_number", "test");
            // 证件居住地址
            // obj.Add("ubo_id_doc_address", "test");
            // 证件有效期开始时间
            // obj.Add("ubo_period_begin", "test");
            // 证件有效期结束时间
            // obj.Add("ubo_period_end", "test");
            // 证件反面照片
            // obj.Add("ubo_id_doc_copy_back", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
