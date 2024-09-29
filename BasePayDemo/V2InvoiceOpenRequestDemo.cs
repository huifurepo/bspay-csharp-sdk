using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 发票开具 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceOpenRequestDemo
    {

        public static void V2InvoiceOpenRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2InvoiceOpenRequest request = new V2InvoiceOpenRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 渠道号汇付商户号为空时，必传；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812124&lt;/font&gt;
            // request.setChannelId("test");
            // 发票类型
            request.setIvcType("1");
            // 开票类型
            request.setOpenType("0");
            // 购方单位名称
            request.setBuyerName("张三");
            // 含税合计金额(元)
            request.setOrderAmt("70.00");
            // 冲红原因open_type&#x3D;1时必填01：开票有误02：销货退回03：服务终止04：销售转让
            // request.setRedApplyReason("test");
            // 冲红申请来源open_type&#x3D;1时必填01：销方02：购方
            // request.setRedApplySource("test");
            // 原发票代码openType&#x3D;1时必填；参见[发票右上角](https://paas.huifu.com/open/doc/api/#/fp/api_fp_yanglitu.md)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：144032209110&lt;/font&gt;
            request.setOriIvcCode("90222082");
            // 原发票号码openType&#x3D;1时必填；参见[发票右上角](https://paas.huifu.com/open/doc/api/#/fp/api_fp_yanglitu.md)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20685767&lt;/font&gt;
            request.setOriIvcNumber("150000020026");
            // 开票商品信息
            request.setGoodsInfos(getGoodsInfosRc());
            // 开票人信息
            request.setPayerInfo(getPayerInfo());

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
            // 汇付商户号
            extendInfoMap.Add("huifu_id", "6666000107430944");
            // 外部商户号
            extendInfoMap.Add("ext_mer_id", "");
            // 税控盘编号
            extendInfoMap.Add("tax_device_id", "661919694739");
            // 购方单位识别号
            extendInfoMap.Add("buyer_no", "");
            // 购方单位地址
            extendInfoMap.Add("buyer_address", "");
            // 购方单位电话
            extendInfoMap.Add("buyer_tel", "");
            // 购方开户行名称
            extendInfoMap.Add("buyer_bank_name", "");
            // 购方银行账号
            extendInfoMap.Add("buyer_acct_no", "");
            // 购方企业类型
            extendInfoMap.Add("buyer_ent_type", "");
            // 收票人手机号
            extendInfoMap.Add("rec_ivc_phone", "");
            // 收票人邮件
            extendInfoMap.Add("rec_ivc_email", "test@126.com");
            // 备注
            extendInfoMap.Add("resv", "备注");
            // 特殊票种标识
            extendInfoMap.Add("special_flag", "00");
            // 红字信息表编号
            extendInfoMap.Add("red_info_number", "");
            // 开票结果异步通知地址
            extendInfoMap.Add("callback_url", "virgo://http://192.168.85.157:30031/sspm/testVirgo");
            return extendInfoMap;
        }

        private static string getGoodsInfosRc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 发票行性质
            obj.Add("ivc_nature", "0");
            // 商品序号ivc_type&#x3D;1 红票必填，要与开具的蓝票商品一致；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：备注&lt;/font&gt;
            obj.Add("goods_serial_num", "");
            // 商品名称goodsCode不为空时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：&lt;/font&gt;
            obj.Add("goods_name", "预付卡");
            // 税率goodsCode不为空时必填，最多三位小数；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.130&lt;/font&gt;
            obj.Add("tax_rate", "0.03");
            // 金额(元)
            obj.Add("trans_amt", "70.00");
            // 商品id
            obj.Add("goods_id", "");
            // 商品税收分类编码
            obj.Add("goods_code", "6010000000000000000");
            // 规格型号
            obj.Add("goods_model", "");
            // 计量单位
            obj.Add("goods_unit", "");
            // 优惠政策标识
            obj.Add("preferential_flag", "0");
            // 零税率标示
            obj.Add("zero_tax_rate_flag", "");
            // 增值税特殊管理
            obj.Add("add_tax_spec_manage", "");
            // 含税标识
            obj.Add("is_price_con_tax", "1");
            // 商品数量
            obj.Add("goods_count", "7");
            // 单价
            obj.Add("goods_price", "10");
            // 折扣金额(元)
            obj.Add("sale_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getPayerInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开票人
            obj.Add("payer_name", "开票人");
            // 收款人
            obj.Add("payee", "收款人");
            // 复核人
            obj.Add("reviewer", "复核");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
