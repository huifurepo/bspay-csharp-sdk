using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 个人商户基本信息入驻(2022) - 示例
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
            // 上级主体ID
            request.setUpperHuifuId("6666000107803321");
            // 商户名
            request.setRegName("张天德");
            // 经营省
            request.setProvId("310000");
            // 经营市
            request.setAreaId("310100");
            // 经营区
            request.setDistrictId("310105");
            // 经营详细地址
            request.setDetailAddr("上海市长宁区定西路1310号");
            // 联系人姓名
            request.setContactName("张天德");
            // 联系人手机号
            request.setContactMobileNo("13111112222");
            // 联系人电子邮箱
            request.setContactEmail("jeff.peng@huifu.com");
            // 结算卡信息配置
            request.setCardInfo(getCardInfo());

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
            // 商户通知标识
            extendInfoMap.Add("sms_send_flag", "1");
            // 管理员账号
            extendInfoMap.Add("login_name", "tinysword0116");
            // 取现信息配置
            extendInfoMap.Add("cash_config", getCashConfig());
            // 结算规则配置
            extendInfoMap.Add("settle_config", getSettleConfig());
            // 异步通知地址
            extendInfoMap.Add("async_return_url", "http://192.168.85.157:30031/sspm/testVirgo");
            // D1结算协议图片文件
            extendInfoMap.Add("settle_agree_pic", "119bc780-b1c5-3a9c-8b18-f911de6ff28c");
            // 商户主页URL
            // extendInfoMap.Add("mer_url", "");
            // 商户ICP备案编号
            // extendInfoMap.Add("mer_icp", "");
            // 结算卡反面
            // extendInfoMap.Add("settle_card_back_pic", "");
            // 结算卡正面
            // extendInfoMap.Add("settle_card_front_pic", "");
            // 法人身份证反面
            // extendInfoMap.Add("legal_cert_back_pic", "");
            // 法人身份证正面
            // extendInfoMap.Add("legal_cert_front_pic", "");
            // 授权委托书
            // extendInfoMap.Add("auth_enturst_pic", "");
            return extendInfoMap;
        }

        private static string getCardInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡户名
            obj.Add("card_name", "张天德");
            // 结算账号
            obj.Add("card_no", "4367421217494235081");
            // 银行所在省
            obj.Add("prov_id", "310000");
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
            // 结算人手机号
            obj.Add("mp", "13700000214");
            // 银行编号
            obj.Add("bank_code", "01030000");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCashConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 取现类型
            obj.Add("cash_type", "D1");
            // 取现固定手续费（元）fix_amt与fee_rate至少填写一项，单位元，需保留小数点后两位，不收费请填写0.00； &lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;
            obj.Add("fix_amt", "1.00");
            // 取现手续费率（%）fix_amt与fee_rate至少填写一项，单位%，需保留小数点后两位，取值范围[0.00,100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;&lt;br/&gt;注：如果fix_amt与fee_rate都填写了则手续费&#x3D;fix_amt+支付金额\*fee_rate
            obj.Add("fee_rate", "");
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
        private static string getSettleConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算周期
            obj.Add("settle_cycle", "D1");
            // 结算手续费外扣商户号结算手续费外扣商户号，填写承担手续费的汇付商户号&lt;br/&gt;当out_settle_flag&#x3D;1时必填，否则非必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
            obj.Add("out_settle_huifuid", "");
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
            // 节假日结算手续费率（%）
            obj.Add("fixed_ratio", "5.00");
            // 结算方式
            // obj.Add("settle_pattern", "");
            // 结算批次号
            // obj.Add("settle_batch_no", "");
            // 是否优先到账
            // obj.Add("is_priority_receipt", "");
            // 自定义结算处理时间
            // obj.Add("settle_time", "");
            // 节假日结算手续费固定金额（元）
            // obj.Add("constant_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
