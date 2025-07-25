using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 灵工企业商户进件接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleEntRequestDemo
    {

        public static void V2FlexibleEntRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2FlexibleEntRequest request = new V2FlexibleEntRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 渠道商号
            request.setUpperHuifuId("6666000108406684");
            // 商户角色
            // request.setMerRole("test");
            // 落地公司类型当选择落地公司时，必填;SELF-自有，COOPERATE-合作
            // request.setLocalCompanyType("test");
            // 商户名称
            request.setRegName("圆务铁白事");
            // 商户简称
            request.setShortName("沈桂英");
            // 证照图片
            request.setLicensePic("f6fc539b-73ff-3645-8539-ad318971cc48");
            // 证照编号
            request.setLicenseCode("91440101MA20250618");
            // 证照有效期类型
            request.setLicenseValidityType("1");
            // 证照有效期开始日期
            request.setLicenseBeginDate("20240314");
            // 证照有效期截止日期格式：yyyyMMdd。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;  当license_validity_type&#x3D;0时必填；当license_validity_type&#x3D;1时为空；
            request.setLicenseEndDate("");
            // 成立时间
            request.setFoundDate("20240314");
            // 注册区
            request.setRegDistrictId("310104");
            // 注册详细地址
            request.setRegDetail("方立全气气目队得形");
            // 法人姓名
            request.setLegalName("天天优先");
            // 法人证件类型
            request.setLegalCertType("00");
            // 法人证件号码
            request.setLegalCertNo("110101199003072551");
            // 法人证件有效期类型
            request.setLegalCertValidityType("1");
            // 法人证件有效期开始日期
            request.setLegalCertBeginDate("19710718");
            // 法人证件有效期截止日期日期格式：yyyyMMdd， &lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;当legal_cert_validity_type&#x3D;0时必填；&lt;br/&gt;当legal_cert_validity_type&#x3D;1时为空；&lt;br/&gt;
            request.setLegalCertEndDate("");
            // 法人证件地址
            request.setLegalAddr("信约候再研情其常");
            // 法人身份证国徽面
            request.setLegalCertBackPic("f6fc539b-73ff-3645-8539-ad318971cc48");
            // 法人身份证人像面
            request.setLegalCertFrontPic("f6fc539b-73ff-3645-8539-ad318971cc48");
            // 店铺门头照
            request.setStoreHeaderPic("f6fc539b-73ff-3645-8539-ad318971cc48");
            // 联系人手机号
            request.setContactMobileNo("13074561767");
            // 联系人电子邮箱
            request.setContactEmail("c.vwpjkqx@urgr.be");
            // 管理员账号
            request.setLoginName("req2025061853130071");
            // 银行卡信息配置
            request.setCardInfo(getCaa0c059Bc8544639eabA1cbfb39c354());
            // 签约人
            // request.setSignUserInfo(get22486c6a11674ab78c2898a036901bf9());

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
            // 商户通知标识
            extendInfoMap.Add("sms_send_flag", "1");
            // 证照类型
            extendInfoMap.Add("license_type", "NATIONAL_LEGAL_MERGE");
            // 注册省
            extendInfoMap.Add("reg_prov_id", "310000");
            // 注册市
            extendInfoMap.Add("reg_area_id", "310100");
            // 法人手机号
            extendInfoMap.Add("legal_mobile_no", "13074561767");
            // 联系人姓名
            extendInfoMap.Add("contact_name", "文超");
            // 取现业务配置
            // extendInfoMap.Add("cash_config", get990b98a297e44a189e1aF069844dc589());
            // 大额支付配置
            // extendInfoMap.Add("large_amt_pay_config", getB721f3523cb14df09177415a293eb494());
            // 是否开通网银充值
            // extendInfoMap.Add("online_recharge_flag", "");
            // 线上费率配置
            // extendInfoMap.Add("online_fee_conf_list", getFb310e7292804509Ba9e019648efe90c());
            // 线上手续费承担方配置
            // extendInfoMap.Add("online_pay_fee_conf_list", get20b809b62f9f4239A59fE5b8fcd2d44d());
            // 灵工支付配置
            // extendInfoMap.Add("flexible_pay_config", getAa3c46b582694c21A5a82f4e29d46802());
            // 电子协议异步通知地址
            // extendInfoMap.Add("agreement_async_return_url", "");
            // 异步请求地址
            // extendInfoMap.Add("async_return_url", "");
            // 业务开通结果异步消息接收地址
            // extendInfoMap.Add("busi_async_return_url", "");
            // 扩展资料包
            // extendInfoMap.Add("extended_material_list", getE932a627C70c4eacAe676058420b597b());
            return extendInfoMap;
        }

        private static string getCaa0c059Bc8544639eabA1cbfb39c354() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行账户名
            obj.Add("card_name", "圆务铁白事");
            // 银行账号
            obj.Add("card_no", "6222021287358404424");
            // 银行所在市
            obj.Add("area_id", "310100");
            // 银行编码
            obj.Add("bank_code", "01050000");
            // 联行号
            obj.Add("branch_code", "105290071050");
            // 银行所在省
            obj.Add("prov_id", "310000");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get990b98a297e44a189e1aF069844dc589() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 取现手续费（固定/元）fix_amt与fee_rate至少填写一项， 需保留小数点后两位，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;注：当cash_type&#x3D;D1时为节假日取现手续费；当cash_type&#x3D;T1时为工作日取现手续费
            // obj.Add("fix_amt", "test");
            // 取现手续费率（%）fix_amt与fee_rate至少填写一项，需保留小数点后两位，取值范围[0.00,100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;注：1、如果fix_amt与fee_rate都填写了则手续费&#x3D;fix_amt+支付金额\*fee_rate2、当cash_type&#x3D;D1时为节假日取现手续费；当cash_type&#x3D;T1时为工作日取现手续费
            // obj.Add("fee_rate", "test");
            // D1工作日取现手续费固定金额单位元，需保留小数点后两位。不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;cash_type&#x3D;T1时，不生效 ；cash_type取现类型为D1时，遇工作日按此费率结算，若未配置则默认按照节假日手续费计算
            // obj.Add("weekday_fix_amt", "test");
            // D1工作日取现手续费率单位%，需保留小数点后两位。取值范围[0.00，100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;cash_type&#x3D;T1时，不生效 ；cash_type取现类型为D1时，遇工作日按此费率结算 ，若未配置则默认按照节假日手续费计算
            // obj.Add("weekday_fee_rate", "test");
            // 手续费承担方手续费外扣时必需指定手续费承担方ID ；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
            // obj.Add("out_fee_huifu_id", "test");
            // 取现类型
            // obj.Add("cash_type", "");
            // 是否取现手续费外扣
            // obj.Add("out_fee_flag", "");
            // 手续费外扣的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 是否优先到账
            // obj.Add("is_priority_receipt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object getE76fe6ae64054e81AcacBde2a5371a92() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
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
        private static string getB721f3523cb14df09177415a293eb494() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 大额支付配置列表
            // obj.Add("large_amt_pay_config_info_list", getE76fe6ae64054e81AcacBde2a5371a92());
            // 交易手续费外扣huifuId交易手续费外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000108854952&lt;/font&gt;
            // obj.Add("out_fee_huifu_id", "test");
            // 交易手续费外扣账户号交易手续费外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：F00598602&lt;/font&gt;
            // obj.Add("out_fee_acct_id", "test");
            // 交易手续费外扣标记
            // obj.Add("out_fee_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getFb310e7292804509Ba9e019648efe90c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行编码
            // obj.Add("bank_id", "test");
            // 功能开关状态
            // obj.Add("stat_flag", "test");
            // 借贷标志
            // obj.Add("dc_flag", "test");
            // 银行名称
            // obj.Add("bank_name", "");
            // 银行中文简称
            // obj.Add("bank_short_chn", "");
            // 手续费（固定/元）
            // obj.Add("fix_amt", "");
            // 费率（%）
            // obj.Add("fee_rate", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get20b809b62f9f4239A59fE5b8fcd2d44d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            // obj.Add("pay_type", "");
            // 手续费外扣时的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 手续费外扣汇付ID
            // obj.Add("out_fee_huifuid", "");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getAa3c46b582694c21A5a82f4e29d46802() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "test");
            // 手续费(%)
            // obj.Add("fee_rate", "");
            // 手续费（固定/元）
            // obj.Add("fix_amt", "");
            // 外扣规则
            // obj.Add("out_charge_mode", "");
            // 手续费外扣时的账户ID
            // obj.Add("out_fee_acct_id", "");
            // 手续费外扣汇付ID
            // obj.Add("out_fee_huifu_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get22486c6a11674ab78c2898a036901bf9() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 签约人类型
            // obj.Add("type", "test");
            // 姓名签约人类型&#x3D;联系人（经办人），必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：张三&lt;/font&gt;
            // obj.Add("name", "test");
            // 身份证签约人类型&#x3D;联系人（经办人），必填 ；注意：**签约人会做姓名+身份证+手机号验证，请正确填写**；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：320946195712025082&lt;/font&gt;
            // obj.Add("cert_no", "test");
            // 手机号签约人类型&#x3D;法人 ，必填；注意：**签约人会做姓名+身份证+手机号验证，请正确填写**；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：13917463536&lt;/font&gt;
            // obj.Add("mobile_no", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getE932a627C70c4eacAe676058420b597b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件id
            // obj.Add("file_id", "test");
            // 文件类型
            // obj.Add("file_type", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
