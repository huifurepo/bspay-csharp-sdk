using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银行卡代发 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettlementSurrogateRequestDemo
    {

        public static void V2TradeSettlementSurrogateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeSettlementSurrogateRequest request = new V2TradeSettlementSurrogateRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000000041651");
            // 代发金额
            request.setCashAmt("9.00");
            // 代发用途描述
            request.setPurposeDesc("v2测试用");
            // 省份选填，参见[代发省市地区码](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/area/%E6%96%97%E6%8B%B1%E4%BB%A3%E5%8F%91%E7%9C%81%E4%BB%BD%E5%9C%B0%E5%8C%BA%E7%BC%96%E7%A0%81.xlsx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0013&lt;/font&gt;&lt;br/&gt;对公代发(省份+地区)与联行号信息二选一填入；对私代发非必填；
            request.setProvince("0278");
            // 地区选填，参见[代发省市地区码](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/area/%E6%96%97%E6%8B%B1%E4%BB%A3%E5%8F%91%E7%9C%81%E4%BB%BD%E5%9C%B0%E5%8C%BA%E7%BC%96%E7%A0%81.xlsx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1301&lt;/font&gt;&lt;br/&gt;对公代发(省份+地区)与联行号信息二选一填入；对私代发非必填；
            request.setArea("2619");
            // 银行编号参考： [银行编码](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_yhbm)； &lt;font color&#x3D;&quot;green&quot;&gt;&lt;br/&gt; 选填 ，card_acct_type&#x3D;E 时必填， 示例值：01040000&lt;/font&gt;
            request.setBankCode("01020000");
            // 联行号选填，参见：[银行支行编码](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_yhzhbm) &lt;font color&#x3D;&quot;green&quot;&gt;示例值：102290026507&lt;/font&gt;&lt;br/&gt;对公代发(省份+地区)与联行号信息二选一填入；对私代发非必填；
            request.setCorrespondentCode("correspondentCode");
            // 银行卡用户名
            request.setBankAccountName("王大锤");
            // 对公对私标识
            request.setCardAcctType("E");
            // 银行账号密文
            request.setBankCardNoCrypt("fM3G4fV8dfyA9GvSPckj7DM/0ZPgIuTrCj5chjRP2np/j+5xBkDp+hGLSskALgMijL837blhwVwfpPstkR2t+0aLtRLC1IpggVKKbNefoqcahF2a4zh+YssAulOoQ6T7DDWTjaa0qzILmLV+J/CCW6ioE+pdsBlGKee7Cc0iD6VqAjkSmnx2kWadz9CpaH8ayvyivdkc87SHsSgexQ5scyZdkGYSpXtRf/rSTcfsf5Q3NP+uKA6lJ0hnESiCw/1POoszJrSlGT2U7jpQLDWVENKcW06bReKxQuAdxFaX4DqkwbQeN5nzHvYh14IU8KrZZDAoiCx12x+IcHIVB2tBmw==");
            // 证件号密文
            request.setCertificateNoCrypt("cw8BlH40+weHiFnIonCiSak1wWeCiRWpMF1cBHhuE+vagzKT37MRvouVboLnaWwIry3joQOoVJipDTPpzAMGVrbLQTdtZoHhgyynnD3MS0NTPch2W4i9dO3/ikLylbs2HitUlCThXEX7DIrIbLLYZ7zzeYUyXAs6dKlehMNxAaF4utJpxV84tB3ZmCKKFairE6+al4Id+/c7536G0j5lKn7lWSawl8A1UEbMMmHFvydGEBgaCAmvu0WEx7llhtPl1GpJnwqieAt9u+lM0cjUGEYfw54/JnmEF3uVuHqjco/EAMKmWiqONqCT4ptBLlOiT15FUejK0iFiUrS0Y3ytMg==");
            // 证件类型
            request.setCertificateType("01");
            // 手机号密文
            request.setMobileNoCrypt("Uc2rjt3iqQMIjUubLKvrE4ynG2XoZDXl4sSqHB7xFvz6EyhS+WMm+tp7WLzG97PqdsmlfURRLjmSR3u98Zz0HV7wO4zvUwdOMzA1rX2Ab9Cz6eKHBWwkRpEn8zmq3KdsHpifKd5y6/MuEyXJ6tdKjBrmXTn3Ut6goz+yhUcPbvV4HEMCybRmF9YTvblb7Yk8trMHjOkq6J6EIEfQL3X07WTNpseCtuYF/j5tNws4boezEmOnS2hNkneMR+OfRaZ6UndFAMHd/Lj9fY2mscpPnWNACtmsD2nh0Z8ziwzCYnYAH2EV988cSq2vi3fkgCtd5b8zNGp+XJBefPaK7Vcp+w==");
            // 到账日期类型
            request.setIntoAcctDateType("T0");

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
            // 支行名
            extendInfoMap.Add("subbranch_bank_name", "subbranchBankName");
            // 收款方三证合一码
            extendInfoMap.Add("bank_acct_three_in_one", "dfa");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.gangcai.com");
            return extendInfoMap;
        }

    }
}
