using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 企业用户基本信息开户 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBasicdataEntRequestDemo
    {

        public static void V2UserBasicdataEntRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2UserBasicdataEntRequest request = new V2UserBasicdataEntRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 企业用户名称
            request.setRegName("企业商户名称8225");
            // 营业执照编号
            request.setLicenseCode("20220222013747149");
            // 证照有效期类型
            request.setLicenseValidityType("1");
            // 证照有效期起始日期
            request.setLicenseBeginDate("20200117");
            // 证照有效期结束日期日期格式：yyyyMMdd; 非长期有效时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20320905&lt;/font&gt;
            request.setLicenseEndDate("20400117");
            // 注册地址(省)
            request.setRegProvId("310000");
            // 注册地址(市)
            request.setRegAreaId("310100");
            // 注册地址(区)
            request.setRegDistrictId("310104");
            // 注册地址(详细信息)
            request.setRegDetail("上海市宜山路");
            // 法人姓名
            request.setLegalName("陈立五");
            // 法人证件类型
            request.setLegalCertType("00");
            // 法人证件号码
            request.setLegalCertNo("321084198912066582");
            // 法人证件有效期类型
            request.setLegalCertValidityType("1");
            // 法人证件有效期开始日期
            request.setLegalCertBeginDate("20120801");
            // 法人证件有效期截止日期日期格式：yyyyMMdd; 非长期有效时必填，长期有效为空；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20320905&lt;/font&gt;
            request.setLegalCertEndDate("20300801");
            // 联系人姓名
            request.setContactName("小的");
            // 联系人手机号
            request.setContactMobile("13764462211");
            // 管理员账号如需短信通知则必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：Lg20220222013747&lt;/font&gt;
            request.setLoginName("Lg2022022201374721361");

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
            // 经营简称
            extendInfoMap.Add("short_name", "企业商户");
            // 联系人电子邮箱
            extendInfoMap.Add("contact_email", "jeff.peng@huifu.com");
            // 操作员
            extendInfoMap.Add("operator_id", "");
            // 是否发送短信标识
            extendInfoMap.Add("sms_send_flag", "1");
            // 扩展方字段
            extendInfoMap.Add("expand_id", "");
            // 文件列表
            // extendInfoMap.Add("file_list", getFileList());
            // 公司类型
            // extendInfoMap.Add("ent_type", "");
            return extendInfoMap;
        }

        private static string getFileList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            // obj.Add("file_type", "test");
            // 文件jfileID
            // obj.Add("file_id", "test");
            // 文件名称
            // obj.Add("file_name", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
