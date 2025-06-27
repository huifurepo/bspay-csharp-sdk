using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 抖音套餐映射接口 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2CouponDouyinProductQueryRequestDemo
    {

        public static void V2CouponDouyinProductQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2CouponDouyinProductQueryRequest request = new V2CouponDouyinProductQueryRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付商户号
            request.setHuifuId("6666000108412345");
            // 门店绑定流水号
            request.setBindId("7123fc6e5c564f539e73031c08912345");

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
            // 区分商品创建者的查询方式
            extendInfoMap.Add("goods_creator_type", "0");
            // 商品名称
            // extendInfoMap.Add("product_name", "");
            // 是否查询商品全量关联门店
            // extendInfoMap.Add("query_all_poi", "");
            // 筛选在线状态
            extendInfoMap.Add("status", "1");
            // 光标
            // extendInfoMap.Add("cursor", "");
            // 分页数量
            // extendInfoMap.Add("count", "");
            // 门店ID list
            extendInfoMap.Add("poi_ids", "[23,45]");
            // 外部门店ID list
            // extendInfoMap.Add("ext_ids", "");
            return extendInfoMap;
        }

    }
}
