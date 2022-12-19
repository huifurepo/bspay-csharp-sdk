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
            extendInfoMap.Add("bank_fq_list", getBankFqList());
            // 花呗分期费率
            extendInfoMap.Add("hb_fq_fee_list", getHbFqFeeList());
            return extendInfoMap;
        }

        private static string getHbFqFeeList() {
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

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static object getBankFqFeeList() {
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
        private static string getBankFqList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银联入网模式
            obj.Add("ent_way", "1");
            // 商户汇付Id
            obj.Add("huifu_id", "6666000003156435");
            // 银行卡分期状态
            obj.Add("bank_card_fq_status", "1");
            // 银行卡分期费率
            obj.Add("bank_fq_fee_list", getBankFqFeeList());
            // 贴息模式
            obj.Add("fee_model", "1");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
