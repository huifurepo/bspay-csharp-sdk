using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 钱包绑定手机号验证 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2WalletMobileVerifyRequestDemo
    {

        public static void V2WalletMobileVerifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2WalletMobileVerifyRequest request = new V2WalletMobileVerifyRequest();
            // 请求流水号
            // request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            // request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000107309462");
            // 钱包用户ID斗拱系统生成的钱包用户ID。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123122343&lt;/font&gt;&lt;br/&gt;验证类型为2-密码修改和3-密码重置时，必须提供钱包用户的汇付ID。
            request.setUserHuifuId("6666000107355468");
            // 用户手机号
            request.setMobileNo("13771817106");
            // 验证类型
            request.setType("3");

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
            return extendInfoMap;
        }

    }
}
