using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 卡bin信息查询 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2TradeCardbinQueryRequestDemo
    {

        public static void V2TradeCardbinQueryRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2TradeCardbinQueryRequest request = new V2TradeCardbinQueryRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 银行卡号密文
            request.setBankCardNoCrypt("b9LE5RccVVLChrHgo9lvpLB1XIyJlEeETa1APmkRQ35z06zJ8zD7cnqypNSnA8iK3uAYVDJtCfrz1Hqu1qTCdu5eVWkjBYaAUtuy1ZD4HkEkqbY9/z5lN4jdDyF8xlzonfxhxzm3OM1fWRoYl39Te+pW71ag0SSbQGu6yhWzFD9mBllbj2RR5fWm9BZVtJTLmitIO/HZfirXkRiCPHBjosQJm2bCrVSuzxqJgqmB9Cp1ADIB+f7fG1/G8RElkJ5zyqhDyinlB5b2+fy3hoyuPqB44GCSLEeOF8V0C9uMNNVor1DwvPRLYleNSw43lW4mFx4PhWhjKrWg2NPfbe0mkQ==");

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
            return extendInfoMap;
        }

    }
}
