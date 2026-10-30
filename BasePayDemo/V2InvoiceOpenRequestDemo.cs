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
            // 汇付商户号huifu_id与ext_mer_id二选一必填，汇付商户号优先；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812123&lt;/font&gt;
            request.setHuifuId("6666000107430944");
            // 外部商户号&lt;font color&#x3D;&quot;green&quot;&gt;示例值：&lt;/font&gt;
            request.setExtMerId("");
            // 开票方式乐企联用模式下非斗拱交易必填 枚举： TRADE-交易即开票  PAY-支付即开票
            // request.setIvcModeCode("test");
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
            // 冲红申请来源open_type&#x3D;1时必填01：销方02：购方03：第三方
            // request.setRedApplySource("test");
            // 原发票代码openType&#x3D;1时必填；参见[发票右上角](https://paas.huifu.com/open/doc/api/#/fp/api_fp_yanglitu.md)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：144032209110&lt;/font&gt;
            request.setOriIvcCode("90222082");
            // 原发票号码openType&#x3D;1时必填；参见[发票右上角](https://paas.huifu.com/open/doc/api/#/fp/api_fp_yanglitu.md)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：20685767&lt;/font&gt;
            request.setOriIvcNumber("150000020026");
            // 开票商品信息
            request.setGoodsInfos(getE39d35ceD1c946049c4a78abe4385b46());
            // 不动产销售特殊字段specialFlag为05时，必填；jsonArray格式
            // request.setEstateSales(get3e2cef346688416b829072c10a9ceadd());
            // 不动产租赁特殊字段specialFlag为16时，必填；jsonArray格式
            // request.setEstateLease(get47f6d2af90b840db984f379ab6303717());
            // 交易订单信息jsonObject格式，订单信息（乐企联用，AT联用模式必填）
            // request.setOrderInfo(get9f17cfb9260e4d8c9db3Ee08ada0cc13());

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
            // 开票模式
            // extendInfoMap.Add("issue_mode", "");
            // 子商户号
            // extendInfoMap.Add("sub_mer_id", "");
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
            // 收票人邮件
            extendInfoMap.Add("rec_ivc_email", "test@126.com");
            // 备注
            extendInfoMap.Add("resv", "备注");
            // 特殊票种标识
            extendInfoMap.Add("special_flag", "00");
            // 红字信息表编号
            extendInfoMap.Add("red_info_number", "");
            // 开票人信息
            extendInfoMap.Add("payer_info", getCa65c4309ca442c0A892037585b8e873());
            // 开票结果异步通知地址
            extendInfoMap.Add("callback_url", "virgo://http://192.168.85.157:30031/sspm/testVirgo");
            // 强制开票标识
            extendInfoMap.Add("buyer_info_confirm", "");
            // 购方自然人标识
            // extendInfoMap.Add("buyer_nature_person_type", "");
            // 购方自然人证件类型
            // extendInfoMap.Add("buyer_nature_person_card_type", "");
            // 购方自然人证件号码
            // extendInfoMap.Add("buyer_nature_person_card_no", "");
            // 购方自然人国籍代码
            // extendInfoMap.Add("buyer_nature_person_nation_no", "");
            // 减按征税类型代码
            // extendInfoMap.Add("reduced_tax_type", "");
            // 二手车信息
            // extendInfoMap.Add("used_car", get4095e83b0a9b46eeB3305641800925eb());
            return extendInfoMap;
        }

        private static object get6e4b3c323c4d4fa6Ae98414ce70f646a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 加油站名称
            // obj.Add("station", "test");
            // 油枪号
            // obj.Add("gun_number", "test");
            // 加油时间
            // obj.Add("oil_time", "test");

            return obj;
        }
        private static string getE39d35ceD1c946049c4a78abe4385b46() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 发票行性质
            obj.Add("ivc_nature", "0");
            // 商品序号ivc_type&#x3D;1 红票必填，要与开具的蓝票商品一致；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：备注&lt;/font&gt;
            obj.Add("goods_serial_num", "");
            // 商品id二选一必填，税收分类编码优先；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：&lt;/font&gt;
            obj.Add("goods_id", "");
            // 商品税收分类编码参考[商品编码](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/api/prod/download_file/fp/%E7%94%B5%E5%AD%90%E5%8F%91%E7%A5%A8%E5%95%86%E5%93%81%E7%BC%96%E7%A0%81.xlsx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1010101090000000000&lt;/font&gt;
            obj.Add("goods_code", "6010000000000000000");
            // 商品名称goods_code不为空时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：&lt;/font&gt;
            obj.Add("goods_name", "预付卡");
            // 税率goods_code不为空时必填，最多三位小数；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.130&lt;/font&gt;
            obj.Add("tax_rate", "0.03");
            // 含税标识
            obj.Add("is_price_con_tax", "1");
            // 金额(元)
            obj.Add("trans_amt", "70.00");
            // 成品油信息乐企联用、AT乐企联用模式下成品油票种必传
            // obj.Add("oil_info", get6e4b3c323c4d4fa6Ae98414ce70f646a());
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
        private static string getCa65c4309ca442c0A892037585b8e873() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 收款人
            obj.Add("payee", "收款人");
            // 复核人
            obj.Add("reviewer", "复核");
            // 开票人
            obj.Add("payer_name", "开票人");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get3e2cef346688416b829072c10a9ceadd() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 不动产地址
            // obj.Add("addr", "test");
            // 不动产详细地址
            // obj.Add("detail_addr", "test");
            // 跨地（市）标志
            // obj.Add("area_flag", "test");
            // 土地增值税项目编号
            // obj.Add("tax_item_no", "test");
            // 不动产单元代码/网签合同备案编号
            // obj.Add("record_no", "test");
            // 核定计税价格
            // obj.Add("total_amt", "test");
            // 实际成交含税金额
            // obj.Add("deal_amt", "test");
            // 房屋产权证书/不动产产权号
            // obj.Add("estate_no", "test");
            // 不动产单位
            // obj.Add("unit", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get47f6d2af90b840db984f379ab6303717() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 不动产地址
            // obj.Add("addr", "test");
            // 不动产详细地址
            // obj.Add("detail_addr", "test");
            // 跨地（市）标志
            // obj.Add("area_flag", "test");
            // 租赁日期起
            // obj.Add("start_date", "test");
            // 租赁日期止
            // obj.Add("end_date", "test");
            // 房屋产权证书/不动产产权号
            // obj.Add("estate_no", "test");
            // 不动产单位
            // obj.Add("unit", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string getAbba899f2acf4386A7b6B14265184add() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 支付方式
            // obj.Add("pay_way", "");
            // 支付金额
            // obj.Add("trade_amt", "");
            // 支付通道订单号
            // obj.Add("trade_no", "");
            // 支付时间
            // obj.Add("trade_time", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get9f17cfb9260e4d8c9db3Ee08ada0cc13() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 交易订单号
            // obj.Add("order_id", "test");
            // 交易金额示例值：1.00 单位元，is_dg_trans &#x3D; N，必填
            // obj.Add("amt", "test");
            // 支付方式jsonArray格式，支付信息明细，is_dg_trans&#x3D;N时必填
            // obj.Add("pay_infos", getAbba899f2acf4386A7b6B14265184add());
            // 交易订单日期
            // obj.Add("order_date", "");
            // 是否斗拱交易
            // obj.Add("is_dg_trans", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get3cec4f3f754c4e91Ae1e5c32d003cd8c() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 车牌号码
            // obj.Add("plate_number", "");
            // 登记证号
            // obj.Add("register_cert_number", "");
            // 厂牌型号
            // obj.Add("factory_plate_model", "");
            // 车辆类型代码
            // obj.Add("car_type", "");
            // 转入地车辆管理所名称
            // obj.Add("into_vehicle_manage_name", "");
            // 车架号
            // obj.Add("vehicle_identification_number", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get4095e83b0a9b46eeB3305641800925eb() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 二手车销售统一发票正向开票标识
            // obj.Add("direction_type", "");
            // 二手车企业性质
            // obj.Add("ent_prop_type", "");
            // 二手车销售统一发票号码
            // obj.Add("unified_sales_inv_number", "");
            // 卖方自然人标识
            // obj.Add("car_nature_person_type", "");
            // 卖方自然人证件类型
            // obj.Add("car_nature_person_card_type", "");
            // 卖方自然人证件号码
            // obj.Add("car_nature_person_card_no", "");
            // 卖方自然人国籍代码
            // obj.Add("car_nature_person_nation_no", "");
            // 卖方单位名称/自然人姓名
            // obj.Add("car_nature_ent_name", "");
            // 卖方税号
            // obj.Add("car_ent_no", "");
            // 卖方地址/自然人地址
            // obj.Add("car_nature_ent_address", "");
            // 卖方电话/自然人电话
            // obj.Add("car_nature_ent_tell", "");
            // 车辆费基本信息集合
            // obj.Add("car_base_list", get3cec4f3f754c4e91Ae1e5c32d003cd8c());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
