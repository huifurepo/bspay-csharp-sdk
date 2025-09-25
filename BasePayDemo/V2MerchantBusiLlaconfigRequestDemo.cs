using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 代运营代扣业务配置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiLlaconfigRequestDemo
    {

        public static void V2MerchantBusiLlaconfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBusiLlaconfigRequest request = new V2MerchantBusiLlaconfigRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付id
            request.setHuifuId("6666000123123123");
            // 所属渠道商
            request.setUpperHuifuId("6666000109812120");
            // 代运营配置json字符串，业务角色为AGENCY:代运营时必填
            // request.setLlaAgencyConfig(getEfde4fc4C2bc4b65Bb9aFa44c01e4e03());
            // 商家配置json字符串，业务角色为MERCHANT:商家时必填
            request.setLlaMerchantConfig(getC8f0b784B86845ff95598724e11c009b());
            // 纸质协议文件协议类型为纸质且业务角色不为空时必填，文件类型F633；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setPaperAgreementFile("test");
            // 签约人信息json字符串，协议类型为电子时必填
            request.setSignUserInfo(getFb3598d168734104Bb0d164b578aab34());

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
            // 业务角色
            extendInfoMap.Add("busi_role", "MERCHANT");
            // 协议类型
            extendInfoMap.Add("agreement_type", "0");
            // 审核异步消息接收地址
            // extendInfoMap.Add("audit_async_return_url", "");
            // 电子协议签约链接异步通知地址
            // extendInfoMap.Add("agreement_async_return_url", "");
            // 交易异步应答地址
            // extendInfoMap.Add("recon_resp_addr", "");
            return extendInfoMap;
        }

        private static string getEfde4fc4C2bc4b65Bb9aFa44c01e4e03() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 代运营配置开关
            // obj.Add("switch_state", "test");
            // 佣金手续费百分比代运营配置开关为开时必填,[0-100]区间的数,小数位最多两位 &lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;；&lt;br/&gt;
            // obj.Add("fee_rate", "test");
            // 佣金手续费内外扣标记代运营配置开关为开时必填,1:外扣 2:内扣 &lt;font color&#x3D;&quot;green&quot;&gt;示例值：2&lt;/font&gt;；&lt;br/&gt;
            // obj.Add("out_fee_flag", "test");
            // 佣金手续费外扣汇付ID佣金手续费内外扣标记为 1:外扣时必填 &lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812120&lt;/font&gt;
            // obj.Add("out_fee_huifuid", "test");
            // 佣金手续费外扣子账户类型01-基本户，05-充值户，09：营销户，佣金手续费内外扣标记为 1:外扣时必填 &lt;font color&#x3D;&quot;green&quot;&gt;示例值：01&lt;/font&gt;
            // obj.Add("out_fee_acct_type", "test");
            // 商家与代运营合作协议代运营配置开关为开时必填，商家与代运营方的扣款协议，文件类型F634；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // obj.Add("ma_cooperation_agreement_file", "test");
            // 代运营服务证明材料代运营配置开关为开时必填，文件类型F635；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // obj.Add("agency_service_prove_file", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getAaee4569633d42ba879536a3ee7acdc4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 抖音来客配置开关
            obj.Add("switch_state", "1");
            // 关联代运营汇付id抖音来客配置开关为开时必填,&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812124&lt;/font&gt;
            obj.Add("agency_huifu_id", "6666000109812124");
            // 代扣卡token抖音来客配置开关为开时必填
            obj.Add("token_no", "32231131111");
            // 抖音账户号
            obj.Add("dy_acct_no", "132123111");
            // 抖音网店名称抖音来客配置开关为开时必填
            obj.Add("dy_online_store_name", "网店名称");
            // 抖音业务类型
            obj.Add("dy_busi_type", "1");
            // 商家与代运营合作协议(抖音来客)抖音来客配置开关为开时必填，商家与代运营方的扣款协议，文件类型F636；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            obj.Add("madylk_cooperation_agreement_file", "57cc7f00-600a-33ab-b614-6221bbf2e530");
            // 商家抖音来客平台材料抖音来客配置开关为开时必填，提供商家在抖音来客平台的店铺名称、结算账户截图、经营照片等信息，文件类型F637；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            obj.Add("merchant_dylk_file", "57cc7f00-600a-33ab-b614-6221bbf2e530");

            return obj;
        }
        private static string getC8f0b784B86845ff95598724e11c009b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商家配置开关
            obj.Add("switch_state", "1");
            // 最大代扣比例(0,100]区间的整数,商家配置开关为开时必填&lt;font color&#x3D;&quot;green&quot;&gt;示例值：50&lt;/font&gt;
            obj.Add("max_withhold_percent", "50");
            // 抖音来客配置json对象,商家配置开关为开时必填
            obj.Add("lla_dylk_config", getAaee4569633d42ba879536a3ee7acdc4());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getFb3598d168734104Bb0d164b578aab34() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 签约人类型
            obj.Add("type", "LEGAL");
            // 签约人手机号
            obj.Add("mobile_no", "18611111111");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
