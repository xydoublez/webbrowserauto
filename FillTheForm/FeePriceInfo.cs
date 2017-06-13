using System;
using System.Collections.Generic;
using System.Text;

namespace FillTheForm
{
    public class FeePriceInfo
    {
        public string queryCodeTxt { get; set; }
        public string patientNameTxt { get; set; }
        public string sexcmb { get; set; }
        public string ageTxt { get; set; }
        public string freeCost { get; set; }
        public string cmbPayKind { get; set; }
        public string mcardNoTxt { get; set; }
        public string medicalTypeCmb { get; set; }
        public string diagnoseCmb { get; set; }
        public string deptCmb { get; set; }
        public string docCmb { get; set; }
        public Feeprice[] FeePrices { get; set; }
    }

    public class Feeprice
    {
        public string pinMing { get; set; }
        public string guiGe { get; set; }
        public string piCi { get; set; }
        public string lingShouJian { get; set; }
        public string baoZhuangDanWei { get; set; }
        public string shuLiang { get; set; }
        public string jiJiaDanWei { get; set; }
        public string jinE { get; set; }
        public string jiBenYongLiang { get; set; }
        public string jiLiangDanWei { get; set; }
        public string yongFa { get; set; }
        public string pinCi { get; set; }
        public string fuShu { get; set; }
        public string xiangMuDengJi { get; set; }
        public string zhiXingKeShi { get; set; }
    }
}



