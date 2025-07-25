using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 商户活动报名 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantActivityAddRequestDemo
    {

        public static void V2MerchantActivityAddRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantActivityAddRequest request = new V2MerchantActivityAddRequest();
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 汇付客户Id
            request.setHuifuId("6666000103627938");
            // 营业执照图片调用[图片上传接口](http://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)获取jfile文件id；[示例图片](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/spin/imgs/%E8%90%A5%E4%B8%9A%E6%89%A7%E7%85%A7%E7%A4%BA%E4%BE%8B.png)参考&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;&lt;br/&gt;活动类型为支付宝谷雨活动时无需填写任何资料
            request.setBlPhoto("42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 店内环境图片参加教育食堂、非校园餐饮、非盈利、停车缴费行业时必传；调用[图片上传接口](http://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)获取jfile文件id；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;&lt;br/&gt;活动类型为支付宝谷雨活动时无需填写任何资料
            request.setDhPhoto("42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 手续费类型
            request.setFeeType("7");
            // 整体门面图片（门头照）参加教育食堂行业、非校园餐饮、非盈利、线下教培、公办医院、商业医疗时必传；调用[图片上传接口](http://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)获取jfile文件id；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;&lt;br/&gt;活动类型为支付宝谷雨活动时无需填写任何资料&lt;br/&gt;若为线下教培活动,[示例图片](https://cloudpnrcdn.oss-cn-shanghai.aliyuncs.com/spin/imgs/%E9%97%A8%E5%A4%B4%E7%85%A7%E7%A4%BA%E4%BE%8B.png)参考
            request.setMmPhoto("42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 收银台照片参加教育食堂行业、线下教培、公办医院时必传；调用[图片上传接口](http://paas.huifu.com/open/doc/api/#/shgl/shjj/api_shjj_shtpsc)获取jfile文件id；&lt;br/&gt;&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e529&lt;/font&gt;&lt;br/&gt;活动类型为支付宝谷雨活动时无需填写任何资料
            request.setSytPhoto("42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 支付通道
            request.setPayWay("W");

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
            // 活动类型
            extendInfoMap.Add("activity_type", "BLUE_SEA");
            // 二级商户号
            extendInfoMap.Add("sub_mer_id", "W5503418657189757903");
            // 二级商户名称
            extendInfoMap.Add("sub_mer_name", "");
            // 异步通知地址
            extendInfoMap.Add("async_return_url", "http://192.168.85.157:30031/sspm/testVirgo");
            // 证明文件图片
            extendInfoMap.Add("certificate_file_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 收费样本
            extendInfoMap.Add("charge_sample_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 照会
            extendInfoMap.Add("diplomatic_note_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 事业单位法人证书图片
            extendInfoMap.Add("inst_org_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 法人身份证图片
            extendInfoMap.Add("legal_person_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 法人登记证书图片
            extendInfoMap.Add("legal_person_reg_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 医疗执业许可证图片
            extendInfoMap.Add("medical_license_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 民办非企业单位登记证书图片
            extendInfoMap.Add("nonenterprise_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 组织机构代码证图片
            extendInfoMap.Add("org_cert_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 机构资质证明照片
            extendInfoMap.Add("org_qualifi_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 办学资质图片
            extendInfoMap.Add("school_license_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 门店省市区编码
            extendInfoMap.Add("shop_add_code", "110101");
            // 门店街道名称
            extendInfoMap.Add("shop_street", "门店街道名称");
            // 门店租赁证明
            extendInfoMap.Add("store_tenancy_proof_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 合作资质证明
            extendInfoMap.Add("cooper_certi_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 优惠费率承诺函
            extendInfoMap.Add("activity_rate_commit_photo", "42204258-967e-373c-88d2-1afa4c7bb8ef");
            // 商户同名银行账户信息
            extendInfoMap.Add("bank_account", getA9362d330e0241b090a8D3be2713bcbf());
            // 银行开户证明图片
            extendInfoMap.Add("bank_account_prove_photo", "");
            // 机构银行合作授权函图
            extendInfoMap.Add("bank_agreement_photo", "");
            // 行业编码
            extendInfoMap.Add("industry_code", "");
            // 商户行业资质图片
            extendInfoMap.Add("industry_photo", "");
            // 负责人授权函图片
            extendInfoMap.Add("legal_person_auth_photo", "");
            // 食堂经营相关资质
            // extendInfoMap.Add("food_qualification_proof", "");
            // 活动费率%
            // extendInfoMap.Add("preferential_rate", "");
            // 活动到期后费率%
            // extendInfoMap.Add("expiration_rate", "");
            // 学校号
            // extendInfoMap.Add("school_id", "");
            return extendInfoMap;
        }

        private static string getA9362d330e0241b090a8D3be2713bcbf() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 账户名
            obj.Add("card_name", "张三");
            // 银行账号
            obj.Add("card_no", "6228480402637874213");
            // 开户行名称
            obj.Add("bank_branch_name", "招商银行");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
