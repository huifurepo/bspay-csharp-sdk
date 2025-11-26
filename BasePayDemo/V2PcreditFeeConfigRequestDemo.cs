using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户分期配置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2PcreditFeeConfigRequestDemo
    {

        public static void V2PcreditFeeConfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2PcreditFeeConfigRequest request = new V2PcreditFeeConfigRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));

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
            // 异步通知地址
            extendInfoMap.Add("async_return_url", "http://192.168.85.157:30031/sspm/testVirgo");
            // 花呗分期费率
            extendInfoMap.Add("hb_fq_fee_list", get33058a553e95455aA0255248d770c221());
            // 白条分期配置对象
            // extendInfoMap.Add("jdbt_data", get5c64baa01d644dac8995286b4cffca1b());
            // 银联聚分期配置对象
            // extendInfoMap.Add("yljfq_data", getD940990307634ddcBaafDcdb0dd06c87());
            return extendInfoMap;
        }

        private static string get33058a553e95455aA0255248d770c221() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户汇付Id
            obj.Add("huifu_id", "6666000003156435");
            // 花呗分期状态
            // obj.Add("hb_fq_status", "");
            // 花呗分期3期开关
            obj.Add("hb_three_period_switch", "Y");
            // 花呗收单分期3期费率（%）
            obj.Add("hb_three_acq_period", "5");
            // 花呗分期3期利率（%）
            obj.Add("hb_three_period", "10");
            // 花呗分期6期开关
            obj.Add("hb_six_period_switch", "Y");
            // 花呗收单分期6期费率（%）
            obj.Add("hb_six_acq_period", "5");
            // 花呗分期6期利率（%）
            obj.Add("hb_six_period", "10");
            // 花呗分期12期开关
            obj.Add("hb_twelve_period_switch", "Y");
            // 花呗收单分期12期费率（%）
            obj.Add("hb_twelve_acq_period", "15");
            // 花呗分期12期利率（%）
            obj.Add("hb_twelve_period", "11");
            // 交易手续费外扣标记
            obj.Add("out_fee_flag", "");
            // 手续费外扣的汇付商户号
            obj.Add("out_fee_huifu_id", "");
            // 花呗分期24期开关
            // obj.Add("hb_twentyfour_period_switch", "");
            // 花呗收单分期24期费率（%）
            // obj.Add("hb_twentyfour_acq_period", "");
            // 花呗分期24期利率（%）
            // obj.Add("hb_twentyfour_period", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object get8e5138faDdb344b6805a94d933246d0d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            // obj.Add("pay_scene", "test");
            // 业务开通标识
            // obj.Add("open_flag", "test");
            // 手续费率(%)
            // obj.Add("fee_rate", "");
            // 手续费扣取方式
            // obj.Add("fee_rec_type", "");
            // 交易手续费扣款标记
            // obj.Add("fee_flag", "");
            // 手续费外扣的汇付商户号
            // obj.Add("out_fee_huifu_id", "");
            // 手续费外扣的汇付账户号
            // obj.Add("out_fee_acct_id", "");
            // 斗拱终端付息方式
            // obj.Add("discount_model", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get5c64baa01d644dac8995286b4cffca1b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户汇付Id
            // obj.Add("huifu_id", "test");
            // 签约人类型
            // obj.Add("sign_user_type", "test");
            // 签约人手机号
            // obj.Add("mobile_no", "test");
            // 挂网协议地址3-挂网协议必填；示例值：https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/dg_gwxy/PaymentServiceAgreement_xxxx.html
            // obj.Add("agreement_url", "test");
            // 京东白条费率数据
            // obj.Add("jdbt_fee_data", get8e5138faDdb344b6805a94d933246d0d());
            // 签约人姓名
            // obj.Add("name", "");
            // 签约人身份证号
            // obj.Add("cert_no", "");
            // 协议类型
            // obj.Add("agreement_type", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get582500aeD6b3421eAfa3Aacb46bbc89c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付场景
            // obj.Add("pay_scene", "test");
            // 业务开通标识
            // obj.Add("open_flag", "test");
            // 贴息模式
            // obj.Add("discount_model", "");
            // 手续费率(%)
            // obj.Add("fee_rate", "");
            // 手续费扣取方式
            // obj.Add("fee_rec_type", "");
            // 交易手续费扣款标记
            // obj.Add("fee_flag", "");
            // 手续费外扣的汇付商户号
            // obj.Add("out_fee_huifu_id", "");
            // 手续费外扣的汇付账户号
            // obj.Add("out_fee_acct_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get5b3906c269e9412387cf7c5707a32c92() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件id
            // obj.Add("file_id", "test");
            // 文件类型
            // obj.Add("file_type", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getD940990307634ddcBaafDcdb0dd06c87() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户汇付Id
            // obj.Add("huifu_id", "test");
            // 签约人类型
            // obj.Add("sign_user_type", "test");
            // 签约人手机号
            // obj.Add("mobile_no", "test");
            // 银联聚分期费率数据
            // obj.Add("yljfq_fee_data", get582500aeD6b3421eAfa3Aacb46bbc89c());
            // 签约人姓名
            // obj.Add("name", "");
            // 签约人身份证号
            // obj.Add("cert_no", "");
            // 补充业务信息
            // obj.Add("file_list", get5b3906c269e9412387cf7c5707a32c92());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
