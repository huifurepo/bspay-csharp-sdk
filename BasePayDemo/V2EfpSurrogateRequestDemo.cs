using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 全渠道资金付款申请 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2EfpSurrogateRequestDemo
    {

        public static void V2EfpSurrogateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2EfpSurrogateRequest request = new V2EfpSurrogateRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付id
            request.setHuifuId("6666000108422302");
            // 交易金额.单位:元，2位小数
            request.setCashAmt("0.01");
            // 银行账号
            request.setCardNo("cDH2Gq/a7PnrH5tvA6JNEFEcLewpEW3x5cRiyJRUEwpoqTMmp74ObRCJCarqKPRnMrnHbXfa1WGAXW24f6SLiDKqCdI0zc5+tQtKBXS5Kh/mfmJIDNU710i5IDs+7luEIpRrsppg6YJejRhGY0TvPVY19dRaJ3KxIeyTkUDv/9KEb8TELxm2GBgfiFlKVPKxf95WpaZWV2kT3rh0ddJXA9YgUvHcTcEEY7GeCv5OHOaquIcP38kv27ZL2rScqgGpmluhyevPtDmvXRkdGK68IfNnWeqfCRjDAdVqcMskTb5Ajq8dtnNlx7uuSwYYKBeJKCzoPX8SE5X+f/9d62Cutw==");
            // 银行编号
            request.setBankCode("01050000");
            // 银行卡用户名
            request.setCardName("交通银行股份有限公司");
            // 对公对私标识
            request.setCardAcctType("E");
            // 省份
            request.setProvId("310000");
            // 地区
            request.setAreaId("310100");
            // 手机号对私必填，使用斗拱系统的公钥对手机号进行RSA加密得到秘文；  示例值：b9LE5RccVVLChrHgo9lvp……PhWhjKrWg2NPfbe0mkUDd
            request.setMobileNo("AJnlbnjQcbTgyDv2NSNdVpMlpE5PkMqtppZj1AQ7yxAbvPhWHwHUzq7J+6C8PIrsHWwI6iwAo07N77zUIbMmORzRY1eENJ9intq0/nGEbRDQ3s6EtV/AXVUR9Pv+GOqetpX5Yi+htEbpKObW8V+jEUngz4L08E5VsPLSjmLKeLkVXGKiMr8jeZf/+QAhDiJFyi533dxHL+KPT0qCa3iebau1NXy17sZm4izmeYf35LxTlgZbQdxhC50z3zlkhZvMsArtod1CmlzI+SB5T3bwqpVkR22o6BkTbLrqBZp+zz5x99o6sqIEKMrwKYjDOJ0UjYsjn+KFTa+PFvJzstmqhg==");
            // 证件类型
            request.setCertType("11");
            // 证件号
            request.setCertNo("KbQ+WwhycbCOeIbrB+pH+eEsJPcYo2Q1IhMUQosshs00qy7hor+CA71bZLMazVOuFkeJxex9BfhR9W2hQNbRaqdWI4yxkDOTw9Qkx1PDTDl/n8CXpxWqQKhObCE5UEd5b+M/wWe+iKNYGcJkcoyswHdMA8kZoezxqwVUi0tbq//1Ov+kTyMVhmIwNbWJpahDvS+f780opCAtlMbz9hl25EcPpeTtNgbruKY+jeO4j6oejFK0epg616uC9jQalryERsX4EjaLqQrtd5nwZBkASc5Up56xkVqvaOo+6hFQP/KbCymxWbM3J0/PFsJtv/CPM4+9JkWusX/Q1ZEH8wdZ+A==");
            // 统一社会信用代码对公必填
            request.setLicenceCode("9131000010000595XD");
            // 挂网协议地址
            request.setAgreementUrl("https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/dg_gwxy/PaymentServiceAgreement_surrogate_20241113.html");

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
            // 原请求流水号
            extendInfoMap.Add("efp_req_seq_id", "20241128164919defaultit687891821");
            // 原请求日期
            extendInfoMap.Add("efp_req_date", "20241128");
            // 联行号
            extendInfoMap.Add("branch_code", "");
            // 备注
            extendInfoMap.Add("remark", "saas申请付款");
            // 异步通知地址
            extendInfoMap.Add("notify_url", "http://www.service.com/getresp");
            return extendInfoMap;
        }

    }
}
