using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 全渠道资金管理配置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiEfpconfigRequestDemo
    {

        public static void V2MerchantBusiEfpconfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBusiEfpconfigRequest request = new V2MerchantBusiEfpconfigRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付id
            request.setHuifuId("6666000108139646");
            // 所属渠道商
            request.setUpperHuifuId("6666000108120249");
            // 开关
            request.setSwitchState("1");
            // 自动入账开关0:关闭 1:开通；switch_state为1时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1&lt;/font&gt;
            request.setOutOrderAutoAcctFlag("1");
            // 支付手续费外扣汇付ID支付手续费外扣标记为1时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812123&lt;/font&gt;
            request.setOutFeeHuifuid("");
            // 全域资金开户使用的银行卡信息首次开通时必填 jsonObject格式
            request.setOutOrderAcctCard("{\"area_id\":\"310100\",\"card_name\":\"圆务铁白事\",\"card_no\":\"4340622119959288\",\"card_type\":\"0\",\"prov_id\":\"310000\",\"bank_code\":\"01050000\",\"branch_code\":\"105290071113\",\"branch_name\":\"中国建设银行股份有限公司上海市中支行\",\"cert_begin_date\":\"20240314\",\"cert_end_date\":\"\",\"cert_no\":\"340000199810170714\",\"cert_type\":\"00\",\"cert_validity_type\":\"1\",\"mp\":\"13777842539\",\"open_licence_no\":\"123456789\"}");
            // 全域资金开户手续费首次开通时必填 jsonObject格式
            request.setOutOrderAcctOpenFees("{\"fee_fix_amt\":\"0\",\"out_fee_acct_type\":\"\",\"out_fee_huifuid\":\"\"}");
            // 全渠道资金管理补充材料id涉及文件类型：[F504-全渠道资金管理补充材料](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            request.setOtherPaymentInstitutionsPic("8c4f6254-6c36-3b3c-ae8b-efcf24ca215e");
            // XW银行数字证书及电子签名授权委托书out_funds_gate_id为xw0时必填；涉及文件类型：[F534-银行数字证书及电子签名授权委托书](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXwDigitalCertificatePic("test");
            // 银行类型
            request.setOutFundsGateId("xw0");
            // 签约人信息switch_state为1时必填 jsonObject格式
            request.setSignUserInfo("{\"type\":\"LEGAL\",\"mobile_no\":\"13777842539\"}");
            // 入账来源
            request.setAcctSource("01");

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
            // 支付手续费百分比
            extendInfoMap.Add("fee_rate", "0.04");
            // 支付手续费最小值
            extendInfoMap.Add("fee_min_amt", "");
            // 支付手续费外扣账户类型
            extendInfoMap.Add("out_fee_acct_type", "");
            // 支付手续费外扣标记
            extendInfoMap.Add("out_fee_flag", "2");
            // 业务模式
            extendInfoMap.Add("business_model", "acquiringMode");
            // 异步消息接收地址
            extendInfoMap.Add("async_return_url", "http://service.example.com/to/path");
            // 业务开通结果异步消息接收地址
            extendInfoMap.Add("busi_async_return_url", "http://service.example.com/to/path");
            // 申请单笔限额
            extendInfoMap.Add("pay_every_deal", "");
            // 申请单日限额
            extendInfoMap.Add("pay_every_day", "");
            // 抖音合作证明材料
            // extendInfoMap.Add("dy_cooperation_prove_pic", "");
            // 美团合作证明材料
            // extendInfoMap.Add("mt_cooperation_prove_pic", "");
            // 快手合作证明材料
            // extendInfoMap.Add("ks_cooperation_prove_pic", "");
            // 拼多多合作证明材料
            // extendInfoMap.Add("pdd_cooperation_prove_pic", "");
            // 小红书合作证明材料
            // extendInfoMap.Add("xhs_cooperation_prove_pic", "");
            // 支付宝相关平台合作证明材料
            // extendInfoMap.Add("zfb_cooperation_prove_pic", "");
            // 微信相关平台合作证明材料
            // extendInfoMap.Add("wx_cooperation_prove_pic", "");
            // 京东合作证明材料
            // extendInfoMap.Add("jd_cooperation_prove_pic", "");
            // 饿了么合作证明材料
            // extendInfoMap.Add("elm_cooperation_prove_pic", "");
            // 得物合作证明材料
            // extendInfoMap.Add("dw_cooperation_prove_pic", "");
            // 唯品会合作证明材料
            // extendInfoMap.Add("wph_cooperation_prove_pic", "");
            // 携程合作证明材料
            // extendInfoMap.Add("xc_cooperation_prove_pic", "");
            // 全域资金分账规则
            // extendInfoMap.Add("efp_spb_config", "");
            // 可付款最大比例配置
            // extendInfoMap.Add("max_payment_percentage_config", "");
            // 客户ip地址
            // extendInfoMap.Add("ip_address", "");
            return extendInfoMap;
        }

    }
}
