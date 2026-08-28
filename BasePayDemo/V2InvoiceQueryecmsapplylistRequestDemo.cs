using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 电子合同申请列表查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceQueryecmsapplylistRequestDemo
    {

        public static void V2InvoiceQueryecmsapplylistRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2InvoiceQueryecmsapplylistRequest request = new V2InvoiceQueryecmsapplylistRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 汇付商户号
            request.setHuifuId("6666000103334211");
            // 协议类型
            request.setAgreementType("ELECT");
            // 当前页
            request.setPageNum("1");
            // 分页大小
            // request.setPageSize("test");

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
            // 协议编号
            extendInfoMap.Add("agreement_id", "202505210201439711");
            // 场景类型
            extendInfoMap.Add("scene_code", "MER_KYC");
            // 协议状态
            // extendInfoMap.Add("sign_status", "");
            // 申请单号
            extendInfoMap.Add("order_id", "2025052118403054");
            // 商户名称
            // extendInfoMap.Add("mer_name", "");
            // 产品号
            // extendInfoMap.Add("product_id", "");
            return extendInfoMap;
        }

    }
}
