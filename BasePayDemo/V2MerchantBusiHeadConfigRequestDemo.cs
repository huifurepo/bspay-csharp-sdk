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
            // extendInfoMap.Add("ali_conf_list", get916e568b03b4448b8442Bc59607f55a9());
            // 微信配置对象
            // extendInfoMap.Add("wx_conf_list", get91a6f3c897084daaA750D460c4223fdd());
            // 银联二维码配置对象
            // extendInfoMap.Add("union_conf_list", get11f18154070b4ef3B79c6bd7442b51bd());
            // 银联卡配置对象
            // extendInfoMap.Add("bank_card_config", getD38dbb2fA005448eAefa2631e82a43bd());
            // 分账配置对象
            // extendInfoMap.Add("split_config", getD74f8d2cAb1345d7B05859cbc476ef6e());
            // 微信直连配置对象
            // extendInfoMap.Add("wx_zl_conf_list", get5a0a3440F93241359adcC4c7bd515643());
            // 支付宝直连配置对象
            // extendInfoMap.Add("ali_zl_conf", getD624c523351a4f1f995f73e7862d4f5c());
            // 线上配置对象
            // extendInfoMap.Add("online_fee_conf_list", get5ed15ef0B2e847f8A438A8c88a7bab1f());
            // 余额支付配置对象
            // extendInfoMap.Add("balance_pay_config", get78b6d2f909434f408f929dd15fee6672());
            // 补贴支付配置对象
            // extendInfoMap.Add("combine_pay_config", get019b2ffc8bb04a42Aa4f87623ed4ee78());
            // 银行大额转账配置对象
            // extendInfoMap.Add("bank_big_amt_pay_config", getDdb760be91d245959c0c57e3795c2e75());
            // 全域资金管理配置对象（华通银行）
            // extendInfoMap.Add("out_order_funds_config", get029b9aa1Ef7c445eAee78f34392d75a1());
            // 全域资金管理配置(XW银行)
            // extendInfoMap.Add("out_order_funds_new_net_config", get11de5eefC8bc4ddd9bc091896e59685a());
            // 结算配置对象
            // extendInfoMap.Add("settle_config_list", getB3273ffb43614889855bF0effa4c544e());
            // 取现配置对象
            // extendInfoMap.Add("cash_config_list", getAb8250102ee14d688a3c697ded75df88());
            // 外扣配置对象
            // extendInfoMap.Add("out_fee_config", get3a66f24451584846865293177b71f238());
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
            // extendInfoMap.Add("large_amt_pay_config_list", getD8c6d0c002ca46cfB9efD110095bd83a());
            // 全域资金管理配置(苏商)
            // extendInfoMap.Add("out_order_funds_su_shang_config", getD31e7929847346248e31C3f56fb221a4());
            // 托管支付开关
            // extendInfoMap.Add("half_pay_host_flag", "");
            return extendInfoMap;
        }

        private static string get916e568b03b4448b8442Bc59607f55a9() {
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
        private static string get91a6f3c897084daaA750D460c4223fdd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            // obj.Add("pay_scene", "test");
            // 手续费
            // obj.Add("fee_rate", "test");
            // 允许开通该场景业务
            // obj.Add("open_flag", "test");
            // 最低收取手续费（元）
            // obj.Add("fee_min_amt", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get11f18154070b4ef3B79c6bd7442b51bd() {
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
        private static string getD38dbb2fA005448eAefa2631e82a43bd() {
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
        private static string getD74f8d2cAb1345d7B05859cbc476ef6e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通分账业务
            // obj.Add("open_flag", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get5a0a3440F93241359adcC4c7bd515643() {
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
        private static string getD624c523351a4f1f995f73e7862d4f5c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通支付宝直连业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get5ed15ef0B2e847f8A438A8c88a7bab1f() {
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
        private static string get78b6d2f909434f408f929dd15fee6672() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通余额支付业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get019b2ffc8bb04a42Aa4f87623ed4ee78() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通补贴支付业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getDdb760be91d245959c0c57e3795c2e75() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通大额转账业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get029b9aa1Ef7c445eAee78f34392d75a1() {
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
        private static string get11de5eefC8bc4ddd9bc091896e59685a() {
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
        private static string getB3273ffb43614889855bF0effa4c544e() {
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
        private static string getAb8250102ee14d688a3c697ded75df88() {
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
        private static string get3a66f24451584846865293177b71f238() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支持结算手续费外扣
            // obj.Add("settle_out_fee_flag", "test");
            // 支持交易手续费外扣
            // obj.Add("trans_fee_out_flag", "test");
            // 支持取现手续费外扣
            // obj.Add("cash_out_fee_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getD8c6d0c002ca46cfB9efD110095bd83a() {
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
        private static string getD31e7929847346248e31C3f56fb221a4() {
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
    }
}
