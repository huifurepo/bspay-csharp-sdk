using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 查询投诉单列表及详情 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintListInfoQueryRequestDemo
    {

        public static void V2MerchantComplaintListInfoQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantComplaintListInfoQueryRequest request = new V2MerchantComplaintListInfoQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 开始日期
            request.setBeginDate("2022-10-20");
            // 结束日期
            request.setEndDate("2022-10-20");

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
            // 分页开始位置
            extendInfoMap.Add("offset", "");
            // 分页大小
            extendInfoMap.Add("limit", "");
            // 被诉的汇付商户ID
            extendInfoMap.Add("huifu_id", "");
            // 被诉的商户名称
            extendInfoMap.Add("reg_name", "");
            // 微信订单号
            extendInfoMap.Add("transaction_id", "");
            // 微信投诉单号
            extendInfoMap.Add("complaint_id", "");
            // 投诉状态
            extendInfoMap.Add("complaint_state", "");
            // 用户投诉次数
            extendInfoMap.Add("user_complaint_times", "");
            // 是否有待回复的用户留言
            extendInfoMap.Add("incoming_user_response", "0");
            return extendInfoMap;
        }

    }
}
