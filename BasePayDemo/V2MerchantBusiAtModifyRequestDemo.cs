using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信支付宝入驻信息修改 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiAtModifyRequestDemo
    {

        public static void V2MerchantBusiAtModifyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBusiAtModifyRequest request = new V2MerchantBusiAtModifyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // AT信息修改列表
            request.setAtRegList(getAtRegList());

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
            // 业务开通结果异步消息接收地址
            extendInfoMap.Add("busi_async_return_url", "http://service.example.com/to/path");
            // 支付成功页商户LOGO图片
            // extendInfoMap.Add("ali_mer_logo", "");
            return extendInfoMap;
        }

        private static string getAtRegList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户汇付ID
            obj.Add("huifu_id", "6666000***456098");
            // 产品号
            obj.Add("product_id", "ZDTEST");
            // 业务开通类型
            obj.Add("fee_type", "03");
            // 支付通道
            obj.Add("pay_way", "W");
            // 子渠道号
            obj.Add("pay_channel_id", "JP00001");
            // 经营简称
            obj.Add("short_name", "盈盈超市3.0");
            // 客服电话
            obj.Add("service_phone", "1752***5001");
            // 商户名称
            // obj.Add("mer_name", "");
            // 营业执照类型
            // obj.Add("business_license_type", "");
            // 商户营业执照号
            // obj.Add("license_code", "");
            // 法人身份证号
            // obj.Add("legal_cert_no", "");
            // 行业分类
            // obj.Add("cls_id", "");
            // 申请服务
            // obj.Add("service_codes", "");
            // 结算卡
            // obj.Add("settle_card_no", "");
            // 结算卡户名
            // obj.Add("settle_card_name", "");
            // 商户结算卡开卡行支行名称
            // obj.Add("mer_card_bank_branch_name", "");
            // 支付宝登录账号
            // obj.Add("alipay_account", "");
            // 联系人类型
            // obj.Add("contact_type", "");
            // 联系人姓名
            // obj.Add("contact_name", "");
            // 联系人手机号
            // obj.Add("contact_mobile", "");
            // 联系人邮箱
            // obj.Add("contact_email", "");
            // 商户地址
            // obj.Add("mer_addr", "");
            // 省份编码
            // obj.Add("province_code", "");
            // 城市编码
            // obj.Add("city_code", "");
            // 区县编码
            // obj.Add("district_code", "");
            // 拟申请的间联商户等级
            // obj.Add("indirect_level", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
