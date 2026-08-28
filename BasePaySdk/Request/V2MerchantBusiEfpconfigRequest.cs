using System;

namespace BasePaySdk.Request
{
    /**
     * 全渠道资金管理配置
     *
     * @author sdk-generator
     * @Description
     */
    public class V2MerchantBusiEfpconfigRequest : BaseRequest
    {

        /**
         * 请求流水号
         */
        private string reqSeqId;
        /**
         * 请求日期
         */
        private string reqDate;
        /**
         * 商户汇付id
         */
        private string huifuId;
        /**
         * 所属渠道商
         */
        private string upperHuifuId;
        /**
         * 支付手续费外扣汇付ID支付手续费外扣标记为1时必填；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：6666000109812123&lt;/font&gt;
         */
        private string outFeeHuifuid;
        /**
         * 全域资金开户使用的银行卡信息首次开通时必填 jsonObject格式
         */
        private string outOrderAcctCard;
        /**
         * 全域资金开户手续费首次开通时必填 jsonObject格式
         */
        private string outOrderAcctOpenFees;
        /**
         * 业务模式acquiringMode:收单模式 switch_state为1时必填
         */
        private string businessModel;
        /**
         * 银行类型switch_state有值时需填写； ht1-华通银行，xw0-XW银行，ss0-苏商银行,wz1-微众银行&lt;font color&#x3D;&quot;green&quot;&gt;示例值：ht1&lt;/font&gt;
         */
        private string outFundsGateId;
        /**
         * 签约人信息switch_state为1时必填 jsonObject格式
         */
        private string signUserInfo;
        /**
         * 入账来源开通全域资金时需填写；01:抖音 02:美团 03:快手 04:拼多多 05:小红书 06:淘宝/天猫/飞猪 07:微信视频号/微信小店 08:京东 09:饿了么 11:得物 12:唯品会 13:携程 14:支付宝直连 15:微信直连 16:滴滴加油 17:团油 18:通联 19:易宝 20:百度 21:顺丰22:希音23:高德 24:贝壳 多个逗号分隔；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01,02,05&lt;/font&gt;；
         */
        private string acctSource;
        /**
         * 抖音合作证明材料入账来源包含01:抖音时必填 文件类型F535；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dyCooperationProvePic;
        /**
         * 美团合作证明材料入账来源包含02:美团时必填 文件类型F536；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string mtCooperationProvePic;
        /**
         * 快手合作证明材料入账来源包含03:快手时必填 文件类型F537；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string ksCooperationProvePic;
        /**
         * 拼多多合作证明材料入账来源包含04:拼多多时必填 文件类型F538；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string pddCooperationProvePic;
        /**
         * 小红书合作证明材料入账来源包含05:小红书时必填 文件类型F539；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xhsCooperationProvePic;
        /**
         * 淘宝天猫飞猪合作证明材料入账来源包含06:淘宝天猫飞猪时必填 文件类型F540；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string zfbCooperationProvePic;
        /**
         * 微信视频号合作证明材料入账来源包含07:微信视频号时必填 文件类型F541；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wxCooperationProvePic;
        /**
         * 京东合作证明材料入账来源包含08:京东时必填 文件类型F542；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string jdCooperationProvePic;
        /**
         * 饿了么合作证明材料入账来源包含09:饿了么时必填 文件类型F543；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string elmCooperationProvePic;
        /**
         * 得物合作证明材料入账来源包含11:得物时必填 文件类型F591；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dwCooperationProvePic;
        /**
         * 唯品会合作证明材料入账来源包含12:唯品会时必填 文件类型F592；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wphCooperationProvePic;
        /**
         * 携程合作证明材料入账来源包含13:携程时必填 文件类型F593；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xcCooperationProvePic;
        /**
         * 支付宝直连合作证明材料入账来源包含14:支付宝直连时必填 文件类型F594；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string zfbzlCooperationProvePic;
        /**
         * 微信直连合作证明材料入账来源包含15:微信直连时必填 文件类型F595；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wxzlCooperationProvePic;
        /**
         * 滴滴加油合作证明材料入账来源包含16:滴滴加油时必填 文件类型F596；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string ddjyCooperationProvePic;
        /**
         * 团油合作证明材料入账来源包含17:团油时必填 文件类型F597；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string tyCooperationProvePic;
        /**
         * 通联合作证明材料入账来源包含18:通联时必填 文件类型F598；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string tlCooperationProvePic;
        /**
         * 易宝合作证明材料入账来源包含19:易宝时必填 文件类型F599；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string ybCooperationProvePic;
        /**
         * 全渠道资金纸质协议文件协议类型为纸质时必填，文件类型F605；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string efpPaperAgreementFile;
        /**
         * 百度合作证明材料入账来源包含20:百度时必填 文件类型F616；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string bdCooperationProvePic;
        /**
         * 主店商户号是否店群为是时必填
         */
        private string mainStoreHuifuId;
        /**
         * 顺丰合作证明材料入账来源包含21:顺丰时必填 文件类型F618；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string sfCooperationProvePic;
        /**
         * 希音合作证明材料入账来源包含22:希音时必填 文件类型F619；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xyCooperationProvePic;
        /**
         * 高德合作证明材料入账来源包含23:高德时必填 文件类型F615；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string gdCooperationProvePic;
        /**
         * 贝壳合作证明材料入账来源包含24:贝壳时必填 文件类型F802；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string bkCooperationProvePic;
        /**
         * 抖音平台后台交易数据截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F730；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dyPlatformTransDataPic;
        /**
         * 抖音平台后台店铺信息截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F731；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dyPlatformStoreInfoPic;
        /**
         * 抖音平台后台经营主体截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F732；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dyPlatformBusiEntPic;
        /**
         * 抖音平台后台订单明细截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F733；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dyPlatformOrderDetailPic;
        /**
         * 抖音平台后台资金流水截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F734；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dyPlatformFundFlowPic;
        /**
         * 抖音移动端店铺橱窗截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F735；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dyMobileStoreShowcasePic;
        /**
         * 抖音移动端商家资质截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F736；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dyMobileBusiQualificationPic;
        /**
         * 抖音移动端店铺详情截屏开通微众银行且入账来源包含01:抖音时必填 文件类型F737；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dyMobileStoreDetailPic;
        /**
         * 快手平台后台交易数据截屏开通微众银行且入账来源包含03:快手时必填 文件类型F738；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string ksPlatformTransDataPic;
        /**
         * 快手平台后台店铺信息截屏开通微众银行且入账来源包含03:快手时必填 文件类型F739；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string ksPlatformStoreInfoPic;
        /**
         * 快手平台后台经营主体截屏开通微众银行且入账来源包含03:快手时必填 文件类型F740；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string ksPlatformBusiEntPic;
        /**
         * 快手平台后台订单明细截屏开通微众银行且入账来源包含03:快手时必填 文件类型F741；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string ksPlatformOrderDetailPic;
        /**
         * 快手平台后台资金流水截屏开通微众银行且入账来源包含03:快手时必填 文件类型F742；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string ksPlatformFundFlowPic;
        /**
         * 快手移动端店铺橱窗截屏开通微众银行且入账来源包含03:快手时必填 文件类型F743；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string ksMobileStoreShowcasePic;
        /**
         * 快手移动端商家资质截屏开通微众银行且入账来源包含03:快手时必填 文件类型F744；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string ksMobileBusiQualificationPic;
        /**
         * 快手移动端店铺详情截屏开通微众银行且入账来源包含03:快手时必填 文件类型F745；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string ksMobileStoreDetailPic;
        /**
         * 拼多多平台后台交易数据截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F746；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string pddPlatformTransDataPic;
        /**
         * 拼多多平台后台店铺信息截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F747；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string pddPlatformStoreInfoPic;
        /**
         * 拼多多平台后台经营主体截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F748；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string pddPlatformBusiEntPic;
        /**
         * 拼多多平台后台订单明细截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F749；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string pddPlatformOrderDetailPic;
        /**
         * 拼多多平台后台资金流水截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F750；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string pddPlatformFundFlowPic;
        /**
         * 拼多多移动端店铺橱窗截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F751；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string pddMobileStoreShowcasePic;
        /**
         * 拼多多移动端商家资质截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F752；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string pddMobileBusiQualificationPic;
        /**
         * 拼多多移动端店铺详情截屏开通微众银行且入账来源包含04:拼多多时必填 文件类型F753；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string pddMobileStoreDetailPic;
        /**
         * 小红书平台后台交易数据截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F754；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xhsPlatformTransDataPic;
        /**
         * 小红书平台后台店铺信息截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F755；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xhsPlatformStoreInfoPic;
        /**
         * 小红书平台后台经营主体截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F756；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xhsPlatformBusiEntPic;
        /**
         * 小红书平台后台订单明细截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F757；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xhsPlatformOrderDetailPic;
        /**
         * 小红书平台后台资金流水截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F758；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xhsPlatformFundFlowPic;
        /**
         * 小红书移动端店铺橱窗截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F759；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xhsMobileStoreShowcasePic;
        /**
         * 小红书移动端商家资质截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F760；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xhsMobileBusiQualificationPic;
        /**
         * 小红书移动端店铺详情截屏开通微众银行且入账来源包含05:小红书时必填 文件类型F761；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string xhsMobileStoreDetailPic;
        /**
         * 微信视频号平台后台交易数据截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F762；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wxsphPlatformTransDataPic;
        /**
         * 微信视频号平台后台店铺信息截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F763；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wxsphPlatformStoreInfoPic;
        /**
         * 微信视频号平台后台经营主体截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F764；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wxsphPlatformBusiEntPic;
        /**
         * 微信视频号平台后台订单明细截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F765；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wxsphPlatformOrderDetailPic;
        /**
         * 微信视频号平台后台资金流水截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F766；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wxsphPlatformFundFlowPic;
        /**
         * 微信视频号移动端店铺橱窗截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F767；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wxsphMobileStoreShowcasePic;
        /**
         * 微信视频号移动端商家资质截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F768；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wxsphMobileBusiQualificationPic;
        /**
         * 微信视频号移动端店铺详情截屏开通微众银行且入账来源包含07:微信视频号时必填 文件类型F769；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wxsphMobileStoreDetailPic;
        /**
         * 京东平台后台交易数据截屏开通微众银行且入账来源包含08:京东时必填 文件类型F770；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string jdPlatformTransDataPic;
        /**
         * 京东平台后台店铺信息截屏开通微众银行且入账来源包含08:京东时必填 文件类型F771；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string jdPlatformStoreInfoPic;
        /**
         * 京东平台后台经营主体截屏开通微众银行且入账来源包含08:京东时必填 文件类型F772；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string jdPlatformBusiEntPic;
        /**
         * 京东平台后台订单明细截屏开通微众银行且入账来源包含08:京东时必填 文件类型F773；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string jdPlatformOrderDetailPic;
        /**
         * 京东平台后台资金流水截屏开通微众银行且入账来源包含08:京东时必填 文件类型F774；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string jdPlatformFundFlowPic;
        /**
         * 京东移动端店铺橱窗截屏开通微众银行且入账来源包含08:京东时必填 文件类型F775；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string jdMobileStoreShowcasePic;
        /**
         * 京东移动端商家资质截屏开通微众银行且入账来源包含08:京东时必填 文件类型F776；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string jdMobileBusiQualificationPic;
        /**
         * 京东移动端店铺详情截屏开通微众银行且入账来源包含08:京东时必填 文件类型F777；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string jdMobileStoreDetailPic;
        /**
         * 得物平台后台交易数据截屏开通微众银行且入账来源包含11:得物时必填 文件类型F778；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dwPlatformTransDataPic;
        /**
         * 得物平台后台店铺信息截屏开通微众银行且入账来源包含11:得物时必填 文件类型F779；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dwPlatformStoreInfoPic;
        /**
         * 得物平台后台经营主体截屏开通微众银行且入账来源包含11:得物时必填 文件类型F780；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dwPlatformBusiEntPic;
        /**
         * 得物平台后台订单明细截屏开通微众银行且入账来源包含11:得物时必填 文件类型F781；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dwPlatformOrderDetailPic;
        /**
         * 得物平台后台资金流水截屏开通微众银行且入账来源包含11:得物时必填 文件类型F782；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dwPlatformFundFlowPic;
        /**
         * 得物移动端店铺橱窗截屏开通微众银行且入账来源包含11:得物时必填 文件类型F783；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dwMobileStoreShowcasePic;
        /**
         * 得物移动端商家资质截屏开通微众银行且入账来源包含11:得物时必填 文件类型F784；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dwMobileBusiQualificationPic;
        /**
         * 得物移动端店铺详情截屏开通微众银行且入账来源包含11:得物时必填 文件类型F785；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string dwMobileStoreDetailPic;
        /**
         * 美团平台后台交易数据截屏开通微众银行且入账来源包含02:美团时必填 文件类型F786；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string mtPlatformTransDataPic;
        /**
         * 美团平台后台店铺信息截屏开通微众银行且入账来源包含02:美团时必填 文件类型F787；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string mtPlatformStoreInfoPic;
        /**
         * 美团平台后台经营主体截屏开通微众银行且入账来源包含02:美团时必填 文件类型F788；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string mtPlatformBusiEntPic;
        /**
         * 美团平台后台订单明细截屏开通微众银行且入账来源包含02:美团时必填 文件类型F789；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string mtPlatformOrderDetailPic;
        /**
         * 美团平台后台资金流水截屏开通微众银行且入账来源包含02:美团时必填 文件类型F790；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string mtPlatformFundFlowPic;
        /**
         * 美团移动端店铺橱窗截屏开通微众银行且入账来源包含02:美团时必填 文件类型F791；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string mtMobileStoreShowcasePic;
        /**
         * 美团移动端商家资质截屏开通微众银行且入账来源包含02:美团时必填 文件类型F792；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string mtMobileBusiQualificationPic;
        /**
         * 美团移动端店铺详情截屏开通微众银行且入账来源包含02:美团时必填 文件类型F793；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string mtMobileStoreDetailPic;
        /**
         * 唯品会平台后台交易数据截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F794；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wphPlatformTransDataPic;
        /**
         * 唯品会平台后台店铺信息截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F795；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wphPlatformStoreInfoPic;
        /**
         * 唯品会平台后台经营主体截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F796；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wphPlatformBusiEntPic;
        /**
         * 唯品会平台后台订单明细截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F797；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wphPlatformOrderDetailPic;
        /**
         * 唯品会平台后台资金流水截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F798；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wphPlatformFundFlowPic;
        /**
         * 唯品会移动端店铺橱窗截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F799；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wphMobileStoreShowcasePic;
        /**
         * 唯品会移动端商家资质截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F800；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wphMobileBusiQualificationPic;
        /**
         * 唯品会移动端店铺详情截屏开通微众银行且入账来源包含12:唯品会时必填 文件类型F801；详见[文件类型说明](https://paas.huifu.com/open/doc/api/#/csfl/api_csfl_wjlx)；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：57cc7f00-600a-33ab-b614-6221bbf2e530&lt;/font&gt;
         */
        private string wphMobileStoreDetailPic;

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_EFPCONFIG;
        }

        public V2MerchantBusiEfpconfigRequest() {
        }

        public V2MerchantBusiEfpconfigRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string outFeeHuifuid, string outOrderAcctCard, string outOrderAcctOpenFees, string businessModel, string outFundsGateId, string signUserInfo, string acctSource, string dyCooperationProvePic, string mtCooperationProvePic, string ksCooperationProvePic, string pddCooperationProvePic, string xhsCooperationProvePic, string zfbCooperationProvePic, string wxCooperationProvePic, string jdCooperationProvePic, string elmCooperationProvePic, string dwCooperationProvePic, string wphCooperationProvePic, string xcCooperationProvePic, string zfbzlCooperationProvePic, string wxzlCooperationProvePic, string ddjyCooperationProvePic, string tyCooperationProvePic, string tlCooperationProvePic, string ybCooperationProvePic, string efpPaperAgreementFile, string bdCooperationProvePic, string mainStoreHuifuId, string sfCooperationProvePic, string xyCooperationProvePic, string gdCooperationProvePic, string bkCooperationProvePic, string dyPlatformTransDataPic, string dyPlatformStoreInfoPic, string dyPlatformBusiEntPic, string dyPlatformOrderDetailPic, string dyPlatformFundFlowPic, string dyMobileStoreShowcasePic, string dyMobileBusiQualificationPic, string dyMobileStoreDetailPic, string ksPlatformTransDataPic, string ksPlatformStoreInfoPic, string ksPlatformBusiEntPic, string ksPlatformOrderDetailPic, string ksPlatformFundFlowPic, string ksMobileStoreShowcasePic, string ksMobileBusiQualificationPic, string ksMobileStoreDetailPic, string pddPlatformTransDataPic, string pddPlatformStoreInfoPic, string pddPlatformBusiEntPic, string pddPlatformOrderDetailPic, string pddPlatformFundFlowPic, string pddMobileStoreShowcasePic, string pddMobileBusiQualificationPic, string pddMobileStoreDetailPic, string xhsPlatformTransDataPic, string xhsPlatformStoreInfoPic, string xhsPlatformBusiEntPic, string xhsPlatformOrderDetailPic, string xhsPlatformFundFlowPic, string xhsMobileStoreShowcasePic, string xhsMobileBusiQualificationPic, string xhsMobileStoreDetailPic, string wxsphPlatformTransDataPic, string wxsphPlatformStoreInfoPic, string wxsphPlatformBusiEntPic, string wxsphPlatformOrderDetailPic, string wxsphPlatformFundFlowPic, string wxsphMobileStoreShowcasePic, string wxsphMobileBusiQualificationPic, string wxsphMobileStoreDetailPic, string jdPlatformTransDataPic, string jdPlatformStoreInfoPic, string jdPlatformBusiEntPic, string jdPlatformOrderDetailPic, string jdPlatformFundFlowPic, string jdMobileStoreShowcasePic, string jdMobileBusiQualificationPic, string jdMobileStoreDetailPic, string dwPlatformTransDataPic, string dwPlatformStoreInfoPic, string dwPlatformBusiEntPic, string dwPlatformOrderDetailPic, string dwPlatformFundFlowPic, string dwMobileStoreShowcasePic, string dwMobileBusiQualificationPic, string dwMobileStoreDetailPic, string mtPlatformTransDataPic, string mtPlatformStoreInfoPic, string mtPlatformBusiEntPic, string mtPlatformOrderDetailPic, string mtPlatformFundFlowPic, string mtMobileStoreShowcasePic, string mtMobileBusiQualificationPic, string mtMobileStoreDetailPic, string wphPlatformTransDataPic, string wphPlatformStoreInfoPic, string wphPlatformBusiEntPic, string wphPlatformOrderDetailPic, string wphPlatformFundFlowPic, string wphMobileStoreShowcasePic, string wphMobileBusiQualificationPic, string wphMobileStoreDetailPic) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.outFeeHuifuid = outFeeHuifuid;
            this.outOrderAcctCard = outOrderAcctCard;
            this.outOrderAcctOpenFees = outOrderAcctOpenFees;
            this.businessModel = businessModel;
            this.outFundsGateId = outFundsGateId;
            this.signUserInfo = signUserInfo;
            this.acctSource = acctSource;
            this.dyCooperationProvePic = dyCooperationProvePic;
            this.mtCooperationProvePic = mtCooperationProvePic;
            this.ksCooperationProvePic = ksCooperationProvePic;
            this.pddCooperationProvePic = pddCooperationProvePic;
            this.xhsCooperationProvePic = xhsCooperationProvePic;
            this.zfbCooperationProvePic = zfbCooperationProvePic;
            this.wxCooperationProvePic = wxCooperationProvePic;
            this.jdCooperationProvePic = jdCooperationProvePic;
            this.elmCooperationProvePic = elmCooperationProvePic;
            this.dwCooperationProvePic = dwCooperationProvePic;
            this.wphCooperationProvePic = wphCooperationProvePic;
            this.xcCooperationProvePic = xcCooperationProvePic;
            this.zfbzlCooperationProvePic = zfbzlCooperationProvePic;
            this.wxzlCooperationProvePic = wxzlCooperationProvePic;
            this.ddjyCooperationProvePic = ddjyCooperationProvePic;
            this.tyCooperationProvePic = tyCooperationProvePic;
            this.tlCooperationProvePic = tlCooperationProvePic;
            this.ybCooperationProvePic = ybCooperationProvePic;
            this.efpPaperAgreementFile = efpPaperAgreementFile;
            this.bdCooperationProvePic = bdCooperationProvePic;
            this.mainStoreHuifuId = mainStoreHuifuId;
            this.sfCooperationProvePic = sfCooperationProvePic;
            this.xyCooperationProvePic = xyCooperationProvePic;
            this.gdCooperationProvePic = gdCooperationProvePic;
            this.bkCooperationProvePic = bkCooperationProvePic;
            this.dyPlatformTransDataPic = dyPlatformTransDataPic;
            this.dyPlatformStoreInfoPic = dyPlatformStoreInfoPic;
            this.dyPlatformBusiEntPic = dyPlatformBusiEntPic;
            this.dyPlatformOrderDetailPic = dyPlatformOrderDetailPic;
            this.dyPlatformFundFlowPic = dyPlatformFundFlowPic;
            this.dyMobileStoreShowcasePic = dyMobileStoreShowcasePic;
            this.dyMobileBusiQualificationPic = dyMobileBusiQualificationPic;
            this.dyMobileStoreDetailPic = dyMobileStoreDetailPic;
            this.ksPlatformTransDataPic = ksPlatformTransDataPic;
            this.ksPlatformStoreInfoPic = ksPlatformStoreInfoPic;
            this.ksPlatformBusiEntPic = ksPlatformBusiEntPic;
            this.ksPlatformOrderDetailPic = ksPlatformOrderDetailPic;
            this.ksPlatformFundFlowPic = ksPlatformFundFlowPic;
            this.ksMobileStoreShowcasePic = ksMobileStoreShowcasePic;
            this.ksMobileBusiQualificationPic = ksMobileBusiQualificationPic;
            this.ksMobileStoreDetailPic = ksMobileStoreDetailPic;
            this.pddPlatformTransDataPic = pddPlatformTransDataPic;
            this.pddPlatformStoreInfoPic = pddPlatformStoreInfoPic;
            this.pddPlatformBusiEntPic = pddPlatformBusiEntPic;
            this.pddPlatformOrderDetailPic = pddPlatformOrderDetailPic;
            this.pddPlatformFundFlowPic = pddPlatformFundFlowPic;
            this.pddMobileStoreShowcasePic = pddMobileStoreShowcasePic;
            this.pddMobileBusiQualificationPic = pddMobileBusiQualificationPic;
            this.pddMobileStoreDetailPic = pddMobileStoreDetailPic;
            this.xhsPlatformTransDataPic = xhsPlatformTransDataPic;
            this.xhsPlatformStoreInfoPic = xhsPlatformStoreInfoPic;
            this.xhsPlatformBusiEntPic = xhsPlatformBusiEntPic;
            this.xhsPlatformOrderDetailPic = xhsPlatformOrderDetailPic;
            this.xhsPlatformFundFlowPic = xhsPlatformFundFlowPic;
            this.xhsMobileStoreShowcasePic = xhsMobileStoreShowcasePic;
            this.xhsMobileBusiQualificationPic = xhsMobileBusiQualificationPic;
            this.xhsMobileStoreDetailPic = xhsMobileStoreDetailPic;
            this.wxsphPlatformTransDataPic = wxsphPlatformTransDataPic;
            this.wxsphPlatformStoreInfoPic = wxsphPlatformStoreInfoPic;
            this.wxsphPlatformBusiEntPic = wxsphPlatformBusiEntPic;
            this.wxsphPlatformOrderDetailPic = wxsphPlatformOrderDetailPic;
            this.wxsphPlatformFundFlowPic = wxsphPlatformFundFlowPic;
            this.wxsphMobileStoreShowcasePic = wxsphMobileStoreShowcasePic;
            this.wxsphMobileBusiQualificationPic = wxsphMobileBusiQualificationPic;
            this.wxsphMobileStoreDetailPic = wxsphMobileStoreDetailPic;
            this.jdPlatformTransDataPic = jdPlatformTransDataPic;
            this.jdPlatformStoreInfoPic = jdPlatformStoreInfoPic;
            this.jdPlatformBusiEntPic = jdPlatformBusiEntPic;
            this.jdPlatformOrderDetailPic = jdPlatformOrderDetailPic;
            this.jdPlatformFundFlowPic = jdPlatformFundFlowPic;
            this.jdMobileStoreShowcasePic = jdMobileStoreShowcasePic;
            this.jdMobileBusiQualificationPic = jdMobileBusiQualificationPic;
            this.jdMobileStoreDetailPic = jdMobileStoreDetailPic;
            this.dwPlatformTransDataPic = dwPlatformTransDataPic;
            this.dwPlatformStoreInfoPic = dwPlatformStoreInfoPic;
            this.dwPlatformBusiEntPic = dwPlatformBusiEntPic;
            this.dwPlatformOrderDetailPic = dwPlatformOrderDetailPic;
            this.dwPlatformFundFlowPic = dwPlatformFundFlowPic;
            this.dwMobileStoreShowcasePic = dwMobileStoreShowcasePic;
            this.dwMobileBusiQualificationPic = dwMobileBusiQualificationPic;
            this.dwMobileStoreDetailPic = dwMobileStoreDetailPic;
            this.mtPlatformTransDataPic = mtPlatformTransDataPic;
            this.mtPlatformStoreInfoPic = mtPlatformStoreInfoPic;
            this.mtPlatformBusiEntPic = mtPlatformBusiEntPic;
            this.mtPlatformOrderDetailPic = mtPlatformOrderDetailPic;
            this.mtPlatformFundFlowPic = mtPlatformFundFlowPic;
            this.mtMobileStoreShowcasePic = mtMobileStoreShowcasePic;
            this.mtMobileBusiQualificationPic = mtMobileBusiQualificationPic;
            this.mtMobileStoreDetailPic = mtMobileStoreDetailPic;
            this.wphPlatformTransDataPic = wphPlatformTransDataPic;
            this.wphPlatformStoreInfoPic = wphPlatformStoreInfoPic;
            this.wphPlatformBusiEntPic = wphPlatformBusiEntPic;
            this.wphPlatformOrderDetailPic = wphPlatformOrderDetailPic;
            this.wphPlatformFundFlowPic = wphPlatformFundFlowPic;
            this.wphMobileStoreShowcasePic = wphMobileStoreShowcasePic;
            this.wphMobileBusiQualificationPic = wphMobileBusiQualificationPic;
            this.wphMobileStoreDetailPic = wphMobileStoreDetailPic;
        }

        public string getReqSeqId() {
            return reqSeqId;
        }

        public void setReqSeqId(string reqSeqId) {
            this.reqSeqId = reqSeqId;
        }

        public string getReqDate() {
            return reqDate;
        }

        public void setReqDate(string reqDate) {
            this.reqDate = reqDate;
        }

        public string getHuifuId() {
            return huifuId;
        }

        public void setHuifuId(string huifuId) {
            this.huifuId = huifuId;
        }

        public string getUpperHuifuId() {
            return upperHuifuId;
        }

        public void setUpperHuifuId(string upperHuifuId) {
            this.upperHuifuId = upperHuifuId;
        }

        public string getOutFeeHuifuid() {
            return outFeeHuifuid;
        }

        public void setOutFeeHuifuid(string outFeeHuifuid) {
            this.outFeeHuifuid = outFeeHuifuid;
        }

        public string getOutOrderAcctCard() {
            return outOrderAcctCard;
        }

        public void setOutOrderAcctCard(string outOrderAcctCard) {
            this.outOrderAcctCard = outOrderAcctCard;
        }

        public string getOutOrderAcctOpenFees() {
            return outOrderAcctOpenFees;
        }

        public void setOutOrderAcctOpenFees(string outOrderAcctOpenFees) {
            this.outOrderAcctOpenFees = outOrderAcctOpenFees;
        }

        public string getBusinessModel() {
            return businessModel;
        }

        public void setBusinessModel(string businessModel) {
            this.businessModel = businessModel;
        }

        public string getOutFundsGateId() {
            return outFundsGateId;
        }

        public void setOutFundsGateId(string outFundsGateId) {
            this.outFundsGateId = outFundsGateId;
        }

        public string getSignUserInfo() {
            return signUserInfo;
        }

        public void setSignUserInfo(string signUserInfo) {
            this.signUserInfo = signUserInfo;
        }

        public string getAcctSource() {
            return acctSource;
        }

        public void setAcctSource(string acctSource) {
            this.acctSource = acctSource;
        }

        public string getDyCooperationProvePic() {
            return dyCooperationProvePic;
        }

        public void setDyCooperationProvePic(string dyCooperationProvePic) {
            this.dyCooperationProvePic = dyCooperationProvePic;
        }

        public string getMtCooperationProvePic() {
            return mtCooperationProvePic;
        }

        public void setMtCooperationProvePic(string mtCooperationProvePic) {
            this.mtCooperationProvePic = mtCooperationProvePic;
        }

        public string getKsCooperationProvePic() {
            return ksCooperationProvePic;
        }

        public void setKsCooperationProvePic(string ksCooperationProvePic) {
            this.ksCooperationProvePic = ksCooperationProvePic;
        }

        public string getPddCooperationProvePic() {
            return pddCooperationProvePic;
        }

        public void setPddCooperationProvePic(string pddCooperationProvePic) {
            this.pddCooperationProvePic = pddCooperationProvePic;
        }

        public string getXhsCooperationProvePic() {
            return xhsCooperationProvePic;
        }

        public void setXhsCooperationProvePic(string xhsCooperationProvePic) {
            this.xhsCooperationProvePic = xhsCooperationProvePic;
        }

        public string getZfbCooperationProvePic() {
            return zfbCooperationProvePic;
        }

        public void setZfbCooperationProvePic(string zfbCooperationProvePic) {
            this.zfbCooperationProvePic = zfbCooperationProvePic;
        }

        public string getWxCooperationProvePic() {
            return wxCooperationProvePic;
        }

        public void setWxCooperationProvePic(string wxCooperationProvePic) {
            this.wxCooperationProvePic = wxCooperationProvePic;
        }

        public string getJdCooperationProvePic() {
            return jdCooperationProvePic;
        }

        public void setJdCooperationProvePic(string jdCooperationProvePic) {
            this.jdCooperationProvePic = jdCooperationProvePic;
        }

        public string getElmCooperationProvePic() {
            return elmCooperationProvePic;
        }

        public void setElmCooperationProvePic(string elmCooperationProvePic) {
            this.elmCooperationProvePic = elmCooperationProvePic;
        }

        public string getDwCooperationProvePic() {
            return dwCooperationProvePic;
        }

        public void setDwCooperationProvePic(string dwCooperationProvePic) {
            this.dwCooperationProvePic = dwCooperationProvePic;
        }

        public string getWphCooperationProvePic() {
            return wphCooperationProvePic;
        }

        public void setWphCooperationProvePic(string wphCooperationProvePic) {
            this.wphCooperationProvePic = wphCooperationProvePic;
        }

        public string getXcCooperationProvePic() {
            return xcCooperationProvePic;
        }

        public void setXcCooperationProvePic(string xcCooperationProvePic) {
            this.xcCooperationProvePic = xcCooperationProvePic;
        }

        public string getZfbzlCooperationProvePic() {
            return zfbzlCooperationProvePic;
        }

        public void setZfbzlCooperationProvePic(string zfbzlCooperationProvePic) {
            this.zfbzlCooperationProvePic = zfbzlCooperationProvePic;
        }

        public string getWxzlCooperationProvePic() {
            return wxzlCooperationProvePic;
        }

        public void setWxzlCooperationProvePic(string wxzlCooperationProvePic) {
            this.wxzlCooperationProvePic = wxzlCooperationProvePic;
        }

        public string getDdjyCooperationProvePic() {
            return ddjyCooperationProvePic;
        }

        public void setDdjyCooperationProvePic(string ddjyCooperationProvePic) {
            this.ddjyCooperationProvePic = ddjyCooperationProvePic;
        }

        public string getTyCooperationProvePic() {
            return tyCooperationProvePic;
        }

        public void setTyCooperationProvePic(string tyCooperationProvePic) {
            this.tyCooperationProvePic = tyCooperationProvePic;
        }

        public string getTlCooperationProvePic() {
            return tlCooperationProvePic;
        }

        public void setTlCooperationProvePic(string tlCooperationProvePic) {
            this.tlCooperationProvePic = tlCooperationProvePic;
        }

        public string getYbCooperationProvePic() {
            return ybCooperationProvePic;
        }

        public void setYbCooperationProvePic(string ybCooperationProvePic) {
            this.ybCooperationProvePic = ybCooperationProvePic;
        }

        public string getEfpPaperAgreementFile() {
            return efpPaperAgreementFile;
        }

        public void setEfpPaperAgreementFile(string efpPaperAgreementFile) {
            this.efpPaperAgreementFile = efpPaperAgreementFile;
        }

        public string getBdCooperationProvePic() {
            return bdCooperationProvePic;
        }

        public void setBdCooperationProvePic(string bdCooperationProvePic) {
            this.bdCooperationProvePic = bdCooperationProvePic;
        }

        public string getMainStoreHuifuId() {
            return mainStoreHuifuId;
        }

        public void setMainStoreHuifuId(string mainStoreHuifuId) {
            this.mainStoreHuifuId = mainStoreHuifuId;
        }

        public string getSfCooperationProvePic() {
            return sfCooperationProvePic;
        }

        public void setSfCooperationProvePic(string sfCooperationProvePic) {
            this.sfCooperationProvePic = sfCooperationProvePic;
        }

        public string getXyCooperationProvePic() {
            return xyCooperationProvePic;
        }

        public void setXyCooperationProvePic(string xyCooperationProvePic) {
            this.xyCooperationProvePic = xyCooperationProvePic;
        }

        public string getGdCooperationProvePic() {
            return gdCooperationProvePic;
        }

        public void setGdCooperationProvePic(string gdCooperationProvePic) {
            this.gdCooperationProvePic = gdCooperationProvePic;
        }

        public string getBkCooperationProvePic() {
            return bkCooperationProvePic;
        }

        public void setBkCooperationProvePic(string bkCooperationProvePic) {
            this.bkCooperationProvePic = bkCooperationProvePic;
        }

        public string getDyPlatformTransDataPic() {
            return dyPlatformTransDataPic;
        }

        public void setDyPlatformTransDataPic(string dyPlatformTransDataPic) {
            this.dyPlatformTransDataPic = dyPlatformTransDataPic;
        }

        public string getDyPlatformStoreInfoPic() {
            return dyPlatformStoreInfoPic;
        }

        public void setDyPlatformStoreInfoPic(string dyPlatformStoreInfoPic) {
            this.dyPlatformStoreInfoPic = dyPlatformStoreInfoPic;
        }

        public string getDyPlatformBusiEntPic() {
            return dyPlatformBusiEntPic;
        }

        public void setDyPlatformBusiEntPic(string dyPlatformBusiEntPic) {
            this.dyPlatformBusiEntPic = dyPlatformBusiEntPic;
        }

        public string getDyPlatformOrderDetailPic() {
            return dyPlatformOrderDetailPic;
        }

        public void setDyPlatformOrderDetailPic(string dyPlatformOrderDetailPic) {
            this.dyPlatformOrderDetailPic = dyPlatformOrderDetailPic;
        }

        public string getDyPlatformFundFlowPic() {
            return dyPlatformFundFlowPic;
        }

        public void setDyPlatformFundFlowPic(string dyPlatformFundFlowPic) {
            this.dyPlatformFundFlowPic = dyPlatformFundFlowPic;
        }

        public string getDyMobileStoreShowcasePic() {
            return dyMobileStoreShowcasePic;
        }

        public void setDyMobileStoreShowcasePic(string dyMobileStoreShowcasePic) {
            this.dyMobileStoreShowcasePic = dyMobileStoreShowcasePic;
        }

        public string getDyMobileBusiQualificationPic() {
            return dyMobileBusiQualificationPic;
        }

        public void setDyMobileBusiQualificationPic(string dyMobileBusiQualificationPic) {
            this.dyMobileBusiQualificationPic = dyMobileBusiQualificationPic;
        }

        public string getDyMobileStoreDetailPic() {
            return dyMobileStoreDetailPic;
        }

        public void setDyMobileStoreDetailPic(string dyMobileStoreDetailPic) {
            this.dyMobileStoreDetailPic = dyMobileStoreDetailPic;
        }

        public string getKsPlatformTransDataPic() {
            return ksPlatformTransDataPic;
        }

        public void setKsPlatformTransDataPic(string ksPlatformTransDataPic) {
            this.ksPlatformTransDataPic = ksPlatformTransDataPic;
        }

        public string getKsPlatformStoreInfoPic() {
            return ksPlatformStoreInfoPic;
        }

        public void setKsPlatformStoreInfoPic(string ksPlatformStoreInfoPic) {
            this.ksPlatformStoreInfoPic = ksPlatformStoreInfoPic;
        }

        public string getKsPlatformBusiEntPic() {
            return ksPlatformBusiEntPic;
        }

        public void setKsPlatformBusiEntPic(string ksPlatformBusiEntPic) {
            this.ksPlatformBusiEntPic = ksPlatformBusiEntPic;
        }

        public string getKsPlatformOrderDetailPic() {
            return ksPlatformOrderDetailPic;
        }

        public void setKsPlatformOrderDetailPic(string ksPlatformOrderDetailPic) {
            this.ksPlatformOrderDetailPic = ksPlatformOrderDetailPic;
        }

        public string getKsPlatformFundFlowPic() {
            return ksPlatformFundFlowPic;
        }

        public void setKsPlatformFundFlowPic(string ksPlatformFundFlowPic) {
            this.ksPlatformFundFlowPic = ksPlatformFundFlowPic;
        }

        public string getKsMobileStoreShowcasePic() {
            return ksMobileStoreShowcasePic;
        }

        public void setKsMobileStoreShowcasePic(string ksMobileStoreShowcasePic) {
            this.ksMobileStoreShowcasePic = ksMobileStoreShowcasePic;
        }

        public string getKsMobileBusiQualificationPic() {
            return ksMobileBusiQualificationPic;
        }

        public void setKsMobileBusiQualificationPic(string ksMobileBusiQualificationPic) {
            this.ksMobileBusiQualificationPic = ksMobileBusiQualificationPic;
        }

        public string getKsMobileStoreDetailPic() {
            return ksMobileStoreDetailPic;
        }

        public void setKsMobileStoreDetailPic(string ksMobileStoreDetailPic) {
            this.ksMobileStoreDetailPic = ksMobileStoreDetailPic;
        }

        public string getPddPlatformTransDataPic() {
            return pddPlatformTransDataPic;
        }

        public void setPddPlatformTransDataPic(string pddPlatformTransDataPic) {
            this.pddPlatformTransDataPic = pddPlatformTransDataPic;
        }

        public string getPddPlatformStoreInfoPic() {
            return pddPlatformStoreInfoPic;
        }

        public void setPddPlatformStoreInfoPic(string pddPlatformStoreInfoPic) {
            this.pddPlatformStoreInfoPic = pddPlatformStoreInfoPic;
        }

        public string getPddPlatformBusiEntPic() {
            return pddPlatformBusiEntPic;
        }

        public void setPddPlatformBusiEntPic(string pddPlatformBusiEntPic) {
            this.pddPlatformBusiEntPic = pddPlatformBusiEntPic;
        }

        public string getPddPlatformOrderDetailPic() {
            return pddPlatformOrderDetailPic;
        }

        public void setPddPlatformOrderDetailPic(string pddPlatformOrderDetailPic) {
            this.pddPlatformOrderDetailPic = pddPlatformOrderDetailPic;
        }

        public string getPddPlatformFundFlowPic() {
            return pddPlatformFundFlowPic;
        }

        public void setPddPlatformFundFlowPic(string pddPlatformFundFlowPic) {
            this.pddPlatformFundFlowPic = pddPlatformFundFlowPic;
        }

        public string getPddMobileStoreShowcasePic() {
            return pddMobileStoreShowcasePic;
        }

        public void setPddMobileStoreShowcasePic(string pddMobileStoreShowcasePic) {
            this.pddMobileStoreShowcasePic = pddMobileStoreShowcasePic;
        }

        public string getPddMobileBusiQualificationPic() {
            return pddMobileBusiQualificationPic;
        }

        public void setPddMobileBusiQualificationPic(string pddMobileBusiQualificationPic) {
            this.pddMobileBusiQualificationPic = pddMobileBusiQualificationPic;
        }

        public string getPddMobileStoreDetailPic() {
            return pddMobileStoreDetailPic;
        }

        public void setPddMobileStoreDetailPic(string pddMobileStoreDetailPic) {
            this.pddMobileStoreDetailPic = pddMobileStoreDetailPic;
        }

        public string getXhsPlatformTransDataPic() {
            return xhsPlatformTransDataPic;
        }

        public void setXhsPlatformTransDataPic(string xhsPlatformTransDataPic) {
            this.xhsPlatformTransDataPic = xhsPlatformTransDataPic;
        }

        public string getXhsPlatformStoreInfoPic() {
            return xhsPlatformStoreInfoPic;
        }

        public void setXhsPlatformStoreInfoPic(string xhsPlatformStoreInfoPic) {
            this.xhsPlatformStoreInfoPic = xhsPlatformStoreInfoPic;
        }

        public string getXhsPlatformBusiEntPic() {
            return xhsPlatformBusiEntPic;
        }

        public void setXhsPlatformBusiEntPic(string xhsPlatformBusiEntPic) {
            this.xhsPlatformBusiEntPic = xhsPlatformBusiEntPic;
        }

        public string getXhsPlatformOrderDetailPic() {
            return xhsPlatformOrderDetailPic;
        }

        public void setXhsPlatformOrderDetailPic(string xhsPlatformOrderDetailPic) {
            this.xhsPlatformOrderDetailPic = xhsPlatformOrderDetailPic;
        }

        public string getXhsPlatformFundFlowPic() {
            return xhsPlatformFundFlowPic;
        }

        public void setXhsPlatformFundFlowPic(string xhsPlatformFundFlowPic) {
            this.xhsPlatformFundFlowPic = xhsPlatformFundFlowPic;
        }

        public string getXhsMobileStoreShowcasePic() {
            return xhsMobileStoreShowcasePic;
        }

        public void setXhsMobileStoreShowcasePic(string xhsMobileStoreShowcasePic) {
            this.xhsMobileStoreShowcasePic = xhsMobileStoreShowcasePic;
        }

        public string getXhsMobileBusiQualificationPic() {
            return xhsMobileBusiQualificationPic;
        }

        public void setXhsMobileBusiQualificationPic(string xhsMobileBusiQualificationPic) {
            this.xhsMobileBusiQualificationPic = xhsMobileBusiQualificationPic;
        }

        public string getXhsMobileStoreDetailPic() {
            return xhsMobileStoreDetailPic;
        }

        public void setXhsMobileStoreDetailPic(string xhsMobileStoreDetailPic) {
            this.xhsMobileStoreDetailPic = xhsMobileStoreDetailPic;
        }

        public string getWxsphPlatformTransDataPic() {
            return wxsphPlatformTransDataPic;
        }

        public void setWxsphPlatformTransDataPic(string wxsphPlatformTransDataPic) {
            this.wxsphPlatformTransDataPic = wxsphPlatformTransDataPic;
        }

        public string getWxsphPlatformStoreInfoPic() {
            return wxsphPlatformStoreInfoPic;
        }

        public void setWxsphPlatformStoreInfoPic(string wxsphPlatformStoreInfoPic) {
            this.wxsphPlatformStoreInfoPic = wxsphPlatformStoreInfoPic;
        }

        public string getWxsphPlatformBusiEntPic() {
            return wxsphPlatformBusiEntPic;
        }

        public void setWxsphPlatformBusiEntPic(string wxsphPlatformBusiEntPic) {
            this.wxsphPlatformBusiEntPic = wxsphPlatformBusiEntPic;
        }

        public string getWxsphPlatformOrderDetailPic() {
            return wxsphPlatformOrderDetailPic;
        }

        public void setWxsphPlatformOrderDetailPic(string wxsphPlatformOrderDetailPic) {
            this.wxsphPlatformOrderDetailPic = wxsphPlatformOrderDetailPic;
        }

        public string getWxsphPlatformFundFlowPic() {
            return wxsphPlatformFundFlowPic;
        }

        public void setWxsphPlatformFundFlowPic(string wxsphPlatformFundFlowPic) {
            this.wxsphPlatformFundFlowPic = wxsphPlatformFundFlowPic;
        }

        public string getWxsphMobileStoreShowcasePic() {
            return wxsphMobileStoreShowcasePic;
        }

        public void setWxsphMobileStoreShowcasePic(string wxsphMobileStoreShowcasePic) {
            this.wxsphMobileStoreShowcasePic = wxsphMobileStoreShowcasePic;
        }

        public string getWxsphMobileBusiQualificationPic() {
            return wxsphMobileBusiQualificationPic;
        }

        public void setWxsphMobileBusiQualificationPic(string wxsphMobileBusiQualificationPic) {
            this.wxsphMobileBusiQualificationPic = wxsphMobileBusiQualificationPic;
        }

        public string getWxsphMobileStoreDetailPic() {
            return wxsphMobileStoreDetailPic;
        }

        public void setWxsphMobileStoreDetailPic(string wxsphMobileStoreDetailPic) {
            this.wxsphMobileStoreDetailPic = wxsphMobileStoreDetailPic;
        }

        public string getJdPlatformTransDataPic() {
            return jdPlatformTransDataPic;
        }

        public void setJdPlatformTransDataPic(string jdPlatformTransDataPic) {
            this.jdPlatformTransDataPic = jdPlatformTransDataPic;
        }

        public string getJdPlatformStoreInfoPic() {
            return jdPlatformStoreInfoPic;
        }

        public void setJdPlatformStoreInfoPic(string jdPlatformStoreInfoPic) {
            this.jdPlatformStoreInfoPic = jdPlatformStoreInfoPic;
        }

        public string getJdPlatformBusiEntPic() {
            return jdPlatformBusiEntPic;
        }

        public void setJdPlatformBusiEntPic(string jdPlatformBusiEntPic) {
            this.jdPlatformBusiEntPic = jdPlatformBusiEntPic;
        }

        public string getJdPlatformOrderDetailPic() {
            return jdPlatformOrderDetailPic;
        }

        public void setJdPlatformOrderDetailPic(string jdPlatformOrderDetailPic) {
            this.jdPlatformOrderDetailPic = jdPlatformOrderDetailPic;
        }

        public string getJdPlatformFundFlowPic() {
            return jdPlatformFundFlowPic;
        }

        public void setJdPlatformFundFlowPic(string jdPlatformFundFlowPic) {
            this.jdPlatformFundFlowPic = jdPlatformFundFlowPic;
        }

        public string getJdMobileStoreShowcasePic() {
            return jdMobileStoreShowcasePic;
        }

        public void setJdMobileStoreShowcasePic(string jdMobileStoreShowcasePic) {
            this.jdMobileStoreShowcasePic = jdMobileStoreShowcasePic;
        }

        public string getJdMobileBusiQualificationPic() {
            return jdMobileBusiQualificationPic;
        }

        public void setJdMobileBusiQualificationPic(string jdMobileBusiQualificationPic) {
            this.jdMobileBusiQualificationPic = jdMobileBusiQualificationPic;
        }

        public string getJdMobileStoreDetailPic() {
            return jdMobileStoreDetailPic;
        }

        public void setJdMobileStoreDetailPic(string jdMobileStoreDetailPic) {
            this.jdMobileStoreDetailPic = jdMobileStoreDetailPic;
        }

        public string getDwPlatformTransDataPic() {
            return dwPlatformTransDataPic;
        }

        public void setDwPlatformTransDataPic(string dwPlatformTransDataPic) {
            this.dwPlatformTransDataPic = dwPlatformTransDataPic;
        }

        public string getDwPlatformStoreInfoPic() {
            return dwPlatformStoreInfoPic;
        }

        public void setDwPlatformStoreInfoPic(string dwPlatformStoreInfoPic) {
            this.dwPlatformStoreInfoPic = dwPlatformStoreInfoPic;
        }

        public string getDwPlatformBusiEntPic() {
            return dwPlatformBusiEntPic;
        }

        public void setDwPlatformBusiEntPic(string dwPlatformBusiEntPic) {
            this.dwPlatformBusiEntPic = dwPlatformBusiEntPic;
        }

        public string getDwPlatformOrderDetailPic() {
            return dwPlatformOrderDetailPic;
        }

        public void setDwPlatformOrderDetailPic(string dwPlatformOrderDetailPic) {
            this.dwPlatformOrderDetailPic = dwPlatformOrderDetailPic;
        }

        public string getDwPlatformFundFlowPic() {
            return dwPlatformFundFlowPic;
        }

        public void setDwPlatformFundFlowPic(string dwPlatformFundFlowPic) {
            this.dwPlatformFundFlowPic = dwPlatformFundFlowPic;
        }

        public string getDwMobileStoreShowcasePic() {
            return dwMobileStoreShowcasePic;
        }

        public void setDwMobileStoreShowcasePic(string dwMobileStoreShowcasePic) {
            this.dwMobileStoreShowcasePic = dwMobileStoreShowcasePic;
        }

        public string getDwMobileBusiQualificationPic() {
            return dwMobileBusiQualificationPic;
        }

        public void setDwMobileBusiQualificationPic(string dwMobileBusiQualificationPic) {
            this.dwMobileBusiQualificationPic = dwMobileBusiQualificationPic;
        }

        public string getDwMobileStoreDetailPic() {
            return dwMobileStoreDetailPic;
        }

        public void setDwMobileStoreDetailPic(string dwMobileStoreDetailPic) {
            this.dwMobileStoreDetailPic = dwMobileStoreDetailPic;
        }

        public string getMtPlatformTransDataPic() {
            return mtPlatformTransDataPic;
        }

        public void setMtPlatformTransDataPic(string mtPlatformTransDataPic) {
            this.mtPlatformTransDataPic = mtPlatformTransDataPic;
        }

        public string getMtPlatformStoreInfoPic() {
            return mtPlatformStoreInfoPic;
        }

        public void setMtPlatformStoreInfoPic(string mtPlatformStoreInfoPic) {
            this.mtPlatformStoreInfoPic = mtPlatformStoreInfoPic;
        }

        public string getMtPlatformBusiEntPic() {
            return mtPlatformBusiEntPic;
        }

        public void setMtPlatformBusiEntPic(string mtPlatformBusiEntPic) {
            this.mtPlatformBusiEntPic = mtPlatformBusiEntPic;
        }

        public string getMtPlatformOrderDetailPic() {
            return mtPlatformOrderDetailPic;
        }

        public void setMtPlatformOrderDetailPic(string mtPlatformOrderDetailPic) {
            this.mtPlatformOrderDetailPic = mtPlatformOrderDetailPic;
        }

        public string getMtPlatformFundFlowPic() {
            return mtPlatformFundFlowPic;
        }

        public void setMtPlatformFundFlowPic(string mtPlatformFundFlowPic) {
            this.mtPlatformFundFlowPic = mtPlatformFundFlowPic;
        }

        public string getMtMobileStoreShowcasePic() {
            return mtMobileStoreShowcasePic;
        }

        public void setMtMobileStoreShowcasePic(string mtMobileStoreShowcasePic) {
            this.mtMobileStoreShowcasePic = mtMobileStoreShowcasePic;
        }

        public string getMtMobileBusiQualificationPic() {
            return mtMobileBusiQualificationPic;
        }

        public void setMtMobileBusiQualificationPic(string mtMobileBusiQualificationPic) {
            this.mtMobileBusiQualificationPic = mtMobileBusiQualificationPic;
        }

        public string getMtMobileStoreDetailPic() {
            return mtMobileStoreDetailPic;
        }

        public void setMtMobileStoreDetailPic(string mtMobileStoreDetailPic) {
            this.mtMobileStoreDetailPic = mtMobileStoreDetailPic;
        }

        public string getWphPlatformTransDataPic() {
            return wphPlatformTransDataPic;
        }

        public void setWphPlatformTransDataPic(string wphPlatformTransDataPic) {
            this.wphPlatformTransDataPic = wphPlatformTransDataPic;
        }

        public string getWphPlatformStoreInfoPic() {
            return wphPlatformStoreInfoPic;
        }

        public void setWphPlatformStoreInfoPic(string wphPlatformStoreInfoPic) {
            this.wphPlatformStoreInfoPic = wphPlatformStoreInfoPic;
        }

        public string getWphPlatformBusiEntPic() {
            return wphPlatformBusiEntPic;
        }

        public void setWphPlatformBusiEntPic(string wphPlatformBusiEntPic) {
            this.wphPlatformBusiEntPic = wphPlatformBusiEntPic;
        }

        public string getWphPlatformOrderDetailPic() {
            return wphPlatformOrderDetailPic;
        }

        public void setWphPlatformOrderDetailPic(string wphPlatformOrderDetailPic) {
            this.wphPlatformOrderDetailPic = wphPlatformOrderDetailPic;
        }

        public string getWphPlatformFundFlowPic() {
            return wphPlatformFundFlowPic;
        }

        public void setWphPlatformFundFlowPic(string wphPlatformFundFlowPic) {
            this.wphPlatformFundFlowPic = wphPlatformFundFlowPic;
        }

        public string getWphMobileStoreShowcasePic() {
            return wphMobileStoreShowcasePic;
        }

        public void setWphMobileStoreShowcasePic(string wphMobileStoreShowcasePic) {
            this.wphMobileStoreShowcasePic = wphMobileStoreShowcasePic;
        }

        public string getWphMobileBusiQualificationPic() {
            return wphMobileBusiQualificationPic;
        }

        public void setWphMobileBusiQualificationPic(string wphMobileBusiQualificationPic) {
            this.wphMobileBusiQualificationPic = wphMobileBusiQualificationPic;
        }

        public string getWphMobileStoreDetailPic() {
            return wphMobileStoreDetailPic;
        }

        public void setWphMobileStoreDetailPic(string wphMobileStoreDetailPic) {
            this.wphMobileStoreDetailPic = wphMobileStoreDetailPic;
        }


    }
}
