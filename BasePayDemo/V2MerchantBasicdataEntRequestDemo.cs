using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 企业商户基本信息入驻 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBasicdataEntRequestDemo
    {

        public static void V2MerchantBasicdataEntRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBasicdataEntRequest request = new V2MerchantBasicdataEntRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 上级主体ID
            request.setUpperHuifuId("6666000003080000");
            // 商户名称
            request.setRegName("集成企业商户8664");
            // 商户简称
            request.setShortName("企业商户3471");
            // 公司类型
            request.setEntType("1");
            // 营业执照编号
            request.setLicenseCode("20220422267883697");
            // 营业执照有效期类型
            request.setLicenseValidityType("1");
            // 营业执照有效期开始日期
            request.setLicenseBeginDate("20200401");
            // 营业执照有效期截止日期日期格式：yyyyMMdd，以北京时间为准。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;  当license_validity_type&#x3D;0时必填  ;当license_validity_type&#x3D;1时为空；当使用总部资质时不填
            request.setLicenseEndDate("");
            // 注册省
            request.setRegProvId("350000");
            // 注册市
            request.setRegAreaId("350200");
            // 注册区
            request.setRegDistrictId("350203");
            // 注册详细地址
            request.setRegDetail("吉林省长春市思明区解放2路59096852");
            // 法人姓名
            request.setLegalName("陈立健");
            // 法人证件类型
            request.setLegalCertType("00");
            // 法人证件号码
            request.setLegalCertNo("321084198912060000");
            // 法人证件有效期类型
            request.setLegalCertValidityType("1");
            // 法人证件有效期开始日期
            request.setLegalCertBeginDate("20121201");
            // 法人证件有效期截止日期日期格式：yyyyMMdd，以北京时间为准。  &lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;当legal_cert_validity_type&#x3D;0时必填 ；当legal_cert_validity_type&#x3D;1时为空 ；当使用总部资质时不填
            request.setLegalCertEndDate("20301201");
            // 经营省
            request.setProvId("310000");
            // 经营市
            request.setAreaId("310100");
            // 经营区
            request.setDistrictId("310104");
            // 经营详细地址
            request.setDetailAddr("吉林省长春市思明区解放1路49227677");
            // 联系人姓名
            request.setContactName("联系人");
            // 联系人手机号
            request.setContactMobileNo("13111112222");
            // 联系人电子邮箱
            request.setContactEmail("jeff.peng@huifu.com");
            // 客服电话
            request.setServicePhone("021-121111221");
            // 经营类型
            request.setBusiType("1");
            // 小票名称
            request.setReceiptName("盈盈超市");
            // 所属行业
            request.setMcc("5411");
            // 结算卡信息配置
            request.setCardInfo(getCardInfo());
            // 基本存款账户编号或核准号基本存款账户信息请填写基本存款账户编号；开户许可证请填写核准号 ；&lt;br/&gt;当注册地址或经营地址为如下地区时必填：浙江,海南,重庆,河南,江苏,宁波市,黑龙江,吉林,湖南,贵州,陕西,湖北 &lt;br/&gt;当使用总部资质时不填 ；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：J2900123456789&lt;/font&gt;
            request.setOpenLicenceNo("");
            // 总部汇付Id如果headOfficeFlag&#x3D;0，useHeadInfoFlag&#x3D;Y,且head_huifu_id不为空则基本信息部分复用总部的基本信息。&lt;br/&gt;如果head_office_flag&#x3D;0，则字段必填,如果head_office_flag&#x3D;1，总部汇付Id不可传&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
            // request.setHeadHuifuId("test");

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
            // 营业执照类型
            extendInfoMap.Add("license_type", "");
            // 商户短信通知标识
            extendInfoMap.Add("sms_send_flag", "Y");
            // 管理员账号
            extendInfoMap.Add("login_name", "LG20220422267883697");
            // 取现信息配置
            extendInfoMap.Add("cash_config", getCashConfig());
            // 结算规则配置
            extendInfoMap.Add("settle_config", getSettleConfig());
            // 异步请求地址
            extendInfoMap.Add("async_return_url", "virgo://http://192.168.85.157:30031/sspm/testVirgo");
            // D1结算协议
            extendInfoMap.Add("settle_agree_pic", "");
            // 商户英文名称
            extendInfoMap.Add("mer_en_name", "");
            // 商户主页URL
            extendInfoMap.Add("mer_url", "");
            // 商户ICP备案编号
            extendInfoMap.Add("mer_icp", "");
            // 签约人
            // extendInfoMap.Add("sign_user_info", getSignUserInfo());
            // 是否总部商户
            // extendInfoMap.Add("head_office_flag", "");
            // 使用总部资料
            // extendInfoMap.Add("use_head_info_flag", "");
            // 开户许可证
            // extendInfoMap.Add("reg_acct_pic", "");
            // 结算卡反面
            // extendInfoMap.Add("settle_card_back_pic", "");
            // 结算卡正面
            // extendInfoMap.Add("settle_card_front_pic", "");
            // 结算人身份证反面
            // extendInfoMap.Add("settle_cert_back_pic", "");
            // 结算人身份证正面
            // extendInfoMap.Add("settle_cert_front_pic", "");
            // 税务登记证
            // extendInfoMap.Add("tax_reg_pic", "");
            // 法人身份证反面
            // extendInfoMap.Add("legal_cert_back_pic", "");
            // 法人身份证正面
            // extendInfoMap.Add("legal_cert_front_pic", "");
            // 营业执照图片
            // extendInfoMap.Add("license_pic", "");
            // 授权委托书
            // extendInfoMap.Add("auth_enturst_pic", "");
            // 组织机构代码证
            // extendInfoMap.Add("org_code_pic", "");
            return extendInfoMap;
        }

        private static string getSettleConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算周期
            obj.Add("settle_cycle", "D1");
            // 结算手续费外扣商户号填写承担手续费的汇付商户号；当out_settle_flag&#x3D;1时必填，否则非必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
            obj.Add("out_settle_huifuid", "");
            // 起结金额
            obj.Add("min_amt", "1.00");
            // 留存金额
            obj.Add("remained_amt", "2.00");
            // 结算摘要
            obj.Add("settle_abstract", "abstract");
            // 手续费外扣标记
            obj.Add("out_settle_flag", "2");
            // 结算手续费外扣账户类型
            obj.Add("out_settle_acct_type", "");
            // 节假日结算手续费率（%）
            obj.Add("fixed_ratio", "5.00");
            // 结算方式
            obj.Add("settle_pattern", "");
            // 结算批次号
            obj.Add("settle_batch_no", "");
            // 是否优先到账
            obj.Add("is_priority_receipt", "");
            // 自定义结算处理时间
            obj.Add("settle_time", "");
            // 节假日结算手续费固定金额（元）
            // obj.Add("constant_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCardInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算账户类型
            obj.Add("card_type", "1");
            // 结算账户名
            obj.Add("card_name", "陈立健");
            // 结算账号
            obj.Add("card_no", "6225682141000000000");
            // 银行所在省
            obj.Add("prov_id", "310000");
            // 银行所在市
            obj.Add("area_id", "310100");
            // 银行编码参考： [银行编码](https://paas.huifu.com/partners/api/#/csfl/api_csfl_yhbm)；当card_type&#x3D;0时必填， 当card_type&#x3D;1或2时非必填 &lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01020000&lt;/font&gt;
            obj.Add("bank_code", "01030000");
            // 联行号参考：[银行支行编码](https://paas.huifu.com/partners/api/#/csfl/api_csfl_yhzhbm) 当card_type&#x3D;0时必填， 当card_type&#x3D;1或2时非必填 &lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：102290026507&lt;/font&gt;
            obj.Add("branch_code", "103290040169");
            // 支行名称开户支行名称。 当card_type&#x3D;0时必填， 当card_type&#x3D;1或2时非必填； &lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：中国工商银行上海市中山北路支行&lt;/font&gt;
            obj.Add("branch_name", "中国农业银行股份有限公司上海马当路支行");
            // 持卡人证件类型持卡人证件类型，参见《[自然人证件类型](https://paas.huifu.com/partners/api/#/api_ggcsbm?id&#x3D;%e8%87%aa%e7%84%b6%e4%ba%ba%e8%af%81%e4%bb%b6%e7%b1%bb%e5%9e%8b)》。&lt;br/&gt; 当card_type&#x3D;0时为空， 当card_type&#x3D;1或2时必填； &lt;font color&#x3D;&quot;green&quot;&gt;示例值：00&lt;/font&gt;
            obj.Add("cert_type", "00");
            // 持卡人证件有效期截止日期日期格式：yyyyMMdd，以北京时间为准。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;  当cert_validity_type&#x3D;0时必填；当cert_validity_type&#x3D;1时为空
            obj.Add("cert_end_date", "20301201");
            // 持卡人证件号码
            obj.Add("cert_no", "321084198912066512");
            // 持卡人证件有效期类型
            obj.Add("cert_validity_type", "1");
            // 持卡人证件有效期开始日期
            obj.Add("cert_begin_date", "20121201");
            // 银行卡绑定手机号
            obj.Add("mp", "13700000214");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getSignUserInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 签约人类型
            // obj.Add("type", "test");
            // 姓名
            // obj.Add("name", "");
            // 手机号
            // obj.Add("mobile_no", "");
            // 身份证
            // obj.Add("cert_no", "");
            // 身份证照片-人像面
            // obj.Add("identity_front_file_id", "");
            // 身份证照片-国徽面
            // obj.Add("identity_back_file_id", "");
            // 法人授权书
            // obj.Add("auth_file_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCashConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 取现固定手续费（元）fix_amt与fee_rate至少填写一项，单位元，需保留小数点后两位，不收费请填写0.00； &lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;
            obj.Add("fix_amt", "1.00");
            // 取现手续费率（%）fix_amt与fee_rate至少填写一项，单位%，需保留小数点后两位，取值范围[0.00,100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;&lt;br/&gt;注：如果fix_amt与fee_rate都填写了则手续费&#x3D;fix_amt+支付金额*fee_rate
            obj.Add("fee_rate", "");
            // 取现类型
            obj.Add("cash_type", "D0");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");
            // 手续费承担方
            // obj.Add("out_fee_huifu_id", "");
            // 交易手续费外扣的账户类型
            // obj.Add("out_fee_acct_type", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
