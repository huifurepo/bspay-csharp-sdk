using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户统一进件接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantIntegrateRegRequestDemo
    {

        public static void V2MerchantIntegrateRegRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantIntegrateRegRequest request = new V2MerchantIntegrateRegRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 渠道商汇付id
            request.setUpperHuifuId("6666000105215341");
            // 公司类型
            request.setEntType("3");
            // 商户名称
            request.setRegName("天马微电子股份有限公司");
            // 经营类型
            request.setBusiType("1");
            // 经营详细地址
            request.setDetailAddr("深圳市宝安区新安街道海旺社区N26区海秀路2021号荣超滨海大厦A座2111");
            // 经营省
            request.setProvId("310000");
            // 经营市
            request.setAreaId("310100");
            // 经营区
            request.setDistrictId("310104");
            // 联系人信息
            request.setContactInfo(getContactInfo());
            // 卡信息配置实体
            request.setCardInfo(getCardInfo());
            // 取现配置列表jsonArray格式 ；
            request.setCashConfig(getCashConfig());
            // 结算配置jsonObject格式；
            request.setSettleConfig(getSettleConfig());

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
            // 经营简称
            extendInfoMap.Add("short_name", "姜雨");
            // 小票名称
            extendInfoMap.Add("receipt_name", "汇付天下");
            // 商户英文名称
            extendInfoMap.Add("mer_en_name", "huifu");
            // 所属行业
            extendInfoMap.Add("mcc", "7273");
            // 营业执照类型
            extendInfoMap.Add("license_type", "NATIONAL_LEGAL_MERGE");
            // 营业执照编号
            extendInfoMap.Add("license_code", "914403001921834459");
            // 营业执照有效期类型
            extendInfoMap.Add("license_validity_type", "0");
            // 营业执照有效期开始日期
            extendInfoMap.Add("license_begin_date", "19831108");
            // 营业执照有效期截止日期
            extendInfoMap.Add("license_end_date", "20380831");
            // 注册详细地址
            extendInfoMap.Add("reg_detail", "深圳市宝安区新安街道海旺社区N26区海秀路2021号荣超滨海大厦A座2111");
            // 注册省
            extendInfoMap.Add("reg_prov_id", "310000");
            // 注册市
            extendInfoMap.Add("reg_area_id", "310100");
            // 注册区
            extendInfoMap.Add("reg_district_id", "310104");
            // 客服电话
            extendInfoMap.Add("service_phone", "15556622000");
            // 商户主页URL
            extendInfoMap.Add("mer_url", "http://www.baidu.com");
            // 商户ICP备案编号
            extendInfoMap.Add("mer_icp", "苏ICP备15042526号");
            // 开户许可证核准号
            extendInfoMap.Add("open_licence_no", "123456789");
            // 法人信息
            extendInfoMap.Add("legal_info", getLegalInfo());
            // 签约人
            // extendInfoMap.Add("sign_user_info", getSignUserInfo());
            // 管理员账号
            extendInfoMap.Add("login_name", "LG02022072707540497330158089012");
            // 是否发送短信通知商户标识
            extendInfoMap.Add("sms_send_flag", "1");
            // 协议信息实体
            extendInfoMap.Add("agreement_info", getAgreementInfo());
            // 业务开关配置
            extendInfoMap.Add("biz_conf", getBizConf());
            // 微信配置对象
            extendInfoMap.Add("wx_conf_list", getWxConfList());
            // 实名认证信息
            extendInfoMap.Add("wx_realname_info", getWxRealnameInfo());
            // 支付宝配置对象
            extendInfoMap.Add("ali_conf_list", getAliConfList());
            // 银联配置对象
            extendInfoMap.Add("union_conf_list", getUnionConfList());
            // 银联小微入驻信息实体
            extendInfoMap.Add("union_micro_info", getUnionMicroInfo());
            // 余额支付配置实体
            extendInfoMap.Add("balance_pay_config", getBalancePayConfig());
            // 银行卡业务配置实体
            extendInfoMap.Add("bank_card_conf", getBankCardConf());
            // 花呗分期费率配置实体
            extendInfoMap.Add("hb_fq_fee_config", getHbFqFeeConfig());
            // 营销补贴
            extendInfoMap.Add("combine_pay_config", getCombinePayConfig());
            // 商户业务类型
            // extendInfoMap.Add("mer_bus_type", "");
            // 线上费率配置
            // extendInfoMap.Add("online_fee_conf_list", getOnlineFeeConfList());
            // 线上手续费承担方配置
            // extendInfoMap.Add("online_pay_fee_conf_list", getOnlinePayFeeConfList());
            // 文件列表
            extendInfoMap.Add("file_info", getFileInfo());
            // 异步消息接收地址
            extendInfoMap.Add("async_return_url", "rmq://C_SSPM_YMFZ_AUDIT");
            // 业务开通结果异步消息接收地址
            extendInfoMap.Add("busi_async_return_url", "virgo://http://192.168.85.157:30031/sspm/testVirgo");
            // 交易异步应答地址
            extendInfoMap.Add("recon_resp_addr", "archer://C_SSPM_NSPOSM_BUSIRESULT");
            return extendInfoMap;
        }

        private static string getWxConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            obj.Add("pay_scene", "1");
            // 手续费（%）
            obj.Add("fee_rate", "0.38");
            // 费率规则id
            obj.Add("fee_rule_id", "758");
            // 商户经营类目
            obj.Add("mcc", "111");
            // 子渠道号
            obj.Add("pay_channel_id", "JP00001");
            // 公众号支付Appid
            obj.Add("wx_woa_app_id", "wx_woa_app_id");
            // 微信公众号授权目录
            obj.Add("wx_woa_path", "wx_woa_path ");
            // 微信小程序APPID
            obj.Add("wx_applet_app_id", "wx_applet_app_id");
            // 微信公众号APPID对应的秘钥
            obj.Add("wx_woa_secret", "wx_woa_secret");
            // 微信小程序APPID对应的秘钥
            obj.Add("wx_applet_secret", "wx_applet_secret");
            // 申请服务 
            obj.Add("service_codes", "['JSAPI','PAP']");
            // 交易手续费外扣时的账户类型
            obj.Add("out_fee_acct_type", "01");
            // 交易手续费外扣汇付ID
            obj.Add("out_fee_huifuid", "6666000105215340");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getBankCardConf() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 借记卡手续费（%）
            obj.Add("debit_fee_rate", "0.38");
            // 贷记卡手续费（%）
            obj.Add("credit_fee_rate", "0.39");
            // 商户经营类目
            obj.Add("mcc", "5411");
            // 银行业务手续费类型
            obj.Add("charge_cate_code", "02");
            // 借记卡封顶值（元）
            obj.Add("debit_fee_limit", "0.56");
            // 云闪付借记卡手续费1000以上（%）
            obj.Add("cloud_debit_fee_rate_up", "0.56");
            // 云闪付借记卡封顶1000以上(元)
            obj.Add("cloud_debit_fee_limit_up", "12");
            // 云闪付贷记卡手续费1000以上（%）
            obj.Add("cloud_credit_fee_rate_up", "0.59");
            // 云闪付借记卡手续费1000以下（%）
            obj.Add("cloud_debit_fee_rate_down", "0.37");
            // 云闪付借记卡封顶1000以下(元)
            obj.Add("cloud_debit_fee_limit_down", "5");
            // 云闪付贷记卡手续费1000以下（%）
            obj.Add("cloud_credit_fee_rate_down", "0.36");
            // 是否开通小额双免
            obj.Add("is_open_small_flag", "0");
            // 小额双免单笔限额(元)
            obj.Add("small_free_amt", "1000");
            // 小额双免手续费（%）
            obj.Add("small_fee_amt", "0.33");
            // 交易手续费外扣时的账户类型
            obj.Add("out_fee_acct_type", "01");
            // 交易手续费外扣汇付ID
            obj.Add("out_fee_huifuid", "6666000105215340");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getLegalInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 法人姓名
            obj.Add("legal_name", "张三");
            // 法人证件类型
            obj.Add("legal_cert_type", "00");
            // 法人证件号码
            obj.Add("legal_cert_no", "210411198701140000");
            // 法人证件有效期开始日期
            obj.Add("legal_cert_begin_date", "20180201");
            // 法人证件有效期类型
            obj.Add("legal_cert_validity_type", "0");
            // 法人证件有效期截止日期
            obj.Add("legal_cert_end_date", "20380201");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getUnionMicroInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银联商户类别
            obj.Add("mchnt_type", "0101");
            // 商户经度
            obj.Add("mer_lng", "121.472644");
            // 商户纬度
            obj.Add("mer_lat", "31.231706");
            // 店铺名称
            obj.Add("shop_name", "测试");
            // 商户经营类目
            obj.Add("mcc", "5992");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCombinePayConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付手续费(%)
            obj.Add("fee_rate", "5");
            // 支付固定手续费(元)
            obj.Add("fee_fix_amt", "0.56");
            // 交易手续费外扣时的账户类型
            obj.Add("out_fee_acct_type", "01");
            // 交易手续费外扣汇付ID
            obj.Add("out_fee_huifuid", "6666000105215340");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAgreementInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 协议类型
            obj.Add("agreement_type", "1");
            // 协议号
            obj.Add("agreement_no", "202010200100000203");
            // 协议模板号
            obj.Add("agreement_model", "202010200100000203");
            // 协议模板名称
            obj.Add("agreement_name", "电子协议签约模板");
            // 签约日期
            obj.Add("sign_date", "20200325");
            // 协议开始日期
            obj.Add("agree_begin_date", "20200325");
            // 协议结束日期
            obj.Add("agree_end_date", "20400325");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getBizConf() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 延迟入账开关
            obj.Add("delay_flag", "Y");
            // 商户开通强制延迟标记
            obj.Add("forced_delay_flag", "Y");
            // 是否开通网银
            obj.Add("online_flag", "Y");
            // 是否开通快捷
            obj.Add("quick_flag", "Y");
            // 是否开通代扣
            obj.Add("withhold_flag", "Y");
            // 是否开通微信预授权
            obj.Add("wechatpay_pre_auth_flag", "Y");
            // 是否开通支付宝预授权
            obj.Add("alipay_pre_auth_flag", "Y");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCardInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算类型
            obj.Add("card_type", "2");
            // 银行所在省
            obj.Add("prov_id", "310000");
            // 银行所在市
            obj.Add("area_id", "310100");
            // 结算账户名
            obj.Add("card_name", "张华");
            // 结算账号
            obj.Add("card_no", "621485121290000");
            // 银行编码
            obj.Add("bank_code", "01050000");
            // 联行号
            obj.Add("branch_code", "105290075067");
            // 支行名称
            obj.Add("branch_name", "中国建设银行股份有限公司上海五角场支行");
            // 持卡人证件有效期类型
            obj.Add("cert_validity_type", "1");
            // 持卡人证件有效期（起始）
            obj.Add("cert_begin_date", "20210201");
            // 持卡人证件有效期（截止）
            obj.Add("cert_end_date", "");
            // 持卡人证件号码
            obj.Add("cert_no", "110101199305182000");
            // 持卡人证件类型
            obj.Add("cert_type", "00");
            // 银行卡绑定手机号
            obj.Add("mp", "1865590000");

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
            obj.Add("debit_fee_rate_up", "0.55");
            // 银联二维码业务贷记卡手续费1000以上（%）
            obj.Add("credit_fee_rate_up", "0.56");
            // 借记卡手续费1000以下（%）
            obj.Add("debit_fee_rate_down", "0.38");
            // 银联二维码业务贷记卡手续费1000以下（%）
            obj.Add("credit_fee_rate_down", "0.38");
            // 银联业务手续费类型
            obj.Add("charge_cate_code", "03");
            // 借记卡封顶1000以上（元）
            obj.Add("debit_fee_limit_up", "20");
            // 借记卡封顶1000以下（元）
            obj.Add("debit_fee_limit_down", "10");
            // 商户经营类目
            obj.Add("mcc", "5411");
            // 交易手续费外扣时的账户类型
            obj.Add("out_fee_acct_type", "01");
            // 交易手续费外扣汇付ID
            obj.Add("out_fee_huifuid", "6666000105215340");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getCashConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 取现手续费率（%）fix_amt与fee_rate至少填写一项，单位%，需保留小数点后两位，取值范围[0.00,100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;&lt;br/&gt;注：如果fix_amt与fee_rate都填写了则手续费&#x3D;fix_amt+支付金额*fee_rate
            obj.Add("fee_rate", "2");
            // 业务类型
            obj.Add("cash_type", "D1");
            // 提现手续费（固定/元）
            obj.Add("fix_amt", "0.04");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");
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
            obj.Add("fee_rate", "3");
            // 支付固定手续费(元)
            obj.Add("fee_fix_amt", "0.80");
            // 交易手续费外扣时的账户类型
            obj.Add("out_fee_acct_type", "01");
            // 交易手续费外扣汇付ID
            obj.Add("out_fee_huifuid", "6666000105215340");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getQualificationInfoList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 行业类目id
            // obj.Add("mcc_code", "test");
            // 行业经营许可证资质照片
            // obj.Add("image_list", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getFileInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // D1结算协议图片
            obj.Add("settle_agree_pic", "测试2022062910491030461");
            // 授权委托书
            obj.Add("auth_enturst_pic", "0215232e-b595-368e-8a68-8c15b04f875b");
            // 商务协议
            obj.Add("ba_pic", "d1451277-85c6-3177-ac3d-a8be47b9ae9d");
            // 公司照片一
            obj.Add("store_header_pic", "d1451277-85c6-3177-ac3d-a8be47b9ae9d");
            // 公司照片二
            obj.Add("store_indoor_pic", "009cd33c-01be-31f0-8e8c-615460949b96");
            // 公司照片三
            obj.Add("store_cashier_desk_pic", "2020022204231214021970311");
            // 法人身份证反面
            obj.Add("legal_cert_back_pic", "2020022204231214021970321");
            // 法人身份证正面
            obj.Add("legal_cert_front_pic", "2022071804231214021970321");
            // 营业执照图片
            obj.Add("license_pic", "36ac0355-a54d-3178-b4b5-9aecd07367e6");
            // 组织机构代码证
            obj.Add("org_code_pic", "5bd7fea7-c8e4-31fc-a672-755adbcd4a4c");
            // 开户许可证
            obj.Add("reg_acct_pic", "d1d50615-0ff4-3488-b415-0ac21a556c4a");
            // 结算卡反面
            obj.Add("settle_card_back_pic", "9aa840b9-517e-3828-9e7e-7098eff89f24");
            // 结算卡正面
            obj.Add("settle_card_front_pic", "f90c3466-bbb8-3309-b0d5-961abe6567b1");
            // 结算人身份证反面
            obj.Add("settle_cert_back_pic", "7d4fd561-b70f-3b2e-b958-85f5328d226f");
            // 结算人身份证正面
            obj.Add("settle_cert_front_pic", "a95a035a-d7e3-39fa-a869-dcc7d25a3349");
            // 税务登记证
            obj.Add("tax_reg_pic", "d13832f9-2244-3a3b-ba09-936b100a8ce9");
            // 实名登记证书照片
            obj.Add("cert_pic", "90dab223-0b14-3ec8-8c65-f388f1c6b1f1");
            // 个人商户身份证件正面照片
            obj.Add("identification_front_pic", "b6fc4738-fe0a-3940-98e8-0987fee50b42");
            // 个人商户身份证件反面照片
            obj.Add("identification_back_pic", "30492625-20c5-3796-822f-a10e63ba76e5");
            // 单位证明函照片
            obj.Add("company_prove_pic", "36ac0355-a54d-3178-b4b5-9aecd07367e6");
            // 金融机构许可证图片1
            obj.Add("finance_license_pic1", "ff647802-0ba1-36c0-952e-e94623cf0e7c");
            // 金融机构许可证图片2
            obj.Add("finance_license_pic2", "42cecea7-1aef-33fb-bf04-c2bc621b0302");
            // 金融机构许可证图片3
            obj.Add("finance_license_pic3", "48157e9b-44cc-33e1-8169-a0fe8c1c0848");
            // 金融机构许可证图片4
            obj.Add("finance_license_pic4", "ca1cbd42-b14e-326b-9aef-288d45cf8b42");
            // 金融机构许可证图片5
            obj.Add("finance_license_pic5", "2e74d95f-fd16-3766-ab39-c407c5b1c004");
            // 联系人身份证正面照
            obj.Add("contact_id_front_pic", "b6fc4738-fe0a-3940-98e8-0987fee50b42");
            // 联系人身份证反面照
            obj.Add("contact_id_back_pic", "71da066c-5d15-3658-a86d-4e85ee67808a");
            // 联系人护照人像面
            obj.Add("contact_passport_img_pic", "8958a61c-970c-3ad8-a091-80238ef80a8b");
            // 联系人证件照正面
            obj.Add("contact_cert_front_pic", "75ef9587-2faf-3b2c-820b-9ea447e754e3");
            // 联系人证件照反面
            obj.Add("contact_cert_back_pic", "d42c010b-9316-369f-80ed-4ce4bda13602");
            // 微信业务办理授权函
            obj.Add("contact_wx_busi_auth_pic", "49ac7d9b-851c-31b4-8b21-2983ea97b98c");
            // 行业经营许可证资质照片一
            obj.Add("industry_busi_license_pic1", "1931c359-e42f-3e5f-875e-e22fc695aefd");
            // 行业经营许可证资质照片二
            obj.Add("industry_busi_license_pic2", "0ddea6a0-6991-39ac-a68d-155d5d00d840");
            // 行业经营许可证资质照片三
            obj.Add("industry_busi_license_pic3", "b5d77b0f-391f-3447-9843-386fc4096649");
            // 行业经营许可证资质照片四
            obj.Add("industry_busi_license_pic4", "2af4514d-3d9c-3545-bc45-2424e80ab7e4");
            // 行业经营许可证资质照片五
            obj.Add("industry_busi_license_pic5", "c3421d61-df60-3b2d-bcf1-e3709da867f2");
            // 行业经营许可证资质照片六
            obj.Add("industry_busi_license_pic6", "b56c5cb1-4724-3574-ae38-7e8d5510b607");
            // 法人护照人像面
            obj.Add("legal_passport_img_pic", "893dd8c7-c0a6-3cbd-a6c2-a52baf40398c");
            // 法人港澳台通行证正面
            obj.Add("legal_hk_aom_front_pic", "8cb60559-e51c-344e-bcbf-96f3011acbd4");
            // 法人其他证件照片
            obj.Add("legal_other_cert_pic", "562511a9-aa29-3e9e-9647-a97430ea9766");
            // 持卡人身份证人像面
            obj.Add("cert_front_pic", "01c81d4f-0efd-3771-a8b2-660fe37f3859");
            // 持卡人身份证国徽面
            obj.Add("cert_back_pic", "9f459914-4021-3c54-a5d9-31f1a64dc392");
            // 持卡人护照人像面
            obj.Add("cert_passport_img_pic", "a501f0c6-a9ee-30d0-aedb-cec882da6d21");
            // 持卡人港澳台通行证正面
            obj.Add("cert_hk_aom_front_pic", "cdcae795-6a9d-32f8-8033-d7bad4008974");
            // 持卡人其它证件照片
            obj.Add("cert_other_pic", "398bbd13-40c9-37ce-8265-f6c1ecd317fa");
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
            obj.Add("pay_scene", "1");
            // 联系人姓名
            obj.Add("name", "詹振");
            // 联系人手机号
            obj.Add("mobile", "15657470001");
            // 联系人证件号码
            obj.Add("contact_id_card_number", "210411198701140000");
            // 实名认证类型
            // obj.Add("realname_info_type", "");
            // 子渠道号
            obj.Add("pay_channel_id", "JP00001");
            // 联系人类型
            obj.Add("contact_type", "SUPER");
            // 联系人证件类型
            obj.Add("contact_id_doc_type", "00");
            // 联系人证件有效期开始时间
            obj.Add("contact_period_begin_date", "20210101");
            // 联系人证件有效期结束时间
            obj.Add("contact_period_end_date", "20410101");
            // 机构证书类型
            obj.Add("cert_type", "CERTIFICATE_TYPE_2389");
            // 机构证书编号
            obj.Add("cert_number", "1234567892");
            // 经营者/法人是否为受益人
            obj.Add("owner", "Y");
            // 法人证件居住地址
            obj.Add("legal_identification_address", "上海祁连山路1号");
            // 小微经营类型
            obj.Add("micro_biz_type", "");
            // 门店名称
            obj.Add("store_name", "");
            // 门店省市编码
            obj.Add("store_address_code", "");
            // 门店地址
            obj.Add("store_address", "");
            // 特殊行业Id
            obj.Add("category_id", "");
            // 是否金融机构
            obj.Add("finance_institution_flag", "N");
            // 金融机构类型
            obj.Add("finance_type", "");
            // 受益人信息
            obj.Add("ubo_info_list", getUboInfo());
            // 经营许可证
            // obj.Add("qualification_info_list", getQualificationInfoList());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getHbFqFeeConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 花呗收单分期3期（%）分期费率不为空时，收单费率必填，大于0，保留2位小数，不小于渠道商成本；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.0&lt;/font&gt;代表费率为1.00%
            obj.Add("acq_three_period", "1.30");
            // 花呗收单分期6期（%）分期费率不为空时，收单费率必填，大于0，保留2位小数，不小于渠道商成本；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.0&lt;/font&gt;代表费率为1.00%
            obj.Add("acq_six_period", "4.60");
            // 花呗收单分期12期（%）分期费率不为空时，收单费率必填，大于0，保留2位小数，不小于渠道商成本；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.0&lt;/font&gt;代表费率为1.00%
            obj.Add("acq_twelve_period", "9.12");
            // 花呗分期3期（%）
            obj.Add("three_period", "1.80");
            // 花呗分期6期（%）
            obj.Add("six_period", "4.60");
            // 花呗分期12期（%）
            obj.Add("twelve_period", "9.12");
            // 商户经营类目
            obj.Add("ali_mcc", "2015063000020189");
            // 支付场景
            obj.Add("pay_scene", "1");
            // 交易手续费外扣时的账户类型
            obj.Add("out_fee_acct_type", "01");
            // 交易手续费外扣汇付ID
            obj.Add("out_fee_huifuid", "6666000105215340");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAliConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            obj.Add("pay_scene", "1");
            // 手续费（%）
            obj.Add("fee_rate", "0.38");
            // 商户经营类目
            obj.Add("mcc", "2015063000020189");
            // 子渠道号
            obj.Add("pay_channel_id", "JQF00001");
            // 拟申请的间联商户等级
            obj.Add("indirect_level", "INDIRECT_LEVEL_M3");
            // 交易手续费外扣时的账户类型
            obj.Add("out_fee_acct_type", "01");
            // 交易手续费外扣汇付ID
            obj.Add("out_fee_huifuid", "6666000105215340");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getSettleConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算周期
            obj.Add("settle_cycle", "T1");
            // 节假日结算手续费率%
            obj.Add("fixed_ratio", "3");
            // 起结金额
            obj.Add("min_amt", "0.40");
            // 结算手续费外扣时的账户类型
            obj.Add("out_settle_acct_type", "01");
            // 结算手续费外扣时的汇付ID
            obj.Add("out_settle_huifuid", "6666000105215340");
            // 手续费外扣标记
            obj.Add("out_settle_flag", "1");
            // 留存金额
            obj.Add("remained_amt", "100");
            // 结算摘要
            obj.Add("settle_abstract", "结算测试");
            // 结算方式
            obj.Add("settle_pattern", "P0");
            // 结算批次号
            obj.Add("settle_batch_no", "300");
            // 是否优先到账
            obj.Add("is_priority_receipt", "N");
            // 自定义结算处理时间
            obj.Add("settle_time", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getContactInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 联系人姓名
            obj.Add("contact_name", "张三");
            // 联系人手机号
            obj.Add("contact_mobile_no", "15657470000");
            // 联系人电子邮箱
            obj.Add("contact_email", "jeff.peng@huifu.com");
            // 联系人身份证号
            // obj.Add("contact_cert_no", "");

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
            obj.Add("ubo_id_doc_type", "00");
            // 证件正面照片
            obj.Add("ubo_id_doc_copy", "c7faf0e6-39e9-3c35-9075-2312ad6f4ea4");
            // 证件姓名
            obj.Add("ubo_id_doc_name", "王五");
            // 证件号码
            obj.Add("ubo_id_doc_number", "110101199003072631");
            // 证件居住地址
            obj.Add("ubo_id_doc_address", "上海市徐汇区宜山路789号");
            // 证件有效期开始时间
            obj.Add("ubo_period_begin", "19900307");
            // 证件有效期结束时间
            obj.Add("ubo_period_end", "19930909");
            // 证件反面照片
            obj.Add("ubo_id_doc_copy_back", "c7faf0e6-39e9-3c35-9075-2312ad6f4ea4");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
