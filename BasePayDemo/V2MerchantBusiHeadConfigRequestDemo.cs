using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 开通下级商户权限配置接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiHeadConfigRequestDemo
    {

        public static void V2MerchantBusiHeadConfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBusiHeadConfigRequest request = new V2MerchantBusiHeadConfigRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000108854952");
            // 产品编号
            // request.setProductId("test");
            // 直属渠道号
            // request.setUpperHuifuId("test");

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
            // 支付宝配置对象
            // extendInfoMap.Add("ali_conf_list", get13c3b33e932a42d2A7f4798ecbe93d46());
            // 微信配置对象
            // extendInfoMap.Add("wx_conf_list", get16bbb5862999456495d27d558e2291be());
            // 银联二维码配置对象
            // extendInfoMap.Add("union_conf_list", getAad2676438224c29B409Ac741647877c());
            // 银联卡配置对象
            // extendInfoMap.Add("bank_card_config", get690b30c6B2144955B5f1F9ac7e7a65a4());
            // 分账配置对象
            // extendInfoMap.Add("split_config", get52816b962be4453aB1ca03d7794944a4());
            // 微信直连配置对象
            // extendInfoMap.Add("wx_zl_conf_list", getF757d19392f549b2Bd09D509c3660eab());
            // 支付宝直连配置对象
            // extendInfoMap.Add("ali_zl_conf", getE235c2d1Cd454236A48318430670882b());
            // 线上配置对象
            // extendInfoMap.Add("online_fee_conf_list", get863d3757Bf154effAf4dB2423b77a0cd());
            // 余额支付配置对象
            // extendInfoMap.Add("balance_pay_config", getCe01db43F95f4e8c920550bc64905e96());
            // 补贴支付配置对象
            // extendInfoMap.Add("combine_pay_config", getFe4eee1dAa4a4efa9caf37af7b1a35dd());
            // 银行大额转账配置对象
            // extendInfoMap.Add("bank_big_amt_pay_config", get9863fd490a284fe390d10d30e6ffa498());
            // 全域资金管理配置对象（华通银行）
            // extendInfoMap.Add("out_order_funds_config", get7dfeca255a6040de91b9E60a636eed21());
            // 全域资金管理配置(XW银行)
            // extendInfoMap.Add("out_order_funds_new_net_config", getFbef274f07d54d8c9992Cf69d6502f1e());
            // 结算配置对象
            // extendInfoMap.Add("settle_config_list", get8284b36fDc404c48Aa27A946ee52804d());
            // 取现配置对象
            // extendInfoMap.Add("cash_config_list", getB5db301aAd5b465cAf4f1c326ab75a7e());
            // 外扣配置对象
            // extendInfoMap.Add("out_fee_config", getC6f8e890248e40ca80ff193b2be602d9());
            // 允许开通支付宝预授权
            // extendInfoMap.Add("alipay_pre_auth_flag", "");
            // 允许开通微信预授权
            // extendInfoMap.Add("wechatpay_pre_auth_flag", "");
            // 允许开通商户定时结算
            // extendInfoMap.Add("mer_timing_settle_flag", "");
            // 允许开通商户优先结算
            // extendInfoMap.Add("mer_prior_settle_flag", "");
            // 允许使用上级商户经营信息
            // extendInfoMap.Add("use_upper_mer_auth_flag", "");
            // 允许使用上级商户号发起AT交易
            // extendInfoMap.Add("use_upper_mer_at_trans_flag", "");
            // 大额支付配置
            // extendInfoMap.Add("large_amt_pay_config_list", get503cedaf88f14a03940a577a67f5cffe());
            // 全域资金管理配置(苏商)
            // extendInfoMap.Add("out_order_funds_su_shang_config", getC9a1790b0e9a415bB4cc45e9d3f2e690());
            // 统一收银台开关
            // extendInfoMap.Add("half_pay_host_flag", "");
            // 全域资金费用配置对象
            // extendInfoMap.Add("out_order_funds_fee_list", getDcfe9801Bfca44549e8337c736660146());
            // 本地生活生活配置对象
            // extendInfoMap.Add("lla_withhold_config", getE14936f33577427e8ad8Bb1b2bf9958f());
            // 是否开通账单支付
            // extendInfoMap.Add("bill_payment_flag", "");
            return extendInfoMap;
        }

        private static string get13c3b33e932a42d2A7f4798ecbe93d46() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            // obj.Add("pay_scene", "test");
            // 手续费
            // obj.Add("fee_rate", "test");
            // 允许开通该业务
            // obj.Add("open_flag", "test");
            // 最低收取手续费（元）
            // obj.Add("fee_min_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get16bbb5862999456495d27d558e2291be() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            // obj.Add("pay_scene", "test");
            // 手续费
            // obj.Add("fee_rate", "test");
            // 允许开通该场景业务
            // obj.Add("open_flag", "test");
            // 最低收取手续费（元）
            // obj.Add("fee_min_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getAad2676438224c29B409Ac741647877c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 借记卡手续费1000以上(%)
            // obj.Add("debit_fee_rate_up", "test");
            // 银联二维码业务贷记卡手续费1000以上(%)
            // obj.Add("credit_fee_rate_up", "test");
            // 借记卡手续费1000以下(%)
            // obj.Add("debit_fee_rate_down", "test");
            // 银联二维码业务贷记卡手续费1000以下(%)
            // obj.Add("credit_fee_rate_down", "test");
            // 允许开通银联二维码业务
            // obj.Add("open_flag", "test");
            // 银联业务手续费类型
            // obj.Add("charge_cate_code", "");
            // 借记卡封顶1000以上（元）
            // obj.Add("debit_fee_limit_up", "");
            // 借记卡封顶1000以下（元）
            // obj.Add("debit_fee_limit_down", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get690b30c6B2144955B5f1F9ac7e7a65a4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 借记卡手续费（%）
            // obj.Add("debit_fee_rate", "test");
            // 贷记卡手续费（%）
            // obj.Add("credit_fee_rate", "test");
            // 允许开通银行卡业务
            // obj.Add("open_flag", "test");
            // 借记卡封顶值
            // obj.Add("debit_fee_limit", "");
            // 银联手机闪付借记卡手续费1000以上（%）
            // obj.Add("cloud_debit_fee_rate_up", "");
            // 银联手机闪付借记卡封顶1000以上（元）
            // obj.Add("cloud_debit_fee_limit_up", "");
            // 银联手机闪付贷记卡手续费1000以上（%）
            // obj.Add("cloud_credit_fee_rate_up", "");
            // 银联手机闪付借记卡手续费1000以下（%）
            // obj.Add("cloud_debit_fee_rate_down", "");
            // 银联手机闪付借记卡封顶1000以下（元）
            // obj.Add("cloud_debit_fee_limit_down", "");
            // 银联手机闪付贷记卡手续费1000以下（%）
            // obj.Add("cloud_credit_fee_rate_down", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get52816b962be4453aB1ca03d7794944a4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通分账业务
            // obj.Add("open_flag", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getF757d19392f549b2Bd09D509c3660eab() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            // obj.Add("pay_scene", "test");
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通微信直连业务
            // obj.Add("open_flag", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getE235c2d1Cd454236A48318430670882b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通支付宝直连业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get863d3757Bf154effAf4dB2423b77a0cd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            // obj.Add("bus_type", "test");
            // 借贷记标识
            // obj.Add("dc_flag", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 银行号
            // obj.Add("bank_code", "test");
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通线上支付业务
            // obj.Add("open_flag", "test");
            // 手续费最小值（元）
            // obj.Add("fee_min_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getCe01db43F95f4e8c920550bc64905e96() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通余额支付业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getFe4eee1dAa4a4efa9caf37af7b1a35dd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通补贴支付业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get9863fd490a284fe390d10d30e6ffa498() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通大额转账业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get7dfeca255a6040de91b9E60a636eed21() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 开户手续费（元）
            // obj.Add("open_fee_fix_amt", "test");
            // 保底手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通全域资金业务（华通）
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getFbef274f07d54d8c9992Cf69d6502f1e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 保底手续费(元)
            // obj.Add("fee_min_amt", "test");
            // 对公固定手续费(元)
            // obj.Add("public_fee_fix_amt", "test");
            // 对私固定手续费(元)
            // obj.Add("private_fee_fix_amt", "test");
            // 允许开通全域资金业务(XW)
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get8284b36fDc404c48Aa27A946ee52804d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            // obj.Add("bus_type", "test");
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通结算配置
            // obj.Add("open_flag", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getB5db301aAd5b465cAf4f1c326ab75a7e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            // obj.Add("bus_type", "test");
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通取现配置
            // obj.Add("open_flag", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getC6f8e890248e40ca80ff193b2be602d9() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支持结算手续费外扣
            // obj.Add("settle_out_fee_flag", "test");
            // 支持交易手续费外扣
            // obj.Add("trans_fee_out_flag", "test");
            // 支持取现手续费外扣
            // obj.Add("cash_out_fee_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get503cedaf88f14a03940a577a67f5cffe() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通大额转账业务
            // obj.Add("open_flag", "test");
            // 大额支付业务模式
            // obj.Add("business_model", "test");
            // 允许用户入账
            // obj.Add("allow_user_deposit_flag", "");
            // 银行卡绑定支付权限
            // obj.Add("mer_same_card_recharge_flag", "");
            // 备付金固定账号模式自动退款
            // obj.Add("provisions_auto_refund_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getC9a1790b0e9a415bB4cc45e9d3f2e690() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 保底手续费(元)
            // obj.Add("fee_min_amt", "test");
            // 对公固定手续费(元)
            // obj.Add("public_fee_fix_amt", "test");
            // 对私固定手续费(元)
            // obj.Add("private_fee_fix_amt", "test");
            // 允许开通全域资金业务(苏商)
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getDcfe9801Bfca44549e8337c736660146() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            // obj.Add("bus_type", "test");
            // 手续费（百分比/%）
            // obj.Add("fee_rate", "test");
            // 手续费（固定/元）
            // obj.Add("fee_fix_amt", "test");
            // 是否允许开通
            // obj.Add("open_flag", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object getE14936f33577427e8ad8Bb1b2bf9958f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 本地生活开关
            // obj.Add("llaWithholdFlag", "test");
            // 佣金收取手续费率
            // obj.Add("fee_rate", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
    }
}
