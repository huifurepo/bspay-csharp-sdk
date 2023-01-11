using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 回复用户 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantComplaintReplyRequestDemo
    {

        public static void V2MerchantComplaintReplyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantComplaintReplyRequest request = new V2MerchantComplaintReplyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 微信投诉单号
            request.setComplaintId("200000020221020220032603511");
            // 被诉商户微信号
            request.setComplaintedMchid("535295270");
            // 回复内容
            request.setResponseContent("该问题请联系商家处理，谢谢。");
            // 跳转链接
            request.setJumpUrl("");
            // 跳转链接文案
            request.setJumpUrlText("");
            // 微信商户号
            request.setMchId("1502073961");

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
            // 文件列表
            // extendInfoMap.Add("file_info", getFileInfo());
            return extendInfoMap;
        }

        private static string getFileInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 回复图片1
            // obj.Add("response_pic1", "");
            // 回复图片2
            // obj.Add("response_pic2", "");
            // 回复图片3
            // obj.Add("response_pic3", "");
            // 回复图片4
            // obj.Add("response_pic4", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
