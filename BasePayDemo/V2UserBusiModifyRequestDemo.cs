using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 用户业务入驻修改 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2UserBusiModifyRequestDemo
    {

        public static void V2UserBusiModifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2UserBusiModifyRequest request = new V2UserBusiModifyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 渠道商汇付Id
            request.setUpperHuifuId("6666000104633228");
            // 汇付ID
            request.setHuifuId("6666000104896342");

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
            extendInfoMap.Add("settle_config", getSettleConfig());
            // 结算卡信息
            extendInfoMap.Add("card_info", getCardInfo());
            // 取现配置列表
            extendInfoMap.Add("cash_config", getCashConfig());
            // 文件列表
            extendInfoMap.Add("file_list", getFileList());
            // 延迟入账开关
            // extendInfoMap.Add("delay_flag", "");
            // 异步请求地址
            extendInfoMap.Add("async_return_url", "//http://service.example.com/to/path");
            return extendInfoMap;
        }

        private static string getSettleConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开通状态
            obj.Add("settle_status", "1");
            // 结算周期
            obj.Add("settle_cycle", "D1");
            // 结算批次号settle_pattern为P0时选填；&lt;br/&gt;0点昨日余额结算批次:0,&lt;/br&gt;1点余额结算批次:100,&lt;/br&gt;2点余额结算批次:200,&lt;/br&gt;3点余额结算批次:300,&lt;/br&gt;4点余额结算批次:400,&lt;/br&gt;5点余额结算批次:500,&lt;/br&gt;6点余额结算批次:600,&lt;/br&gt;7点余额结算批次:700,&lt;/br&gt;8点余额结算批次:800,&lt;/br&gt;9点余额结算批次:900,&lt;/br&gt;10点余额结算批次:1000,&lt;/br&gt;11点余额结算批次:1100,&lt;/br&gt;12点余额结算批次:1200&lt;/br&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1000&lt;/font&gt;
            obj.Add("settle_batch_no", "0");
            // 是否优先到账settle_pattern为P0时选填， Y：是 N：否（为空默认取值）；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：Y&lt;/font&gt;
            obj.Add("is_priority_receipt", "Y");
            // 自定义结算处理时间settle_pattern为P1时必填， 格式：HHmmss；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：103000&lt;/font&gt;
            obj.Add("settle_time", "");
            // 节假日结算手续费率(%)
            obj.Add("fixed_ratio", "0.1");
            // 起结金额
            obj.Add("min_amt", "0.1");
            // 结算手续费外扣时的账户类型
            obj.Add("out_settle_acct_type", "05");
            // 手续费外扣标记
            obj.Add("out_settle_flag", "1");
            // 结算手续费外扣时的汇付ID
            obj.Add("out_settle_huifuid", "6666000104633228");
            // 留存金额
            obj.Add("remained_amt", "0.1");
            // 结算摘要
            obj.Add("settle_abstract", "吃吃");
            // 结算方式
            obj.Add("settle_pattern", "P0");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCardInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡类型
            obj.Add("card_type", "0");
            // 卡户名
            obj.Add("card_name", "陈立一");
            // 卡号
            obj.Add("card_no", "6217001210064762000");
            // 银行所在省
            obj.Add("prov_id", "310000");
            // 银行所在市
            obj.Add("area_id", "310100");
            // 银行号对公时必填，对私可以为空；[参见银行编码](https://paas.huifu.com/partners/api/#/csfl/api_csfl_yhbm)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01020000&lt;/font&gt;
            obj.Add("bank_code", "01050000");
            // 支行联行号对公时联行号、支行名称二选一必填，[点击查看](https://paas.huifu.com/partners/api/#/csfl/api_csfl_yhzhbm)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：102290026507&lt;/font&gt;
            obj.Add("branch_code", "105305264815");
            // 支行名称对公时联行号、支行名称二选一必填，&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：中国工商银行上海市中山北路支行&lt;/font&gt;
            obj.Add("branch_name", "中国建设银行股份有限公司上海平凉路支行");
            // 持卡人证件类型
            obj.Add("cert_type", "00");
            // 持卡人证件号码
            obj.Add("cert_no", "110101197003077000");
            // 持卡人证件有效期类型
            obj.Add("cert_validity_type", "0");
            // 持卡人证件有效期起始日期
            obj.Add("cert_begin_date", "20210806");
            // 持卡人证件有效期截止日期
            obj.Add("cert_end_date", "20410806");
            // 银行卡绑定手机号
            obj.Add("mp", "15556622000");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getCashConfig() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开通状态
            obj.Add("switch_state", "1");
            // 取现手续费率（%）fix_amt与fee_rate至少填写一项，单位%，需保留小数点后两位，取值范围[0.00,100.00]，不收费请填写0.00；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.05&lt;/font&gt;&lt;br/&gt;注：如果fix_amt与fee_rate都填写了则手续费&#x3D;fix_amt+支付金额\*fee_rate
            obj.Add("fee_rate", "0.05");
            // 业务类型
            obj.Add("cash_type", "D0");
            // 提现手续费（固定/元）
            obj.Add("fix_amt", "3");
            // 是否交易手续费外扣
            obj.Add("out_fee_flag", "1");
            // 手续费承担方
            obj.Add("out_fee_huifu_id", "6666000104633228");
            // 交易手续费外扣的账户类型
            obj.Add("out_fee_acct_type", "05");
            // 是否优先到账
            // obj.Add("is_priority_receipt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getFileList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件类型
            obj.Add("file_type", "F02");
            // 文件jfileID
            obj.Add("file_id", "99e00421-dad7-3334-9538-4f2ad10612d5");
            // 文件名称
            obj.Add("file_name", "企业营业执照1.jpg");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
