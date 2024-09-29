using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户注册 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceMerRegRequestDemo
    {

        public static void V2InvoiceMerRegRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2InvoiceMerRegRequest request = new V2InvoiceMerRegRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 开票方汇付ID
            request.setHuifuId("6666000149801800");
            // 纳税人识别号
            request.setTaxPayerId("91310000795605184T");
            // 销方名称
            request.setTaxPayerName("汇付网络技术（上海）有限公司");
            // 公司电话
            request.setTelNo("021-33323999");
            // 公司地址
            request.setRegAddress("徐汇宜山路700号C5栋021-33323999");
            // 开户银行
            request.setBankName("民生银行徐汇支行");
            // 开户账户
            request.setAccountNo("0206014180001609");
            // 联系人手机号
            request.setContactPhoneNo("17621100776");
            // 开票方式
            request.setOpenMode("2");
            // 所属省
            request.setProvId("310000");
            // 所属市
            request.setCityId("310100");

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
            // 联系人
            extendInfoMap.Add("contact", "王姗");
            // 联系人身份证号
            extendInfoMap.Add("id_card_no", "210123198702122747");
            // 业务到期年限
            extendInfoMap.Add("valid_period", "1");
            // 自动续约
            extendInfoMap.Add("auto_renewal", "Y");
            // 开票结果异步通知地址
            extendInfoMap.Add("callback_url", "http: //service.example.com/to/path");
            return extendInfoMap;
        }

    }
}
