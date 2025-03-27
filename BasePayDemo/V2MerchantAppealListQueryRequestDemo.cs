using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 申诉单列表查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantAppealListQueryRequestDemo
    {

        public static void V2MerchantAppealListQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantAppealListQueryRequest request = new V2MerchantAppealListQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 分页条数
            request.setPageSize("20");
            // 申诉创建开始日期
            request.setBeginDate("20240701");
            // 申诉创建结束日期
            request.setEndDate("20240731");

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
            // 分页页码
            extendInfoMap.Add("page_num", "1");
            // 协查单号
            extendInfoMap.Add("assist_id", "");
            // 渠道/代理/商户/用户编号
            extendInfoMap.Add("huifu_id", "6666000108285670");
            // 商户名称
            extendInfoMap.Add("mer_name", "");
            // 申诉状态
            extendInfoMap.Add("appeal_node", "");
            // 审核结论
            extendInfoMap.Add("audit_result", "");
            // 运营处理状态
            extendInfoMap.Add("operation_status", "");
            // 汇付处置等级
            extendInfoMap.Add("handle_degree", "");
            return extendInfoMap;
        }

    }
}
