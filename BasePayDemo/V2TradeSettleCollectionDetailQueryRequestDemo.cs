using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 资金归集明细查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeSettleCollectionDetailQueryRequestDemo
    {

        public static void V2TradeSettleCollectionDetailQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeSettleCollectionDetailQueryRequest request = new V2TradeSettleCollectionDetailQueryRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 开始日期
            request.setBeginDate("20240711");
            // 结束日期
            request.setEndDate("20240718");
            // 转出方商户号转出方商户号和转入方商户号必填一个；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123124&lt;/font&gt;
            request.setOutHuifuId("");
            // 转入方商户号转出方商户号和转入方商户号必填一个；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000123123124&lt;/font&gt;
            request.setInHuifuId("6666000146178696");

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
            // 分页页码
            extendInfoMap.Add("page_num", "0");
            // 分页条数
            extendInfoMap.Add("page_size", "5");
            // 归集状态
            extendInfoMap.Add("status", "");
            // 转出方账户号
            extendInfoMap.Add("out_acct_id", "");
            // 转入方账户号
            extendInfoMap.Add("in_acct_id", "");
            return extendInfoMap;
        }

    }
}
