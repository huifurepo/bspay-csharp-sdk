using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 个人用户基本信息修改 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBasicdataIndvModifyRequestDemo
    {

        public static void V2UserBasicdataIndvModifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2UserBasicdataIndvModifyRequest request = new V2UserBasicdataIndvModifyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付客户Id
            request.setHuifuId("6666000103854106");

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
            // 个人证件有效期类型
            extendInfoMap.Add("cert_validity_type", "2");
            // 个人证件有效期开始日期
            extendInfoMap.Add("cert_begin_date", "20200111");
            // 个人证件有效期截止日期
            extendInfoMap.Add("cert_end_date", "20400111");
            // 电子邮箱
            extendInfoMap.Add("email", "jeff.peng@huifu.com");
            // 手机号
            extendInfoMap.Add("mobile_no", "15556622000");
            // 文件列表
            // extendInfoMap.Add("file_list", getB751a3d0C54d4718808cFd8fbde4bf08());
            // 地址
            // extendInfoMap.Add("address", "");
            // 所属行业
            // extendInfoMap.Add("mcc", "");
            // 省
            // extendInfoMap.Add("prov_id", "");
            // 市
            // extendInfoMap.Add("area_id", "");
            // 区
            // extendInfoMap.Add("district_id", "");
            return extendInfoMap;
        }

        private static string getB751a3d0C54d4718808cFd8fbde4bf08() {
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
