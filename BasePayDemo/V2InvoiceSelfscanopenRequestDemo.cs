using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 自助扫码开票 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2InvoiceSelfscanopenRequestDemo
    {

        public static void V2InvoiceSelfscanopenRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2InvoiceSelfscanopenRequest request = new V2InvoiceSelfscanopenRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付商户号
            request.setHuifuId("6666000103675282");
            // 发票类型
            // request.setIvcType("test");
            // 开票类型
            // request.setOpenType("test");
            // 含税合计金额（元）
            // request.setOrderAmt("test");
            // 开票商品信息
            // request.setGoodsInfos(getGoodsInfosRc());
            // 开票人信息
            // request.setPayerInfo(getPayerInfo());

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
            // 税控盘编号
            // extendInfoMap.Add("tax_device_id", "");
            // 备注
            // extendInfoMap.Add("resv", "");
            // 特殊票种标识
            // extendInfoMap.Add("special_flag", "");
            // 开票结果异步通知地址
            // extendInfoMap.Add("callback_url", "");
            return extendInfoMap;
        }

        private static string getGoodsInfosRc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 发票行性质
            // obj.Add("ivc_nature", "test");
            // 商品名称goods_code不为空时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：电视机&lt;/font&gt;
            // obj.Add("goods_name", "test");
            // 税率goods_code不为空时必填，最多三位小数 如：税率13% 则传入&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.13&lt;/font&gt;
            // obj.Add("tax_rate", "test");
            // 金额（元）
            // obj.Add("trans_amt", "test");
            // 商品id
            // obj.Add("goods_id", "");
            // 商品税收分类编码
            // obj.Add("goods_code", "");
            // 规格型号
            // obj.Add("goods_model", "");
            // 计量单位
            // obj.Add("goods_unit", "");
            // 优惠政策标识
            // obj.Add("preferential_flag", "");
            // 零税率标示
            // obj.Add("zero_tax_rate_flag", "");
            // 增值税特殊管理
            // obj.Add("add_tax_spec_manage", "");
            // 含税标识
            // obj.Add("is_price_con_tax", "");
            // 数量
            // obj.Add("goods_count", "");
            // 单价
            // obj.Add("goods_price", "");
            // 折扣金额(元)
            // obj.Add("sale_amt", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getPayerInfo() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开票人
            // obj.Add("payer_name", "test");
            // 收款人
            // obj.Add("payee", "");
            // 复核人
            // obj.Add("reviewer", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
