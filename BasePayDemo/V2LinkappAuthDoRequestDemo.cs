using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户公域授权 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LinkappAuthDoRequestDemo
    {

        public static void V2LinkappAuthDoRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2LinkappAuthDoRequest request = new V2LinkappAuthDoRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付商户号
            request.setHuifuId("6666000107203801");
            // 平台类型
            request.setPlatformType("21");
            // 协议地址
            request.setContractUrl("https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/spin/files/斗拱增值业务服务协议 V1.020231120.docx");
            // 签约商户名称
            request.setContractMerName("于云飞");
            // 签约时间
            request.setContractTime("1744008692000");
            // 登录用手机号第一次登录有需要手机验证码的情况;（需要授权手机安装一个转发短信的应用）
            // request.setPhoneNumber("test");
            // 商户类型商户类型：0个人店 1企业 2个体工商户 3其他(目前固定填3即可)
            // request.setMerchantType("test");

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
            // 回调地址
            // extendInfoMap.Add("callback_url", "");
            // 
            // extendInfoMap.Add("以下仅RPA授权输入", "");
            // 登录账号名称
            // extendInfoMap.Add("account_name", "");
            // 登录账号密码
            // extendInfoMap.Add("account_password", "");
            // 门店名称
            // extendInfoMap.Add("shop_name", "");
            // 管理员手机号
            // extendInfoMap.Add("admin_phone_num", "");
            return extendInfoMap;
        }

    }
}
