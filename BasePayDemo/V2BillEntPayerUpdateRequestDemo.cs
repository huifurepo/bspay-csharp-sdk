using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 修改付款人信息 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2BillEntPayerUpdateRequestDemo
    {

        public static void V2BillEntPayerUpdateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2BillEntPayerUpdateRequest request = new V2BillEntPayerUpdateRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000003100615");
            // 付款人
            request.setPayerId("P2024082786373612");
            // 付款人名称
            request.setPayerName("史凡");

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
            // 付款人邮箱地址
            extendInfoMap.Add("payer_email", "1111@163.com");
            // 付款人手机号码
            extendInfoMap.Add("payer_mobile_no", "17611111111");
            return extendInfoMap;
        }

    }
}
