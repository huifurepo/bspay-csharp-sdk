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
            extendInfoMap.Add("short_name", "");
            // 税务登记证
            extendInfoMap.Add("tax_reg_pic", "");
            // 公司照片一
            extendInfoMap.Add("comp_pic1", "");
            // 公司照片二
            extendInfoMap.Add("comp_pic2", "");
            // 公司照片三
            extendInfoMap.Add("comp_pic3", "");
            // 法人身份证反面
            extendInfoMap.Add("legal_cert_back_pic", "");
            // 法人身份证正面
            extendInfoMap.Add("legal_cert_front_pic", "");
            // 营业执照图片
            extendInfoMap.Add("license_pic", "");
            // 组织机构代码证
            extendInfoMap.Add("org_code_pic", "");
            // 商务协议
            extendInfoMap.Add("ba_pic", "");
            // 开户许可证
            extendInfoMap.Add("reg_acct_pic", "");
            // 结算卡反面
            extendInfoMap.Add("settle_card_back_pic", "");
            // 结算卡正面
            extendInfoMap.Add("settle_card_front_pic", "");
            // 结算人身份证反面
            extendInfoMap.Add("settle_cert_back_pic", "");
            // 结算人身份证正面
            extendInfoMap.Add("settle_cert_front_pic", "");
            // 授权委托书
            extendInfoMap.Add("auth_enturst_pic", "[http://192.168.85.157:30031/sspm/testVirgo](http://192.168.85.157:30031/sspm/testVirgo)");
            // 协议信息实体
            extendInfoMap.Add("agreement_info", getAgreementInfo());
            // 是否交易手续费外扣
            extendInfoMap.Add("out_fee_flag", "2");
            // 交易手续费外扣汇付ID
            extendInfoMap.Add("out_fee_huifuid", "");
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
            // 开通微信预授权
            // extendInfoMap.Add("wechatpay_pre_auth_flag", "");
            // 商户业务类型
            // extendInfoMap.Add("mer_bus_type", "");
            // 线上费率配置
            // extendInfoMap.Add("online_fee_conf_list", getOnlineFeeConfList());
            // 支付宝配置对象
            extendInfoMap.Add("ali_conf_list", getAliConfList());
            // 微信配置对象
            extendInfoMap.Add("wx_conf_list", getWxConfList());
            // 银联二维码配置对象
            extendInfoMap.Add("union_conf_list", getUnionConfList());
            // 银行卡支付配置信息
            extendInfoMap.Add("bank_card_conf", getBankCardConf());
            // 余额支付配置对象
            extendInfoMap.Add("balance_pay_config", getBalancePayConfig());
            // 补贴支付
            extendInfoMap.Add("combine_pay_config", getCombinePayConfig());
            // 线上手续费承担方配置
            // extendInfoMap.Add("online_pay_fee_conf_list", getOnlinePayFeeConfList());
            // 银行大额转账对象
            // extendInfoMap.Add("bank_big_amt_pay_config", getBankBigAmtPayConfig());
            // 全域资金管理配置
            // extendInfoMap.Add("out_order_funds_config", getOutOrderFundsConfig());
            // 汇总结算配置实体
            // extendInfoMap.Add("collection_settle_config_list", getCollectionSettleConfigList());
            // 微信直连配置对象
            // extendInfoMap.Add("wx_zl_conf", getWxZlConf());
            // 异步消息接收地址
            extendInfoMap.Add("async_return_url", "[http://www.baidu55.com](http://www.baidu55.com/)");
            // 业务开通结果异步消息接收地址
            extendInfoMap.Add("busi_async_return_url", "");
            // 交易异步应答地址
            extendInfoMap.Add("recon_resp_addr", "[http://192.168.85.157:30031/sspm/testVirgo](http://192.168.85.157:30031/sspm/testVirgo)");
            return extendInfoMap;
        }

        private static string getAgreementInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 协议类型
            obj.Add("agreement_type", "0");
            // 协议开始日期
            obj.Add("agree_begin_date", "20200325");
            // 协议结束日期
            obj.Add("agree_end_date", "20400325");
            // 协议模板号
            obj.Add("agreement_model", "202106070100000380");
            // 协议模板名称
            obj.Add("agreement_name", "电子协议签约模板");
            // 协议号
            obj.Add("agreement_no", "202106070100000380");
            // 签约日期
            obj.Add("sign_date", "20200325");

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
        private static string getAliConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            obj.Add("fee_rate", "3.15");
            // 支付场景
            obj.Add("pay_scene", "1");
            // 商户经营类目
            obj.Add("mcc", "2016062900190337");
            // 子渠道号
            obj.Add("pay_channel_id", "10000001");
            // 拟申请的间联商户等级
            obj.Add("indirect_level", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getWxConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            obj.Add("fee_rate", "2.15");
            // 支付场景
            obj.Add("pay_scene", "10");
            // 商户经营类目[参见微信支付宝MCC](https://paas.huifu.com/partners/api/#/csfl/api_csfl_zfbmcc)；个体工商户、小微商户必填，企业使用fee_rule_id代替原有mcc
            obj.Add("mcc", "5943");
            // 费率规则ID
            obj.Add("fee_rule_id", "765");
            // 子渠道号
            obj.Add("pay_channel_id", "JP00001");
            // 申请服务
            obj.Add("service_codes", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getUnionConfList() {
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

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getBankCardConf() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 借记卡手续费（%）
            obj.Add("debit_fee_rate", "3");
            // 贷记卡手续费（%）
            obj.Add("credit_fee_rate", "6");
            // 银行业务手续费类型
            obj.Add("charge_cate_code", "02");
            // 借记卡封顶值
            obj.Add("debit_fee_limit", "5");
            // 云闪付借记卡手续费1000以上（%）
            obj.Add("cloud_debit_fee_rate_up", "7");
            // 云闪付借记卡封顶1000以上(元)
            obj.Add("cloud_debit_fee_limit_up", "8.922");
            // 云闪付贷记卡手续费1000以上（%）
            obj.Add("cloud_credit_fee_rate_up", "4.86");
            // 云闪付借记卡手续费1000以下（%）
            obj.Add("cloud_debit_fee_rate_down", "0");
            // 云闪付借记卡封顶1000以下(元)
            obj.Add("cloud_debit_fee_limit_down", "10");
            // 云闪付贷记卡手续费1000以下（%）
            obj.Add("cloud_credit_fee_rate_down", "2");
            // 是否开通小额双免
            obj.Add("is_open_small_flag", "0");
            // 小额双免单笔限额(元)
            obj.Add("small_free_amt", "500");
            // 小额双免手续费（%）
            obj.Add("small_fee_amt", "1");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getBalancePayConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付手续费(%)
            obj.Add("fee_rate", "2");
            // 支付固定手续费(元)
            obj.Add("fee_fix_amt", "1");
            // 费率开关
            obj.Add("switch_state", "1");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCombinePayConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开通状态
            obj.Add("switch_state", "0");
            // 支付手续费(%)
            obj.Add("fee_rate", "10");
            // 支付固定手续费(元)
            obj.Add("fee_fix_amt", "5");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            return JsonConvert.SerializeObject(obj);
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
        private static string getBankBigAmtPayConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开关状态
            // obj.Add("switch_state", "");
            // 大额调账标识申请类型
            // obj.Add("biz_type", "");
            // 费率（百分比/%）
            // obj.Add("fee_rate", "");
            // 交易手续费（固定/元）
            // obj.Add("fee_fix_amt", "");
            // 手续费外扣标记
            // obj.Add("out_fee_flag", "");
            // 手续费外扣时的汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 外扣手续费费承担账户号
            // obj.Add("out_fee_acct_id", "");
            // 银行大额转账单笔额度
            // obj.Add("big_amt_limit_per_time", "");
            // 银行大额转账单日额度
            // obj.Add("big_amt_limit_per_day", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getOutOrderAcctCard() {
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

            return JsonConvert.SerializeObject(obj);
        }
        private static string getOutOrderAcctOpenFees() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 开户手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "test");
            // 开户手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getOutOrderFundsConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开通状态
            // obj.Add("switch_state", "test");
            // 自动入账开关
            // obj.Add("out_order_auto_acct_flag", "test");
            // 批次入账时间10:00-10点批次入账&lt;br/&gt;16:00-16点批次入账&lt;/br&gt;开通批次入账时必填 ，多个批次使用逗号分隔；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：10:00,16:00&lt;/font&gt;
            // obj.Add("batch_no", "test");
            // 批量入账开关
            // obj.Add("batch_auto_acct_flag", "");
            // 支付手续费(%)
            // obj.Add("fee_rate", "");
            // 支付固定手续费(元)
            // obj.Add("fee_fix_amt", "");
            // 手续费最小值(元)
            // obj.Add("fee_min_amt", "");
            // 交易手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 交易手续费外扣标记
            // obj.Add("out_fee_flag", "");
            // 交易手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 全域资金开户使用的银行卡信息
            // obj.Add("out_order_acct_card", getOutOrderAcctCard());
            // 全域资金开户手续费
            // obj.Add("out_order_acct_open_fees", getOutOrderAcctOpenFees());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCollectionSettleConfigList() {
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
        private static object getWxZlPayConfList() {
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
        private static string getWxZlConf() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 微信子商户号
            // obj.Add("sub_mch_id", "test");
            // 配置集合
            // obj.Add("wx_zl_pay_conf_list", getWxZlPayConfList());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
