using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 灵工企业商户业务修改 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleEntModifyRequestDemo
    {

        public static void V2FlexibleEntModifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2FlexibleEntModifyRequest request = new V2FlexibleEntModifyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付id
            request.setHuifuId("6666000108903754");
            // 渠道商汇付ID
            request.setUpperHuifuId("6666000108329682");
            // 商户基本信息jsonObject格式；其中的contact_info和legal_info联系人和法人信息可能在卡信息修改时需要
            request.setBasicInfo(getAf9330e0B7264377B857891dc3eb74b3());
            // 签约人
            request.setSignUserInfo(getDe548fa487934ee186afEa5616d3ccec());

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
            // 卡信息配置实体
            // extendInfoMap.Add("card_info", getA2ffaf5c578d4b6bB755C3b8e7d5b8ad());
            // 取现配置列表
            extendInfoMap.Add("cash_config", getA24f3b43221241a093199927ac24f2c2());
            // 大额支付配置
            extendInfoMap.Add("large_amt_pay_config", get82e2c731C2f54b44B1d092c62832ed01());
            // 是否开通网银充值
            extendInfoMap.Add("online_recharge_flag", "Y");
            // 线上费率配置
            extendInfoMap.Add("online_fee_conf_list", get8ff6cf9e57f54a5a9483718f03c3f835());
            // 线上手续费承担方配置
            extendInfoMap.Add("online_pay_fee_conf_list", get1af27596Cf084258Bc586a3b7cb7c5b7());
            // 灵工支付配置
            // extendInfoMap.Add("flexible_pay_config", getE3a042a10b974c549f6c1d254f199c71());
            // 扩展资料包
            // extendInfoMap.Add("extended_material_list", getFc39cf6e632c458b923dFf4a8a8ca660());
            // 电子协议异步通知地址
            extendInfoMap.Add("agreement_async_return_url", "");
            // 异步请求地址
            extendInfoMap.Add("async_return_url", "");
            // 业务开通结果异步消息接收地址
            extendInfoMap.Add("busi_async_return_url", "");
            return extendInfoMap;
        }

        private static object get653797d254e64a5087bcB4b7943d72c5() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 营业执照类型
            obj.Add("license_type", "CERTIFICATE_TYPE_0001");
            // 营业执照编号
            // obj.Add("license_code", "test");
            // 营业执照有效期开始日期
            obj.Add("license_begin_date", "20210101");
            // 营业执照有效期截止日期
            obj.Add("license_end_date", "20410101");
            // 营业执照有效期类型
            obj.Add("license_validity_type", "0");
            // 注册省
            obj.Add("reg_prov_id", "340000");
            // 注册市
            obj.Add("reg_area_id", "340100");
            // 注册区
            obj.Add("reg_district_id", "340102");
            // 注册详细地址
            obj.Add("reg_detail", "瑶海区1号");
            // 证照图片
            obj.Add("license_pic", "67cce967-bd22-32b4-a250-58b82e78154a");

            return obj;
        }
        private static object get8c2a41ad32e54400Af7b162f388c2ad2() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 店铺门头照
            obj.Add("store_header_pic", "ececec87-e772-331a-b4fc-fae92732d992");
            // 经营简称
            obj.Add("short_name", "简称888");

            return obj;
        }
        private static object get26d8f85d50ab4f5aAcb66d645323ce74() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 法人姓名
            obj.Add("legal_name", "岑晓");
            // 法人证件类型
            obj.Add("legal_cert_type", "00");
            // 法人证件号码
            obj.Add("legal_cert_no", "513701199108105217");
            // 法人证件有效期类型
            obj.Add("legal_cert_validity_type", "");
            // 法人证件有效期开始日期
            obj.Add("legal_cert_begin_date", "");
            // 法人证件有效期截止日期
            obj.Add("legal_cert_end_date", "");
            // 法人手机号
            obj.Add("legal_mobile_no", "");
            // 法人证件地址
            obj.Add("legal_addr", "");
            // 法人身份证国徽面
            obj.Add("legal_cert_back_pic", "");
            // 法人身份证人像面
            obj.Add("legal_cert_front_pic", "");

            return obj;
        }
        private static object get95a38d50674543749f622f58fe3e01d3() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 联系人姓名
            obj.Add("contact_name", "岑晓");
            // 联系人手机号
            obj.Add("contact_mobile_no", "18777716992");
            // 联系人电子邮箱
            obj.Add("contact_email", "lianxi@huifu.com");

            return obj;
        }
        private static string getAf9330e0B7264377B857891dc3eb74b3() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 营业执照信息
            obj.Add("license_info", get653797d254e64a5087bcB4b7943d72c5());
            // 经营信息
            obj.Add("company_info", get8c2a41ad32e54400Af7b162f388c2ad2());
            // 法人信息
            obj.Add("legal_info", get26d8f85d50ab4f5aAcb66d645323ce74());
            // 联系人信息
            obj.Add("contact_info", get95a38d50674543749f622f58fe3e01d3());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getDe548fa487934ee186afEa5616d3ccec() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 签约人类型
            obj.Add("type", "CONTACT");
            // 姓名
            obj.Add("name", "施忠晶");
            // 手机号
            obj.Add("mobile_no", "13812345231");
            // 身份证
            obj.Add("cert_no", "513701201104022297");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getA2ffaf5c578d4b6bB755C3b8e7d5b8ad() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行账户名
            // obj.Add("card_name", "test");
            // 银行账号
            // obj.Add("card_no", "test");
            // 银行所在省
            // obj.Add("prov_id", "test");
            // 银行所在市
            // obj.Add("area_id", "test");
            // 银行编码
            // obj.Add("bank_code", "test");
            // 联行号
            // obj.Add("branch_code", "test");

            return obj;
        }
        private static object getA24f3b43221241a093199927ac24f2c2() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否开通取现
            obj.Add("switch_state", "");
            // 业务类型
            obj.Add("cash_type", "D1");
            // 提现手续费（固定/元）开通提现业务时fix_amt与fee_rate至少填写一项；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;
            obj.Add("fix_amt", "2");
            // D1工作日取现手续费固定金额单位元，需保留小数点后两位。不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;cash_type&#x3D;T1时，不生效 ；cash_type取现类型为D1时，遇工作日按此费率结算，若未配置则默认按照节假日手续费计算
            obj.Add("weekday_fix_amt", "2");
            // D1工作日取现手续费率单位%，需保留小数点后两位。取值范围[0.00，100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;cash_type&#x3D;T1时，不生效 ；cash_type取现类型为D1时，遇工作日按此费率结算 ，若未配置则默认按照节假日手续费计算
            obj.Add("weekday_fee_rate", "3");
            // 取现手续费率（%）
            obj.Add("fee_rate", "10.00");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");
            // 手续费承担方
            obj.Add("out_fee_huifu_id", "6666000108329682");
            // 手续费外扣的账户类型
            obj.Add("out_fee_acct_type", "01");
            // 是否优先到账
            obj.Add("is_priority_receipt", "Y");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object getCaa423dd4dbf41b0981a73e8906bd5d5() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 费率（%）开通大额业务时必须填写一种收费方式；大于0,保留2位小数；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;
            obj.Add("fee_rate", "4");
            // 交易手续费（固定/元）开通大额业务时必须填写一种收费方式；大于0,保留2位小数；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：10.00&lt;/font&gt;
            obj.Add("fee_fix_amt", "5");
            // 功能开关
            obj.Add("switch_state", "1");
            // 大额调账标识申请类型
            obj.Add("biz_type", "01");
            // 是否允许绑卡支付
            obj.Add("mer_same_card_recharge_flag", "Y");
            // 是否允许用户入账
            obj.Add("allow_user_deposit_flag", "N");
            // 备付金固定账号模式自动退款
            obj.Add("provisions_auto_refund_flag", "Y");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get82e2c731C2f54b44B1d092c62832ed01() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 大额支付配置列表
            obj.Add("large_amt_pay_config_info_list", getCaa423dd4dbf41b0981a73e8906bd5d5());
            // 交易手续费外扣huifuId交易手续费外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000108854952&lt;/font&gt;
            obj.Add("out_fee_huifu_id", "6666000108329682");
            // 交易手续费外扣账户号交易手续费外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：F00598602&lt;/font&gt;
            obj.Add("out_fee_acct_id", "C02714529");
            // 交易手续费外扣标记
            obj.Add("out_fee_flag", "1");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get8ff6cf9e57f54a5a9483718f03c3f835() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行编码
            obj.Add("bank_id", "01050000");
            // 功能开关状态
            obj.Add("stat_flag", "1");
            // 借贷标志
            obj.Add("dc_flag", "D");
            // 银行名称
            obj.Add("bank_name", "中国建设银行股份有限公司上海市中支行");
            // 银行中文简称
            obj.Add("bank_short_chn", "上海市中支行");
            // 手续费（固定/元）
            obj.Add("fix_amt", "6");
            // 费率（%）
            obj.Add("fee_rate", "6");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get1af27596Cf084258Bc586a3b7cb7c5b7() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 业务类型
            obj.Add("pay_type", "ONLINE_ENT_TOP_UP");
            // 手续费外扣时的账户类型
            obj.Add("out_fee_acct_type", "01");
            // 手续费外扣汇付ID
            obj.Add("out_fee_huifuid", "6666000108329682");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getE3a042a10b974c549f6c1d254f199c71() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "test");
            // 功能开关
            // obj.Add("switch_state", "");
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
        private static string getFc39cf6e632c458b923dFf4a8a8ca660() {
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
