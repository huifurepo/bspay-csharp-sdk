﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BasePaySdk;

namespace BasePaySdk.Request
{
    public class FunctionCodeEnum
    {
        /**
         * 网银支付接口
         */
        public const string V2_TRADE_ONLINEPAYMENT_BANKING_FRONTPAY = "v2.trade.onlinepayment.banking.frontpay";
        /**
         * 微信支付宝预授权完成撤销
         */
        public const string V2_TRADE_PAYMENT_PREAUTHPAYCANCEL_REFUND = "v2.trade.payment.preauthpaycancel.refund";
        /**
         * 微信支付宝预授权完成
         */
        public const string V2_TRADE_PREAUTHPAY = "v2.trade.preauthpay";
        /**
         * 微信支付宝预授权撤销
         */
        public const string V2_TRADE_PAYMENT_PREAUTHCANCEL_REFUND = "v2.trade.payment.preauthcancel.refund";
        /**
         * 微信支付宝预授权
         */
        public const string V2_TRADE_PREAUTH = "v2.trade.preauth";
        /**
         * 支付宝申诉提交凭证
         */
        public const string V2_MERCHANT_COMPLAINT_SUBMIT_CERTIFICATES = "v2.merchant.complaint.submit.certificates";
        /**
         * 支付宝申诉查询
         */
        public const string V2_MERCHANT_COMPLAINT_QUERY_STATUS = "v2.merchant.complaint.query.status";
        /**
         * 支付宝申诉请求凭证
         */
        public const string V2_MERCHANT_COMPLAINT_REQUEST_CERTIFICATES = "v2.merchant.complaint.request.certificates";
        /**
         * 支付宝投诉查询
         */
        public const string V2_MERCHANT_COMPLAINT_ALI_RISKINFO_QUERY = "v2.merchant.complaint.ali.riskinfo.query";
        /**
         * 查询投诉协商历史
         */
        public const string V2_MERCHANT_COMPLAINT_HISTORY_QUERY = "v2.merchant.complaint.history.query";
        /**
         * 查询投诉单列表及详情
         */
        public const string V2_MERCHANT_COMPLAINT_LIST_INFO_QUERY = "v2.merchant.complaint.list.info.query";
        /**
         * 图片下载
         */
        public const string V2_MERCHANT_COMPLAINT_DOWNLOAD_PICTURE = "v2.merchant.complaint.download.picture";
        /**
         * 更新退款审批结果
         */
        public const string V2_MERCHANT_COMPLAINT_UPDATE_REFUNDPROGRESS = "v2.merchant.complaint.update.refundprogress";
        /**
         * 回复用户
         */
        public const string V2_MERCHANT_COMPLAINT_REPLY = "v2.merchant.complaint.reply";
        /**
         * 反馈处理完成
         */
        public const string V2_MERCHANT_COMPLAINT_COMPLETE = "v2.merchant.complaint.complete";
        /**
         * 商户统一进件（页面版）
         */
        public const string V2_MERCHANT_URL_FORWARD = "v2.merchant.url.forward";
        /**
         * 商户微信支付宝ID查询
         */
        public const string V2_MERCHANT_BUSI_MERCODE_QUERY = "v2.merchant.busi.mercode.query";
        /**
         * 银行转账资金流水查询
         */
        public const string V2_TRADE_ONLINEPAYMENT_TRANSFER_ACCOUNT_QUERY = "v2.trade.onlinepayment.transfer.account.query";
        /**
         * 银行大额转账关单
         */
        public const string V2_TRADE_ONLINEPAYMENT_TRANSFER_ACCOUNT_CLOSE = "v2.trade.onlinepayment.transfer.account.close";
        /**
         * 银行大额转账
         */
        public const string V2_TRADE_ONLINEPAYMENT_TRANSFER_ACCOUNT = "v2.trade.onlinepayment.transfer.account";
        /**
         * 银行卡代发
         */
        public const string V2_TRADE_SETTLEMENT_SURROGATE = "v2.trade.settlement.surrogate";
        /**
         * 微信代发查询
         */
        public const string V2_TRADE_TRANS_WXSURROGATE_QUERY = "v2.trade.trans.wxsurrogate.query";
        /**
         * 微信代发
         */
        public const string V2_TRADE_TRANS_WX_SURROGATE = "v2.trade.trans.wx.surrogate";
        /**
         * 企业用户基本信息修改
         */
        public const string V2_USER_BASICDATA_ENT_MODIFY = "v2.user.basicdata.ent.modify";
        /**
         * 个人用户基本信息修改
         */
        public const string V2_USER_BASICDATA_INDV_MODIFY = "v2.user.basicdata.indv.modify";
        /**
         * 商户状态变更
         */
        public const string V2_MERCHANT_BUSI_MODIFY_BUSISTATUS = "v2.merchant.busi.modify.busistatus";
        /**
         * 交易关单查询接口
         */
        public const string V2_TRADE_PAYMENT_SCANPAY_CLOSEQUERY = "v2.trade.payment.scanpay.closequery";
        /**
         * 余额支付查询
         */
        public const string V2_TRADE_ACCTPAYMENT_PAY_QUERY = "v2.trade.acctpayment.pay.query";
        /**
         * 支付宝直连-申请当面付代签约
         */
        public const string V2_MERCHANT_DIRECT_ALIPAY_FACETOFACESIGN_APPLY = "v2.merchant.direct.alipay.facetofacesign.apply";
        /**
         * 支付宝直连-换取应用授权令牌
         */
        public const string V2_MERCHANT_DIRECT_ALIPAY_APPAUTHTOKEN_EXCHANGE = "v2.merchant.direct.alipay.appauthtoken.exchange";
        /**
         * 支付宝直连-查询申请状态
         */
        public const string V2_MERCHANT_DIRECT_ALIPAY_APPLYORDERSTATUS_QUERY = "v2.merchant.direct.alipay.applyorderstatus.query";
        /**
         * 直付通商户入驻
         */
        public const string V2_MERCHANT_DIRECT_ZFT_REG = "v2.merchant.direct.zft.reg";
        /**
         * 直付通分账关系查询
         */
        public const string V2_MERCHANT_DIRECT_ZFT_RECEIVER_QUERY = "v2.merchant.direct.zft.receiver.query";
        /**
         * 直付通分账关系绑定解绑
         */
        public const string V2_MERCHANT_DIRECT_ZFT_RECEIVER_CONFIG = "v2.merchant.direct.zft.receiver.config";
        /**
         * 终端自助申请单创建
         */
        public const string V2_TERMINALDEVICE_ORDER_CREATE = "v2.terminaldevice.order.create";
        /**
         * 终端申请列表查询
         */
        public const string V2_TERMINALDEVICE_ORDER_QUERY = "v2.terminaldevice.order.query";
        /**
         * 终端申请订单详情
         */
        public const string V2_TERMINALDEVICE_ORDER_DETAIL = "v2.terminaldevice.order.detail";
        /**
         * 终端申请订单取消
         */
        public const string V2_TERMINALDEVICE_ORDER_CANCEL = "v2.terminaldevice.order.cancel";
        /**
         * 查询商户或渠道商销售策略
         */
        public const string V2_TERMINALDEVICE_ORDER_SALESSTRATEGY = "v2.terminaldevice.order.salesstrategy";
        /**
         * 服务商终端列表查询
         */
        public const string V2_TERMINALDEVICE_MANAGE_QUERY = "v2.terminaldevice.manage.query";
        /**
         * 终端解绑
         */
        public const string V2_TERMINALDEVICE_MANAGE_UNBIND = "v2.terminaldevice.manage.unbind";
        /**
         * 终端绑定
         */
        public const string V2_TERMINALDEVICE_MANAGE_BIND = "v2.terminaldevice.manage.bind";
        /**
         * 注销终端
         */
        public const string V2_TERMINALDEVICE_DEVICEINFO_CANCEL = "v2.terminaldevice.deviceInfo.cancel";
        /**
         * 新增终端报备
         */
        public const string V2_TERMINALDEVICE_DEVICEINFO_ADD = "v2.terminaldevice.deviceInfo.add";
        /**
         * 绑定终端信息查询
         */
        public const string V2_TERMINALDEVICE_DEVICEINFO_QUERY = "v2.terminaldevice.deviceInfo.query";
        /**
         * 银联活动商户信息查询
         */
        public const string V2_MERCHANT_ACTIVITY_UNIONPAY_MERBASEINFO_QUERY = "v2.merchant.activity.unionpay.merbaseInfo.query";
        /**
         * 银联活动商户入驻状态查询
         */
        public const string V2_MERCHANT_ACTIVITY_UNIONPAY_REGISTE_STATUS_QUERY = "v2.merchant.activity.unionpay.registe.status.query";
        /**
         * 银联活动商户入驻
         */
        public const string V2_MERCHANT_ACTIVITY_UNIONPAY_MERBASEINFO_APPLY = "v2.merchant.activity.unionpay.merbaseInfo.apply";
        /**
         * 银联活动列表查询
         */
        public const string V2_MERCHANT_ACTIVITY_UNIONPAY_QUERY = "v2.merchant.activity.unionpay.query";
        /**
         * 银联活动报名进度查询
         */
        public const string V2_MERCHANT_ACTIVITY_UNIONPAY_SIGN_STATUS = "v2.merchant.activity.unionpay.sign.status";
        /**
         * 银联活动报名
         */
        public const string V2_MERCHANT_ACTIVITY_UNIONPAY_SIGN = "v2.merchant.activity.unionpay.sign";
        /**
         * 用户业务入驻修改
         */
        public const string V2_USER_BUSI_MODIFY = "v2.user.busi.modify";
        /**
         * 用户业务入驻
         */
        public const string V2_USER_BUSI_OPEN = "v2.user.busi.open";
        /**
         * 用户信息查询
         */
        public const string V2_USER_BASICDATA_QUERY = "v2.user.basicdata.query";
        /**
         * 企业用户基本信息开户
         */
        public const string V2_USER_BASICDATA_ENT = "v2.user.basicdata.ent";
        /**
         * 个人用户基本信息开户
         */
        public const string V2_USER_BASICDATA_INDV = "v2.user.basicdata.indv";
        /**
         * 线上交易退款查询
         */
        public const string V2_TRADE_ONLINEPAYMENT_REFUND_QUERY = "v2.trade.onlinepayment.refund.query";
        /**
         * 线上交易退款
         */
        public const string V2_TRADE_ONLINEPAYMENT_REFUND = "v2.trade.onlinepayment.refund";
        /**
         * 线上交易查询
         */
        public const string V2_TRADE_ONLINEPAYMENT_QUERY = "v2.trade.onlinepayment.query";
        /**
         * 网银支持银行列表查询
         */
        public const string V2_TRADE_ONLINEPAYMENT_BANKPAY_BANKLIST = "v2.trade.onlinepayment.bankpay.banklist";
        /**
         * 手机WAP支付
         */
        public const string V2_TRADE_ONLINEPAYMENT_WAPPAY = "v2.trade.onlinepayment.wappay";
        /**
         * 网银付款银行账户查询
         */
        public const string V2_TRADE_ONLINEPAYMENT_BANKPAY_PAYERQUERY = "v2.trade.onlinepayment.bankpay.payerquery";
        /**
         * 证书登记
         */
        public const string V2_MERCHANT_DIRECT_CERTINFO_ADD = "v2.merchant.direct.certinfo.add";
        /**
         * 微信直连-修改微信结算帐号
         */
        public const string V2_MERCHANT_DIRECT_WECHAT_SETTLEMENTINFO_MODIFY = "v2.merchant.direct.wechat.settlementInfo.modify";
        /**
         * 微信特约商户进件
         */
        public const string V2_MERCHANT_DIRECT_WECHAT_SIGN = "v2.merchant.direct.wechat.sign";
        /**
         * 微信直连-微信关注配置查询
         */
        public const string V2_MERCHANT_DIRECT_WECHAT_SUBSCRIBE_QUERY = "v2.merchant.direct.wechat.subscribe.query";
        /**
         * 微信直连-微信关注配置
         */
        public const string V2_MERCHANT_DIRECT_WECHAT_SUBSCRIBE_CONFIG = "v2.merchant.direct.wechat.subscribe.config";
        /**
         * 查询微信申请状态
         */
        public const string V2_MERCHANT_DIRECT_WECHAT_QUERY = "v2.merchant.direct.wechat.query";
        /**
         * 微信直连-查询微信结算账户
         */
        public const string V2_MERCHANT_DIRECT_WECHAT_SETTLEMENTINFO_QUERY = "v2.merchant.direct.wechat.settlementInfo.query";
        /**
         * 微信用户标识查询接口
         */
        public const string V2_TRADE_WXUSERMARK_QUERY = "v2.trade.wxusermark.query";
        /**
         * 银联统一在线收银台接口
         */
        public const string V2_TRADE_ONLINEPAYMENT_UNIONPAY = "v2.trade.onlinepayment.unionpay";
        /**
         * 手续费试算
         */
        public const string V2_TRADE_FEECALC = "v2.trade.feecalc";
        /**
         * 支付宝实名申请提交
         */
        public const string V2_MERCHANT_BUSI_ALI_REALNAME_APPLY = "v2.merchant.busi.ali.realname.apply";
        /**
         * 支付宝实名申请单查询
         */
        public const string V2_MERCHANT_BUSI_ALI_REALNAME_QUERY = "v2.merchant.busi.ali.realname.query";
        /**
         * 微信实名认证状态查询
         */
        public const string V2_MERCHANT_BUSI_REALNAME_QUERY = "v2.merchant.busi.realname.query";
        /**
         * 微信实名认证
         */
        public const string V2_MERCHANT_BUSI_REALNAME = "v2.merchant.busi.realname";
        /**
         * 微信配置查询
         */
        public const string V2_MERCHANT_BUSI_CONFIG_QUERY = "v2.merchant.busi.config.query";
        /**
         * 微信商户配置
         */
        public const string V2_MERCHANT_BUSI_CONFIG = "v2.merchant.busi.config";
        /**
         * 申请单状态查询
         */
        public const string V2_MERCHANT_BASICDATA_STATUS_QUERY = "v2.merchant.basicdata.status.query";
        /**
         * 商户详细信息查询
         */
        public const string V2_MERCHANT_BASICDATA_QUERY = "v2.merchant.basicdata.query";
        /**
         * 商户统一进件接口
         */
        public const string V2_MERCHANT_INTEGRATE_REG = "v2.merchant.integrate.reg";
        /**
         * 商户统一变更接口
         */
        public const string V2_MERCHANT_INTEGRATE_UPDATE = "v2.merchant.integrate.update";
        /**
         * 商户基本信息修改
         */
        public const string V2_MERCHANT_BASICDATA_MODIFY = "v2.merchant.basicdata.modify";
        /**
         * 商户活动报名查询
         */
        public const string V2_MERCHANT_ACTIVITY_QUERY = "v2.merchant.activity.query";
        /**
         * 商户活动报名
         */
        public const string V2_MERCHANT_ACTIVITY_ADD = "v2.merchant.activity.add";
        /**
         * 企业商户基本信息入驻
         */
        public const string V2_MERCHANT_BASICDATA_ENT = "v2.merchant.basicdata.ent";
        /**
         * 个人商户基本信息入驻
         */
        public const string V2_MERCHANT_BASICDATA_INDV = "v2.merchant.basicdata.indv";
        /**
         * 微信支付宝入驻信息修改
         */
        public const string V2_MERCHANT_BUSI_AT_MODIFY = "v2.merchant.busi.at.modify";
        /**
         * 商户业务开通修改
         */
        public const string V2_MERCHANT_BUSI_MODIFY = "v2.merchant.busi.modify";
        /**
         * 取现接口
         */
        public const string V2_TRADE_SETTLEMENT_ENCHASHMENT = "v2.trade.settlement.enchashment";
        /**
         * 获取银联用户标识接口
         */
        public const string V2_TRADE_PAYMENT_USERMARK2_QUERY = "v2.trade.payment.usermark2.query";
        /**
         * 交易退款查询接口
         */
        public const string V2_TRADE_PAYMENT_SCANPAY_REFUNDQUERY = "v2.trade.payment.scanpay.refundquery";
        /**
         * 扫码交易退款
         */
        public const string V2_TRADE_PAYMENT_SCANPAY_REFUND = "v2.trade.payment.scanpay.refund";
        /**
         * 交易查询接口
         */
        public const string V2_TRADE_PAYMENT_SCANPAY_QUERY = "v2.trade.payment.scanpay.query";
        /**
         * 快捷支付申请
         */
        public const string V2_TRADE_ONLINEPAYMENT_QUICKPAY_APPLY = "v2.trade.onlinepayment.quickpay.apply";
        /**
         * 快捷支付确认
         */
        public const string V2_TRADE_ONLINEPAYMENT_QUICKPAY_CONFIRM = "v2.trade.onlinepayment.quickpay.confirm";
        /**
         * 快捷支付页面版接口
         */
        public const string V2_TRADE_ONLINEPAYMENT_QUICKPAY_PAGEINFO = "v2.trade.onlinepayment.quickpay.pageinfo";
        /**
         * 新增快捷/代扣解绑接口
         */
        public const string V2_QUICKBUCKLE_UNBIND = "v2.quickbuckle.unbind";
        /**
         * 快捷绑卡申请接口
         */
        public const string V2_QUICKBUCKLE_APPLY = "v2.quickbuckle.apply";
        /**
         * 快捷绑卡确认接口
         */
        public const string V2_QUICKBUCKLE_CONFIRM = "v2.quickbuckle.confirm";
        /**
         * 交易确认退款接口
         */
        public const string V2_TRADE_PAYMENT_DELAYTRANS_CONFIRMREFUND = "v2.trade.payment.delaytrans.confirmrefund";
        /**
         * 交易确认查询接口
         */
        public const string V2_TRADE_PAYMENT_DELAYTRANS_CONFIRMQUERY = "v2.trade.payment.delaytrans.confirmquery";
        /**
         * 交易确认接口
         */
        public const string V2_TRADE_PAYMENT_DELAYTRANS_CONFIRM = "v2.trade.payment.delaytrans.confirm";
        /**
         * 账户余额信息查询接口
         */
        public const string V2_TRADE_ACCTPAYMENT_BALANCE_QUERY = "v2.trade.acctpayment.balance.query";
        /**
         * 交易结算对账单配置查询
         */
        public const string V2_MERCHANT_BUSI_BILL_QUERY = "v2.merchant.busi.bill.query";
        /**
         * 交易结算对账文件配置
         */
        public const string V2_MERCHANT_BUSI_BILL_CONFIG = "v2.merchant.busi.bill.config";
        /**
         * 交易结算对账单查询
         */
        public const string V2_TRADE_CHECK_FILEQUERY = "v2.trade.check.filequery";
        /**
         * 交易结算对账文件重新生成
         */
        public const string V2_TRADE_CHECK_REPLAY = "v2.trade.check.replay";
        /**
         * 交易关单接口
         */
        public const string V2_TRADE_PAYMENT_SCANPAY_CLOSE = "v2.trade.payment.scanpay.close";
        /**
         * 结算记录查询
         */
        public const string V2_MERCHANT_BASICDATA_SETTLEMENT_QUERY = "v2.merchant.basicdata.settlement.query";
        /**
         * 聚合正扫接口
         */
        public const string V2_TRADE_PAYMENT_JSPAY = "v2.trade.payment.jspay";
        /**
         * 聚合反扫接口
         */
        public const string V2_TRADE_PAYMENT_MICROPAY = "v2.trade.payment.micropay";
        /**
         * 商户分期配置详情查询
         */
        public const string V2_PCREDIT_FEE_DETAIL = "v2.pcredit.fee.detail";
        /**
         * 商户分期配置
         */
        public const string V2_PCREDIT_FEE_CONFIG = "v2.pcredit.fee.config";
        /**
         * 银行卡分期支持银行查询
         */
        public const string V2_TRADE_BANKINSTALLMENTINFO_QUERY = "v2.trade.bankinstallmentinfo.query";
        /**
         * 分期证书配置
         */
        public const string V2_PCREDIT_CERTIFICATE_CONFIG = "v2.pcredit.certificate.config";
        /**
         * 花呗分期活动查询
         */
        public const string V2_PCREDIT_SOLUTION_QUERY = "v2.pcredit.solution.query";
        /**
         * 更新花呗分期方案
         */
        public const string V2_PCREDIT_SOLUTION_MODIFY = "v2.pcredit.solution.modify";
        /**
         * 上架下架分期活动接口
         */
        public const string V2_PCREDIT_STATUE_MODIFY = "v2.pcredit.statue.modify";
        /**
         * 花呗分期贴息查询
         */
        public const string V2_PCREDIT_ORDER_QUERY = "v2.pcredit.order.query";
        /**
         * 创建花呗分期方案
         */
        public const string V2_PCREDIT_SOLUTION_CREATE = "v2.pcredit.solution.create";
        /**
         * 商户分账配置查询
         */
        public const string V2_MERCHANT_SPLIT_QUERY = "v2.merchant.split.query";
        /**
         * 商户分账配置
         */
        public const string V2_MERCHANT_SPLIT_CONFIG = "v2.merchant.split.config";
        /**
         * 交易分账明细查询接口
         */
        public const string V2_TRADE_TRANS_SPLIT_QUERY = "v2.trade.trans.split.query";
        /**
         * 电子回单查询
         */
        public const string V2_TRADE_PAYMENT_GETELECTRONICRECEIPT = "v2.trade.payment.getelectronicreceipt";
        /**
         * 支付宝小程序预下单接口
         */
        public const string V2_TRADE_HOSTING_PAYMENT_PREORDER = "v2.trade.hosting.payment.preorder";
        /**
         * 出金交易查询接口
         */
        public const string V2_TRADE_SETTLEMENT_QUERY = "v2.trade.settlement.query";
        /**
         * 卡bin信息查询
         */
        public const string V2_TRADE_CARDBIN_QUERY = "v2.trade.cardbin.query";
        /**
         * 余额支付退款查询
         */
        public const string V2_TRADE_ACCTPAYMENT_REFUND_QUERY = "v2.trade.acctpayment.refund.query";
        /**
         * 余额支付退款
         */
        public const string V2_TRADE_ACCTPAYMENT_REFUND = "v2.trade.acctpayment.refund";
        /**
         * 余额支付
         */
        public const string V2_TRADE_ACCTPAYMENT_PAY = "v2.trade.acctpayment.pay";
        /**
         * 账务流水查询
         */
        public const string V2_TRADE_ACCTPAYMENT_ACCTLOG_QUERY = "v2.trade.acctpayment.acctlog.query";
        /**
         * 网银支付
         */
        public const string V2_TRADE_ONLINEPAYMENT_BANKPAY_PAGEINFO = "v2.trade.onlinepayment.bankpay.pageinfo";
        /**
         * 图片上传
         */
        public const string V2_SUPPLEMENTARY_PICTURE = "v2.supplementary.picture";
        /**
         * 商户业务开通
         */
        public const string V2_MERCHANT_BUSI_OPEN = "v2.merchant.busi.open";

    }
}
