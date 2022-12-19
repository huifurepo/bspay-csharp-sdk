using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 用户业务入驻 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBusiOpenRequestDemo
    {

        public static void V2UserBusiOpenRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2UserBusiOpenRequest request = new V2UserBusiOpenRequest();
            // 汇付ID
            request.setHuifuId("6666000105765113");
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 渠道商/商户汇付Id
            request.setUpperHuifuId("6666000003084836");

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
            // 结算信息配置
            // extendInfoMap.Add("&lt;span class&#x3D;&quot;extend settle_config&quot;&gt;settle_config&lt;/span&gt;", "");
            // 结算卡信息
            // extendInfoMap.Add("&lt;span class&#x3D;&quot;extend card_info&quot;&gt;card_info&lt;/span&gt;", "");
            // 取现配置列表
            // extendInfoMap.Add("&lt;span class&#x3D;&quot;extend cash_config&quot;&gt;cash_config&lt;/span&gt;", "");
            // 文件列表
            // extendInfoMap.Add("&lt;span class&#x3D;&quot;extend file_list&quot;&gt;file_list&lt;/span&gt;", "");
            // 延迟入账开关
            // extendInfoMap.Add("delay_flag", "");
            return extendInfoMap;
        }

    }
}
