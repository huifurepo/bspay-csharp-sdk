using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 企业用户基本信息修改 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBasicdataEntModifyRequestDemo
    {

        public static void V2UserBasicdataEntModifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2UserBasicdataEntModifyRequest request = new V2UserBasicdataEntModifyRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 汇付客户Id
            request.setHuifuId("6666000103862211");

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
            extendInfoMap.Add("short_name", "企业商户测试22");
            // 法人姓名
            extendInfoMap.Add("legal_name", "陈立健");
            // 法人证件类型
            extendInfoMap.Add("legal_cert_type", "00");
            // 法人证件号码
            extendInfoMap.Add("legal_cert_no", "370684198903061155");
            // 法人证件有效期类型
            extendInfoMap.Add("legal_cert_validity_type", "0");
            // 法人证件有效期开始日期
            extendInfoMap.Add("legal_cert_begin_date", "20121010");
            // 法人证件有效期截止日期
            extendInfoMap.Add("legal_cert_end_date", "20301010");
            // 联系人姓名
            extendInfoMap.Add("contact_name", "花朵");
            // 联系人电子邮箱
            extendInfoMap.Add("contact_email", "chang@huifu.com");
            // 联系人手机号
            extendInfoMap.Add("contact_mobile", "13764462288");
            // 证照有效期类型
            extendInfoMap.Add("license_validity_type", "1");
            // 证照有效期起始日期
            extendInfoMap.Add("license_begin_date", "20200117");
            // 证照有效期结束日期
            extendInfoMap.Add("license_end_date", "20400117");
            // 注册地址(省)
            extendInfoMap.Add("reg_prov_id", "310000");
            // 注册地址(市)
            extendInfoMap.Add("reg_area_id", "310100");
            // 注册地址(区)
            extendInfoMap.Add("reg_district_id", "310104");
            // 注册地址(详细信息)
            extendInfoMap.Add("reg_detail", "上海市宜山路");
            // 文件列表
            extendInfoMap.Add("file_list", getFileList());
            return extendInfoMap;
        }

        private static string getFileList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            obj.Add("file_type", "F01");
            // 文件jfileID
            obj.Add("file_id", "71da066c-5d15-3658-a86d-4e85ee67808a");
            // 文件名称
            obj.Add("file_name", "企业营业执照1.jpg");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
