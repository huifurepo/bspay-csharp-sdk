using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 微信小程序预下单接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeHostingPaymentPreorderWxRequestDemo
    {

        public static void V2TradeHostingPaymentPreorderWxRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeHostingPaymentPreorderWxRequest request = new V2TradeHostingPaymentPreorderWxRequest();
            // 预下单类型
            request.setPreOrderType("3");
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 商户号
            request.setHuifuId("6666000109133323");
            // 交易金额
            request.setTransAmt("0.13");
            // 商品描述
            request.setGoodsDesc("app跳微信消费");
            // 微信小程序扩展参数集合
            request.setMiniappData(getFb8d217747794a7a8b44B97d1707840b());

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
            extendInfoMap.Add("delay_acct_flag", "Y");
            // 是否拆单支付
            // extendInfoMap.Add("split_pay_flag", "");
            // 拆单支付参数集合
            // extendInfoMap.Add("split_pay_data", get33b93d702a424823A9c104c962b0a4d3());
            // 分账对象
            extendInfoMap.Add("acct_split_bunch", get41a5e8fcA0a0401aA6f2279cf764b391());
            // 统一收银台扩展参数集合
            // extendInfoMap.Add("hosting_data", get74d0313eFbd74bf49eef5f0e71adaf93());
            // 交易失效时间
            // extendInfoMap.Add("time_expire", "");
            // 业务信息
            // extendInfoMap.Add("biz_info", getB15a1cee66424b8dA524Fb3dcc211aa9());
            // 交易异步通知地址
            extendInfoMap.Add("notify_url", "https://callback.service.com/xx");
            // 微信参数集合
            // extendInfoMap.Add("wx_data", get3b4a86c0Fb9546d298f37ea8e161c2a0());
            // 设备信息
            // extendInfoMap.Add("terminal_device_data", getEc9037987819440fB638B05a05de8932());
            // 手续费场景标识
            // extendInfoMap.Add("fee_sign", "");
            // 是否交易手续费分摊
            // extendInfoMap.Add("fee_split_flag", "");
            return extendInfoMap;
        }

        private static string get33b93d702a424823A9c104c962b0a4d3() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商户贴息标记
            // obj.Add("fq_mer_discount_flag", "");
            // 商户业务信息
            // obj.Add("ali_business_params", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get94fb584696764557940b87b68de6e256() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账金额
            obj.Add("div_amt", "0.01");
            // 分账接收方ID
            obj.Add("huifu_id", "6666000109133323");
            // 收款汇付账户号
            // obj.Add("acct_id", "");
            // 分账百分比%
            // obj.Add("percentage_div", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return objList;
        }
        private static string get41a5e8fcA0a0401aA6f2279cf764b391() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账明细
            obj.Add("acct_infos", get94fb584696764557940b87b68de6e256());
            // 百分比分账标志
            // obj.Add("percentage_flag", "");
            // 是否净值分账
            // obj.Add("is_clean_split", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get74d0313eFbd74bf49eef5f0e71adaf93() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 项目号
            // obj.Add("project_id", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getFb8d217747794a7a8b44B97d1707840b() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 是否生成scheme_code
            obj.Add("need_scheme", "Y");
            // 应用ID
            obj.Add("seq_id", "APP_2022100912694428");
            // 私有信息
            obj.Add("private_info", "oppsHosting://");

            return JsonConvert.SerializeObject(obj);
        }
        private static object get9e5c93bb1c864987907cB96cc9c1bdbc() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 指定支付者
            // obj.Add("limit_payer", "");
            // 微信实名验证
            // obj.Add("real_name_flag", "");

            return obj;
        }
        private static object get1584a9c420a6463dA01010944ee35fd9() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 姓名
            // obj.Add("name", "");
            // 证件类型
            // obj.Add("cert_type", "");
            // 证件号
            // obj.Add("cert_no", "");

            return obj;
        }
        private static string getB15a1cee66424b8dA524Fb3dcc211aa9() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 付款人验证（微信）
            // obj.Add("payer_check_wx", get9e5c93bb1c864987907cB96cc9c1bdbc());
            // 个人付款人信息
            // obj.Add("person_payer", get1584a9c420a6463dA01010944ee35fd9());

            return JsonConvert.SerializeObject(obj);
        }
        private static object getC17acafc5b524dfbB569D428985d86ea() {
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
        private static object getD8eff6a7D39741bb81a38ef29fdb841f() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 单品列表
            // obj.Add("goods_detail", getC17acafc5b524dfbB569D428985d86ea());
            // 订单原价(元)
            // obj.Add("cost_price", "");
            // 商品小票ID
            // obj.Add("receipt_id", "");

            return obj;
        }
        private static object getFf2bd73bFe6b4e9eAe5553471ba84021() {
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
        private static object get620d86e01a934650A7e99dccba659467() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 门店信息
            // obj.Add("store_info", getFf2bd73bFe6b4e9eAe5553471ba84021());

            return obj;
        }
        private static string get3b4a86c0Fb9546d298f37ea8e161c2a0() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 子商户应用ID
            // obj.Add("sub_appid", "");
            // 子商户用户标识
            // obj.Add("sub_openid", "");
            // 附加数据
            // obj.Add("attach", "");
            // 商品描述
            // obj.Add("body", "");
            // 商品详情
            // obj.Add("detail", getD8eff6a7D39741bb81a38ef29fdb841f());
            // 设备号
            // obj.Add("device_info", "");
            // 订单优惠标记
            // obj.Add("goods_tag", "");
            // 实名支付
            // obj.Add("identity", "");
            // 开发票入口开放标识
            // obj.Add("receipt", "");
            // 场景信息
            // obj.Add("scene_info", get620d86e01a934650A7e99dccba659467());
            // 终端ip
            // obj.Add("spbill_create_ip", "");
            // 单品优惠标识
            // obj.Add("promotion_flag", "");
            // 新增商品ID
            // obj.Add("product_id", "");
            // 指定支付者
            // obj.Add("limit_payer", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string getEc9037987819440fB638B05a05de8932() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 汇付机具号
            // obj.Add("devs_id", "test");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
