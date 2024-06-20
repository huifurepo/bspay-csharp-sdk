using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户注册信息修改 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceMerModifyRequestDemo
    {

        public static void V2InvoiceMerModifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2InvoiceMerModifyRequest request = new V2InvoiceMerModifyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 开票方汇付ID
            request.setHuifuId("6666000149801800");

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
            // 销方名称
            extendInfoMap.Add("tax_payer_name", "汇付网络技术（上海）有限公司");
            // 公司电话
            extendInfoMap.Add("tel_no", "021-33323999");
            // 公司地址
            extendInfoMap.Add("reg_address", "徐汇宜山路700号C5栋021-33323999");
            // 开户银行
            extendInfoMap.Add("bank_name", "民生银行徐汇支行");
            // 开户账户
            extendInfoMap.Add("account_no", "0206014180001609");
            // 联系人手机号
            extendInfoMap.Add("contact_phone_no", "17621100776");
            // 联系人
            extendInfoMap.Add("contact", "王姗");
            // 联系人身份证号
            extendInfoMap.Add("id_card_no", "210123198702122747");
            // 所属省
            extendInfoMap.Add("prov_id", "310000");
            // 所属市
            extendInfoMap.Add("city_id", "310100");
            return extendInfoMap;
        }

    }
}
