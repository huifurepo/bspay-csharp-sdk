using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 个人商户进件 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBasicdataIndvRequestDemo
    {

        public static void V2MerchantBasicdataIndvRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBasicdataIndvRequest request = new V2MerchantBasicdataIndvRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 直属渠道号
            request.setUpperHuifuId("6666000107803321");
            // 商户名
            request.setRegName("张天德");
            // *所属行业*
            // request.setMcc("test");
            // *场景类型*
            // request.setSceneType("test");
            // 经营区
            request.setDistrictId("310105");
            // 经营详细地址scene_type字段含有线下场景时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：上海市徐汇区XX路XX号&lt;/font&gt;
            request.setDetailAddr("上海市长宁区定西路1310号");
            // *负责人证件号码*
            // request.setLegalCertNo("test");
            // *负责人证件有效期开始日期*
            // request.setLegalCertBeginDate("test");
            // *负责人证件有效期截止日期*
            // request.setLegalCertEndDate("test");
            // *负责人身份证地址*
            // request.setLegalAddr("test");
            // 负责人身份证国徽面
            // request.setLegalCertBackPic("test");
            // 负责人身份证人像面
            // request.setLegalCertFrontPic("test");
            // 负责人手机号
            request.setContactMobileNo("13111112222");
            // 负责人电子邮箱
            request.setContactEmail("jeff.peng@huifu.com");
            // 结算卡信息配置
            request.setCardInfo(get2163a263E1b544e9992243a235819818());
            // 结算卡正面
            // request.setSettleCardFrontPic("test");
            // *商户ICP备案编号*商户ICP备案编号或网站许可证号；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：沪ICP备06046402号-28 &lt;/font&gt;&lt;br/&gt;类型为PC网站时，且为企业商户，且开通快捷或网银，或大额转账，或余额支付或分账业务（20%（不含）-100%），或为个人商户开通分账业务（10%（不含）-100%），必填
            // request.setMerIcp("test");
            // 店铺门头照文件类型：F22；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;&lt;br/&gt;微信/支付宝实名认证个人商户，门头照也使用此字段； &lt;br/&gt;门店场所：提交门店门口照片，要求招牌清晰可见; &lt;br/&gt;小微商户流动经营/便民服务：提交经营/服务现场照片
            // request.setStoreHeaderPic("test");
            // 店铺内景/工作区域照文件类型：F24；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;&lt;br/&gt;微信/支付宝实名认证个人商户，内景照也使用此字段； &lt;br/&gt;门店场所：提交店内环境照片 &lt;br/&gt;小微商户流动经营/便民服务：可提交另一张经营/服务现场照片
            // request.setStoreIndoorPic("test");
            // 店铺收银台/公司前台照商户线下场景需要提供；文件类型：F105；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setStoreCashierDeskPic("test");
            // 上级商户汇付ID如果head_office_flag&#x3D;0，则字段必填&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
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
            // 商户简称
            extendInfoMap.Add("short_name", "张天德");
            // 经营省
            extendInfoMap.Add("prov_id", "310000");
            // 经营市
            extendInfoMap.Add("area_id", "310100");
            // 负责人证件有效期类型
            // extendInfoMap.Add("legal_cert_validity_type", "");
            // *负责人职业*
            // extendInfoMap.Add("occupation", "");
            // 结算规则配置
            extendInfoMap.Add("settle_config", get26bc42ac4cad449fA6f73a71584d36e8());
            // 取现信息配置
            extendInfoMap.Add("cash_config", getF162193a75514a13B8a4257f71670e9f());
            // 商户通知标识
            extendInfoMap.Add("sms_send_flag", "1");
            // 管理员账号
            extendInfoMap.Add("login_name", "tinysword0116");
            // 商户主页URL
            // extendInfoMap.Add("mer_url", "");
            // 外部商户号
            // extendInfoMap.Add("ext_mer_id", "");
            // 备注
            // extendInfoMap.Add("remarks", "");
            // 异步通知地址
            extendInfoMap.Add("async_return_url", "http://192.168.85.157:30031/sspm/testVirgo");
            // 商户身份
            // extendInfoMap.Add("head_office_flag", "");
            // 斗拱e账户功能配置
            // extendInfoMap.Add("elec_acct_config", getE858fe262ee542b7B05b1061a6f8dc05());
            // 扩展资料包
            // extendInfoMap.Add("extended_material_list", getF61572bdAc9a460fBada227b2cec7f05());
            return extendInfoMap;
        }

        private static string get2163a263E1b544e9992243a235819818() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡户名
            obj.Add("card_name", "张天德");
            // 结算账号
            obj.Add("card_no", "4367421217494235081");
            // 银行所在市
            obj.Add("area_id", "310100");
            // 持卡人证件类型
            obj.Add("cert_type", "00");
            // 持卡人证件号码
            obj.Add("cert_no", "321084198912066512");
            // 持卡人证件有效期类型
            obj.Add("cert_validity_type", "0");
            // 持卡人证件有效期开始
            obj.Add("cert_begin_date", "20180824");
            // 持卡人证件有效期截止日期格式yyyyMMdd，以北京时间为准。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;&lt;br/&gt;当cert_validity_type&#x3D;0时必填  &lt;br/&gt;当cert_validity_type&#x3D;1时为空
            obj.Add("cert_end_date", "20380824");
            // 银行所在省
            obj.Add("prov_id", "310000");
            // 银行编号
            obj.Add("bank_code", "01030000");
            // 结算人手机号
            obj.Add("mp", "13700000214");
            // 默认结算卡标志
            // obj.Add("is_settle_default", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get26bc42ac4cad449fA6f73a71584d36e8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算周期
            obj.Add("settle_cycle", "D1");
            // 结算手续费外扣商户号结算手续费外扣商户号，填写承担手续费的汇付商户号&lt;br/&gt;当out_settle_flag&#x3D;1时必填，否则非必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
            obj.Add("out_settle_huifuid", "");
            // 结算批次号settle_cycle为TS时不填。结算方式为P0：批次结算时必填，即将按指定结算批次号进行资金结算；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：100&lt;/font&gt;；[参见结算批次说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_jspc)
            // obj.Add("settle_batch_no", "test");
            // 自定义结算处理时间settle_cycle为TS时不填。当settle_pattern&#x3D;P1/P2自定义时间结算时必填；注意：00:00到00:30不能指定；&lt;br/&gt;到账时间，格式：HHmmss；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：103000&lt;/font&gt;
            // obj.Add("settle_time", "test");
            // 节假日结算手续费率settle_cycle为D1、TS时必填。单位%，需保留小数点后两位。取值范围[0.00，100.00]，不收费请填写0.00；settle_cycle&#x3D;T1时，不生效 ；settle_cycle为D1时，遇节假日按此费率结算 ；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;
            obj.Add("fixed_ratio", "5.00");
            // 节假日结算手续费固定金额settle_cycle为D1、TS时必填。单位元，需保留小数点后两位。不收费请填写0.00；settle_cycle结算周期为D1时，遇节假日按此费率结算 ；&lt;br/&gt; &lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;
            // obj.Add("constant_amt", "test");
            // 起结金额
            obj.Add("min_amt", "1.00");
            // 留存金额
            obj.Add("remained_amt", "2.00");
            // 结算摘要
            obj.Add("settle_abstract", "我这里显示结算摘要");
            // 手续费外扣标记
            obj.Add("out_settle_flag", "2");
            // 结算手续费外扣账户类型
            // obj.Add("out_settle_acct_type", "");
            // 结算方式
            // obj.Add("settle_pattern", "");
            // 是否优先到账
            // obj.Add("is_priority_receipt", "");
            // 工作日结算手续费率
            // obj.Add("workday_fixed_ratio", "");
            // 工作日结算手续费固定金额
            // obj.Add("workday_constant_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getF162193a75514a13B8a4257f71670e9f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 取现类型
            obj.Add("cash_type", "D1");
            // 提现手续费（固定/元）fix_amt与fee_rate至少填写一项， 需保留小数点后两位，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;注：当cash_type&#x3D;D1时为节假日取现手续费
            obj.Add("fix_amt", "1.00");
            // 提现手续费率（%）fix_amt与fee_rate至少填写一项，需保留小数点后两位，取值范围[0.00,100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;注：1、如果fix_amt与fee_rate都填写了则手续费&#x3D;fix_amt+支付金额\*fee_rate2、当cash_type&#x3D;D1时为节假日取现手续费
            obj.Add("fee_rate", "");
            // D1工作日取现手续费固定金额单位元，需保留小数点后两位。不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;cash_type&#x3D;D1时，不生效 ；cash_type取现类型为D1时，遇工作日按此费率结算，若未配置则默认按照节假日手续费计算
            // obj.Add("weekday_fix_amt", "test");
            // D1工作日取现手续费率单位%，需保留小数点后两位。取值范围[0.00，100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;cash_type&#x3D;D1时，不生效 ；cash_type取现类型为D1时，遇工作日按此费率结算 ，若未配置则默认按照节假日手续费计算
            // obj.Add("weekday_fee_rate", "test");
            // 手续费承担方手续费外扣时必需指定手续费承担方ID； &lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
            // obj.Add("out_fee_huifu_id", "test");
            // 是否交易手续费外扣
            // obj.Add("out_fee_flag", "");
            // 交易手续费外扣的账户类型
            // obj.Add("out_fee_acct_type", "");
            // 是否优先到账
            // obj.Add("is_priority_receipt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object getDf5cd65fFcb845edAd2353121e8002df() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行编码
            // obj.Add("bank_code", "test");
            // 支行联行号
            // obj.Add("branch_code", "test");
            // 支行名称
            // obj.Add("branch_name", "test");
            // 结算账户名
            // obj.Add("card_name", "test");
            // 银行卡号
            // obj.Add("card_no", "test");
            // 卡类型
            // obj.Add("card_type", "test");
            // 银行绑定手机号为空取联系人手机号，注意如果联系人非持卡人银行会报错；&lt;!--2024.5.19--&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值:13911111111&lt;/font&gt;
            // obj.Add("mp", "test");
            // 用户授权协议版本号该字段在绑定个人账户时必填，取值商户自定义。与个人用户签约的电子协议版本号，通过该版本号能够确定协议的具体内容
            // obj.Add("auth_version", "test");
            // 用户授权协议号该字段在绑定个人账户时必填，取值商户自定义。与个人用户签约的授权交易流水号，通过该流水号应能确定电子协议版本号、签约人、签约时间
            // obj.Add("auth_no", "test");
            // 银行所在省
            // obj.Add("prov_id", "");
            // 银行所在市
            // obj.Add("area_id", "");
            // 默认卡标识
            // obj.Add("default_cash_flag", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getE858fe262ee542b7B05b1061a6f8dc05() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 电子账户开关
            // obj.Add("switch_state", "test");
            // 账户类型
            // obj.Add("acct_type", "test");
            // 电子账户提现手续费承担方
            // obj.Add("cash_fee_party", "test");
            // 场景类型
            // obj.Add("scene", "test");
            // 角色类型
            // obj.Add("role_type", "test");
            // 银行卡信息
            // obj.Add("elec_card_list", getDf5cd65fFcb845edAd2353121e8002df());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getF61572bdAc9a460fBada227b2cec7f05() {
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
