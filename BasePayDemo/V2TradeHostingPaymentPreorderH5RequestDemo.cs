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
            request.setGoodsDesc("个人电脑");
            // 预下单类型
            request.setPreOrderType("1");
            // 统一收银台扩展参数集合
            request.setHostingData(get29ce328014e44a04Ba34089b50c93254());

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
            // 是否延迟交易
            extendInfoMap.Add("delay_acct_flag", "N");
            // 是否支持切换支付方式
            // extendInfoMap.Add("multi_pay_way_flag", "");
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", get005c7da916154564851790c84fa499d8());
            // 交易失效时间
            // extendInfoMap.Add("time_expire", "");
            // 业务信息
            extendInfoMap.Add("biz_info", getAe2838a976da4a67927f0013169b2972());
            // 交易异步通知地址
            extendInfoMap.Add("notify_url", "https://callback.service.com/xx");
            // 使用类型
            // extendInfoMap.Add("usage_type", "");
            // 交易类型
            // extendInfoMap.Add("trans_type", "");
            // 微信参数集合
            // extendInfoMap.Add("wx_data", get74b1cc9b796348d6Bd4d162a489b37d2());
            // 支付宝参数集合
            // extendInfoMap.Add("alipay_data", get546f7a5344f4490eB3b9D40b41fd6718());
            // 抖音参数集合
            // extendInfoMap.Add("dy_data", get0ee9ad37Af094c979cbbD3543fcb5814());
            // 银联参数集合
            // extendInfoMap.Add("unionpay_data", get50d967093e184280B38262a6fb5fd16a());
            // 设备信息
            // extendInfoMap.Add("terminal_device_data", get07df0303Af0f43479da035683eadf683());
            // 大额支付参数集合
            // extendInfoMap.Add("largeamt_data", get0cbbfab1Dc17405eBae9606a530f5312());
            // 手续费场景标识
            // extendInfoMap.Add("fee_sign", "");
            // 是否交易手续费分摊
            // extendInfoMap.Add("fee_split_flag", "");
            // 手续费扣款标志
            // extendInfoMap.Add("fee_flag", "");
            // 渠道号
            // extendInfoMap.Add("channel_no", "");
            // 场景类型
            // extendInfoMap.Add("pay_scene", "");
            // 
            // extendInfoMap.Add("", "");
            return extendInfoMap;
        }

        private static object get731f1620F32e47cc82102a6511caa6cc() {
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
        private static string get005c7da916154564851790c84fa499d8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", get731f1620F32e47cc82102a6511caa6cc());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get29ce328014e44a04Ba34089b50c93254() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 项目标题
            obj.Add("project_title", "收银台标题");
            // 项目号
            obj.Add("project_id", "PROJECTID2023101225142567");
            // 请求类型P:PC页面版，默认：P；M:H5页面版；指定交易类型时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：M&lt;/font&gt;
            // obj.Add("request_type", "test");
            // 商户私有信息
            obj.Add("private_info", "商户私有信息test");
            // 回调地址
            obj.Add("callback_url", "https://paas.huifu.com");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getFffccda98ffc4cbfAdad8b9d3cbee2c4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否提供校验身份信息
            obj.Add("need_check_info", "T");
            // 允许的最小买家年龄
            obj.Add("min_age", "12");
            // 是否强制校验付款人身份信息
            obj.Add("fix_buyer", "F");

            return obj;
        }
        private static object get5615d9b54e8542c7A0161308c69246a8() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 指定支付者
            obj.Add("limit_payer", "ADULT");
            // 微信实名验证
            obj.Add("real_name_flag", "Y");

            return obj;
        }
        private static object get3600ab5f99ad4cea92d3770e80b647c5() {
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
        private static string getAe2838a976da4a67927f0013169b2972() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 付款人验证（支付宝）
            obj.Add("payer_check_ali", getFffccda98ffc4cbfAdad8b9d3cbee2c4());
            // 付款人验证（微信）
            obj.Add("payer_check_wx", get5615d9b54e8542c7A0161308c69246a8());
            // 个人付款人信息
            obj.Add("person_payer", get3600ab5f99ad4cea92d3770e80b647c5());

            return JsonConvert.SerializeObject(obj);
        }
        private static object getF2e57e8e206a49a2B2274b1b5377c67c() {
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
        private static object getA93f7ae5B9844237821d1c86240dc6ba() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 单品列表
            // obj.Add("goods_detail", getF2e57e8e206a49a2B2274b1b5377c67c());
            // 订单原价(元)
            // obj.Add("cost_price", "");
            // 商品小票ID
            // obj.Add("receipt_id", "");

            return obj;
        }
        private static object getB6eb8ca3832f4f48A86d17abbb0ae6aa() {
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
        private static object get62dbf1f58573482aBd61D3d86d2dd878() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店信息
            // obj.Add("store_info", getB6eb8ca3832f4f48A86d17abbb0ae6aa());

            return obj;
        }
        private static string get74b1cc9b796348d6Bd4d162a489b37d2() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 附加数据
            // obj.Add("attach", "");
            // 商品详情
            // obj.Add("detail", getA93f7ae5B9844237821d1c86240dc6ba());
            // 订单优惠标记
            // obj.Add("goods_tag", "");
            // 开发票入口开放标识
            // obj.Add("receipt", "");
            // 场景信息
            // obj.Add("scene_info", get62dbf1f58573482aBd61D3d86d2dd878());
            // 单品优惠标识
            // obj.Add("promotion_flag", "");
            // 新增商品ID
            // obj.Add("product_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get7fe45454C92e4a2cB2deD99bd5cc6ccc() {
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
        private static object get2330dbbbC2814cc89ee574dd672b17d5() {
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
        private static string get546f7a5344f4490eB3b9D40b41fd6718() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付宝的店铺编号
            // obj.Add("alipay_store_id", "");
            // 业务扩展参数
            // obj.Add("extend_params", get7fe45454C92e4a2cB2deD99bd5cc6ccc());
            // 订单包含的商品列表信息
            // obj.Add("goods_detail", get2330dbbbC2814cc89ee574dd672b17d5());
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
            // 商户贴息标记
            // obj.Add("fq_mer_discount_flag", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object getBeba017b8c6d49ffB843097fe9dd835a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 场景类型
            // obj.Add("type", "test");
            // 应用名称
            // obj.Add("app_name", "");
            // 网站URL
            // obj.Add("app_url", "");
            // iOS平台BundleID
            // obj.Add("bundle_id", "");
            // Android平台PackageName
            // obj.Add("package_name", "");

            return obj;
        }
        private static object get5fa98f68993745fdA8d2Ff02c378ecb4() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 用户终端IP
            // obj.Add("payer_client_ip", "test");

            return obj;
        }
        private static string get0ee9ad37Af094c979cbbD3543fcb5814() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 子商户应用ID
            // obj.Add("sub_appid", "test");
            // H5场景信息
            // obj.Add("h5_info", getBeba017b8c6d49ffB843097fe9dd835a());
            // 场景信息
            // obj.Add("scene_info", get5fa98f68993745fdA8d2Ff02c378ecb4());
            // 优惠标记
            // obj.Add("coupon_info", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get3b19e57c8e76420383679950003a7739() {
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
        private static string get426ad9f717b241bf916e9756b0f9a126() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 服务商订单编号
            // obj.Add("pnr_order_id", "");
            // 服务商密文
            // obj.Add("pid_sct", "");
            // 场景标识
            // obj.Add("trade_scene", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get50d967093e184280B38262a6fb5fd16a() {
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
            // obj.Add("payee_info", get3b19e57c8e76420383679950003a7739());
            // 银联分配的服务商机构标识码
            // obj.Add("pnr_ins_id_cd", "");
            // 请求方自定义域
            // obj.Add("req_reserved", "");
            // 终端信息
            // obj.Add("term_info", "");
            // 服务商信息
            // obj.Add("pid_info", get426ad9f717b241bf916e9756b0f9a126());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get07df0303Af0f43479da035683eadf683() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 汇付机具号
            // obj.Add("devs_id", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get0cbbfab1Dc17405eBae9606a530f5312() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 付款方名称
            // obj.Add("certificate_name", "");
            // 付款方银行卡号
            // obj.Add("bank_card_no", "");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
