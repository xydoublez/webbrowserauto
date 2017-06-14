using System;
using System.Collections.Generic;
using System.Text;

namespace FillTheForm
{
    public class FeePriceInfo
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        public string queryCodeTxt { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string patientNameTxt { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string sexcmb { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string ageTxt { get; set; }
        /// <summary>
        /// 帐户余额
        /// </summary>
        public string freeCost { get; set; }
        /// <summary>
        /// 结算类别如医保
        /// </summary>
        public string cmbPayKind { get; set; }
        /// <summary>
        /// 医疗证号
        /// </summary>
        public string mcardNoTxt { get; set; }
        /// <summary>
        /// 医疗类别如普通门诊
        /// </summary>
        public string medicalTypeCmb { get; set; }
        /// <summary>
        /// 门诊诊断
        /// </summary>
        public string diagnoseCmb { get; set; }
        /// <summary>
        /// 看诊科室
        /// </summary>
        public string deptCmb { get; set; }
        /// <summary>
        /// 看诊医生
        /// </summary>
        public string docCmb { get; set; }
        /// <summary>
        /// 费用明细列表
        /// </summary>
        public List<FeePrice> FeePriceList { get; set; }
    }

    public class FeePrice
    {
        /// <summary>
        /// 品名
        /// </summary>
        public string pinMing { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string guiGe { get; set; }
        /// <summary>
        /// 批次
        /// </summary>
        public string piCi { get; set; }
        /// <summary>
        /// 零售价
        /// </summary>
        public string lingShouJia { get; set; }
        /// <summary>
        /// 包装单位
        /// </summary>
        public string baoZhuangDanWei { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string shuLiang { get; set; }
        /// <summary>
        /// 计价单位
        /// </summary>
        public string jiJiaDanWei { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public string jinE { get; set; }
        /// <summary>
        /// 基本用量
        /// </summary>
        public string jiBenYongLiang { get; set; }
        /// <summary>
        /// 计量单位
        /// </summary>
        public string jiLiangDanWei { get; set; }
        /// <summary>
        /// 用法
        /// </summary>
        public string yongFa { get; set; }
        /// <summary>
        /// 频次
        /// </summary>
        public string pinCi { get; set; }
        /// <summary>
        /// 付数
        /// </summary>
        public string fuShu { get; set; }
        /// <summary>
        /// 项目等级
        /// </summary>
        public string xiangMuDengJi { get; set; }
        /// <summary>
        /// 执行科室
        /// </summary>
        public string zhiXingKeShi { get; set; }
    }
}



