using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 提交申诉 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantAppealCommonSubmitRequestDemo
    {

        public static void V2MerchantAppealCommonSubmitRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantAppealCommonSubmitRequest request = new V2MerchantAppealCommonSubmitRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户经营模式
            request.setBusinessPattern("03");
            // 协查单号
            request.setAssistId("202407021808060672701923328");
            // 申诉单号
            request.setAppealId("202407021808060674786492416");
            // 商户类型
            request.setMerType("01");
            // 申诉人姓名
            request.setAppealPersonName("张三");
            // 申诉人身份证号
            request.setAppealPersonCertNo("41162719213519");
            // 申诉人联系电话
            request.setAppealPersonPhoneNo("186234508");
            // 法人姓名
            request.setLegalName("张三");
            // 法人身份证号
            request.setLegalCertNo("411627199509123");
            // 法人联系电话
            request.setLegalPhoneNo("186234502");
            // 商户主营业务
            request.setMainBusiness("批发零食饮料");
            // 申诉理由
            request.setAppealDesc("因XX申诉");

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
            // 商户营业执照号
            extendInfoMap.Add("mer_business_license_no", "916501042135");
            // app名称
            extendInfoMap.Add("app_name", "app名称");
            // app下载链接
            extendInfoMap.Add("app_url", "XXX");
            // 电商网址
            extendInfoMap.Add("commerce_url", "www.baidu.com");
            // ICP备案号
            extendInfoMap.Add("icp_record_no", "京ICP21003632-7");
            // 实际经营地址
            extendInfoMap.Add("business_address", "实际经营地址");
            // 营业用地性质
            extendInfoMap.Add("business_location_nature", "01");
            // 经营时长
            extendInfoMap.Add("business_time", "09:00:00-21:30:00");
            // 经营地段
            extendInfoMap.Add("business_location_type", "01");
            // 员工人数
            extendInfoMap.Add("employee_cnt", "10");
            // 申诉文件列表
            extendInfoMap.Add("appeal_file_list", getAppealFileList());
            return extendInfoMap;
        }

        private static string getAppealFileList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 申诉文件名称
            obj.Add("item_name", "法人身份证正面");
            // 申诉文件Id
            obj.Add("file_id", "fede0ba8-4994-386c-966a-sd23");
            // 申诉文件类型
            obj.Add("file_code", "F01");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
