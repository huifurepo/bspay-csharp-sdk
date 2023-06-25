using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 创建修改小票自定义入口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeElectronReceiptsCustomentrancesCreateRequestDemo
    {

        public static void V2TradeElectronReceiptsCustomentrancesCreateRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeElectronReceiptsCustomentrancesCreateRequest request = new V2TradeElectronReceiptsCustomentrancesCreateRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000103334211");
            // 操作类型
            request.setOperateType("A");

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
            // 票据信息
            extendInfoMap.Add("receipt_data", getReceiptData());
            return extendInfoMap;
        }

        private static object getJumpLinkData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 商家小程序AppID
            obj.Add("mini_programs_app_id", "oBmItsxLKa6pd5dSHK4xRLXTt05M");
            // 商家小程序path
            obj.Add("mini_programs_path", "https://wxpaylogo.qpic.cn/wxpaylogo/PiajxSqBRaEIPAeia7ImvtsoMpdQ8uEd23s8VtfKDXa04FZk8kXDeH9Q/0");

            return obj;
        }
        private static object getWxReceiptData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 品牌ID
            obj.Add("brand_id", "1");
            // 自定义入口种类
            obj.Add("custom_entrance_type", "MERCHANT_ACTIVITY");
            // 副标题
            obj.Add("sub_title", "1");
            // 商品缩略图URL
            obj.Add("goods_thumbnail_url", "1");
            // 入口展示开始时间
            obj.Add("start_time", "2023-08-17T13:20:00+08:00");
            // 入口展示结束时间
            obj.Add("end_time", "2023-08-18T11:20:00+08:00");
            // 自定义入口状态
            obj.Add("custom_entrance_state", "ONLINE");
            // 请求业务单据号
            obj.Add("out_request_no", "1");
            // 跳转信息
            obj.Add("jump_link_data", getJumpLinkData());

            return obj;
        }
        private static string getReceiptData() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 三方通道类型
            obj.Add("third_channel_type", "T");
            // 微信票据信息
            obj.Add("wx_receipt_data", getWxReceiptData());

            return JsonConvert.SerializeObject(obj);
        }
    }
}
