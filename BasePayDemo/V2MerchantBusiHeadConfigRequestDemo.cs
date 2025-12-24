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
            // extendInfoMap.Add("ali_conf_list", get913c1602480a4d3f9272Ec0e767d7aeb());
            // 微信配置对象
            // extendInfoMap.Add("wx_conf_list", get7c4de91918c54844A91660cc790a6279());
            // 银联二维码配置对象
            // extendInfoMap.Add("union_conf_list", get5bb3480e73e74c89A5b8E8d55fcd727f());
            // 银联卡配置对象
            // extendInfoMap.Add("bank_card_config", get43610f0c07234fd6Aaa572407a3afc14());
            // 分账配置对象
            // extendInfoMap.Add("split_config", get6966f9e50a5440a58786Ff2442383ca1());
            // 微信直连配置对象
            // extendInfoMap.Add("wx_zl_conf_list", getB9b15afd4a8845c68a93E1842aff41af());
            // 支付宝直连配置对象
            // extendInfoMap.Add("ali_zl_conf", getA690bc363cdd4dd98ff27380d9a5e3ad());
            // 线上配置对象
            // extendInfoMap.Add("online_fee_conf_list", getF65bded5Bed64adfB2b93e7b63e655ef());
            // 余额支付配置对象
            // extendInfoMap.Add("balance_pay_config", getE2ea5610E72a4eb7BcbfB22e421f2280());
            // 补贴支付配置对象
            // extendInfoMap.Add("combine_pay_config", get954e91de94c1460c84a09c566d830256());
            // 银行大额转账配置对象
            // extendInfoMap.Add("bank_big_amt_pay_config", getF455cd9778ea4b56994dF548ccc8f072());
            // 全域资金管理配置对象（华通银行）
            // extendInfoMap.Add("out_order_funds_config", getD7cd57bdAdb745cfA5dd146451d79cfa());
            // 全域资金管理配置(XW银行)
            // extendInfoMap.Add("out_order_funds_new_net_config", getBf284cc60b5b4672887749ad39dc8524());
            // 结算配置对象
            // extendInfoMap.Add("settle_config_list", getE6d4b7d816ee4f47887fDdd12d36aa23());
            // 取现配置对象
            // extendInfoMap.Add("cash_config_list", get5d6c5e557bb04748B1254a84df2d23ef());
            // 外扣配置对象
            // extendInfoMap.Add("out_fee_config", get4ad35a9b5ff64f65A4e1A84915733f4d());
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
            // extendInfoMap.Add("large_amt_pay_config_list", get91761c415cb347e59369Ada12376ef40());
            // 全域资金管理配置(苏商)
            // extendInfoMap.Add("out_order_funds_su_shang_config", getD8d27591E0424fc9B36115f70c06480b());
            // 托管支付开关
            // extendInfoMap.Add("half_pay_host_flag", "");
            // 全域资金费用配置对象
            // extendInfoMap.Add("out_order_funds_fee_list", getE42011c14cae453788fb872edae6a744());
            // 本地生活生活配置对象
            // extendInfoMap.Add("lla_withhold_config", getEd96185593a44f3480a2F84da188b3ee());
            return extendInfoMap;
        }

        private static string get913c1602480a4d3f9272Ec0e767d7aeb() {
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
        private static string get7c4de91918c54844A91660cc790a6279() {
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
        private static string get5bb3480e73e74c89A5b8E8d55fcd727f() {
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
        private static string get43610f0c07234fd6Aaa572407a3afc14() {
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
        private static string get6966f9e50a5440a58786Ff2442383ca1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通分账业务
            // obj.Add("open_flag", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getB9b15afd4a8845c68a93E1842aff41af() {
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
        private static string getA690bc363cdd4dd98ff27380d9a5e3ad() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 允许开通支付宝直连业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getF65bded5Bed64adfB2b93e7b63e655ef() {
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
        private static string getE2ea5610E72a4eb7BcbfB22e421f2280() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通余额支付业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get954e91de94c1460c84a09c566d830256() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通补贴支付业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getF455cd9778ea4b56994dF548ccc8f072() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费（%）
            // obj.Add("fee_rate", "test");
            // 固定手续费(元)
            // obj.Add("fee_fix_amt", "test");
            // 允许开通大额转账业务
            // obj.Add("open_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getD7cd57bdAdb745cfA5dd146451d79cfa() {
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
        private static string getBf284cc60b5b4672887749ad39dc8524() {
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
        private static string getE6d4b7d816ee4f47887fDdd12d36aa23() {
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
        private static string get5d6c5e557bb04748B1254a84df2d23ef() {
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
        private static string get4ad35a9b5ff64f65A4e1A84915733f4d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支持结算手续费外扣
            // obj.Add("settle_out_fee_flag", "test");
            // 支持交易手续费外扣
            // obj.Add("trans_fee_out_flag", "test");
            // 支持取现手续费外扣
            // obj.Add("cash_out_fee_flag", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get91761c415cb347e59369Ada12376ef40() {
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
        private static string getD8d27591E0424fc9B36115f70c06480b() {
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
        private static string getE42011c14cae453788fb872edae6a744() {
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
        private static object getEd96185593a44f3480a2F84da188b3ee() {
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
