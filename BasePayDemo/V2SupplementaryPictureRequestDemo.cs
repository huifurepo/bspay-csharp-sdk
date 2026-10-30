using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 图片上传 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2SupplementaryPictureRequestDemo
    {

        public static void V2SupplementaryPictureRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2SupplementaryPictureRequest request = new V2SupplementaryPictureRequest();
            // 业务请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 业务请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 图片类型
            request.setFileType("F01");
            // 文件url链接文件url链接与file文件流不能同时上传；文件支持类型：JPG,BMP,PNG；单个图片最大支持2M；除去图片外其他类型文件支持10M&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：[https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/imgs/guide/jinjian/%E8%90%A5%E4%B8%9A%E6%89%A7%E7%85%A71-2.png](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/opps/imgs/guide/jinjian/%E8%90%A5%E4%B8%9A%E6%89%A7%E7%85%A71-2.png)
            request.setFileUrl("https://example.com/image.jpg");

            // 设置非必填字段
            Dictionary<string, object> extendInfoMap = getExtendInfos();
            request.setExtendInfo(extendInfoMap);

            try {
                // 3. 发起API调用
                // 调用接口,使用默认商户配置时可省略配置key
                Dictionary<string, Object> result = null;
                result = BasePayClient.postRequest(request,"D:/法人身份证正反面.png");
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
            // 商户号
            extendInfoMap.Add("huifu_id", "6666000103413615");
            return extendInfoMap;
        }

    }
}
