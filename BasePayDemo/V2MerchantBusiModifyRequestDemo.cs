using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户业务开通修改 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiModifyRequestDemo
    {

        public static void V2MerchantBusiModifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBusiModifyRequest request = new V2MerchantBusiModifyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000103668046");
            // 是否交易手续费外扣
            request.setOutFeeFlag("2");
            // 交易手续费外扣汇付ID
            request.setOutFeeHuifuid("");
            // *线上业务类型编码*开通快捷、网银、余额支付、分账必填；参见[线上业务类型编码及补充材料说明](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/kyc/KYC-%E7%BA%BF%E4%B8%8A%E4%B8%9A%E5%8A%A1%E7%B1%BB%E5%9E%8B%E7%BC%96%E7%A0%81%E5%8F%8A%E8%A1%A5%E5%85%85%E6%9D%90%E6%96%99%E8%AF%B4%E6%98%8E.xlsx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：H7999AL&lt;/font&gt;
            // request.setOnlineBusiType("test");
            // 签约人jsonObject格式；agreement_info中选择电子签约时必填；个人商户填本人信息。
            // request.setSignUserInfo(get968d12e47ae945bc914c8bd3f4ee92fc());

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
            extendInfoMap.Add("short_name", "");
            // *协议信息实体*
            extendInfoMap.Add("agreement_info", get41fe702bBc134bb1Ac23332425bffe34());
            // 交易手续费外扣时的账户类型
            extendInfoMap.Add("out_fee_acct_type", "");
            // 是否开通网银
            extendInfoMap.Add("online_flag", "");
            // 是否开通快捷
            extendInfoMap.Add("quick_flag", "");
            // 是否开通代扣
            extendInfoMap.Add("withhold_flag", "");
            // 延迟入账开关
            extendInfoMap.Add("delay_flag", "Y");
            // 开通支付宝预授权
            extendInfoMap.Add("alipay_pre_auth_flag", "Y");
            // 开通微信预media_type授权
            // extendInfoMap.Add("wechatpay_pre_auth_flag", "");
            // 商户业务类型
            // extendInfoMap.Add("mer_bus_type", "");
            // 线上费率配置
            // extendInfoMap.Add("online_fee_conf_list", getE914ac8756ac47faAe75472bb005b9c4());
            // 支付宝配置对象
            extendInfoMap.Add("ali_conf_list", getC2a66746086d47a0B006372a417e62c2());
            // 微信配置对象
            extendInfoMap.Add("wx_conf_list", get40f7fd9962a24400A551120a574bfe26());
            // 银联二维码配置对象
            extendInfoMap.Add("union_conf_list", get7439c0bd1c0e4492Bc5e020eede61435());
            // 银行卡支付配置信息
            extendInfoMap.Add("bank_card_conf", getD64f4ddeBe9c4aeb889e24377234984e());
            // *余额支付配置对象*
            extendInfoMap.Add("balance_pay_config", get7df3545aF9c7424a94612925776e0b00());
            // 补贴支付
            extendInfoMap.Add("combine_pay_config", get13c36880F85344188329Cb06a0c216f1());
            // 线上手续费承担方配置
            // extendInfoMap.Add("online_pay_fee_conf_list", get59e8fe59779d45e89213295f510bfb56());
            // 全域资金管理配置(华通银行)
            // extendInfoMap.Add("out_order_funds_config", get0242f554801346ed9c42404cec334190());
            // 汇总结算配置实体
            // extendInfoMap.Add("collection_settle_config_list", getAcd27836A6a04af4A80c0e29e0627903());
            // 异步消息接收地址
            extendInfoMap.Add("async_return_url", "http://www.baidu55.com");
            // 业务开通结果异步消息接收地址
            extendInfoMap.Add("busi_async_return_url", "");
            // 交易异步应答地址
            extendInfoMap.Add("recon_resp_addr", "http://192.168.85.157:30031/sspm/testVirgo");
            // *运营媒介*
            // extendInfoMap.Add("online_media_info_list", getFef82a16A9e4425e998241cf05cfcff5());
            // *补充文件信息*
            // extendInfoMap.Add("extended_material_list", get867839a65d9648ba952739845e2086a8());
            // 商户开通强制延迟标记
            // extendInfoMap.Add("forced_delay_flag", "");
            // 微信直连配置对象
            // extendInfoMap.Add("wx_zl_conf", get988f1817D2f342adAb06C8e8ca42b631());
            // 支付宝直连配置对象
            // extendInfoMap.Add("ali_zl_conf", get030bfc7221bc4f7fA8ceB1f688da8f37());
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
            // 分账配置信息
            // extendInfoMap.Add("split_conf_info", get7309a2ccC97845e685ac3d9afb00c1cd());
            // 银联线上收银台
            // extendInfoMap.Add("uni_app_payment_config", get880d3a59Ff494ccb9ce9B06b11e6fcb1());
            // 资金归集开通标记
            // extendInfoMap.Add("fund_collection_flag", "");
            // 代发配置
            // extendInfoMap.Add("surrogate_config_list", get7be6dd50942647b087e0F43216b45b8f());
            // 大额支付配置
            // extendInfoMap.Add("large_amt_pay_config", get8b24dcf61f8d40bdA9bf797c9f107f34());
            // 托管支付开关
            // extendInfoMap.Add("half_pay_host_flag", "");
            return extendInfoMap;
        }

        private static string get41fe702bBc134bb1Ac23332425bffe34() {
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
        private static string getE914ac8756ac47faAe75472bb005b9c4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            // obj.Add("fee_type", "test");
            // 银行编码
            // obj.Add("bank_id", "test");
            // 借贷标志
            // obj.Add("dc_flag", "test");
            // 费率状态
            // obj.Add("stat_flag", "test");
            // *单笔限额*
            // obj.Add("pay_every_deal", "test");
            // *单日限额*
            // obj.Add("pay_everyday", "test");
            // 手续费（固定/元）
            // obj.Add("fix_amt", "");
            // 费率（%）
            // obj.Add("fee_rate", "");
            // 银行名称
            // obj.Add("bank_name", "");
            // 银行中文简称
            // obj.Add("bank_short_chn", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get75aa8341Cf4e4022B828167223d1450c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 联系人身份证号码
            // obj.Add("id_card_number", "test");
            // 联系人姓名
            // obj.Add("name", "");
            // 联系人手机号
            // obj.Add("mobile", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getA22dcc25C7654d5aB8c2322488faf6eb() {
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
        private static string getD3863b26E3a84696Aa2e8a2450206579() {
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
            // obj.Add("contact_person_info", get75aa8341Cf4e4022B828167223d1450c());
            // 法人身份信息
            // obj.Add("legal_person_info", getA22dcc25C7654d5aB8c2322488faf6eb());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getC2a66746086d47a0B006372a417e62c2() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            obj.Add("fee_rate", "3.15");
            // 支付场景
            obj.Add("pay_scene", "1");
            // *功能开关*
            // obj.Add("switch_state", "test");
            // 最低收取手续费（元）
            // obj.Add("fee_min_amt", "");
            // 商户经营类目
            obj.Add("mcc", "2016062900190337");
            // 子渠道号
            obj.Add("pay_channel_id", "10000001");
            // 是否需要实名认证
            // obj.Add("is_check_real_name", "");
            // 实名认证信息
            // obj.Add("al_real_name_info", getD3863b26E3a84696Aa2e8a2450206579());

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object get528794d3F9c94fb4B24202664a4e41bc() {
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
        private static string get40f7fd9962a24400A551120a574bfe26() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            obj.Add("fee_rate", "2.15");
            // 支付场景
            obj.Add("pay_scene", "10");
            // 开关状态
            // obj.Add("switch_state", "");
            // 最低收取手续费（元）
            // obj.Add("fee_min_amt", "");
            // 费率规则ID
            obj.Add("fee_rule_id", "765");
            // 子渠道号
            obj.Add("pay_channel_id", "JP00001");
            // 申请服务
            obj.Add("service_codes", "");
            // 是否需要实名认证
            // obj.Add("is_check_real_name", "");
            // 实名认证信息
            // obj.Add("wx_real_name_info", get528794d3F9c94fb4B24202664a4e41bc());

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get7439c0bd1c0e4492Bc5e020eede61435() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银联二维码1000以上借记卡费率
            obj.Add("debit_fee_rate_up", "6");
            // 银联二维码1000以下借记卡费率
            obj.Add("debit_fee_rate_down", "2.55");
            // 银联二维码1000以下贷记卡费率
            obj.Add("credit_fee_rate_down", "1");
            // 银联二维码1000以上贷记卡费率
            obj.Add("credit_fee_rate_up", "6.566");
            // 银行业务手续费类型
            obj.Add("charge_cate_code", "");
            // 银联二维码1000以上借记卡费率封顶值
            obj.Add("debit_fee_limit_up", "641");
            // 银联二维码1000以下借记卡费率封顶值
            obj.Add("debit_fee_limit_down", "11.3");
            // 功能开关
            // obj.Add("switch_state", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getD64f4ddeBe9c4aeb889e24377234984e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 借记卡手续费（%）
            obj.Add("debit_fee_rate", "3");
            // 贷记卡手续费（%）
            obj.Add("credit_fee_rate", "6");
            // 银行业务手续费类型
            obj.Add("charge_cate_code", "02");
            // 借记卡封顶值
            obj.Add("debit_fee_limit", "5");
            // 银联手机闪付借记卡手续费1000以上（%）
            obj.Add("cloud_debit_fee_rate_up", "7");
            // 银联手机闪付借记卡封顶1000以上(元)
            obj.Add("cloud_debit_fee_limit_up", "8.922");
            // 银联手机闪付贷记卡手续费1000以上（%）
            obj.Add("cloud_credit_fee_rate_up", "4.86");
            // 银联手机闪付借记卡手续费1000以下（%）
            obj.Add("cloud_debit_fee_rate_down", "0");
            // 银联手机闪付借记卡封顶1000以下(元)
            obj.Add("cloud_debit_fee_limit_down", "10");
            // 银联手机闪付贷记卡手续费1000以下（%）
            obj.Add("cloud_credit_fee_rate_down", "2");
            // 是否开通小额双免
            obj.Add("is_open_small_flag", "0");
            // 小额双免单笔限额(元)
            obj.Add("small_free_amt", "500");
            // 小额双免手续费（%）
            obj.Add("small_fee_amt", "1");
            // 功能开关
            // obj.Add("switch_state", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getCbce4d0b9eec452e8108Ac05dd20467c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // *业务模式说明*
            // obj.Add("busi_instruction", "test");
            // *资金流向说明*
            // obj.Add("capital_instruction", "test");
            // *功能开通用途说明*
            // obj.Add("function_instruction", "test");

            return obj;
        }
        private static string get7df3545aF9c7424a94612925776e0b00() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // *业务模式*
            // obj.Add("balance_model", "test");
            // *业务情况说明*
            // obj.Add("description_info", getCbce4d0b9eec452e8108Ac05dd20467c());
            // 支付手续费(%)
            obj.Add("fee_rate", "2");
            // 支付固定手续费(元)
            obj.Add("fee_fix_amt", "1");
            // 功能开关
            obj.Add("switch_state", "1");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");
            // 扣费模式
            // obj.Add("charge_mode", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get13c36880F85344188329Cb06a0c216f1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 功能开关
            obj.Add("switch_state", "0");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "test");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "test");
            // 支付手续费(%)
            obj.Add("fee_rate", "10");
            // 支付固定手续费(元)
            obj.Add("fee_fix_amt", "5");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get59e8fe59779d45e89213295f510bfb56() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            // obj.Add("pay_type", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");
            // 功能开关
            // obj.Add("switch_state", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object getDd385efe490640669c4bBcb073e4e51e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
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
            // 银行所在省
            // obj.Add("prov_id", "");
            // 银行所在市
            // obj.Add("area_id", "");
            // 银行编码
            // obj.Add("bank_code", "");
            // 支行联行号
            // obj.Add("branch_code", "");
            // 支行名称
            // obj.Add("branch_name", "");
            // 持卡人证件有效期类型
            // obj.Add("cert_validity_type", "");
            // 开户许可证核准号
            // obj.Add("open_licence_no", "");

            return obj;
        }
        private static object getC05ec5dc4827430e8f7419af824d07d1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开户手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 开户手续费外扣时的账户类型01-基本户，05-充值户，09-营销户，不填默认01；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01&lt;/font&gt;&lt;br/&gt;注：fee_fix_amt：开户手续费大于0时必填
            // obj.Add("out_fee_acct_type", "test");
            // 开户手续费外扣汇付ID开通手续费外扣业务时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812123&lt;/font&gt;&lt;br/&gt;注：fee_fix_amt：开户手续费大于0时必填
            // obj.Add("out_fee_huifuid", "test");

            return obj;
        }
        private static string get0242f554801346ed9c42404cec334190() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 功能开关
            // obj.Add("switch_state", "test");
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
            // 全域资金开户使用的银行卡信息
            // obj.Add("out_order_acct_card", getDd385efe490640669c4bBcb073e4e51e());
            // 全域资金开户手续费
            // obj.Add("out_order_acct_open_fees", getC05ec5dc4827430e8f7419af824d07d1());
            // 全域支付业务模式
            // obj.Add("business_model", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getAcd27836A6a04af4A80c0e29e0627903() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 归集留存金(元)
            // obj.Add("out_resv_amt", "test");
            // 转入商户号
            // obj.Add("in_huifu_id", "test");
            // 转入账户
            // obj.Add("in_acct_id", "test");
            // 生效日期
            // obj.Add("valid_date", "test");
            // 功能开关
            // obj.Add("switch_state", "");
            // 转出账户
            // obj.Add("out_acct_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getFef82a16A9e4425e998241cf05cfcff5() {
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
        private static string get867839a65d9648ba952739845e2086a8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // *文件id*
            // obj.Add("file_id", "test");
            // *文件类型*
            // obj.Add("file_type", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get968d12e47ae945bc914c8bd3f4ee92fc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 签约人类型
            // obj.Add("type", "test");
            // 姓名签约人类型&#x3D;其他，必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：张三&lt;/font&gt;
            // obj.Add("name", "test");
            // 手机号签约人类型&#x3D;法人/其他 ，必填；注意：**签约人会做姓名+身份证+手机号验证，请正确填写**；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：13917463536&lt;/font&gt;
            // obj.Add("mobile_no", "test");
            // 身份证签约人类型&#x3D;联系人/其他，必填 ；注意：**签约人会做姓名+身份证+手机号验证，请正确填写**；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：320946195712025082&lt;/font&gt;
            // obj.Add("cert_no", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getBc1a4b7394984b2c823e19be1aa0672a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            return obj;
        }
        private static object getEd3b58ff9d204cfcA615F8501933563d() {
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
            // obj.Add("contact_file_list", getBc1a4b7394984b2c823e19be1aa0672a());
            // 证件有效期类型
            // obj.Add("contact_cert_validity_type", "test");
            // 证件有效期开始日期
            // obj.Add("contact_cert_begin_date", "test");
            // 证件有效期截止日期
            // obj.Add("contact_cert_end_date", "");

            return obj;
        }
        private static object getE4c2d0a83c5145b4B346E0f5f9b33f7c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get0b7cd5e0985c41e19d04B281c980d6ab() {
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
            // obj.Add("cert_file_list", getE4c2d0a83c5145b4B346E0f5f9b33f7c());
            // 证书有效期截止日期
            // obj.Add("cert_end_date", "");

            return obj;
        }
        private static object get4d08af8212924404B427F9607d8047f7() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get17cb026f379a4f2eA853D3aa4fa20f8d() {
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
            // obj.Add("ubo_file_list", get4d08af8212924404B427F9607d8047f7());
            // 证件有效期截止日期
            // obj.Add("ubo_cert_end_date", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object getB1a8af62Bad34387956a8fcddf330cef() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 经营者/法人是否为受益人
            // obj.Add("ubo_type", "test");
            // 受益人信息列表jsonArray格式,当ubo_type为Y时可不填
            // obj.Add("ubo_info_list", get17cb026f379a4f2eA853D3aa4fa20f8d());

            return obj;
        }
        private static object get2d048363598f487eAd44Df030eb2ae25() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            return obj;
        }
        private static object get58df169e677047fcA53dD333cd8e8291() {
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
            // obj.Add("sales_scenes_file_list", get2d048363598f487eAd44Df030eb2ae25());
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
        private static object getE6f9101e5ba14ecb9438E6f4eab52070() {
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
        private static object get9da3f81aF644429fA7cf5b5ad4f91d64() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object getB9c41818097640aaAe294d153d32fa97() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 申请服务
            // obj.Add("service_code", "test");
            // 功能服务appid
            // obj.Add("sub_app_id", "test");
            // 功能开关
            // obj.Add("switch_state", "test");
            // 功能费率(%)
            // obj.Add("fee_rate", "test");
            // 操作类型ADD-新增， UPDATE-修改， 默认新增；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：ADD&lt;/font&gt;
            // obj.Add("operate_type", "test");
            // 联系人信息jsonObject字符串,新增时必填
            // obj.Add("contact_info", getEd3b58ff9d204cfcA615F8501933563d());
            // 特殊主体登记证书jsonObject字符串，商户营业执照类型为政府机关/事业单位/其他组织时，传入相应信息。新增时需填入
            // obj.Add("certificate_info", get0b7cd5e0985c41e19d04B281c980d6ab());
            // 最终受益人信息jsonObject字符串，商户类型为企业时，微信侧必填。（如果基本信息里有的话，可以不传取 huifu_id 对应的信息）。新增时填入
            // obj.Add("ubo_info", getB1a8af62Bad34387956a8fcddf330cef());
            // 经营场景jsonObject字符串，新增时填入
            // obj.Add("sales_info", get58df169e677047fcA53dD333cd8e8291());
            // 银行账户信息jsonObject字符串，该字段不填时，取商户在汇付系统录入的结算账号信息。新增或修改时填入，修改时必填
            // obj.Add("wx_card_info", getE6f9101e5ba14ecb9438E6f4eab52070());
            // 补充说明信息
            // obj.Add("business_addition_msg", "");
            // 补充说明文件列表
            // obj.Add("addition_file_list", get9da3f81aF644429fA7cf5b5ad4f91d64());

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get988f1817D2f342adAb06C8e8ca42b631() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 微信子商户号
            // obj.Add("sub_mch_id", "test");
            // 配置集合
            // obj.Add("wx_zl_pay_conf_list", getB9c41818097640aaAe294d153d32fa97());

            return JsonConvert.SerializeObject(obj);
        }
        private static object get8a64d19700cc47179a8bD63062da0bdb() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileId
            // obj.Add("file_id", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get030bfc7221bc4f7fA8ceB1f688da8f37() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 申请类型
            // obj.Add("apply_type", "test");
            // 商户支付宝账号
            // obj.Add("account", "test");
            // 服务费率仅支持渠道商。平台商户调用不支持该字段服务费率（%），0.38~3之间，精确到0.01。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.06&lt;/font&gt;
            // obj.Add("fee_rate", "test");
            // 文件列表
            // obj.Add("file_list", get8a64d19700cc47179a8bD63062da0bdb());
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
        private static object get6a7db1c1709545c79a2b2f5255901b20() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账比例
            // obj.Add("fee_rate", "test");
            // 汇付Id
            // obj.Add("huifu_id", "test");

            return obj;
        }
        private static object get16e4f4620c224265Ad24Cd43185595fe() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // *业务模式说明*
            // obj.Add("busi_instruction", "test");
            // *资金流向说明*
            // obj.Add("capital_instruction", "test");
            // *功能开通用途说明*
            // obj.Add("function_instruction", "test");

            return obj;
        }
        private static string get7309a2ccC97845e685ac3d9afb00c1cd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账规则来源
            // obj.Add("rule_origin", "test");
            // 分账开关
            // obj.Add("div_flag", "test");
            // 最大分账比例%
            // obj.Add("apply_ratio", "test");
            // 生效类型
            // obj.Add("start_type", "test");
            // 分账模式
            // obj.Add("scene", "test");
            // 分账明细
            // obj.Add("acct_split_bunch_list", get6a7db1c1709545c79a2b2f5255901b20());
            // 交易手续费外扣开关
            // obj.Add("out_fee_flag", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 手续费%
            // obj.Add("split_fee_rate", "");
            // 固定手续费
            // obj.Add("per_amt", "");
            // 业务情况说明
            // obj.Add("split_ext_info", get16e4f4620c224265Ad24Cd43185595fe());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get880d3a59Ff494ccb9ce9B06b11e6fcb1() {
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
        private static string get7be6dd50942647b087e0F43216b45b8f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 代发业务类型
            // obj.Add("surrogate_type", "test");
            // 手续费（固定/元）fix_amt与fee_rate至少填写一项， 需保留小数点后两位；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;
            // obj.Add("fix_amt", "test");
            // 费率（百分比/%）fix_amt与fee_rate至少填写一项，需保留小数点后两位，取值范围[0.00,100.00]；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;
            // obj.Add("fee_rate", "test");
            // 开通状态
            // obj.Add("switch_state", "");
            // 是否交手续费外扣标记
            // obj.Add("out_fee_flag", "");
            // 交易手续费外扣时账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifu_id", "");
            // 是否允许对私代发
            // obj.Add("surrogate_private_flag", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object getAc3f8d0c1b0247c9B33d3ef8d014d57a() {
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
        private static string get8b24dcf61f8d40bdA9bf797c9f107f34() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 大额支付配置列表
            // obj.Add("large_amt_pay_config_info_list", getAc3f8d0c1b0247c9B33d3ef8d014d57a());
            // 交易手续费外扣huifuId交易手续费外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000108854952&lt;/font&gt;
            // obj.Add("out_fee_huifu_id", "test");
            // 交易手续费外扣账户号交易手续费外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：F00598602&lt;/font&gt;
            // obj.Add("out_fee_acct_id", "test");
            // 银行大额转账单笔额度
            // obj.Add("large_amt_limit_per_time", "test");
            // 银行大额转账单日额度
            // obj.Add("large_amt_limit_per_day", "test");
            // 交易手续费外扣标记
            // obj.Add("out_fee_flag", "");
            // 商户付款方卡类型
            // obj.Add("mer_payer_card_type", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
