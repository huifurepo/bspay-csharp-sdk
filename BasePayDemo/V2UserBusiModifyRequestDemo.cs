using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 用户业务入驻修改 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBusiModifyRequestDemo
    {

        public static void V2UserBusiModifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2UserBusiModifyRequest request = new V2UserBusiModifyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 渠道商/商户汇付Id
            request.setUpperHuifuId("6666000104633228");
            // 汇付ID
            request.setHuifuId("6666000104896342");

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
            // 结算信息配置
            extendInfoMap.Add("settle_config", getSettleConfig());
            // 结算卡信息
            extendInfoMap.Add("card_info", getCardInfo());
            // 取现配置列表
            extendInfoMap.Add("cash_config", getCashConfig());
            // 文件列表
            extendInfoMap.Add("file_list", getFileList());
            // 延迟入账开关
            // extendInfoMap.Add("delay_flag", "");
            // 异步请求地址
            extendInfoMap.Add("async_return_url", "//http://service.example.com/to/path");
            // 斗拱e账户功能配置
            // extendInfoMap.Add("elec_acct_config", getElecAcctConfig());
            // 灵活用工开关
            // extendInfoMap.Add("open_tax_flag", "");
            return extendInfoMap;
        }

        private static string getSettleConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开通状态
            obj.Add("settle_status", "1");
            // 结算周期
            obj.Add("settle_cycle", "D1");
            // 结算批次号settle_pattern为P0时必填；[参见结算批次说明](https://paas.huifu.com/partners/api/#/csfl/api_csfl_jspc)
            obj.Add("settle_batch_no", "0");
            // 是否优先到账settle_pattern为P0时选填， Y：是 N：否（为空默认取值）；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：Y&lt;/font&gt;
            obj.Add("is_priority_receipt", "Y");
            // 自定义结算处理时间settle_pattern为P1时必填，注意：00:00到00:30不能指定；格式：HHmmss；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：103000&lt;/font&gt;
            obj.Add("settle_time", "");
            // 节假日结算手续费率settle_cycle为D1时必填。单位%，需保留小数点后两位。取值范围[0.00，100.00]，不收费请填写0.00；settle_cycle&#x3D;T1时，不生效 ；settle_cycle为D1时，遇节假日按此费率结算 ；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;
            obj.Add("fixed_ratio", "0.1");
            // 起结金额
            obj.Add("min_amt", "0.1");
            // 结算手续费外扣时的账户类型
            obj.Add("out_settle_acct_type", "05");
            // 手续费外扣标记
            obj.Add("out_settle_flag", "1");
            // 结算手续费外扣时的汇付ID
            obj.Add("out_settle_huifuid", "6666000104633228");
            // 留存金额
            obj.Add("remained_amt", "0.1");
            // 结算摘要
            obj.Add("settle_abstract", "吃吃");
            // 结算方式
            obj.Add("settle_pattern", "P0");
            // 工作日结算手续费率
            // obj.Add("workday_fixed_ratio", "");
            // 工作日结算手续费固定金额
            // obj.Add("workday_constant_amt", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCardInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡类型
            obj.Add("card_type", "0");
            // 卡户名
            obj.Add("card_name", "陈立一");
            // 卡号
            obj.Add("card_no", "6217001210064762000");
            // 银行所在省
            obj.Add("prov_id", "310000");
            // 银行所在市
            obj.Add("area_id", "310100");
            // 银行号当card_type&#x3D;0时必填，对私可以为空；[参见银行编码](https://paas.huifu.com/partners/api/#/csfl/api_csfl_yhbm)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01020000&lt;/font&gt;
            obj.Add("bank_code", "01050000");
            // 支行联行号当card_type&#x3D;0时必填，[点击查看](https://paas.huifu.com/partners/api/#/csfl/api_csfl_yhzhbm)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：102290026507&lt;/font&gt;
            obj.Add("branch_code", "105305264815");
            // 持卡人证件类型
            obj.Add("cert_type", "00");
            // 持卡人证件号码
            obj.Add("cert_no", "110101197003077000");
            // 持卡人证件有效期类型
            obj.Add("cert_validity_type", "0");
            // 持卡人证件有效期起始日期
            obj.Add("cert_begin_date", "20210806");
            // 持卡人证件有效期截止日期
            obj.Add("cert_end_date", "20410806");
            // 银行卡绑定手机号
            obj.Add("mp", "15556622000");
            // 默认结算卡标志
            // obj.Add("is_settle_default", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCashConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开通状态
            obj.Add("switch_state", "1");
            // 提现手续费（固定/元）fix_amt与fee_rate至少填写一项， 需保留小数点后两位，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;注：当cash_type&#x3D;D1时为节假日取现手续费
            obj.Add("fix_amt", "3");
            // 提现手续费率（%）fix_amt与fee_rate至少填写一项，需保留小数点后两位，取值范围[0.00,100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;注：1、如果fix_amt与fee_rate都填写了则手续费&#x3D;fix_amt+支付金额\*fee_rate2、当cash_type&#x3D;D1时为节假日取现手续费
            obj.Add("fee_rate", "0.05");
            // D1工作日取现手续费固定金额单位元，需保留小数点后两位。不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;cash_type&#x3D;D1时，不生效 ；cash_type取现类型为D1时，遇工作日按此费率结算，若未配置则默认按照节假日手续费计算
            // obj.Add("weekday_fix_amt", "test");
            // D1工作日取现手续费率单位%，需保留小数点后两位。取值范围[0.00，100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;cash_type&#x3D;D1时，不生效 ；cash_type取现类型为D1时，遇工作日按此费率结算 ，若未配置则默认按照节假日手续费计算
            // obj.Add("weekday_fee_rate", "test");
            // 业务类型
            obj.Add("cash_type", "D0");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");
            // 手续费承担方
            obj.Add("out_fee_huifu_id", "6666000104633228");
            // 交易手续费外扣的账户类型
            obj.Add("out_fee_acct_type", "05");
            // 是否优先到账
            // obj.Add("is_priority_receipt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getFileList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            obj.Add("file_type", "F02");
            // 文件jfileID
            obj.Add("file_id", "99e00421-dad7-3334-9538-4f2ad10612d5");
            // 文件名称
            obj.Add("file_name", "企业营业执照1.jpg");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getElecCardList() {
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
            // 银行所在省
            // obj.Add("prov_id", "");
            // 银行所在市
            // obj.Add("area_id", "");
            // 银行绑定手机号
            // obj.Add("mp", "");
            // 默认卡标识
            // obj.Add("default_cash_flag", "");
            // 用户授权协议版本号
            // obj.Add("auth_version", "");
            // 用户授权协议号
            // obj.Add("auth_no", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getElecAcctConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 电子账户开关
            // obj.Add("switch_state", "test");
            // 账户类型
            // obj.Add("acct_type", "test");
            // 电子账户提现手续费承担方
            // obj.Add("cash_fee_party", "test");
            // 场景
            // obj.Add("scence", "test");
            // 角色类型(角色编号)
            // obj.Add("role_type", "test");
            // 银行卡信息
            // obj.Add("**elec_card_list**", getElecCardList());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
