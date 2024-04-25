using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银行大额支付差错申请 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeOnlinepaymentTransferBankmistakeApplyRequestDemo
    {

        public static void V2TradeOnlinepaymentTransferBankmistakeApplyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeOnlinepaymentTransferBankmistakeApplyRequest request = new V2TradeOnlinepaymentTransferBankmistakeApplyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000110468104");
            // 交易金额
            request.setTransAmt("0.01");
            // 订单类型
            request.setOrderType("REFUND");
            // 原请求流水号
            request.setOrgReqSeqId("202308312345678931");
            // 原请求日期
            request.setOrgReqDate("20230831");
            // 实际打款日期
            request.setRemitDate("20230615");
            // 实际付款方姓名
            request.setCertificateName("孙洁");
            // 实际付款方银行卡号
            request.setBankCardNo("V2olJv4Srh…………78M8A==");
            // 实际付款方银行名称
            request.setBankName("招商银行");
            // 异步通知地址
            request.setNotifyUrl("http://www.baidu.com");
            // 商品描述
            // request.setGoodsDesc("test");
            // 汇款凭证文件内容
            request.setCertificateContent("/9j/4QCARXhpZgAATU0…………AAB//2Q==");

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
            // 汇款凭证文件名称
            extendInfoMap.Add("file_name", "汇付电子小票验证.jpg");
            // 备注
            extendInfoMap.Add("remark", "大额支付补入账验证");
            // 银行信息数据
            extendInfoMap.Add("bank_info_data", getBankInfoData());
            return extendInfoMap;
        }

        private static string getBankInfoData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 省份对公代发必填，[参见省市地区码](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/area/%E6%96%97%E6%8B%B1%E4%BB%A3%E5%8F%91%E7%9C%81%E4%BB%BD%E5%9C%B0%E5%8C%BA%E7%BC%96%E7%A0%81.xlsx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0013&lt;/font&gt;
            obj.Add("province", "0031");
            // 地区对公代发必填，[参见省市地区码](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/area/%E6%96%97%E6%8B%B1%E4%BB%A3%E5%8F%91%E7%9C%81%E4%BB%BD%E5%9C%B0%E5%8C%BA%E7%BC%96%E7%A0%81.xlsx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1301&lt;/font&gt;
            obj.Add("area", "3100");
            // 银行编号
            obj.Add("bank_code", "03080000");
            // 联行号选填，参见：[银行支行编码](https://paas.huifu.com/partners/api/#/csfl/api_csfl_yhzhbm)； &lt;font color&#x3D;&quot;green&quot;&gt;示例值：102290026507&lt;/font&gt;&lt;br/&gt;对私代发非必填；
            obj.Add("correspondent_code", "103290076178");
            // 对公对私标识
            obj.Add("card_acct_type", "P");
            // 证件类型
            obj.Add("certificate_type", "01");
            // 手机号
            obj.Add("mobile_no", "oO6XYz…………Is3nZb/5dFj860Z+nQ==");
            // 证件号
            obj.Add("certify_no", "yL09mhS5…………WK04Kdfyg==");
            // 支行名
            obj.Add("subbranch_bank_name", "中国农业银行股份有限公司上海联洋支行");
            // 付款方三证合一码
            obj.Add("bank_acct_three_in_one", "92650109MA79R8E308");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
