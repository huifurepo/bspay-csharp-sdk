using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 子账户开通配置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantSettleConfigRequestDemo
    {

        public static void V2MerchantSettleConfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantSettleConfigRequest request = new V2MerchantSettleConfigRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付Id
            request.setHuifuId("6666000106071234");
            // 渠道商汇付Id
            request.setUpperHuifuId("6666000106065087");
            // 子账户类型
            request.setAcctType("02");
            // 账户名称
            request.setAcctName("现金账户");

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
            // 结算卡信息配置
            extendInfoMap.Add("card_info", getCardInfo());
            // 结算规则配置
            extendInfoMap.Add("settle_config", getSettleConfig());
            // 异步请求地址
            extendInfoMap.Add("async_return_url", "");
            return extendInfoMap;
        }

        private static string getSettleConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算周期
            obj.Add("settle_cycle", "D1");
            // 结算手续费外扣商户号填写承担手续费的汇付商户号；当out_settle_flag&#x3D;1时必填，否则非必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123123&lt;/font&gt;
            obj.Add("out_settle_huifuid", "6666000106070589");
            // 起结金额
            obj.Add("min_amt", "1");
            // 留存金额
            obj.Add("remained_amt", "2");
            // 结算摘要
            obj.Add("settle_abstract", "abstract");
            // 手续费外扣标记
            obj.Add("out_settle_flag", "1");
            // 结算手续费外扣账户类型
            obj.Add("out_settle_acct_type", "01");
            // 节假日结算手续费率（%）
            obj.Add("fixed_ratio", "66.88");
            // 结算方式
            obj.Add("settle_pattern", "P0");
            // 结算批次号
            obj.Add("settle_batch_no", "0");
            // 是否优先到账
            obj.Add("is_priority_receipt", "N");
            // 自定义结算处理时间
            obj.Add("settle_time", "211221");
            // 节假日结算手续费固定金额（元）
            obj.Add("constant_amt", "211221");
            // 卡序列号
            obj.Add("token_no", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCardInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算账户类型
            obj.Add("card_type", "0");
            // 结算账户名
            obj.Add("card_name", "张三");
            // 结算账号
            obj.Add("card_no", "62200000000000000");
            // 银行所在省
            obj.Add("prov_id", "310000");
            // 银行所在市
            obj.Add("area_id", "310100");
            // 银行编号参考： [银行编码](https://paas.huifu.com/partners/api/#/csfl/api_csfl_yhbm) ； &lt;font color&#x3D;&quot;green&quot;&gt;示例值：01020000 &lt;/font&gt; &lt;br/&gt;当card_type&#x3D;0时必填， 当card_type&#x3D;1或2时非必填
            obj.Add("bank_code", "01030000");
            // 联行号参考：[银行支行编码](https://paas.huifu.com/partners/api/#/csfl/api_csfl_yhzhbm) 当card_type&#x3D;0时必填， 当card_type&#x3D;1或2时非必填 &lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：102290026507&lt;/font&gt;
            obj.Add("branch_code", "103290040169");
            // 支行名称开户支行名称。 当card_type&#x3D;0时必填， 当card_type&#x3D;1或2时非必填； &lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：中国工商银行上海市中山北路支行&lt;/font&gt;
            obj.Add("branch_name", "中国农业银行股份有限公司XXX支行");
            // 持卡人证件类型参见《[自然人证件类型](https://paas.huifu.com/partners/api/#/api_ggcsbm?id&#x3D;%e8%87%aa%e7%84%b6%e4%ba%ba%e8%af%81%e4%bb%b6%e7%b1%bb%e5%9e%8b)》 当card_type&#x3D;0时为空， 当card_type&#x3D;1或2时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：00&lt;/font&gt;
            obj.Add("cert_type", "00");
            // 持卡人证件有效期截止日期日期格式：yyyyMMdd，以北京时间为准。&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20220125&lt;/font&gt;，当cert_validity_type&#x3D;0时必填；当cert_validity_type&#x3D;1时为空
            obj.Add("cert_end_date", "20221212");
            // 持卡人证件号码
            obj.Add("cert_no", "220105198806082098");
            // 持卡人证件有效期类型
            obj.Add("cert_validity_type", "0");
            // 持卡人证件有效期开始
            obj.Add("cert_begin_date", "20220101");
            // 银行卡绑定手机号
            obj.Add("mp", "1751111111");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
