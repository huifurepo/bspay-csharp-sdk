using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 申请开票 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2HycInvoiceApplyRequestDemo
    {

        public static void V2HycInvoiceApplyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2HycInvoiceApplyRequest request = new V2HycInvoiceApplyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付id
            request.setHuifuId("6666000109133323");
            // 交易流水列表
            request.setBatchList(get7087791b2c6441789d3fAa1688a130fb());
            // 接收人手机号
            request.setReceiveMobile("13945641357");
            // 接收人姓名
            request.setReceiveName("黄二");
            // 快递地址
            request.setCourierAddress("长江大街161号上海长江经济园");
            // 开票类目
            request.setInvoiceCategory("信息技术服务*软件测试服务");

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
            // 异步地址
            extendInfoMap.Add("asyn_url", "https://www.baidu.com");
            // 购方税号
            extendInfoMap.Add("invoice_tax_no", "91310230MA1JTWAK98");
            // 购方公司名称
            extendInfoMap.Add("invoice_name", "上海汇涵信息科技服务有限公司");
            // 购方公司地址
            extendInfoMap.Add("invoice_address", "长江大街161号上海长江经济园");
            // 购方公司银行账号
            extendInfoMap.Add("invoice_card_num", "631252533");
            // 购方银行名称
            extendInfoMap.Add("invoice_bank_name", "中国民生银行股份有限公司");
            // 购方联系电话
            extendInfoMap.Add("invoice_phone", "400-820-2819");
            // 发票类型
            extendInfoMap.Add("invoice_type", "1");
            // 备注
            extendInfoMap.Add("remarks", "");
            return extendInfoMap;
        }

        private static string get7087791b2c6441789d3fAa1688a130fb() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易流水号
            obj.Add("trans_seq_id", "SSPC8d4406cff4584b2391e113eaa32432bb");
            // 交易日期
            obj.Add("trans_date", "20240112");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
