using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 登记扣款信息 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradePayscoreDeductRegitsterRequestDemo
    {

        public static void V2TradePayscoreDeductRegitsterRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradePayscoreDeductRegitsterRequest request = new V2TradePayscoreDeductRegitsterRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户申请单号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 汇付商户号
            request.setHuifuId("6666000108854952");

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
            // 汇付服务订单号
            // extendInfoMap.Add("out_order_no", "");
            // 创建服务订单返回的汇付全局流水号
            // extendInfoMap.Add("org_hf_seq_id", "");
            // 服务订单创建请求流水号
            // extendInfoMap.Add("org_req_seq_id", "");
            return extendInfoMap;
        }

    }
}
