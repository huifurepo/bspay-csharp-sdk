using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 用户业务入驻 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBusiOpenRequestDemo
    {

        public static void V2UserBusiOpenRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2UserBusiOpenRequest request = new V2UserBusiOpenRequest();
            // 汇付ID
            request.setHuifuId("6666000105765113");
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 渠道商/商户汇付Id
            request.setUpperHuifuId("6666000003084836");
            // 签约人信息当电子回单配置开关为开通时必填;当用户升级LV3，并且开通 取现、余额支付、账户充值或者延迟支付任一功能时必填
            // request.setSignUserInfo(get924a19609f8548539bbf4f57831ff987());

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
            // 结算信息配置列表
            extendInfoMap.Add("settle_config_list", get4dbc3de7C40b40c19d9c388f682890cd());
            // 结算卡信息
            extendInfoMap.Add("card_info", get56624ee8Ad9c4a5e889dA1cef8a18df0());
            // 取现配置列表
            extendInfoMap.Add("cash_config", getEac9fc516d8043c7B4441403898d4a43());
            // 文件列表
            extendInfoMap.Add("file_list", getD417123084fc4ce7B3fd588055896555());
            // 延迟入账开关
            // extendInfoMap.Add("delay_flag", "");
            // 斗拱e账户功能配置
            extendInfoMap.Add("elec_acct_config", getC61ddd2a04ab44949196F7f8f601236b());
            // 异步请求地址
            extendInfoMap.Add("async_return_url", "");
            // 电子回单配置
            // extendInfoMap.Add("elec_receipt_config", get819f4c0899454f319bd5490871308232());
            // 用户等级
            // extendInfoMap.Add("account_level", "");
            // 余额支付配置
            // extendInfoMap.Add("balance_pay_config", get0af3c352800349c7A575274a27a69beb());
            // 账户充值配置
            // extendInfoMap.Add("account_recharge_config", getBd4053a468264a5b9fd5C0cc33a860de());
            // 延迟交易配置
            // extendInfoMap.Add("delay_pay_config", getDc0ef2d528094355855e6039e235bce1());
            // 协议信息实体
            // extendInfoMap.Add("agreement_info", getE6cbc075Db3247349f5eCcb33fdb561d());
            return extendInfoMap;
        }

        private static string get4dbc3de7C40b40c19d9c388f682890cd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算周期
            obj.Add("settle_cycle", "D1");
            // 结算手续费外扣时的汇付ID外扣手续费承担方的汇付ID。外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
            obj.Add("out_settle_huifuid", "");
            // 结算手续费外扣时的账户类型外扣手续费账户类型； 01：基本户（为空时默认值），02-现金户， 05：充值户；外扣时必填；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01&lt;/font&gt;
            obj.Add("out_settle_acct_type", "");
            // 结算批次号settle_pattern为P0时必填；[参见结算批次说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_jspc)
            obj.Add("settle_batch_no", "300");
            // 是否优先到账settle_pattern为P0时选填， Y：是 N：否（为空默认取值）；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：Y&lt;/font&gt;
            obj.Add("is_priority_receipt", "");
            // 自定义结算处理时间settle_pattern为P1/P2时必填，注意：00:00到00:30不能指定；格式：HHmmss；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：103000&lt;/font&gt;
            obj.Add("settle_time", "");
            // 节假日结算手续费率settle_cycle为D1时必填。单位%，需保留小数点后两位。取值范围[0.00，100.00]，不收费请填写0.00；settle_cycle&#x3D;T1时，不生效 ；settle_cycle为D1时，遇节假日按此费率结算 ；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;
            obj.Add("fixed_ratio", "2.00");
            // 节假日结算手续费固定金额settle_cycle为D1时必填。单位元，需保留小数点后两位。不收费请填写0.00；settle_cycle结算周期为D1时，遇节假日按此费率结算 ；&lt;br/&gt; &lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;
            obj.Add("constant_amt", "1.00");
            // 起结金额
            obj.Add("min_amt", "0.01");
            // 留存金额
            obj.Add("remained_amt", "10.00");
            // 结算摘要
            obj.Add("settle_abstract", "结算摘要");
            // 手续费外扣标记
            obj.Add("out_settle_flag", "2");
            // 结算方式
            obj.Add("settle_pattern", "");
            // 工作日结算手续费率
            // obj.Add("workday_fixed_ratio", "");
            // 工作日结算手续费固定金额
            // obj.Add("workday_constant_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get56624ee8Ad9c4a5e889dA1cef8a18df0() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡类型
            obj.Add("card_type", "0");
            // 卡户名持卡人姓名；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：张三&lt;/font&gt;&lt;br/&gt;当card_type&#x3D;4时，需要在file_list中额外上传材料；
            obj.Add("card_name", "交通银行股份有限公司");
            // 卡号
            obj.Add("card_no", "6217001210064762121");
            // 银行所在省
            obj.Add("prov_id", "310000");
            // 银行所在市
            obj.Add("area_id", "310100");
            // 支行联行号当card_type&#x3D;0时必填，[点击查看](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_yhzhbm)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：103124075619&lt;/font&gt;
            obj.Add("branch_code", "103124075619");
            // 持卡人证件类型对私必填；参见《[自然人证件类型](https://paas.huifu.com/open/doc/api/#/api_ggcsbm?id&#x3D;%e8%87%aa%e7%84%b6%e4%ba%ba%e8%af%81%e4%bb%b6%e7%b1%bb%e5%9e%8b)》说明；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00&lt;/font&gt;
            obj.Add("cert_type", "00");
            // 持卡人证件号码对私必填； 如:证件类型为身份证, 则填写身份证号码；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：320926198412032059&lt;/font&gt;
            obj.Add("cert_no", "110101197003077513");
            // 持卡人证件有效期类型对私必填；1：长期有效；0：非长期有效；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0&lt;/font&gt;
            obj.Add("cert_validity_type", "0");
            // 持卡人证件有效期（起始）对私必填；日期格式：yyyyMMdd，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20110112&lt;/font&gt;
            obj.Add("cert_begin_date", "20210806");
            // 持卡人证件有效期（截止）当cert_validity_type&#x3D;0时必须填写；日期格式yyyyMMdd，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20110112&lt;/font&gt;&lt;br/&gt;当cert_validity_type&#x3D;1可不填
            obj.Add("cert_end_date", "20410806");
            // 银行卡绑定手机号
            obj.Add("mp", "15556622368");
            // 默认结算卡标志
            // obj.Add("is_settle_default", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getEac9fc516d8043c7B4441403898d4a43() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 提现手续费（固定/元）fix_amt与fee_rate至少填写一项， 需保留小数点后两位，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;注：当cash_type&#x3D;D1时为节假日取现手续费
            obj.Add("fix_amt", "0.03");
            // 提现手续费率（%）fix_amt与fee_rate至少填写一项，需保留小数点后两位，取值范围[0.00,100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;注：1、如果fix_amt与fee_rate都填写了则手续费&#x3D;fix_amt+支付金额\*fee_rate2、当cash_type&#x3D;D1时为节假日取现手续费
            obj.Add("fee_rate", "2.00");
            // D1工作日取现手续费固定金额单位元，需保留小数点后两位。不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;D1取现配置时选填，其他取现配置无效；cash_type取现类型为D1时，遇工作日按此费率结算，若未配置则默认按照节假日手续费计算
            // obj.Add("weekday_fix_amt", "test");
            // D1工作日取现手续费率单位%，需保留小数点后两位。取值范围[0.00，100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;D1取现配置时选填，其他取现配置无效；cash_type取现类型为D1时，遇工作日按此费率结算 ，若未配置则默认按照节假日手续费计算
            // obj.Add("weekday_fee_rate", "test");
            // 业务类型
            obj.Add("cash_type", "D1");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "");
            // 手续费承担方
            obj.Add("out_fee_huifu_id", "");
            // 交易手续费外扣的账户类型
            obj.Add("out_fee_acct_type", "");
            // 是否优先到账
            // obj.Add("is_priority_receipt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getD417123084fc4ce7B3fd588055896555() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            obj.Add("file_type", "F02");
            // 文件jfileID
            obj.Add("file_id", "71da066c-5d15-3658-a86d-4e85ee67808a");
            // 文件名称
            obj.Add("file_name", "企业营业执照1.jpg");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get32f52ad06c8a4ea1Ae728edf893a0490() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行所在省
            obj.Add("prov_id", "440000");
            // 银行所在市
            obj.Add("area_id", "441200");
            // 银行编码
            obj.Add("bank_code", "01030000");
            // 支行联行号
            obj.Add("branch_code", "103100000018");
            // 支行名称
            obj.Add("branch_name", "中国农业银行股份有限公司总行营业部");
            // 结算账户名
            obj.Add("card_name", "XXXXX有限公司");
            // 银行卡号
            obj.Add("card_no", "44658001123435159");
            // 卡类型
            obj.Add("card_type", "0");
            // 银行绑定手机号
            obj.Add("mp", "18611111111");
            // 默认卡标识
            obj.Add("default_cash_flag", "0");
            // 用户授权协议版本号
            // obj.Add("auth_version", "");
            // 用户授权协议号
            // obj.Add("auth_no", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getC61ddd2a04ab44949196F7f8f601236b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 电子账户开关
            obj.Add("switch_state", "1");
            // 账户类型
            obj.Add("acct_type", "01");
            // 电子账户提现手续费承担方
            obj.Add("cash_fee_party", "2");
            // 场景
            obj.Add("scene", "004");
            // 角色类型(角色编号)
            obj.Add("role_type", "004001");
            // 签约成功标志
            obj.Add("sign_success_flag", "Y");
            // 银行卡信息
            obj.Add("elec_card_list", get32f52ad06c8a4ea1Ae728edf893a0490());
            // 用户类型
            // obj.Add("user_type", "");
            // 中信签约短信流水号
            // obj.Add("elec_acct_sign_seq_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get819f4c0899454f319bd5490871308232() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 电子回单开关
            // obj.Add("switch_state", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get924a19609f8548539bbf4f57831ff987() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 签约人类型
            // obj.Add("type", "test");
            // 签约人手机号
            // obj.Add("mobile_no", "test");
            // 签约人身份证
            // obj.Add("cert_no", "");
            // 签约人姓名
            // obj.Add("name", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get0af3c352800349c7A575274a27a69beb() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费(%)
            // obj.Add("fee_rate", "test");
            // 手续费（固定/元）
            // obj.Add("fee_fix_amt", "test");
            // 手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");
            // 扣费模式
            // obj.Add("charge_mode", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getBd4053a468264a5b9fd5C0cc33a860de() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 手续费(%)
            // obj.Add("fee_rate", "test");
            // 手续费（固定/元）
            // obj.Add("fee_fix_amt", "test");
            // 手续费外扣汇付ID开通账户充值手续费外扣业务时必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
            // obj.Add("out_fee_huifu_id", "test");
            // 交易手续费外扣账户号开通账户充值手续费外扣业务时必填，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：C03540512&lt;/font&gt;
            // obj.Add("out_fee_acct_id", "test");
            // 交易手续费外扣标记
            // obj.Add("out_fee_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getDc0ef2d528094355855e6039e235bce1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开通状态
            // obj.Add("switch_state", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getE6cbc075Db3247349f5eCcb33fdb561d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 协议类型
            // obj.Add("agreement_type", "test");
            // 电子协议签约短信发送标识
            // obj.Add("message_send_type", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
