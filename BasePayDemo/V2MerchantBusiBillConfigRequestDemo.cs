using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 交易结算对账文件配置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiBillConfigRequestDemo
    {

        public static void V2MerchantBusiBillConfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBusiBillConfigRequest request = new V2MerchantBusiBillConfigRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 汇付机构编号
            request.setHuifuId("6666000121363028");
            // 对账文件生成开关
            request.setReconSendFlag("Y");
            // 对账单类型
            request.setFileType("1,2,3,4");

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
            // SFTP地址
            // extendInfoMap.Add("ftp_addr", "");
            // SFTP用户名
            // extendInfoMap.Add("ftp_user", "");
            // SFTP密码
            // extendInfoMap.Add("ftp_pwd", "");
            return extendInfoMap;
        }

    }
}
