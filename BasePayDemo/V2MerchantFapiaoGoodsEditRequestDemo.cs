using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 开票商品修改 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantFapiaoGoodsEditRequestDemo
    {

        public static void V2MerchantFapiaoGoodsEditRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantFapiaoGoodsEditRequest request = new V2MerchantFapiaoGoodsEditRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 汇付商户号
            request.setHuifuId("6666000123123123");
            // 商品id
            request.setGoodsId("G558461047849918464");
            // 是否默认
            request.setIsDefault("Y");

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
            // 商品名称
            extendInfoMap.Add("goods_name", "irure aliqua dolore sed");
            // 税率
            extendInfoMap.Add("tax_rate", "1");
            // 订单商品明细
            extendInfoMap.Add("order_goods_detail", "你好");
            // 规格型号
            extendInfoMap.Add("goods_model", "12345678901234567890123456789012");
            // 计量单位
            extendInfoMap.Add("goods_unit", "2");
            // 单价
            extendInfoMap.Add("goods_price", "2");
            // 含税标识
            extendInfoMap.Add("is_price_con_tax", "0");
            // 优惠政策标识
            extendInfoMap.Add("preferential_flag", "0");
            // 零税率标示
            extendInfoMap.Add("zero_tax_rate_flag", "");
            // 增值税特殊管理
            extendInfoMap.Add("add_tax_spec_manage", "");
            // 说明
            extendInfoMap.Add("ivc_remark", "sss");
            // 生效状态
            extendInfoMap.Add("stat", "N");
            return extendInfoMap;
        }

    }
}
