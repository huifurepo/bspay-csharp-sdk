using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 钱包密码重置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletPasswordResetRequestDemo
    {

        public static void V2WalletPasswordResetRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2WalletPasswordResetRequest request = new V2WalletPasswordResetRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000107309462");
            // 钱包用户ID
            request.setUserHuifuId("6666000107355468");
            // 钱包绑定手机号
            request.setCustMobile("13771817106");
            // 手机短信验证码
            request.setVerifyNo("652364");
            // 短信验证流水号
            request.setVerifySeqId("WALLET0000000054024907");
            // 跳转地址
            request.setFrontUrl("");

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
            // 请求失效时间
            extendInfoMap.Add("time_expired", "");
            // 个人证件号码
            // extendInfoMap.Add("cert_no", "");
            // 银行卡号
            extendInfoMap.Add("card_no", "");
            // 银行卡绑定手机号
            // extendInfoMap.Add("card_mobile", "");
            return extendInfoMap;
        }

    }
}
