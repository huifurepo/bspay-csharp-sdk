using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信直连-修改微信结算帐号 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantDirectWechatSettlementinfoModifyRequestDemo
    {

        public static void V2MerchantDirectWechatSettlementinfoModifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantDirectWechatSettlementinfoModifyRequest request = new V2MerchantDirectWechatSettlementinfoModifyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付ID
            request.setHuifuId("6666000003098550");
            // 开发者的应用ID
            request.setAppId("wxd2da4051c9e32b86");
            // 微信商户号
            request.setMchId("1552470931");
            // 特约商户号
            request.setSubMchid("10888880");
            // 账户类型
            request.setAccountType("ACCOUNT_TYPE_BUSINESS");
            // 开户银行
            request.setAccountBank("农业银行");
            // 开户银行省市编码
            request.setBankAddressCode("310100");
            // 银行账号
            request.setAccountNumber("6235012141000002900");

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
            // 开户银行全称（含支行）
            extendInfoMap.Add("bank_name", "中国农业银行股份有限公司上海马当路支行");
            // 开户银行联行号
            extendInfoMap.Add("bank_branch_id", "103290040169");
            return extendInfoMap;
        }

    }
}
