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
         * 银行类型switch_state有值时需填写； ht1-华通银行，xw0-XW银行，ss0-苏商银行；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：ht1&lt;/font&gt;
         */
        private string outFundsGateId;
        /**
         * 签约人信息switch_state为1时必填 jsonObject格式
         */
        private string signUserInfo;
        /**
         * 入账来源开通全域资金时需填写；01:抖音 02:美团 03:快手 04:拼多多 05:小红书 06:淘宝/天猫/飞猪 07:微信视频号/微信小店 08:京东 09:饿了么 11:得物 12:唯品会 13:携程 14:支付宝直连 15:微信直连 16:滴滴加油 17:团油 18:通联 19:易宝 20:百度 21:顺丰22:希音 多个逗号分隔；&lt;font color&#x3D;&quot;green&quot;&gt;示例值：01,02,05&lt;/font&gt;；
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

        public override string getFunctionCode() {
            return FunctionCodeEnum.V2_MERCHANT_BUSI_EFPCONFIG;
        }

        public V2MerchantBusiEfpconfigRequest() {
        }

        public V2MerchantBusiEfpconfigRequest(string reqSeqId, string reqDate, string huifuId, string upperHuifuId, string outFeeHuifuid, string outOrderAcctCard, string outOrderAcctOpenFees, string outFundsGateId, string signUserInfo, string acctSource, string dyCooperationProvePic, string mtCooperationProvePic, string ksCooperationProvePic, string pddCooperationProvePic, string xhsCooperationProvePic, string zfbCooperationProvePic, string wxCooperationProvePic, string jdCooperationProvePic, string elmCooperationProvePic, string dwCooperationProvePic, string wphCooperationProvePic, string xcCooperationProvePic, string zfbzlCooperationProvePic, string wxzlCooperationProvePic, string ddjyCooperationProvePic, string tyCooperationProvePic, string tlCooperationProvePic, string ybCooperationProvePic, string efpPaperAgreementFile, string bdCooperationProvePic, string mainStoreHuifuId, string sfCooperationProvePic, string xyCooperationProvePic) {
            this.reqSeqId = reqSeqId;
            this.reqDate = reqDate;
            this.huifuId = huifuId;
            this.upperHuifuId = upperHuifuId;
            this.outFeeHuifuid = outFeeHuifuid;
            this.outOrderAcctCard = outOrderAcctCard;
            this.outOrderAcctOpenFees = outOrderAcctOpenFees;
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


    }
}
