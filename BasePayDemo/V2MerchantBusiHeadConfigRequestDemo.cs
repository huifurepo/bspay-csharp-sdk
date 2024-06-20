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
            // extendInfoMap.Add("ali_conf_list", getSubmerAliConfList());
            // 微信配置对象
            // extendInfoMap.Add("wx_conf_list", getSubmerWxConfList());
            // 银联二维码配置对象
            // extendInfoMap.Add("union_conf_list", getSubmerUnionConfList());
            // 银联卡配置对象
            // extendInfoMap.Add("bank_card_config", getSubmerBankCardConfig());
            // 分账配置对象
            // extendInfoMap.Add("split_config", getSubmerSplitConfig());
            // 微信直连配置对象
            // extendInfoMap.Add("wx_zl_conf_list", getSubmerWxZlConfList());
            // 支付宝直连配置对象
            // extendInfoMap.Add("ali_zl_conf", getSubmerAliZlConf());
            // 线上配置对象
            // extendInfoMap.Add("online_fee_conf_list", getSubmerOnlineFeeConfList());
            // 余额支付配置对象
            // extendInfoMap.Add("balance_pay_config", getSubmerBalancePayConfig());
            // 补贴支付配置对象
            // extendInfoMap.Add("combine_pay_config", getSubmerCombinePayConfig());
            // 银行大额转账配置对象
            // extendInfoMap.Add("bank_big_amt_pay_config", getSubmerBankBigAmtPayConfig());
            // 全域资金管理配置对象（华通银行）
            // extendInfoMap.Add("out_order_funds_config", getSubmerOutOrderFundsConfig());
            // 全域资金管理配置(新网银行)
            // extendInfoMap.Add("out_order_funds_new_net_config", getOutOrderFundsNewNetConfig());
            // 结算配置对象
            // extendInfoMap.Add("settle_config_list", getSubmerSettleConfigList());
            // 取现配置对象
            // extendInfoMap.Add("cash_config_list", getSubmerCashConfigList());
            // 外扣配置对象
            // extendInfoMap.Add("out_fee_config", getSubmerOutFeeConfig());
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
            return extendInfoMap;
        }

        private static string getSubmerAliConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            // obj.Add("pay_scene", "test");
            // 手续费
            // obj.Add("fee_rate", "test");
            // 允许开通该业务
            // obj.Add("open_flag", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getSubmerWxConfList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            // obj.Add("pay_scene", "test");
            // 手续费
            // obj.Add("fee_rate", "test");
            // 允许开通该场景业务
            // obj.Add("open_flag", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getSubmerUnionConfList() {
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
        private static string getSubmerBankCardConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 借记卡手续费（%）
            // obj.Add("debit_fee_rate", "test");
            // 贷记卡手续费（%）
            // obj.Add("credit_fee_limit", "test");
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
        private static string getSubmerSplitConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通分账业务
            // obj.Add("open_flag", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getSubmerWxZlConfList() {
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
        private static string getSubmerAliZlConf() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通支付宝直连业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getSubmerOnlineFeeConfList() {
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

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getSubmerBalancePayConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通余额支付业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getSubmerCombinePayConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通补贴支付业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getSubmerBankBigAmtPayConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通大额转账业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getSubmerOutOrderFundsConfig() {
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
        private static string getOutOrderFundsNewNetConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 保底手续费(元)
            // obj.Add("fee_min_amt", "test");
            // 对公固定手续费(元)
            // obj.Add("public_fee_fix_amt", "test");
            // 对私固定手续费(元)
            // obj.Add("private_fee_fix_amt", "test");
            // 允许开通全域资金业务(新网)
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getSubmerSettleConfigList() {
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
        private static string getSubmerCashConfigList() {
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
        private static string getSubmerOutFeeConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支持结算手续费外扣
            // obj.Add("settle_out_fee_flag", "test");
            // 支持交易手续费外扣
            // obj.Add("trans_fee_out_flag", "test");
            // 支持取现手续费外扣
            // obj.Add("cash_out_fee_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
