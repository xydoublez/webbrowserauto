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
        public dsFeeDetail patientFeeItemlist { get; set; }
    }

    
}



