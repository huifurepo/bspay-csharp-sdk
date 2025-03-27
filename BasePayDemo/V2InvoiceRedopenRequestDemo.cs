using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 红字发票开具接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceRedopenRequestDemo
    {

        public static void V2InvoiceRedopenRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2InvoiceRedopenRequest request = new V2InvoiceRedopenRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付商户号
            request.setHuifuId("6666000107430944");
            // 原发票号码
            request.setOriIvcNumber("25317000000132667193");
            // 红冲原因
            request.setRedApplyReason("02");
            // 红冲申请来源
            request.setRedApplySource("01");

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
            // 备注
            extendInfoMap.Add("resv", "备注");
            // 开票结果异步通知地址
            extendInfoMap.Add("callback_url", "virgo://http://192.168.85.157:30031/sspm/testVirgo");
            return extendInfoMap;
        }

    }
}
