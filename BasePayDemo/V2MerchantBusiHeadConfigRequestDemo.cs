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
            // 直属渠道号该商户进件完成后归属的渠道商huifu_id；；&lt;br/&gt;sys_id主体为渠道商时填写； &lt;br/&gt;sys_id主体为总部商户时选填；&lt;br/&gt; &lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
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
            // extendInfoMap.Add("ali_conf_list", get3b39d92eC1c74d6dA4fbC29f0fc5de36());
            // 微信配置对象
            // extendInfoMap.Add("wx_conf_list", getBe2c2ad8B8ff43bf98223776eafe76f6());
            // 银联二维码配置对象
            // extendInfoMap.Add("union_conf_list", getA0588272Dd9543ef86e7B472eb82c55a());
            // 银联卡配置对象
            // extendInfoMap.Add("bank_card_config", get13430b5bDfab4634992748b527981508());
            // 分账配置对象
            // extendInfoMap.Add("split_config", getBc4c9bcbF9b942889486Cdbc5c8c9f1c());
            // 微信直连配置对象
            // extendInfoMap.Add("wx_zl_conf_list", get7a42976cE3da4575B6feDd8932994c14());
            // 支付宝直连配置对象
            // extendInfoMap.Add("ali_zl_conf", get622dcd3a7b7b45c38de2919594c16f41());
            // 线上配置对象
            // extendInfoMap.Add("online_fee_conf_list", get0f786eef05944bf68fb5C92f5906a96a());
            // 余额支付配置对象
            // extendInfoMap.Add("balance_pay_config", get0e160e96Cb17429686a4365e5d968f57());
            // 补贴支付配置对象
            // extendInfoMap.Add("combine_pay_config", get0532062b23d34359A699Ef47a9c75acd());
            // 银行大额转账配置对象
            // extendInfoMap.Add("bank_big_amt_pay_config", get5c94bd76B25040878755136ea12a78de());
            // 全域资金管理配置对象（华通银行）
            // extendInfoMap.Add("out_order_funds_config", getC5eb39eeCa584d29B09e60103d064fb7());
            // 全域资金管理配置(XW银行)
            // extendInfoMap.Add("out_order_funds_new_net_config", getAa4bcb7a48f0433eAda10206f4814f47());
            // 结算配置对象
            // extendInfoMap.Add("settle_config_list", get0c4853b267924652B52e76b3d0fea998());
            // 取现配置对象
            // extendInfoMap.Add("cash_config_list", get6a265ef9E88e4c008176975ce5c72a35());
            // 外扣配置对象
            // extendInfoMap.Add("out_fee_config", get3a37f3557ff64fe6A11e8f0db37e709e());
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
            // extendInfoMap.Add("large_amt_pay_config_list", get0e88fc4d2ab44c46A447F445fc6e6694());
            // 全域资金管理配置(苏商)
            // extendInfoMap.Add("out_order_funds_su_shang_config", getD181c95e0e114a4eB294659df51793cc());
            // 统一收银台开关
            // extendInfoMap.Add("half_pay_host_flag", "");
            // 全域资金费用配置对象
            // extendInfoMap.Add("out_order_funds_fee_list", getE7e28aef95074e0c8886206a279a8cbb());
            // 本地生活生活配置对象
            // extendInfoMap.Add("lla_withhold_config", get8f6fea3524f041fcB92e1b3200c1414b());
            // 是否开通账单支付
            // extendInfoMap.Add("bill_payment_flag", "");
            // 抖音配置对象
            // extendInfoMap.Add("dy_conf_list", get53df1aab578943b7B08cC1524584ea1d());
            return extendInfoMap;
        }

        private static string get3b39d92eC1c74d6dA4fbC29f0fc5de36() {
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
        private static string getBe2c2ad8B8ff43bf98223776eafe76f6() {
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
        private static string getA0588272Dd9543ef86e7B472eb82c55a() {
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
        private static string get13430b5bDfab4634992748b527981508() {
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
        private static string getBc4c9bcbF9b942889486Cdbc5c8c9f1c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通分账业务
            // obj.Add("open_flag", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get7a42976cE3da4575B6feDd8932994c14() {
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
        private static string get622dcd3a7b7b45c38de2919594c16f41() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通支付宝直连业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get0f786eef05944bf68fb5C92f5906a96a() {
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
            // 代扣手续费计费模式
            // obj.Add("fee_formula_type", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get0e160e96Cb17429686a4365e5d968f57() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通余额支付业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get0532062b23d34359A699Ef47a9c75acd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通补贴支付业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get5c94bd76B25040878755136ea12a78de() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通大额转账业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getC5eb39eeCa584d29B09e60103d064fb7() {
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
        private static string getAa4bcb7a48f0433eAda10206f4814f47() {
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
        private static string get0c4853b267924652B52e76b3d0fea998() {
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
        private static string get6a265ef9E88e4c008176975ce5c72a35() {
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
        private static string get3a37f3557ff64fe6A11e8f0db37e709e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支持结算手续费外扣
            // obj.Add("settle_out_fee_flag", "test");
            // 支持交易手续费外扣
            // obj.Add("trans_fee_out_flag", "test");
            // 支持取现手续费外扣
            // obj.Add("cash_out_fee_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get0e88fc4d2ab44c46A447F445fc6e6694() {
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
        private static string getD181c95e0e114a4eB294659df51793cc() {
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
        private static string getE7e28aef95074e0c8886206a279a8cbb() {
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
        private static object get8f6fea3524f041fcB92e1b3200c1414b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 本地生活开关
            // obj.Add("llaWithholdFlag", "test");
            // 佣金收取手续费率
            // obj.Add("fee_rate", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get53df1aab578943b7B08cC1524584ea1d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 抖音商户行业分类
            // obj.Add("mer_industry_category", "test");
            // 手续费模式
            // obj.Add("fee_model", "test");
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 最低收取手续费（元）
            // obj.Add("fee_min_amt", "");
            // 是否允许开通
            // obj.Add("open_flag", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
