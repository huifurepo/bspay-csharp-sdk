using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 扫码交易查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V3TradePaymentScanpayQueryRequestDemo
    {

        public static void V3TradePaymentScanpayQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V3TradePaymentScanpayQueryRequest request = new V3TradePaymentScanpayQueryRequest();
            // 汇付商户号
            request.setHuifuId("6666000109133323");
            // 原机构请求日期格式为yyyyMMdd，&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;；&lt;/br&gt;传入org_hf_seq_id时非必填，其他场景必填；
            request.setOrgReqDate("20240405");
            // 汇付服务订单号out_ord_id,org_hf_seq_id,org_req_seq_id 必填其一；汇付生成的服务订单号；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1234323JKHDFE1243252&lt;/font&gt;
            // request.setOutOrdId("test");
            // 创建服务订单返回的汇付全局流水号out_ord_id,org_hf_seq_id,org_req_seq_id 必填其一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00290TOP1GR210919004230P853ac13262200000&lt;/font&gt;
            // request.setOrgHfSeqId("test");
            // 服务订单创建请求流水号out_ord_id,org_hf_seq_id,org_req_seq_id 必填其一；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：202110210012100005&lt;/font&gt;
            request.setOrgReqSeqId("20240405221826354151");

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
            return extendInfoMap;
        }

    }
}
