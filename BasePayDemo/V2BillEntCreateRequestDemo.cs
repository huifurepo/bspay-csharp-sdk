using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 创建企业账单 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2BillEntCreateRequestDemo
    {

        public static void V2BillEntCreateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2BillEntCreateRequest request = new V2BillEntCreateRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000003100615");
            // 付款人
            request.setPayerId("P2024082286286456");
            // 账单名称
            request.setBillName("账单名称是水电费吧");
            // 账单金额
            request.setBillAmt("0.02");
            // 可支持的付款方式
            request.setSupportPayType("wx,alipay,online_b2c,online_b2b");
            // 账单截止日期
            request.setBillEndDate("20990909");
            // 收款人信息
            request.setPayeeInfo(getPayeeInfo());

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
            // 账单说明
            extendInfoMap.Add("bill_remark", "您本次 SaaS 服务周期为[开始日期]至[结束日期]。费用包括基础服务套餐[X]元，高级功能模块[X]元，总计[X]元。");
            // 汇总信息
            // extendInfoMap.Add("bill_summary_info", "");
            // 更多信息
            // extendInfoMap.Add("bill_extend_info", getBillExtendInfo());
            // 账单推送方式
            extendInfoMap.Add("push_type", "EMAIL");
            // 抄送邮箱
            extendInfoMap.Add("copy_email", "xuemei.ren@huifu.com,guowen.jiang@huifu.com");
            // 备注信息
            extendInfoMap.Add("remark", "I_remark");
            // 账单信息异步通知地址
            extendInfoMap.Add("notify_url", "https://spin-test.cloudpnr.com/trade/billing/pcredit/status");
            // 回调地址
            extendInfoMap.Add("front_url", "https://spin-test.cloudpnr.com/trade/billing/pcredit/status");
            return extendInfoMap;
        }

        private static string getBillExtendInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 字段名
            // obj.Add("extend_name", "test");
            // 字段值
            // obj.Add("extend_value", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getPayeeInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 收款联系人姓名
            obj.Add("payee_name", "黄云");
            // 收款联系人手机payee_mobile_no、payee_tel、payee_email 三选一必填
            obj.Add("payee_mobile_no", "13456787678");
            // 收款联系人座机payee_mobile_no、payee_tel、payee_email 三选一必填
            obj.Add("payee_tel", "0211234444");
            // 收款联系人邮箱payee_mobile_no、payee_tel、payee_email 三选一必填
            obj.Add("payee_email", "lieecho@163.com");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
