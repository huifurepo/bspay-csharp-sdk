using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 个人用户基本信息开户 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBasicdataIndvRequestDemo
    {

        public static void V2UserBasicdataIndvRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2UserBasicdataIndvRequest request = new V2UserBasicdataIndvRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 个人姓名
            request.setName("个人用户名称3657");
            // 个人证件类型
            request.setCertType("00");
            // 个人证件号码
            request.setCertNo("321084198912066512");
            // 个人证件有效期类型
            request.setCertValidityType("1");
            // 个人证件有效期开始日期
            request.setCertBeginDate("20200117");
            // 手机号
            request.setMobileNo("13764462205");

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
            // 个人证件有效期截止日期
            extendInfoMap.Add("cert_end_date", "20400117");
            // 电子邮箱
            extendInfoMap.Add("email", "jeff.peng@huifu.com");
            // 管理员账号
            extendInfoMap.Add("login_name", "Lg2022022201394910571");
            // 是否发送短信标识
            extendInfoMap.Add("sms_send_flag", "1");
            // 拓展方字段
            extendInfoMap.Add("expand_id", "");
            // 文件列表
            extendInfoMap.Add("file_list", getFileList());
            // 地址
            // extendInfoMap.Add("**address**", "");
            return extendInfoMap;
        }

        private static string getFileList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            obj.Add("file_type", "F04");
            // 文件jfileID
            obj.Add("file_id", "2022022201394949297117211");
            // 文件名称
            obj.Add("file_name", "企业营业执照1.jpg");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
