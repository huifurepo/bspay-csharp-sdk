using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 银行大额支付绑卡 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2LargeamtBindcardBindRequestDemo
    {

        public static void V2LargeamtBindcardBindRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2LargeamtBindcardBindRequest request = new V2LargeamtBindcardBindRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户号
            request.setHuifuId("6666000108312997");
            // 卡类型
            request.setCardType("1");
            // 银行账户名
            request.setCardName("许溪证");
            // 银行卡号密文
            request.setCardNo("GCMghaHLsWffNmBl/uuvVnv+kzwvBSLaZR+AsldnabAMzjPUzw4SMe2DX8IvVTM/Qb/tbiQwayeQ+TwkeSyQ0IB6oy/BNgM3rl7wZsdTzKbyigyGQvtOYsauk3IUuiJ8ptJ1k0C4Ysd5Z4+6ApLmOZhAem1pqu+DUk8EpKMj37RDgk3zWgVIf1wX9nBaSN1IGIoVjmweg8/r/UVWqCKoYrEWHxO1R0elZM9+hXTwXEKHFc2L2yossgDGjJDKuykaN0DzVunz1uQbxuvg4lMCmycSRjlQ1MCsIzqs4oiVNW3PCqAwoFkdRKL879e5/EsvohJJNVuX6YOeefFdJOC8Ug==");
            // 银行编码
            request.setBankCode("");
            // 手机号
            request.setMobileNo("dFw39mqjcPyZJk5ukKiH5oL+LyJLdJ2DfPgXcOCCgYfsUuCcOJLPnBc6f0nybPDBnfgLCcK31wG5TLFi97EttpBsrQVI6kEWMrxUAAcIehSMuWEBBuGG8QnaayE0tZa2gSgQZgFltCrkgfQ08N6TwLmvZEJ3z+gudsIPRaMXAgxMgnyH6xjuFbdOWJKfgcTQxpIirIQg0bWPpBPnO6HizB3z435qeep7WVCRK7c+tvYxjLRm7jDEeUCd9c0yZ4eKWOt1vLini6kqAwXuCTXa10z1NEnGbFlBrOK5/R5ZK977BmuAD7ZLuHU6T/j2Ca1nG6JOJwXT827CVo/sU7osjQ==");

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
            // 账户号
            extendInfoMap.Add("acct_id", "C02730634");
            // 银行卡绑定身份证
            extendInfoMap.Add("cert_no", "k05wtsAi+WSv8rdRaj24nOGQetL4L8k5VFRGPdljb1O/5pOJYe4o3ofwiKNjaVyAwvGFWIqMNEu0GU1gcq+UDmnabOROcneJVNGu+XMy5J9I55OqBDOC5lIiiuSWQux7TlaDCZT7ACpYHjRI2r3bzOASgzPXebjYLllnuEg2kxYpGqJBe8jsjaTpAzoEB1Yoy6I0sAn4xxl8IjmGu5AHEA/drWyrAIT0GsEhmeR6wkJK3iCjShqIQ317BkNBzXsdt8dGZLF4M/7iwiQXaVP2KLWKtX+gn2oI19ckTTiFXnvuNtNPJEUEayTbsAODHKvo5wsYLUdbnO2UFJ6wlE3rOQ==");
            // 联行号
            extendInfoMap.Add("branch_code", "105290071051");
            // 银行所在省
            extendInfoMap.Add("prov_id", "130000");
            // 银行所在市
            extendInfoMap.Add("area_id", "130300");
            // 补充资质材料列表
            extendInfoMap.Add("file_list", getFileList());
            return extendInfoMap;
        }

        private static string getFileList() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 文件jfileID
            // obj.Add("file_id", "");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
    }
}
