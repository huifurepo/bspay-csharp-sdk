using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 结算记录查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBasicdataSettlementQueryRequestDemo
    {

        public static void V2MerchantBasicdataSettlementQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBasicdataSettlementQueryRequest request = new V2MerchantBasicdataSettlementQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000111938435");
            // 结算开始日期
            request.setBeginDate("20200810");
            // 结算结束日期
            request.setEndDate("20200810");
            // 分页条数
            request.setPageSize("10");

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
            // 结算方式
            extendInfoMap.Add("settle_cycle", "");
            // 分页页码
            extendInfoMap.Add("page_num", "1");
            // 交易状态
            extendInfoMap.Add("trans_stat", "I");
            // 排序字段
            extendInfoMap.Add("sort_column", "10");
            // 排序顺序
            extendInfoMap.Add("sort_order", "DESC");
            return extendInfoMap;
        }

    }
}
