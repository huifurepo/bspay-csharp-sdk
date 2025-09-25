using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 灵工个人用户进件 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2FlexibleIndvRequestDemo
    {

        public static void V2FlexibleIndvRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2FlexibleIndvRequest request = new V2FlexibleIndvRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 渠道商/商户汇付Id
            request.setUpperHuifuId("6666000108900391");
            // 基本信息
            request.setBasicInfo(get629fab27E82346a2860242a3c0b0d61a());
            // 卡信息
            request.setCardInfo(get30ec05a8D26c45c39e9aA02b3b1711b6());

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
            // 取现配置列表
            extendInfoMap.Add("cash_config", get2367ebbb376546c292f24ed51433e1fe());
            return extendInfoMap;
        }

        private static string get629fab27E82346a2860242a3c0b0d61a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 个人姓名
            obj.Add("name", "张三");
            // 个人身份证号码
            obj.Add("cert_no", "513701195007166573");
            // 个人证件有效期类型
            obj.Add("cert_validity_type", "0");
            // 个人证件有效期开始日期
            obj.Add("cert_begin_date", "20120101");
            // 手机号
            obj.Add("mobile_no", "13917354627");
            // 个人证件有效期截止日期
            obj.Add("cert_end_date", "20320101");
            // 电子邮箱
            obj.Add("email", "");
            // 管理员账号
            obj.Add("login_name", "LG20250619148194131");
            // 是否发送短信标识
            obj.Add("sms_send_flag", "");
            // 拓展方字段
            obj.Add("expand_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get2367ebbb376546c292f24ed51433e1fe() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 提现手续费（固定/元）fix_amt与fee_rate至少填写一项， 需保留小数点后两位，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;注：当cash_type&#x3D;D1时为节假日取现手续费
            obj.Add("fix_amt", "");
            // 提现手续费率（%）fix_amt与fee_rate至少填写一项，需保留小数点后两位，取值范围[0.00,100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;注：1、如果fix_amt与fee_rate都填写了则手续费&#x3D;fix_amt+支付金额\*fee_rate2、当cash_type&#x3D;D1时为节假日取现手续费
            obj.Add("fee_rate", "10.00");
            // D1工作日取现手续费固定金额单位元，需保留小数点后两位。不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;D1取现配置时选填，其他取现配置无效；cash_type取现类型为D1时，遇工作日按此费率结算，若未配置则默认按照节假日手续费计算
            obj.Add("weekday_fix_amt", "");
            // D1工作日取现手续费率单位%，需保留小数点后两位。取值范围[0.00，100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;D1取现配置时选填，其他取现配置无效；cash_type取现类型为D1时，遇工作日按此费率结算 ，若未配置则默认按照节假日手续费计算
            obj.Add("weekday_fee_rate", "");
            // 业务类型
            obj.Add("cash_type", "D1");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "");
            // 手续费承担方
            obj.Add("out_fee_huifu_id", "");
            // 交易手续费外扣的账户类型
            obj.Add("out_fee_acct_type", "");
            // 是否优先到账
            obj.Add("is_priority_receipt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get30ec05a8D26c45c39e9aA02b3b1711b6() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡号
            obj.Add("card_no", "6217001210064762890");
            // 银行所在省
            obj.Add("prov_id", "510000");
            // 银行所在市
            obj.Add("area_id", "510100");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
