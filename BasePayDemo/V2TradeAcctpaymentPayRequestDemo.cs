using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 余额支付 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeAcctpaymentPayRequestDemo
    {

        public static void V2TradeAcctpaymentPayRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeAcctpaymentPayRequest request = new V2TradeAcctpaymentPayRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 出款方商户号
            request.setOutHuifuId("6666000109133323");
            // 支付金额
            request.setOrdAmt("0.01");
            // 分账对象
            request.setAcctSplitBunch(getD37742661e6048c3B305B86f6af02ff6());
            // 安全信息
            request.setRiskCheckData(get7e2f3a0329204bd7Af5b4b0e8e8e6e57());
            // 资金类型资金类型。支付渠道为中信E管家时，资金类型必填（[详见说明](https://paas.huifu.com/open/doc/api/#/yuer/api_zxegjzllx)）
            // request.setFundType("test");
            // 手续费承担方标识余额支付手续费承担方标识；商户余额支付扣收规则为接口指定承担方时必填！枚举值：&lt;br/&gt;OUT：出款方；&lt;br/&gt;IN：分账接受方。&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：IN&lt;/font&gt;
            // request.setTransFeeTakeFlag("test");

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
            // 发起方商户号
            // extendInfoMap.Add("huifu_id", "");
            // 商品描述
            // extendInfoMap.Add("good_desc", "");
            // 备注
            // extendInfoMap.Add("remark", "");
            // 是否延迟交易
            // extendInfoMap.Add("delay_acct_flag", "");
            // 出款方账户号
            // extendInfoMap.Add("out_acct_id", "");
            // 支付渠道
            // extendInfoMap.Add("acct_channel", "");
            // 灵活用工标志
            // extendInfoMap.Add("hyc_flag", "");
            // 灵活用工平台
            // extendInfoMap.Add("lg_platform_type", "");
            // 代发模式
            // extendInfoMap.Add("salary_modle_type", "");
            // 落地公司商户号
            // extendInfoMap.Add("bmember_id", "");
            // 乐接活请求参数集合
            // extendInfoMap.Add("ljh_data", get5de9d033D391477aB3266dcce6b8b3e4());
            // 异步通知地址
            // extendInfoMap.Add("notify_url", "");
            return extendInfoMap;
        }

        private static object getF21d3168F3f74616B096Bccba329d0b9() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账接收方ID
            obj.Add("huifu_id", "6666000109133323");
            // 分账金额
            obj.Add("div_amt", "0.01");
            // 账户号
            // obj.Add("acct_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getD37742661e6048c3B305B86f6af02ff6() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", getF21d3168F3f74616B096Bccba329d0b9());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get7e2f3a0329204bd7Af5b4b0e8e8e6e57() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 转账原因
            obj.Add("transfer_type", "04");
            // 产品子类
            obj.Add("sub_product", "1");
            // 纬度
            // obj.Add("latitude", "");
            // 经度
            // obj.Add("longitude", "");
            // 基站地址
            // obj.Add("base_station", "");
            // IP地址
            // obj.Add("ip_addr", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get5de9d033D391477aB3266dcce6b8b3e4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 税源地ID
            // obj.Add("tax_area_id", "");
            // 任务模板ID
            // obj.Add("template_id", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
