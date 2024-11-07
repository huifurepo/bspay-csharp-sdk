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
         * 分期支付
         */
        public const string V2_TRADE_INSTALLMENT_PAYMENT = "v2.trade.installment.payment";
        /**
         * 服务单关闭
         */
        public const string V2_TRADE_PAYAFTERUSE_CREDITBIZORDER_CLOSE = "v2.trade.payafteruse.creditbizorder.close";
        /**
         * 服务单查询
         */
        public const string V2_TRADE_PAYAFTERUSE_CREDITBIZORDER_QUERY = "v2.trade.payafteruse.creditbizorder.query";
        /**
         * 服务单创建
         */
        public const string V2_TRADE_PAYAFTERUSE_CREDITBIZORDER_CREATE = "v2.trade.payafteruse.creditbizorder.create";
        /**
         * 分期扣款查询
         */
        public const string V2_TRADE_PAYAFTERUSE_INSTALLMENT_QUERY = "v2.trade.payafteruse.installment.query";
        /**
         * 分期扣款
         */
        public const string V2_TRADE_PAYAFTERUSE_INSTALLMENT_PAY = "v2.trade.payafteruse.installment.pay";
        /**
         * 分期交易退款查询
         */
        public const string V2_TRADE_PAYAFTERUSE_INSTALLMENT_REFUNDQUERY = "v2.trade.payafteruse.installment.refundquery";
        /**
         * 分期交易退款
         */
        public const string V2_TRADE_PAYAFTERUSE_INSTALLMENT_REFUND = "v2.trade.payafteruse.installment.refund";
        /**
         * 分期单创建
         */
        public const string V2_TRADE_PAYAFTERUSE_INSTALLMENT_CREATE = "v2.trade.payafteruse.installment.create";
        /**
         * 快捷支付
         */
        public const string V3_TRADE_ONLINEPAYMENT_QUICKPAY_PAY = "v3.trade.onlinepayment.quickpay.pay";
        /**
         * 快捷短信发送
         */
        public const string V3_TRADE_ONLINEPAYMENT_QUICKPAY_SMSSEND = "v3.trade.onlinepayment.quickpay.smssend";
        /**
         * 电子账户余额查询
         */
        public const string V2_BANK_BALANCE_QUERY = "v2.bank.balance.query";
        /**
         * 不明来账列表查询
         */
        public const string V2_TRADE_PAYMENT_ZXE_UNKNOWNINCOME_QUERY = "v2.trade.payment.zxe.unknownincome.query";
        /**
         * 不明来账处理结果查询
         */
        public const string V2_TRADE_PAYMENT_ZXE_UNKNOWNINCOME_DISPOSEQUERY = "v2.trade.payment.zxe.unknownincome.disposequery";
        /**
         * 不明来账处理
         */
        public const string V2_TRADE_PAYMENT_ZXE_UNKNOWNINCOME_DISPOSE = "v2.trade.payment.zxe.unknownincome.dispose";
        /**
         * 云MIS订单详情查询接口
         */
        public const string V2_TRADE_CLOUDMIS_ORDER_DETAIL = "v2.trade.cloudmis.order.detail";
        /**
         * 终端云MIS交易
         */
        public const string V2_TRADE_CLOUDMIS_DEVICE_INFORMATION_MIS = "v2.trade.cloudmis.device.information.mis";
        /**
         * 新建付款人
         */
        public const string V2_BILL_ENT_PAYER_CREATE = "v2.bill.ent.payer.create";
        /**
         * 修改付款人信息
         */
        public const string V2_BILL_ENT_PAYER_UPDATE = "v2.bill.ent.payer.update";
        /**
         * 删除付款人
         */
        public const string V2_BILL_ENT_PAYER_DELETE = "v2.bill.ent.payer.delete";
        /**
         * 企业账单状态变更
         */
        public const string V2_BILL_ENT_CHANGESTAT = "v2.bill.ent.changeStat";
        /**
         * 企业账单退款查询
         */
        public const string V2_BILL_ENT_REFUND_QUERY = "v2.bill.ent.refund.query";
        /**
         * 企业账单退款
         */
        public const string V2_BILL_ENT_REFUND = "v2.bill.ent.refund";
        /**
         * 企业账单查询
         */
        public const string V2_BILL_ENT_QUERY = "v2.bill.ent.query";
        /**
         * 付款人查询
         */
        public const string V2_BILL_ENT_PAYER_QUERY = "v2.bill.ent.payer.query";
        /**
         * 创建企业账单
         */
        public const string V2_BILL_ENT_CREATE = "v2.bill.ent.create";
        /**
         * 申诉单详情查询
         */
        public const string V2_MERCHANT_APPEAL_DETAIL_QUERY = "v2.merchant.appeal.detail.query";
        /**
         * 提交申诉
         */
        public const string V2_MERCHANT_APPEAL_COMMON_SUBMIT = "v2.merchant.appeal.common.submit";
        /**
         * 申诉文件url查询
         */
        public const string V2_MERCHANT_APPEAL_FILEURL_QUERY = "v2.merchant.appeal.fileurl.query";
        /**
         * 申诉单列表查询
         */
        public const string V2_MERCHANT_APPEAL_LIST_QUERY = "v2.merchant.appeal.list.query";
        /**
         * 申诉客户信息查询
         */
        public const string V2_MERCHANT_APPEAL_CUSTINFO_QUERY = "v2.merchant.appeal.custinfo.query";
        /**
         * 关联线索查询
         */
        public const string V2_MERCHANT_APPEAL_RELATEDCLUE_QUERY = "v2.merchant.appeal.relatedclue.query";
        /**
         * 操作日志查询
         */
        public const string V2_MERCHANT_APPEAL_LOG_QUERY = "v2.merchant.appeal.log.query";
        /**
         * 快捷绑卡申请接口
         */
        public const string V3_QUICKBUCKLE_APPLY = "v3.quickbuckle.apply";
        /**
         * 快捷绑卡确认接口
         */
        public const string V3_QUICKBUCKLE_CONFIRM = "v3.quickbuckle.confirm";
        /**
         * 新增归集配置
         */
        public const string V2_TRADE_SETTLE_COLLECTION_RULE_ADD = "v2.trade.settle.collection.rule.add";
        /**
         * 修改归集配置
         */
        public const string V2_TRADE_SETTLE_COLLECTION_RULE_MODIFY = "v2.trade.settle.collection.rule.modify";
        /**
         * 归集配置查询
         */
        public const string V2_TRADE_SETTLE_COLLECTION_RULE_QUERY = "v2.trade.settle.collection.rule.query";
        /**
         * 资金归集明细查询
         */
        public const string V2_TRADE_SETTLE_COLLECTION_DETAIL_QUERY = "v2.trade.settle.collection.detail.query";
        /**
         * 灵工微信代发查询
         */
        public const string V2_TRADE_LGWX_SURROGATE_QUERY = "v2.trade.lgwx.surrogate.query";
        /**
         * 灵工微信代发
         */
        public const string V2_TRADE_LGWX_SURROGATE = "v2.trade.lgwx.surrogate";
        /**
         * 银行大额支付解绑
         */
        public const string V2_LARGEAMT_BINDCARD_UNBIND = "v2.largeamt.bindcard.unbind";
        /**
         * 银行大额支付绑卡查询
         */
        public const string V2_LARGEAMT_BINDCARD_QUERY = "v2.largeamt.bindcard.query";
        /**
         * 银行大额支付绑卡
         */
        public const string V2_LARGEAMT_BINDCARD_BIND = "v2.largeamt.bindcard.bind";
        /**
         * 上传短信验证码
         */
        public const string V2_INVOICE_MER_VERIFYCODE_UPLOAD = "v2.invoice.mer.verifycode.upload";
        /**
         * 获取人脸认证二维码
         */
        public const string V2_INVOICE_MER_AUTHQRCODE_GRANT = "v2.invoice.mer.authqrcode.grant";
        /**
         * 查询人脸认证结果
         */
        public const string V2_INVOICE_MER_AUTHQRCODE_QUERY = "v2.invoice.mer.authqrcode.query";
        /**
         * 用户列表查询
         */
        public const string V2_USER_LIST_QUERY = "v2.user.list.query";
        /**
         * 电子发票业务开通查询
         */
        public const string V2_INVOICE_PERMISSION_QUERY = "v2.invoice.permission.query";
        /**
         * 电子发票业务开通
         */
        public const string V2_INVOICE_PERMISSION_GRANT = "v2.invoice.permission.grant";
        /**
         * 商户注册状态查询
         */
        public const string V2_INVOICE_MER_STATUS_QUERY = "v2.invoice.mer.status.query";
        /**
         * 商户注册信息修改
         */
        public const string V2_INVOICE_MER_MODIFY = "v2.invoice.mer.modify";
        /**
         * 商户注册信息查询
         */
        public const string V2_INVOICE_MER_QUERY = "v2.invoice.mer.query";
        /**
         * 商户注册
         */
        public const string V2_INVOICE_MER_REG = "v2.invoice.mer.reg";
       
        /**
         * 开票员登录
         */
        public const string V2_INVOICE_CLERK_LOGON = "v2.invoice.clerk.logon";
        /**
         * 开票员登记
         */
        public const string V2_INVOICE_CLERK_REG = "v2.invoice.clerk.reg";
     
        /**
         * 完税凭证下载
         */
        public const string V2_HYC_TAX_DOWNLOAD = "v2.hyc.tax.download";
        /**
         * 用户申请单状态查询
         */
        public const string V2_USER_APPLY_QUERY = "v2.user.apply.query";
        /**
         * 开通下级商户权限配置接口
         */
        public const string V2_MERCHANT_BUSI_HEAD_CONFIG = "v2.merchant.busi.head.config";
        /**
         * 一键绑卡-工行卡号查询
         */
        public const string V2_QUICKBUCKLE_BIND_CARDINFO_QUERY = "v2.quickbuckle.bind.cardInfo.query";
        /**
         * 完税凭证查询
         */
        public const string V2_HYC_TAX_QUERY = "v2.hyc.tax.query";
        /**
         * 申请开票
         */
        public const string V2_HYC_INVOICE_APPLY = "v2.hyc.invoice.apply";
        /**
         * 商户签约查询
         */
        public const string V2_HYC_MERSIGN_QUERY = "v2.hyc.mersign.query";
        /**
         * 开票信息查询
         */
        public const string V2_HYC_INVINFO_QUERY = "v2.hyc.invinfo.query";
        /**
         * 开票类目查询
         */
        public const string V2_HYC_INVCATEGORY_QUERY = "v2.hyc.invcategory.query";
        /**
         * 个人签约状态查询
         */
        public const string V2_HYC_CONTRACT_QUERY = "v2.hyc.contract.query";
        /**
         * 个人签约发起
         */
        public const string V2_HYC_PERSONSIGN_CREATE = "v2.hyc.personsign.create";
        /**
         * 用户补贴
         */
        public const string V2_WALLET_TRADE_RECHARGE_TRANSFER = "v2.wallet.trade.recharge.transfer";
        /**
         * 钱包关单
         */
        public const string V2_WALLET_TRADE_ORDER_CLOSE = "v2.wallet.trade.order.close";
        /**
         * 自助扫码开票
         */
        public const string V2_INVOICE_SELFSCANOPEN = "v2.invoice.selfscanopen";
        /**
         * 发票开具状态查询
         */
        public const string V2_INVOICE_QUERYAPPLY = "v2.invoice.queryapply";
        /**
         * 发票开具
         */
        public const string V2_INVOICE_OPEN = "v2.invoice.open";
        /**
         * 全渠道资金管理配置查询
         */
        public const string V2_MERCHANT_BUSI_EFPDETAIL = "v2.merchant.busi.efpdetail";
        /**
         * 全渠道资金管理配置
         */
        public const string V2_MERCHANT_BUSI_EFPCONFIG = "v2.merchant.busi.efpconfig";
        /**
         * 银行大额未入账流水列表查询
         */
        public const string V2_TRADE_ONLINEPAYMENT_TRANSFER_BANKBLOTTER_QUERY = "v2.trade.onlinepayment.transfer.bankblotter.query";
        /**
         * 托管交易退款查询
         */
        public const string V2_TRADE_HOSTING_PAYMENT_QUERYREFUNDINFO = "v2.trade.hosting.payment.queryRefundInfo";
        /**
         * 托管交易退款
         */
        public const string V2_TRADE_HOSTING_PAYMENT_HTREFUND = "v2.trade.hosting.payment.htRefund";
        /**
         * 托管交易查询
         */
        public const string V2_TRADE_HOSTING_PAYMENT_QUERYORDERINFO = "v2.trade.hosting.payment.queryorderinfo";
        /**
         * E账户转账及充值查询接口
         */
        public const string V2_TRADE_PAYMENT_ZXE_INCASH_QUERY = "v2.trade.payment.zxe.incash.query";
        /**
         * 电子账户账务明细查询
         */
        public const string V2_TRADE_PAYMENT_ZXE_ACCTDETAIL_QUERY = "v2.trade.payment.zxe.acctdetail.query";
        /**
         * 付款关系提交
         */
        public const string V2_TRADE_PAYRELATION_APPLY = "v2.trade.payrelation.apply";
        /**
         * 电子账户设置默认卡
         */
        public const string V2_MERCHANT_ELEC_CARD_DEFAULT = "v2.merchant.elec.card.default";
        /**
         * 电子账户解绑
         */
        public const string V2_MERCHANT_ELEC_CARD_UNBIND = "v2.merchant.elec.card.unbind";
        /**
         * 电子账户绑卡
         */
        public const string V2_MERCHANT_ELEC_CARD_BIND = "v2.merchant.elec.card.bind";
        /**
         * 钱包转账下单
         */
        public const string V2_WALLET_TRADE_TRANSFER = "v2.wallet.trade.transfer";
        /**
         * 钱包支付退款查询
         */
        public const string V2_WALLET_TRADE_PAY_REFUND_QUERY = "v2.wallet.trade.pay.refund.query";
        /**
         * 快捷绑卡查询
         */
        public const string V2_QUICKBUCKLE_QUERY = "v2.quickbuckle.query";
        /**
         * 钱包转账下单
         */
        public const string V2_WALLET_TRANSFER = "v2.wallet.transfer";
        /**
         * 钱包支付下单
         */
        public const string V2_WALLET_TRADE_PAY_BALANCE = "v2.wallet.trade.pay.balance";
        /**
         * 钱包支付退款查询
         */
        public const string V2_WALLET_PAY_REFUND_QUERY = "v2.wallet.pay.refund.query";
        /**
         * 钱包支付退款
         */
        public const string V2_WALLET_TRADE_PAY_REFUND = "v2.wallet.trade.pay.refund";
        /**
         * 新增绑定卡结果查询
         */
        public const string V2_WALLET_CARD_QUERY = "v2.wallet.card.query";
        /**
         * 新增绑定银行卡
         */
        public const string V2_WALLET_CARD_ADD = "v2.wallet.card.add";
        /**
         * 钱包提现下单
         */
        public const string V2_WALLET_TRADE_WITHDRAWAL = "v2.wallet.trade.withdrawal";
        /**
         * 钱包绑定手机号验证
         */
        public const string V2_WALLET_MOBILE_VERIFY = "v2.wallet.mobile.verify";
        /**
         * 钱包用户查询
         */
        public const string V2_WALLET_QUERY = "v2.wallet.query";
        /**
         * 钱包开户
         */
        public const string V2_WALLET_CREATE = "v2.wallet.create";
        /**
         * 钱包密码修改
         */
        public const string V2_WALLET_PASSWORD_MODIFY = "v2.wallet.password.modify";
        /**
         * 钱包密码重置
         */
        public const string V2_WALLET_PASSWORD_RESET = "v2.wallet.password.reset";
        /**
         * 钱包交易查询
         */
        public const string V2_WALLET_TRADE_QUERY = "v2.wallet.trade.query";
        /**
         * 钱包绑卡充值下单
         */
        public const string V2_WALLET_TRADE_RECHARGE_CARD = "v2.wallet.trade.recharge.card";
        /**
         * 银行大额支付差错申请查询
         */
        public const string V2_TRADE_ONLINEPAYMENT_TRANSFER_BANKMISTAKE_APPLYQUERY = "v2.trade.onlinepayment.transfer.bankmistake.applyquery";
        /**
         * 银行大额支付差错申请
         */
        public const string V2_TRADE_ONLINEPAYMENT_TRANSFER_BANKMISTAKE_APPLY = "v2.trade.onlinepayment.transfer.bankmistake.apply";
        /**
         * 支付分扣款
         */
        public const string V2_TRADE_PAYSCORE_PAY_PAYSCOREPAY = "v2.trade.payscore.pay.payscorepay";
        /**
         * 完结支付分订单
         */
        public const string V2_TRADE_PAYSCORE_SERVICEORDER_COMPLETE = "v2.trade.payscore.serviceorder.complete";
        /**
         * 取消支付分订单
         */
        public const string V2_TRADE_PAYSCORE_SERVICEORDER_CANCEL = "v2.trade.payscore.serviceorder.cancel";
        /**
         * 登记扣款信息
         */
        public const string V2_TRADE_PAYSCORE_DEDUCT_REGITSTER = "v2.trade.payscore.deduct.regitster";
        /**
         * 查询扣款信息
         */
        public const string V2_TRADE_PAYSCORE_DEDUCT_QUERY = "v2.trade.payscore.deduct.query";
        /**
         * 查询支付分订单
         */
        public const string V2_TRADE_PAYSCORE_SERVICEORDER_QUERY = "v2.trade.payscore.serviceorder.query";
        /**
         * 创建支付分订单
         */
        public const string V2_TRADE_PAYSCORE_SERVICEORDER_CREATE = "v2.trade.payscore.serviceorder.create";
        /**
         * 交易确认退款查询
         */
        public const string V2_TRADE_PAYMENT_DELAYTRANS_CONFIRMREFUNDQUERY = "v2.trade.payment.delaytrans.confirmrefundquery";
        /**
         * 代扣绑卡页面版
         */
        public const string V2_QUICKBUCKLE_WITHHOLD_PAGE_GET = "v2.quickbuckle.withhold.page.get";
        /**
         * 统一进件页面版查询
         */
        public const string V2_MERCHANT_BUSI_STATUS_QUERY = "v2.merchant.busi.status.query";
        /**
         * 银行列表查询
         */
        public const string V2_QUICKBUCKLE_BANK_QUERY = "v2.quickbuckle.bank.query";
        /**
         * 商户短信发送
         */
        public const string V2_MERCHANT_BASICDATA_SMS_SEND = "v2.merchant.basicdata.sms.send";
        /**
         * 批量出金交易查询
         */
        public const string V2_TRADE_BATCHTRANSLOG_QUERY = "v2.trade.batchtranslog.query";
        /**
         * 快捷支付页面版
         */
        public const string V2_TRADE_ONLINEPAYMENT_QUICKPAY_FRONTPAY = "v2.trade.onlinepayment.quickpay.frontpay";
        /**
         * 快捷支付短信预校验
         */
        public const string V2_TRADE_ONLINEPAYMENT_QUICKPAY_SMSCHECK = "v2.trade.onlinepayment.quickpay.smscheck";
        /**
         * 跳转电子小票页面
         */
        public const string V2_TRADE_ELECTRON_RECEIPTS_JUMPINFO = "v2.trade.electron.receipts.jumpinfo";
        /**
         * 图片上传
         */
        public const string V2_TRADE_ELECTRON_RECEIPTS_PICTURE_UPLOAD = "v2.trade.electron.receipts.picture.upload";
        /**
         * 上传电子小票图片
         */
        public const string V2_TRADE_ELECTRON_RECEIPTS_UPLOAD = "v2.trade.electron.receipts.upload";
        /**
         * 查询小票自定义入口
         */
        public const string V2_TRADE_ELECTRON_RECEIPTS_CUSTOMENTRANCES_QUERY = "v2.trade.electron.receipts.customentrances.query";
        /**
         * 创建修改小票自定义入口
         */
        public const string V2_TRADE_ELECTRON_RECEIPTS_CUSTOMENTRANCES_CREATE = "v2.trade.electron.receipts.customentrances.create";
        /**
         * 代扣支付
         */
        public const string V2_TRADE_ONLINEPAYMENT_WITHHOLDPAY = "v2.trade.onlinepayment.withholdpay";
        /**
         * 代扣绑卡申请
         */
        public const string V2_QUICKBUCKLE_WITHHOLD_APPLY = "v2.quickbuckle.withhold.apply";
        /**
         * 代扣绑卡查询
         */
        public const string V2_QUICKBUCKLE_WITHHOLD_QUERY = "v2.quickbuckle.withhold.query";
        /**
         * 汇付入账确认
         */
        public const string V2_TRADE_ONLINEPAYMENT_TRANSFER_REMITTANCE = "v2.trade.onlinepayment.transfer.remittance";
        /**
         * 汇付入账查询
         */
        public const string V2_TRADE_ONLINEPAYMENT_TRANSFER_REMITTANCEORDER = "v2.trade.onlinepayment.transfer.remittanceorder";
        /**
         * 一键绑卡
         */
        public const string V2_QUICKBUCKLE_ONEKEY_CARDBIND = "v2.quickbuckle.onekey.cardbind";
        /**
         * DM取现额度查询
         */
        public const string V2_TRADE_SETTLEMENT_ENCHASHMENT_DMAMT_QUERY = "v2.trade.settlement.enchashment.dmamt.query";
        /**
         * 子账户开通配置(2022)
         */
        public const string V2_MERCHANT_SETTLE_CONFIG = "v2.merchant.settle.config";
        /**
         * 修改子账户配置(2022)
         */
        public const string V2_MERCHANT_SETTLE_MODIFY = "v2.merchant.settle.modify";
        /**
         * 批量交易状态查询
         */
        public const string V2_TRADE_TRANSSTAT_QUERY = "v2.trade.transstat.query";
        /**
         * 网银支付
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
         * 投诉图片下载
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
         * 银行大额资金流水查询
         */
        public const string V2_TRADE_ONLINEPAYMENT_TRANSFER_ACCOUNT_QUERY = "v2.trade.onlinepayment.transfer.account.query";
        /**
         * 银行大额支付关单
         */
        public const string V2_TRADE_ONLINEPAYMENT_TRANSFER_ACCOUNT_CLOSE = "v2.trade.onlinepayment.transfer.account.close";
        /**
         * 银行大额支付
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
         * 银联统一在线收银台
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
         * 商户详细信息查询(2022)
         */
        public const string V2_MERCHANT_BASICDATA_QUERY = "v2.merchant.basicdata.query";
        /**
         * 商户统一进件接口(2022)
         */
        public const string V2_MERCHANT_INTEGRATE_REG = "v2.merchant.integrate.reg";
        /**
         * 商户统一变更接口(2022)
         */
        public const string V2_MERCHANT_INTEGRATE_UPDATE = "v2.merchant.integrate.update";
        /**
         * 商户基本信息修改(2022)
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
         * 企业商户基本信息入驻(2022)
         */
        public const string V2_MERCHANT_BASICDATA_ENT = "v2.merchant.basicdata.ent";
        /**
         * 个人商户基本信息入驻(2022)
         */
        public const string V2_MERCHANT_BASICDATA_INDV = "v2.merchant.basicdata.indv";
        /**
         * 微信支付宝入驻信息修改
         */
        public const string V2_MERCHANT_BUSI_AT_MODIFY = "v2.merchant.busi.at.modify";
        /**
         * 商户业务开通修改(2022)
         */
        public const string V2_MERCHANT_BUSI_MODIFY = "v2.merchant.busi.modify";
        /**
         * 取现
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
         * 商户分账配置查询(2022)
         */
        public const string V2_MERCHANT_SPLIT_QUERY = "v2.merchant.split.query";
        /**
         * 商户分账配置(2022)
         */
        public const string V2_MERCHANT_SPLIT_CONFIG = "v2.merchant.split.config";
        /**
         * 交易分账明细查询
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
         * 商户业务开通(2022)
         */
        public const string V2_MERCHANT_BUSI_OPEN = "v2.merchant.busi.open";

    }
}
