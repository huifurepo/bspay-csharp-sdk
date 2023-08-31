using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 更新退款审批结果 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintUpdateRefundprogressRequestDemo
    {

        public static void V2MerchantComplaintUpdateRefundprogressRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantComplaintUpdateRefundprogressRequest request = new V2MerchantComplaintUpdateRefundprogressRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 投诉单号
            request.setComplaintId("200000020221020220032600930");
            // 审批动作
            request.setAction("APPROVE");
            // 微信商户号
            request.setMchId("1502074862");

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
            // 预计发起退款时间
            extendInfoMap.Add("launch_refund_day", "");
            // 拒绝退款原因
            extendInfoMap.Add("reject_reason", "");
            // 备注
            extendInfoMap.Add("remark", "我是备注1111101");
            // 文件列表
            extendInfoMap.Add("file_info", getFileInfo());
            return extendInfoMap;
        }

        private static string getFileInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 拒绝退款的举证图片1
            obj.Add("reject_media_pic1", "a8a096a3-0dd4-3b0e-886c-9afb20d23b1a");
            // 拒绝退款的举证图片2
            obj.Add("reject_media_pic2", "a8a096a3-0dd4-3b0e-886c-9afb20d23b2a");
            // 拒绝退款的举证图片3
            obj.Add("reject_media_pic3", "a8a096a3-0dd4-3b0e-886c-9afb20d23b3a");
            // 拒绝退款的举证图片4
            obj.Add("reject_media_pic4", "a8a096a3-0dd4-3b0e-886c-9afb20d23b4a");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
