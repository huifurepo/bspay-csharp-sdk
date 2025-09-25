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
            // 银行分期费率
            extendInfoMap.Add("bank_fq_list", get643b36117c8a4786966fB0bba6a939d1());
            // 花呗分期费率
            extendInfoMap.Add("hb_fq_fee_list", get308d245e0cd845bdBe54F6fdb52a9bfa());
            // 白条分期配置对象
            // extendInfoMap.Add("jdbt_data", get3a0128ff678c41dc9bb0484e3c3d7110());
            // 银联聚分期配置对象
            // extendInfoMap.Add("yljfq_data", get42fd748e9c1540e7892aAa585ec85814());
            return extendInfoMap;
        }

        private static object get8199f1ebA0bf4b6f94ff58fb9716e63e() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行编号
            obj.Add("bank_code", "01040000");
            // 银行名称
            obj.Add("bank_name", "");
            // 银联收单分期费率（%）
            obj.Add("bank_acq_period", "6");
            // 用户付息费率
            obj.Add("bank_fee_rate", "2");
            // 交易手续费外扣标记
            obj.Add("out_fee_flag", "");
            // 手续费外扣的汇付商户号
            obj.Add("out_fee_huifu_id", "");
            // 银联分期3期开关
            obj.Add("three_period_switch", "Y");
            // 银联分期3期总费率（%）
            obj.Add("three_period", "10");
            // 银联分期6期开关
            obj.Add("six_period_switch", "Y");
            // 银联分期6期总费率（%）
            obj.Add("six_period", "16");
            // 银联分期12期开关
            obj.Add("twelve_period_switch", "Y");
            // 银联分期12期总费率（%）
            obj.Add("twelve_period", "0.0001");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get643b36117c8a4786966fB0bba6a939d1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银联入网模式
            obj.Add("ent_way", "1");
            // 商户汇付Id
            obj.Add("huifu_id", "6666000003156435");
            // 银行卡分期状态
            obj.Add("bank_card_fq_status", "1");
            // 银行卡分期费率
            obj.Add("bank_fq_fee_list", get8199f1ebA0bf4b6f94ff58fb9716e63e());
            // 贴息模式
            obj.Add("fee_model", "1");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get308d245e0cd845bdBe54F6fdb52a9bfa() {
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
        private static object get277a665967d249959c6eC7bfdb32144f() {
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
        private static string get3a0128ff678c41dc9bb0484e3c3d7110() {
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
            // obj.Add("jdbt_fee_data", get277a665967d249959c6eC7bfdb32144f());
            // 签约人姓名
            // obj.Add("name", "");
            // 签约人身份证号
            // obj.Add("cert_no", "");
            // 协议类型
            // obj.Add("agreement_type", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get3b7f43d36bf34205B32098e783828107() {
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
        private static object get9ec9342cBaf5456998b43aa7dad82bea() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件id
            // obj.Add("file_id", "test");
            // 文件类型
            // obj.Add("file_type", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get42fd748e9c1540e7892aAa585ec85814() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户汇付Id
            // obj.Add("huifu_id", "test");
            // 签约人类型
            // obj.Add("sign_user_type", "test");
            // 签约人手机号
            // obj.Add("mobile_no", "test");
            // 银联聚分期费率数据
            // obj.Add("yljfq_fee_data", get3b7f43d36bf34205B32098e783828107());
            // 签约人姓名
            // obj.Add("name", "");
            // 签约人身份证号
            // obj.Add("cert_no", "");
            // 补充业务信息
            // obj.Add("file_list", get9ec9342cBaf5456998b43aa7dad82bea());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
