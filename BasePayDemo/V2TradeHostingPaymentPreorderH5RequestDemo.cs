using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * H5、PC预下单接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentPreorderH5RequestDemo
    {

        public static void V2TradeHostingPaymentPreorderH5RequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeHostingPaymentPreorderH5Request request = new V2TradeHostingPaymentPreorderH5Request();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000109133323");
            // 交易金额
            request.setTransAmt("0.10");
            // 商品描述
            request.setGoodsDesc("支付托管消费");
            // 预下单类型
            request.setPreOrderType("1");
            // 半支付托管扩展参数集合
            request.setHostingData(get09d88dfbDf114c75A78215a3f7d5763b());

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
            // 收款汇付账户号
            // extendInfoMap.Add("acct_id", "");
            // 收银台样式
            // extendInfoMap.Add("style_id", "");
            // 是否延迟交易
            extendInfoMap.Add("delay_acct_flag", "N");
            // 是否支持切换支付方式
            // extendInfoMap.Add("multi_pay_way_flag", "");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", getEd3159f3265f4b4988c2Fdfb3fc748c5());
            // 交易失效时间
            // extendInfoMap.Add("time_expire", "");
            // 业务信息
            extendInfoMap.Add("biz_info", getE85a3937837c48589c443c2beca86303());
            // 交易异步通知地址
            extendInfoMap.Add("notify_url", "https://callback.service.com/xx");
            // 使用类型
            // extendInfoMap.Add("usage_type", "");
            // 交易类型
            // extendInfoMap.Add("trans_type", "");
            // 微信参数集合
            // extendInfoMap.Add("wx_data", get30117b1cBb8e49a4855575d068bf7a33());
            // 支付宝参数集合
            // extendInfoMap.Add("alipay_data", get616f9db224ed4bcb9b03Add178fe3b38());
            // 银联参数集合
            // extendInfoMap.Add("unionpay_data", get261e0fe676ef4092A9edFbe3b6cf7882());
            // 设备信息
            // extendInfoMap.Add("terminal_device_data", getF326b5a0E9424032A2c05a1c1a6ed619());
            // 大额支付参数集合
            // extendInfoMap.Add("largeamt_data", get64d1afd9A9a1415684c5414bdba18796());
            // 手续费场景标识
            // extendInfoMap.Add("fee_sign", "");
            return extendInfoMap;
        }

        private static object get86977942Dde94776945bF2362fcbc81b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "0.08");
            // 分账接收方ID
            obj.Add("huifu_id", "6666000111546360");
            // 收款汇付账户号
            // obj.Add("acct_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string getEd3159f3265f4b4988c2Fdfb3fc748c5() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", get86977942Dde94776945bF2362fcbc81b());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get09d88dfbDf114c75A78215a3f7d5763b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 项目标题
            obj.Add("project_title", "收银台标题");
            // 半支付托管项目号
            obj.Add("project_id", "PROJECTID2023101225142567");
            // 请求类型P:PC页面版，默认：P；M:H5页面版；指定交易类型时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：M&lt;/font&gt;
            // obj.Add("request_type", "test");
            // 商户私有信息
            obj.Add("private_info", "商户私有信息test");
            // 回调地址
            obj.Add("callback_url", "https://paas.huifu.com");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get83e8e4baA9dd436aBbb350e29de7ded5() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否提供校验身份信息
            obj.Add("need_check_info", "T");
            // 允许的最小买家年龄
            obj.Add("min_age", "12");
            // 是否强制校验付款人身份信息
            obj.Add("fix_buyer", "F");

            return obj;
        }
        private static object getDa7302beA9b04712B615C58cdbe3b063() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 指定支付者
            obj.Add("limit_payer", "ADULT");
            // 微信实名验证
            obj.Add("real_name_flag", "Y");

            return obj;
        }
        private static object get02e34fc880ca40ab8a92C17c422dce9a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 姓名
            obj.Add("name", "张三");
            // 证件类型
            obj.Add("cert_type", "IDENTITY_CARD");
            // 证件号
            obj.Add("cert_no", "OLOxrl809XmVIMmPRTIyIpJHxi4HFMJNmxGz1nhZAtps9xPEVDysU3UZPBZfsNFLFcXEMENPsJ+tymbYt42dNQ+76hyEtx+qz0BQhU8SKV8H5itrI4kaXpaJf+sV8OewrJkhDidPdz01vqMEDQRhaMnNwl8snHZxDdpu7HVUz5JwsLYfBbZP2Q4CZpVWS3NunQahZ8zHQ+8EhvYVH1vE7f/M6nJt1/4GoHz9C/UnuYudV0S2uBhlywbX+YkRGNMl/oz5+UNeMDA2jqhtTreSD4+w7S82L53rqKsAbosodOPo4OAMZk4/0QOH5LDbqFByVM97mzHfw7z+Tx/dsXJ8QQ==");
            // 手机号
            obj.Add("mobile", "15012345678");

            return obj;
        }
        private static string getE85a3937837c48589c443c2beca86303() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 付款人验证（支付宝）
            obj.Add("payer_check_ali", get83e8e4baA9dd436aBbb350e29de7ded5());
            // 付款人验证（微信）
            obj.Add("payer_check_wx", getDa7302beA9b04712B615C58cdbe3b063());
            // 个人付款人信息
            obj.Add("person_payer", get02e34fc880ca40ab8a92C17c422dce9a());

            return JsonConvert.SerializeObject(obj);
        }
        private static object get2841c5f775ef4857A3d3641da0bf5986() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品编码
            // obj.Add("goods_id", "");
            // 商品名称
            // obj.Add("goods_name", "");
            // 商品单价(元)
            // obj.Add("price", "");
            // 商品数量
            // obj.Add("quantity", "");
            // 微信侧商品编码
            // obj.Add("wxpay_goods_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static object get5f223a2753a64f2cBf03Dafdece4d787() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 单品列表
            // obj.Add("goods_detail", get2841c5f775ef4857A3d3641da0bf5986());
            // 订单原价(元)
            // obj.Add("cost_price", "");
            // 商品小票ID
            // obj.Add("receipt_id", "");

            return obj;
        }
        private static object getE1aabf110dd443c397f92dd5e432ba73() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店id
            // obj.Add("id", "");
            // 门店名称
            // obj.Add("name", "");
            // 门店行政区划码
            // obj.Add("area_code", "");
            // 门店详细地址
            // obj.Add("address", "");

            return obj;
        }
        private static object get1d88ffc55f4d4a13A5090111c6f573fa() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店信息
            // obj.Add("store_info", getE1aabf110dd443c397f92dd5e432ba73());

            return obj;
        }
        private static string get30117b1cBb8e49a4855575d068bf7a33() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 附加数据
            // obj.Add("attach", "");
            // 商品详情
            // obj.Add("detail", get5f223a2753a64f2cBf03Dafdece4d787());
            // 订单优惠标记
            // obj.Add("goods_tag", "");
            // 开发票入口开放标识
            // obj.Add("receipt", "");
            // 场景信息
            // obj.Add("scene_info", get1d88ffc55f4d4a13A5090111c6f573fa());
            // 单品优惠标识
            // obj.Add("promotion_flag", "");
            // 新增商品ID
            // obj.Add("product_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get9e16bb9d777d494cAeff02b53ad6dbc7() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 卡类型
            // obj.Add("card_type", "");
            // 支付宝点餐场景类型
            // obj.Add("food_order_type", "");
            // 花呗分期数
            // obj.Add("hb_fq_num", "");
            // 花呗卖家手续费百分比
            // obj.Add("hb_fq_seller_percent", "");
            // 行业数据回流信息
            // obj.Add("industry_reflux_info", "");
            // 信用卡分期资产方式
            // obj.Add("fq_channels", "");
            // 停车场id
            // obj.Add("parking_id", "");
            // 系统商编号
            // obj.Add("sys_service_provider_id", "");

            return obj;
        }
        private static object get64bf68b26e7f4c1e8954C382d9fab3b1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商品的编号
            // obj.Add("goods_id", "test");
            // 商品名称
            // obj.Add("goods_name", "test");
            // 商品单价(元)
            // obj.Add("price", "test");
            // 商品数量
            // obj.Add("quantity", "test");
            // 商品描述信息
            // obj.Add("body", "");
            // 商品类目树
            // obj.Add("categories_tree", "");
            // 商品类目
            // obj.Add("goods_category", "");
            // 商品的展示地址
            // obj.Add("show_url", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get616f9db224ed4bcb9b03Add178fe3b38() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付宝的店铺编号
            // obj.Add("alipay_store_id", "");
            // 业务扩展参数
            // obj.Add("extend_params", get9e16bb9d777d494cAeff02b53ad6dbc7());
            // 订单包含的商品列表信息
            // obj.Add("goods_detail", get64bf68b26e7f4c1e8954C382d9fab3b1());
            // 商户原始订单号
            // obj.Add("merchant_order_no", "");
            // 商户操作员编号
            // obj.Add("operator_id", "");
            // 销售产品码
            // obj.Add("product_code", "");
            // 卖家支付宝用户号
            // obj.Add("seller_id", "");
            // 商户门店编号
            // obj.Add("store_id", "");
            // 订单标题
            // obj.Add("subject", "");
            // 商家门店名称
            // obj.Add("store_name", "");
            // 商户业务信息
            // obj.Add("ali_business_params", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get94660e62B04d47b188e30003e47743d8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户类别
            // obj.Add("mer_cat_code", "");
            // 二级商户代码
            // obj.Add("sub_id", "");
            // 二级商户名称
            // obj.Add("sub_name", "");
            // 终端号
            // obj.Add("term_id", "");

            return obj;
        }
        private static string get261e0fe676ef4092A9edFbe3b6cf7882() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 收款方附加数据
            // obj.Add("addn_data", "");
            // 地区信息
            // obj.Add("area_info", "");
            // 前台通知地址
            // obj.Add("front_url", "");
            // 收款方附言
            // obj.Add("payee_comments", "");
            // 收款方信息
            // obj.Add("payee_info", get94660e62B04d47b188e30003e47743d8());
            // 银联分配的服务商机构标识码
            // obj.Add("pnr_ins_id_cd", "");
            // 请求方自定义域
            // obj.Add("req_reserved", "");
            // 终端信息
            // obj.Add("term_info", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getF326b5a0E9424032A2c05a1c1a6ed619() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 汇付机具号
            // obj.Add("devs_id", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get64d1afd9A9a1415684c5414bdba18796() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 付款方名称
            // obj.Add("certificate_name", "");
            // 付款方银行卡号
            // obj.Add("bank_card_no", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
