using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 分期支付 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeInstallmentPaymentRequestDemo
    {

        public static void V2TradeInstallmentPaymentRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeInstallmentPaymentRequest request = new V2TradeInstallmentPaymentRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000100000000");
            // 交易金额
            request.setTransAmt("100.00");
            // 分期数
            request.setInstallmentNum("3");
            // 商品描述
            request.setGoodsDesc("手机");
            // 安全信息
            request.setRiskCheckData(getRiskCheckData());
            // 京东白条分期信息trans_type&#x3D;JDBT时，必填jsonObject字符串，京东白条分期相关信息通过该参数集上送
            request.setJdbtData(getJdbtData());

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
            // 账户号
            // extendInfoMap.Add("acct_id", "");
            // 交易类型
            // extendInfoMap.Add("trans_type", "");
            // 支付场景
            // extendInfoMap.Add("pay_scene", "");
            // 交易有效期
            extendInfoMap.Add("time_expire", "20241008235959");
            // 手续费扣款标志
            // extendInfoMap.Add("fee_flag", "");
            // 延时标识
            // extendInfoMap.Add("delay_acct_flag", "");
            // 备注
            extendInfoMap.Add("remark", "备注");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "https://www.baidu.com/onlineAsync");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getAcctSplitBunch());
            return extendInfoMap;
        }

        private static object getAcctInfosRc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户号
            obj.Add("huifu_id", "6666000100000000");
            // 分账金额
            obj.Add("div_amt", "");
            // 分账百分比
            obj.Add("percentage_div", "70.00");
            // 账户号
            obj.Add("acct_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getAcctSplitBunch() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 百分比分账标志
            obj.Add("percentage_flag", "Y");
            // 是否净值分账
            obj.Add("is_clean_split", "N");
            // 分账明细
            obj.Add("acct_infos", getAcctInfosRc());

            return JsonConvert.SerializeObject(obj);
        }
        private static string getRiskCheckData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 经度
            obj.Add("longitude", "126.630128");
            // 纬度
            obj.Add("latitude", "126.630128");
            // 基站地址
            obj.Add("base_station", "3");
            // IP地址
            obj.Add("ip_addr", "182.33.21.4");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getJdbtData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品数量
            obj.Add("goods_num", "3");
            // 下单来源
            obj.Add("order_source", "微信APP扫一扫");
            // 请求来源类型
            obj.Add("order_source_type", "H5");
            // 同步通知页面
            obj.Add("callback_url", "https://www.baidu.com");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
