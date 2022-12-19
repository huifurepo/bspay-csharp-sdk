using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信实名认证 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiRealnameRequestDemo
    {

        public static void V2MerchantBusiRealnameRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBusiRealnameRequest request = new V2MerchantBusiRealnameRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付ID
            request.setHuifuId("6666000104854510");
            // 联系人姓名
            request.setName("小枫");
            // 联系人手机号
            request.setMobile("17521205027");
            // 联系人身份证号码
            request.setIdCardNumber("130224198806083798");
            // 联系人类型
            request.setContactType("SUPER");

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
            // 子渠道号
            extendInfoMap.Add("pay_channel_id", "JP00001");
            // 支付场景
            extendInfoMap.Add("pay_scene", "01");
            // 经营者/法人是否为受益人
            extendInfoMap.Add("owner", "N");
            // 法人证件居住地址
            extendInfoMap.Add("identification_address", "上海市徐汇区宜山路789号789室");
            // 受益人信息
            extendInfoMap.Add("ubo_info_list", getUboInfoList());
            // 联系人证件类型
            extendInfoMap.Add("contact_id_doc_type", "01");
            // 联系人证件有效期开始时间
            extendInfoMap.Add("contact_period_begin", "1990-03-07");
            // 联系人证件有效期结束时间
            extendInfoMap.Add("contact_period_end", "长期");
            // 证书类型
            extendInfoMap.Add("cert_type", "CERTIFICATE_TYPE_2389");
            // 证书编号
            extendInfoMap.Add("cert_number", "1234567892");
            // 证书照片
            extendInfoMap.Add("cert_copy", "");
            // 小微经营类型
            extendInfoMap.Add("micro_biz_type", "");
            // 门店名称
            extendInfoMap.Add("store_name", "");
            // 门店门头照片
            extendInfoMap.Add("store_header_copy", "");
            // 店内环境照片
            extendInfoMap.Add("store_indoor_copy", "");
            // 门店省市编码
            extendInfoMap.Add("store_address_code", "");
            // 门店地址
            extendInfoMap.Add("store_address", "");
            // 身份证件正面照片
            extendInfoMap.Add("identification_front_copy", "c7faf0e6-39e9-3c35-9075-2312ad6f4ea4");
            // 身份证件反面照片
            extendInfoMap.Add("identification_back_copy", "c7faf0e6-39e9-3c35-9075-2312ad6f4ea4");
            // 单位证明函照片
            extendInfoMap.Add("company_prove_copy", "");
            // 是否金融机构
            extendInfoMap.Add("finance_institution_flag", "N");
            // 金融机构类型
            extendInfoMap.Add("finance_type", "");
            // 特殊行业Id
            extendInfoMap.Add("category_id", "");
            // 文件列表
            extendInfoMap.Add("special_file_info_list", getSpecialFileInfoList());
            return extendInfoMap;
        }

        private static string getUboInfoList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 受益人证件类型
            obj.Add("ubo_id_doc_type", "00");
            // 证件正面照片
            obj.Add("ubo_id_doc_copy", "c7faf0e6-39e9-3c35-9075-2312ad6f4ea4");
            // 受益人证件姓名
            obj.Add("ubo_id_doc_name", "杨雷");
            // 受益人证件号码
            obj.Add("ubo_id_doc_number", "110101199003072631");
            // 证件居住地址
            obj.Add("ubo_id_doc_address", "上海市徐汇区宜山路789号");
            // 证件有效期开始时间
            obj.Add("ubo_period_begin", "19900307");
            // 证件有效期结束时间
            obj.Add("ubo_period_end", "长期");
            // 证件反面照片
            obj.Add("ubo_id_doc_copy_back", "c7faf0e6-39e9-3c35-9075-2312ad6f4ea4");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getSpecialFileInfoList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            obj.Add("file_type", "F33");
            // 文件jfileID
            obj.Add("file_id", "49ac7d9b-851c-31b4-8b21-2983ea97b98c");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
