using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 全渠道资金管理配置 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiEfpconfigRequestDemo
    {

        public static void V2MerchantBusiEfpconfigRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2MerchantBusiEfpconfigRequest request = new V2MerchantBusiEfpconfigRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求日期
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 商户汇付id
            request.setHuifuId("6666000108139646");
            // 所属渠道商
            request.setUpperHuifuId("6666000108120249");
            // 支付手续费外扣汇付ID支付手续费外扣标记为1时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812123&lt;/font&gt;
            request.setOutFeeHuifuid("");
            // 全域资金开户使用的银行卡信息首次开通时必填 jsonObject格式
            request.setOutOrderAcctCard(getD66709b2C1cd4c8f9a1a6e096c4c1d91());
            // 全域资金开户手续费首次开通时必填 jsonObject格式
            request.setOutOrderAcctOpenFees(get38be8e044bfe44b48ff96f533f80e9e9());
            // 业务模式acquiringMode:收单模式 switch_state为1时必填
            request.setBusinessModel("acquiringMode");
            // 银行类型switch_state有值时需填写； ht1-华通银行，xw0-XW银行，ss0-苏商银行,wz1-微众银行&lt;font color&#x3D;&quot;green&quot;&gt;示例值：ht1&lt;/font&gt;
            request.setOutFundsGateId("xw0");
            // 签约人信息switch_state为1时必填 jsonObject格式
            request.setSignUserInfo(get074b4059011f41f5B6a97432ad51a199());
            // 入账来源开通全域资金时需填写；01:抖音 02:美团 03:快手 04:拼多多 05:小红书 06:淘宝/天猫/飞猪 07:微信视频号/微信小店 08:京东 09:饿了么 11:得物 12:唯品会 13:携程 14:支付宝直连 15:微信直连 16:滴滴加油 17:团油 18:通联 19:易宝 20:百度 21:顺丰22:希音23:高德 24:贝壳 多个逗号分隔；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01,02,05&lt;/font&gt;；
            request.setAcctSource("01");
            // 抖音合作证明材料入账来源包含01:抖音时必填 文件类型F535；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDyCooperationProvePic("test");
            // 美团合作证明材料入账来源包含02:美团时必填 文件类型F536；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setMtCooperationProvePic("test");
            // 快手合作证明材料入账来源包含03:快手时必填 文件类型F537；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setKsCooperationProvePic("test");
            // 拼多多合作证明材料入账来源包含04:拼多多时必填 文件类型F538；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setPddCooperationProvePic("test");
            // 小红书合作证明材料入账来源包含05:小红书时必填 文件类型F539；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXhsCooperationProvePic("test");
            // 淘宝天猫飞猪合作证明材料入账来源包含06:淘宝天猫飞猪时必填 文件类型F540；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setZfbCooperationProvePic("test");
            // 微信视频号合作证明材料入账来源包含07:微信视频号时必填 文件类型F541；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWxCooperationProvePic("test");
            // 京东合作证明材料入账来源包含08:京东时必填 文件类型F542；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setJdCooperationProvePic("test");
            // 饿了么合作证明材料入账来源包含09:饿了么时必填 文件类型F543；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setElmCooperationProvePic("test");
            // 得物合作证明材料入账来源包含11:得物时必填 文件类型F591；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDwCooperationProvePic("test");
            // 唯品会合作证明材料入账来源包含12:唯品会时必填 文件类型F592；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWphCooperationProvePic("test");
            // 携程合作证明材料入账来源包含13:携程时必填 文件类型F593；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXcCooperationProvePic("test");
            // 支付宝直连合作证明材料入账来源包含14:支付宝直连时必填 文件类型F594；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setZfbzlCooperationProvePic("test");
            // 微信直连合作证明材料入账来源包含15:微信直连时必填 文件类型F595；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWxzlCooperationProvePic("test");
            // 滴滴加油合作证明材料入账来源包含16:滴滴加油时必填 文件类型F596；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDdjyCooperationProvePic("test");
            // 团油合作证明材料入账来源包含17:团油时必填 文件类型F597；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setTyCooperationProvePic("test");
            // 通联合作证明材料入账来源包含18:通联时必填 文件类型F598；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setTlCooperationProvePic("test");
            // 易宝合作证明材料入账来源包含19:易宝时必填 文件类型F599；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setYbCooperationProvePic("test");
            // 全渠道资金纸质协议文件协议类型为纸质时必填，文件类型F605；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setEfpPaperAgreementFile("test");
            // 百度合作证明材料入账来源包含20:百度时必填 文件类型F616；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setBdCooperationProvePic("test");
            // 主店商户号是否店群为是时必填
            // request.setMainStoreHuifuId("test");
            // 顺丰合作证明材料入账来源包含21:顺丰时必填 文件类型F618；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setSfCooperationProvePic("test");
            // 希音合作证明材料入账来源包含22:希音时必填 文件类型F619；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXyCooperationProvePic("test");
            // 高德合作证明材料入账来源包含23:高德时必填 文件类型F615；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setGdCooperationProvePic("test");
            // 贝壳合作证明材料入账来源包含24:贝壳时必填 文件类型F802；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setBkCooperationProvePic("test");
            // 抖音平台后台交易数据截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F730；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDyPlatformTransDataPic("test");
            // 抖音平台后台店铺信息截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F731；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDyPlatformStoreInfoPic("test");
            // 抖音平台后台经营主体截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F732；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDyPlatformBusiEntPic("test");
            // 抖音平台后台订单明细截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F733；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDyPlatformOrderDetailPic("test");
            // 抖音平台后台资金流水截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F734；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDyPlatformFundFlowPic("test");
            // 抖音移动端店铺橱窗截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F735；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDyMobileStoreShowcasePic("test");
            // 抖音移动端商家资质截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F736；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDyMobileBusiQualificationPic("test");
            // 抖音移动端店铺详情截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F737；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDyMobileStoreDetailPic("test");
            // 快手平台后台交易数据截屏开通微众银行且入账来源包含03:快手时必填 文件类型F738；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setKsPlatformTransDataPic("test");
            // 快手平台后台店铺信息截屏开通微众银行且入账来源包含03:快手时必填 文件类型F739；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setKsPlatformStoreInfoPic("test");
            // 快手平台后台经营主体截屏开通微众银行且入账来源包含03:快手时必填 文件类型F740；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setKsPlatformBusiEntPic("test");
            // 快手平台后台订单明细截屏开通微众银行且入账来源包含03:快手时必填 文件类型F741；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setKsPlatformOrderDetailPic("test");
            // 快手平台后台资金流水截屏开通微众银行且入账来源包含03:快手时必填 文件类型F742；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setKsPlatformFundFlowPic("test");
            // 快手移动端店铺橱窗截屏开通微众银行且入账来源包含03:快手时必填 文件类型F743；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setKsMobileStoreShowcasePic("test");
            // 快手移动端商家资质截屏开通微众银行且入账来源包含03:快手时必填 文件类型F744；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setKsMobileBusiQualificationPic("test");
            // 快手移动端店铺详情截屏开通微众银行且入账来源包含03:快手时必填 文件类型F745；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setKsMobileStoreDetailPic("test");
            // 拼多多平台后台交易数据截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F746；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setPddPlatformTransDataPic("test");
            // 拼多多平台后台店铺信息截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F747；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setPddPlatformStoreInfoPic("test");
            // 拼多多平台后台经营主体截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F748；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setPddPlatformBusiEntPic("test");
            // 拼多多平台后台订单明细截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F749；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setPddPlatformOrderDetailPic("test");
            // 拼多多平台后台资金流水截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F750；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setPddPlatformFundFlowPic("test");
            // 拼多多移动端店铺橱窗截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F751；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setPddMobileStoreShowcasePic("test");
            // 拼多多移动端商家资质截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F752；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setPddMobileBusiQualificationPic("test");
            // 拼多多移动端店铺详情截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F753；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setPddMobileStoreDetailPic("test");
            // 小红书平台后台交易数据截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F754；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXhsPlatformTransDataPic("test");
            // 小红书平台后台店铺信息截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F755；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXhsPlatformStoreInfoPic("test");
            // 小红书平台后台经营主体截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F756；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXhsPlatformBusiEntPic("test");
            // 小红书平台后台订单明细截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F757；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXhsPlatformOrderDetailPic("test");
            // 小红书平台后台资金流水截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F758；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXhsPlatformFundFlowPic("test");
            // 小红书移动端店铺橱窗截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F759；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXhsMobileStoreShowcasePic("test");
            // 小红书移动端商家资质截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F760；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXhsMobileBusiQualificationPic("test");
            // 小红书移动端店铺详情截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F761；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setXhsMobileStoreDetailPic("test");
            // 微信视频号平台后台交易数据截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F762；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWxsphPlatformTransDataPic("test");
            // 微信视频号平台后台店铺信息截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F763；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWxsphPlatformStoreInfoPic("test");
            // 微信视频号平台后台经营主体截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F764；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWxsphPlatformBusiEntPic("test");
            // 微信视频号平台后台订单明细截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F765；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWxsphPlatformOrderDetailPic("test");
            // 微信视频号平台后台资金流水截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F766；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWxsphPlatformFundFlowPic("test");
            // 微信视频号移动端店铺橱窗截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F767；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWxsphMobileStoreShowcasePic("test");
            // 微信视频号移动端商家资质截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F768；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWxsphMobileBusiQualificationPic("test");
            // 微信视频号移动端店铺详情截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F769；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWxsphMobileStoreDetailPic("test");
            // 京东平台后台交易数据截屏开通微众银行且入账来源包含08:京东时必填 文件类型F770；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setJdPlatformTransDataPic("test");
            // 京东平台后台店铺信息截屏开通微众银行且入账来源包含08:京东时必填 文件类型F771；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setJdPlatformStoreInfoPic("test");
            // 京东平台后台经营主体截屏开通微众银行且入账来源包含08:京东时必填 文件类型F772；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setJdPlatformBusiEntPic("test");
            // 京东平台后台订单明细截屏开通微众银行且入账来源包含08:京东时必填 文件类型F773；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setJdPlatformOrderDetailPic("test");
            // 京东平台后台资金流水截屏开通微众银行且入账来源包含08:京东时必填 文件类型F774；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setJdPlatformFundFlowPic("test");
            // 京东移动端店铺橱窗截屏开通微众银行且入账来源包含08:京东时必填 文件类型F775；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setJdMobileStoreShowcasePic("test");
            // 京东移动端商家资质截屏开通微众银行且入账来源包含08:京东时必填 文件类型F776；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setJdMobileBusiQualificationPic("test");
            // 京东移动端店铺详情截屏开通微众银行且入账来源包含08:京东时必填 文件类型F777；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setJdMobileStoreDetailPic("test");
            // 得物平台后台交易数据截屏开通微众银行且入账来源包含11:得物时必填 文件类型F778；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDwPlatformTransDataPic("test");
            // 得物平台后台店铺信息截屏开通微众银行且入账来源包含11:得物时必填 文件类型F779；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDwPlatformStoreInfoPic("test");
            // 得物平台后台经营主体截屏开通微众银行且入账来源包含11:得物时必填 文件类型F780；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDwPlatformBusiEntPic("test");
            // 得物平台后台订单明细截屏开通微众银行且入账来源包含11:得物时必填 文件类型F781；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDwPlatformOrderDetailPic("test");
            // 得物平台后台资金流水截屏开通微众银行且入账来源包含11:得物时必填 文件类型F782；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDwPlatformFundFlowPic("test");
            // 得物移动端店铺橱窗截屏开通微众银行且入账来源包含11:得物时必填 文件类型F783；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDwMobileStoreShowcasePic("test");
            // 得物移动端商家资质截屏开通微众银行且入账来源包含11:得物时必填 文件类型F784；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDwMobileBusiQualificationPic("test");
            // 得物移动端店铺详情截屏开通微众银行且入账来源包含11:得物时必填 文件类型F785；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setDwMobileStoreDetailPic("test");
            // 美团平台后台交易数据截屏开通微众银行且入账来源包含02:美团时必填 文件类型F786；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setMtPlatformTransDataPic("test");
            // 美团平台后台店铺信息截屏开通微众银行且入账来源包含02:美团时必填 文件类型F787；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setMtPlatformStoreInfoPic("test");
            // 美团平台后台经营主体截屏开通微众银行且入账来源包含02:美团时必填 文件类型F788；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setMtPlatformBusiEntPic("test");
            // 美团平台后台订单明细截屏开通微众银行且入账来源包含02:美团时必填 文件类型F789；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setMtPlatformOrderDetailPic("test");
            // 美团平台后台资金流水截屏开通微众银行且入账来源包含02:美团时必填 文件类型F790；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setMtPlatformFundFlowPic("test");
            // 美团移动端店铺橱窗截屏开通微众银行且入账来源包含02:美团时必填 文件类型F791；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setMtMobileStoreShowcasePic("test");
            // 美团移动端商家资质截屏开通微众银行且入账来源包含02:美团时必填 文件类型F792；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setMtMobileBusiQualificationPic("test");
            // 美团移动端店铺详情截屏开通微众银行且入账来源包含02:美团时必填 文件类型F793；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setMtMobileStoreDetailPic("test");
            // 唯品会平台后台交易数据截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F794；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWphPlatformTransDataPic("test");
            // 唯品会平台后台店铺信息截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F795；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWphPlatformStoreInfoPic("test");
            // 唯品会平台后台经营主体截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F796；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWphPlatformBusiEntPic("test");
            // 唯品会平台后台订单明细截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F797；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWphPlatformOrderDetailPic("test");
            // 唯品会平台后台资金流水截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F798；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWphPlatformFundFlowPic("test");
            // 唯品会移动端店铺橱窗截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F799；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWphMobileStoreShowcasePic("test");
            // 唯品会移动端商家资质截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F800；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWphMobileBusiQualificationPic("test");
            // 唯品会移动端店铺详情截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F801；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
            // request.setWphMobileStoreDetailPic("test");

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
            // 开关
            extendInfoMap.Add("switch_state", "1");
            // 支付手续费百分比
            extendInfoMap.Add("fee_rate", "0.04");
            // 支付手续费最小值
            extendInfoMap.Add("fee_min_amt", "");
            // 支付手续费外扣账户类型
            extendInfoMap.Add("out_fee_acct_type", "");
            // 支付手续费外扣标记
            extendInfoMap.Add("out_fee_flag", "2");
            // 全渠道资金管理补充材料id
            extendInfoMap.Add("other_payment_institutions_pic", "8c4f6254-6c36-3b3c-ae8b-efcf24ca215e");
            // XW银行数字证书及电子签名授权委托书
            // extendInfoMap.Add("xw_digital_certificate_pic", "");
            // 异步消息接收地址
            extendInfoMap.Add("async_return_url", "http://service.example.com/to/path");
            // 业务开通结果异步消息接收地址
            extendInfoMap.Add("busi_async_return_url", "http://service.example.com/to/path");
            // 申请单笔限额
            extendInfoMap.Add("pay_every_deal", "");
            // 申请单日限额
            extendInfoMap.Add("pay_every_day", "");
            // 全域资金分账规则
            // extendInfoMap.Add("efp_spb_config", get9c68bbd739af493e9027D6d2e4e8f4bb());
            // 客户ip地址
            // extendInfoMap.Add("ip_address", "");
            // 是否线上场景
            // extendInfoMap.Add("online_scene_flag", "");
            // 网店网址
            // extendInfoMap.Add("online_store_website", "");
            // 网店名称
            // extendInfoMap.Add("online_store_name", "");
            // 是否加盟连锁
            // extendInfoMap.Add("franchise_chain_flag", "");
            // 交易异步应答地址
            // extendInfoMap.Add("recon_resp_addr", "");
            // 协议类型
            // extendInfoMap.Add("agreement_type", "");
            // 全域资金取现手续费配置
            // extendInfoMap.Add("efp_encash_fee_config", get1990df443ba348bd9768107e2612cc1d());
            // 全域资金付款手续费配置
            // extendInfoMap.Add("efp_payment_fee_config", get6030b0527e524d37Ad86Ff411b9a78d1());
            // 纸质协议开始日期
            // extendInfoMap.Add("agree_begin_date", "");
            // 纸质协议结束日期
            // extendInfoMap.Add("agree_end_date", "");
            // 是否店群
            // extendInfoMap.Add("store_group_flag", "");
            // 商户经营类型
            // extendInfoMap.Add("store_busi_type", "");
            // 行业类型
            // extendInfoMap.Add("store_industry_type", "");
            // 经营信息材料
            // extendInfoMap.Add("management_file", "");
            // 全域资金分账手续费配置
            // extendInfoMap.Add("efp_spb_fee_config", get034ef171B86844e8A7deD5b30093e02a());
            return extendInfoMap;
        }

        private static string getD66709b2C1cd4c8f9a1a6e096c4c1d91() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 结算账户名
            obj.Add("card_name", "圆务铁白事");
            // 银行卡号
            obj.Add("card_no", "4340622119959288");
            // 卡类型
            obj.Add("card_type", "0");
            // 银行卡绑定手机号
            obj.Add("mp", "13777842539");
            // 开户许可证核准号对公卡必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：J2900123456789&lt;/font&gt;
            obj.Add("open_licence_no", "123456789");
            // 银行所在省
            obj.Add("prov_id", "310000");
            // 银行所在市
            obj.Add("area_id", "310100");
            // 银行编码
            obj.Add("bank_code", "01050000");
            // 支行联行号
            obj.Add("branch_code", "105290071113");
            // 支行名称
            obj.Add("branch_name", "中国建设银行股份有限公司上海市中支行");
            // 持卡人证件有效期（起始）
            obj.Add("cert_begin_date", "20240314");
            // 持卡人证件有效期（截止）
            obj.Add("cert_end_date", "");
            // 持卡人证件号码
            obj.Add("cert_no", "340000199810170714");
            // 持卡人证件类型
            obj.Add("cert_type", "00");
            // 持卡人证件有效期类型
            obj.Add("cert_validity_type", "1");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get38be8e044bfe44b48ff96f533f80e9e9() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 开户固定手续费(元)
            obj.Add("fee_fix_amt", "0");
            // 开户手续费外扣时的账户类型
            obj.Add("out_fee_acct_type", "");
            // 开户手续费外扣汇付ID
            obj.Add("out_fee_huifuid", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get074b4059011f41f5B6a97432ad51a199() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 签约人类型
            obj.Add("type", "LEGAL");
            // 签约人手机号
            obj.Add("mobile_no", "13777842539");
            // 签约人姓名
            // obj.Add("name", "");
            // 签约人身份证
            // obj.Add("cert_no", "");
            // 签约人邮箱
            // obj.Add("email", "");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get76777ca5097c46b385342a0bc037e15a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账接收方汇付ID
            // obj.Add("huifu_id", "test");
            // 分账接收方账户类型
            // obj.Add("acct_type", "test");
            // 分账比例(百分比)
            // obj.Add("split_bill_rate", "test");

            JArray objList = new JArray();
            objList.Add(JToken.FromObject(obj));
            return JsonConvert.SerializeObject(objList);
        }
        private static string get9c68bbd739af493e9027D6d2e4e8f4bb() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 分账规则来源
            // obj.Add("rule_origin", "test");
            // 全域资金分账手续费外扣标记1:外扣 2:内扣 规则来源为01时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1&lt;/font&gt;；
            // obj.Add("out_fee_flag", "test");
            // 全域资金分账内扣规则01-商户承担02-分账接收方承担 交易手续费外扣标记为2时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01&lt;/font&gt;；
            // obj.Add("in_fee_rule", "test");
            // 全域资金分账手续费外扣汇付ID交易手续费外扣标记为1时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812123&lt;/font&gt;；
            // obj.Add("out_fee_huifuid", "test");
            // 全域资金分账手续费外扣账户类型交易手续费外扣标记为1时必填 01-基本户05-充值户 09-营销户；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01&lt;/font&gt;；
            // obj.Add("out_fee_acct_type", "test");
            // 分账规则明细规则来源为01时必填 jsonArray格式 最多7条
            // obj.Add("rule_detail", get76777ca5097c46b385342a0bc037e15a());

            return JsonConvert.SerializeObject(obj);
        }
        private static string get1990df443ba348bd9768107e2612cc1d() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 全域资金取现手续费百分比
            // obj.Add("fee_rate", "test");
            // 全域资金取现手续费固定值
            // obj.Add("fee_fix_amt", "test");
            // 全域资金取现手续费收取类型
            // obj.Add("fee_charge_type", "test");
            // 全域资金取现手续费内外扣标记
            // obj.Add("out_fee_flag", "test");
            // 全域资金取现手续费外扣汇付ID全域资金取现手续费内外扣标记为1:外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812123&lt;/font&gt;
            // obj.Add("out_fee_huifuid", "test");
            // 全域资金取现手续费外扣子账户号全域资金取现手续费内外扣标记为1:外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：F00598600&lt;/font&gt;
            // obj.Add("out_fee_acctid", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get6030b0527e524d37Ad86Ff411b9a78d1() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 全域资金付款手续费百分比
            // obj.Add("fee_rate", "test");
            // 全域资金付款手续费固定值
            // obj.Add("fee_fix_amt", "test");
            // 全域资金付款手续费收取类型
            // obj.Add("fee_charge_type", "test");
            // 全域资金付款手续费内外扣标记
            // obj.Add("out_fee_flag", "test");
            // 全域资金付款手续费外扣汇付ID全域资金付款手续费内外扣标记为1:外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812123&lt;/font&gt;
            // obj.Add("out_fee_huifuid", "test");
            // 全域资金付款手续费外扣子账户号全域资金付款手续费内外扣标记为1:外扣时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：F00598600&lt;/font&gt;
            // obj.Add("out_fee_acctid", "test");

            return JsonConvert.SerializeObject(obj);
        }
        private static string get034ef171B86844e8A7deD5b30093e02a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 全域资金分账配置开关
            // obj.Add("switch_state", "test");
            // 全域资金分账手续费百分比全域资金分账配置开关为开时必填，0-100之间的数,&lt;font color&#x3D;&quot;green&quot;&gt;示例值：0.21&lt;/font&gt;
            // obj.Add("fee_rate", "test");
            // 全域资金分账手续费固定值全域资金分账配置开关为开时必填，整数位最多12位，小数位最多2位；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：1.00&lt;/font&gt;
            // obj.Add("fee_fix_amt", "test");

            return JsonConvert.SerializeObject(obj);
        }
    }
}
