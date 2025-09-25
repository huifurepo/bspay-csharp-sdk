using System;
using System.Collections.Generic;
using BasePaySdk;
using BasePaySdk.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasePayDemo
{
    /**
     * 代扣绑卡申请 - 示例
     *
     * @author sdk-generator
     * @Description
     */
    public class V2QuickbuckleWithholdApplyRequestDemo
    {

        public static void V2QuickbuckleWithholdApplyRequestDemoTest()
        {

            // 1. 数据初始化
            InitMerConfig.init();

            // 2.组装请求参数
            V2QuickbuckleWithholdApplyRequest request = new V2QuickbuckleWithholdApplyRequest();
            // 请求流水号
            request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
            // 请求时间
            request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
            // 汇付Id
            request.setHuifuId("6666000003078984");
            // 返回地址
            request.setReturnUrl("http://www.huifu1234.com/");
            // 用户id
            request.setOutCustId("16666000106789536");
            // 绑卡订单号
            request.setOrderId("20230525081932677893621");
            // 绑卡订单日期
            request.setOrderDate("20230525");
            // 银行卡号
            request.setCardId("ZSSW+34A2soLbwLQ5SkZJO4Azy6BknTGkk6EYDTbGA+G0v+zcF3TnU4iYH171KB4ReLjJlY+hSy8MvgVbAx7dL9V7LvLFJd8RE+Lp6XKiIbVUCA1wd2Otp2jI2D32z5gUFqUbB4clRZyRyltXV3xmAWH4fLZDER3H+QwC0/UNF4=");
            // 银行卡开户姓名
            request.setCardName("H12ShtAyV4I4sOQqbISH4eMQUcmzpYOHggxRcXhxNoForh5qLyFgDrsSTn0nnepnPO8okfZYSWQlWIBzsRyyHYwAk94s2sO2Sz/6q4Jg2xDieeGDGrnrAphc8/OAN2OK8dMdbQzL12MvPQU/GX148MCxJzGvvdRFqTEPRLOLXTs=");
            // 银行卡绑定证件类型
            request.setCertType("00");
            // 银行卡绑定身份证
            request.setCertId("FviSPp2Xv6QYfRSYRZcouGAz4BvfZRS9nFKI/7daIUtn4JmBVMTDtrqKLCWeoY7WP4hQAz3rptjOe8WsuynRG3kQhBsXZB0v6e1X1+POD5FXVojquKQb1BF5tKlaOqTj/+G62URC3SWui26JzQQmjGhCORXXHFD7PPNJKusYhHI=");
            // 银行卡绑定手机号
            request.setCardMp("GmMLD+v2Mfc/vr9HOVFKOon3Dl4Q9cjze21X902G8Dnl2/2rpH8wpJUnufoYnI0nR9D2XkOm0ApOJL3ShiZxgLvnTaKrTDjRdrBJexhXbbhbfDx/2x+ZULvZHOEjzRI21tK2WKUzxDhX/lw/iXMjslKNVYlQ7as/aH5bLipf12g=");
            // 个人证件有效期类型
            request.setCertValidityType("0");
            // 个人证件有效期起始日
            request.setCertBeginDate("20140504");
            // 卡的借贷类型
            // request.setDcType("test");

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
            // 页面有效期
            extendInfoMap.Add("expire_time", "15");
            // CVV2
            extendInfoMap.Add("vip_code", "HOVFKOon3Dl4Q9cjze21X902G8Dnl2LvLFJd8RE+Lp6XKiIbVUCA1wd2Otp2jI2D32z5gUFqUbB4clRZyRyltXV3xmAWH4fLZDER3H+YwAk94s2sO2Sz/6q4Jg2xDieesO2Sz/6q4Jg2xDieeGDGbQzL12MvPQU/GX14xJzGvvd=");
            // 卡有效期
            extendInfoMap.Add("expiration", "IUtn4JmBVMTDtrqKLCWeoY7WP4hQAz3rptjOe8WsuySW+34SkZJO4Azy6BknTGkk6EA2soLbwLQ5SkZJO4Azy6BknTGkk6EX902G8Dnl2/2rpH8wpJUnufoYnI0nR9YDTbGA+G0v+ApOJL3ShiZxgLvnTaKrnU4iYH171KB4=");
            // 个人证件有效期到期日
            extendInfoMap.Add("cert_end_date", "20260504");
            // 设备信息域
            extendInfoMap.Add("trx_device_info", getB56bfbeeE390414999542cc647b3ed9a());
            // 风控信息
            extendInfoMap.Add("risk_info", getF494b2e9E5cf4fe592d8Fa81cc893071());
            // 代扣绑卡类型
            // extendInfoMap.Add("binding_card_type", "");
            return extendInfoMap;
        }

        private static object getB56bfbeeE390414999542cc647b3ed9a() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // 银行预留手机号
            obj.Add("trx_mobile_num", "15556622368");
            // 设备类型
            obj.Add("trx_device_type", "1");
            // 交易设备IP
            obj.Add("trx_device_ip", "10.10.0.1");
            // 交易设备MAC
            obj.Add("trx_device_mac", "10.10.0.1");
            // 交易设备IMEI
            obj.Add("trx_device_imei", "030147441006000182623");
            // 交易设备IMSI
            obj.Add("trx_device_imsi", "030147441006000182623");
            // 交易设备ICCID
            obj.Add("trx_device_icc_id", "030147441006000182623");
            // 交易设备WIFIMAC
            obj.Add("trx_device_wfifi_mac", "030147441006000182623");
            // 交易设备GPS
            obj.Add("trx_device_gps", "030147441006000182623");

            return obj;
        }
        private static object getF494b2e9E5cf4fe592d8Fa81cc893071() {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            // IP类型
            obj.Add("ip_type", "04");
            // IP值
            obj.Add("source_ip", "192.168.1.2");
            // 设备标识
            obj.Add("device_id", "123");
            // 设备类型
            obj.Add("device_type", "1");
            // 银行预留手机号
            obj.Add("mobile", "13778787106");
            // 协议编号
            // obj.Add("agreement_no", "");
            // 协议地址
            // obj.Add("agreement_url", "");

            return obj;
        }
    }
}
