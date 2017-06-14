using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FillTheForm
{
    public partial class FillFormDemo : Form
    {
        string userName = System.Configuration.ConfigurationManager.AppSettings["userName"];
        string password = System.Configuration.ConfigurationManager.AppSettings["password"];
        string LoginUrl = System.Configuration.ConfigurationManager.AppSettings["LoginUrl"];
        string FeePriceUrl = System.Configuration.ConfigurationManager.AppSettings["FeePriceUrl"];
        public FillFormDemo()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.wb.Navigate(LoginUrl);
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //登陆界面处理　
            if(this.wb.Document.Url.LocalPath.IndexOf("login.do")>-1)
            {
                AutoLogin(this.wb.Document);
            }
            //门诊医生开方界面
            if (this.wb.Document.Url.LocalPath.IndexOf("feeprice.jsp") > -1)
            {
                AutoFeePrice(this.wb.Document);
            }
           


        }
        //自动处理门诊医生开方界面
        private void AutoFeePrice(HtmlDocument doc)
        {
            //unieap.byId("queryCodeTxt").setValue("test")
            var script = @" function zyAutoFeePrice(jsonInfo){
　　　　　　　　　　　　　　　　var feeChargePriceJson = eval('('+jsonInfo+')');
                                setTimeout(function(){
                                   //1基本信息赋值
                                   unieap.byId('queryCodeTxt').setValue(feeChargePriceJson.queryCodeTxt);
                                   unieap.byId('patientNameTxt').setValue(feeChargePriceJson.patientNameTxt);
                                   unieap.byId('sexcmb').setValue(feeChargePriceJson.sexcmb);
                                   unieap.byId('ageTxt').setValue(feeChargePriceJson.ageTxt);
                                   unieap.byId('freeCost').setValue(feeChargePriceJson.freeCost);
                                   unieap.byId('cmbPayKind').setValue(feeChargePriceJson.cmbPayKind);
                                   unieap.byId('mcardNoTxt').setValue(feeChargePriceJson.mcardNoTxt);
                                   unieap.byId('medicalTypeCmb').setValue(feeChargePriceJson.medicalTypeCmb);
                                   unieap.byId('diagnoseCmb').setValue(feeChargePriceJson.diagnoseCmb);
                                   unieap.byId('deptCmb').setValue(feeChargePriceJson.deptCmb);
                                   unieap.byId('docCmb').setValue(feeChargePriceJson.docCmb);
                                  //2费用明细赋值
                                  var feePrices = feeChargePriceJson.feePrices;
                                  for(int i=0;i<feePrices.length;i++){
                                      var fee = feePrices[i];
                                      //fee.pinMing;
                                  }
                                 },100);
                               }
";
            InstallScript(script);


            //测试用
            //string feeChargePriceJson = System.IO.File.ReadAllText("data.json");

            ////正式查询数据库给feePriceInfo
            FeePriceInfo feePriceInfo = new FeePriceInfo();
            //基本信息
            feePriceInfo.queryCodeTxt = "372826193205043124";
            feePriceInfo.patientNameTxt = "宋立玉";
            feePriceInfo.sexcmb = "女";
            feePriceInfo.ageTxt = "85";
            feePriceInfo.freeCost = "0.00";
            feePriceInfo.cmbPayKind = "医保";
            feePriceInfo.mcardNoTxt = "371102464910";
            feePriceInfo.medicalTypeCmb = "普通门诊";
            feePriceInfo.diagnoseCmb = "感冒";
            feePriceInfo.deptCmb = "外科门诊";
            feePriceInfo.docCmb = "门诊医师";
            //费用明细
            List<FeePrice> FeePriceList = new List<FeePrice>();
            //真实取数据库for添加列表
            FeePrice feePrice = new FeePrice();
            feePrice.pinMing = "无痛皮试";
            feePrice.guiGe = "";
            feePrice.piCi = "";
            feePrice.lingShouJia = "8";
            feePrice.baoZhuangDanWei = "次";
            feePrice.shuLiang = "1";
            feePrice.jiJiaDanWei = "次";
            feePrice.jinE = "8.00";
            feePrice.jiBenYongLiang = "";
            feePrice.jiLiangDanWei = "";
            feePrice.yongFa = "";
            feePrice.pinCi = "";
            feePrice.fuShu = "";
            feePrice.xiangMuDengJi = "甲类";
            feePrice.zhiXingKeShi = "外科门诊";
            FeePriceList.Add(feePrice);

            FeePrice feePrice1 = new FeePrice();
            feePrice1.pinMing = "破伤风抗毒素注射液";
            feePrice1.guiGe = "1500u*10支";
            feePrice1.piCi = "000000";
            feePrice1.lingShouJia = "30";
            feePrice1.baoZhuangDanWei = "盒";
            feePrice1.shuLiang = "1";
            feePrice1.jiJiaDanWei = "支";
            feePrice1.jinE = "30.00";
            feePrice1.jiBenYongLiang = "";
            feePrice1.jiLiangDanWei = "u";
            feePrice1.yongFa = "";
            feePrice1.pinCi = "";
            feePrice1.fuShu = "";
            feePrice1.xiangMuDengJi = "甲类";
            feePrice1.zhiXingKeShi = "外科门诊";
            FeePriceList.Add(feePrice1);

            feePriceInfo.FeePriceList = FeePriceList;

            string feeChargePriceJson = Newtonsoft.Json.JsonConvert.SerializeObject(feePriceInfo);
            var r = this.wb.Document.InvokeScript("zyAutoFeePrice", new object[] { feeChargePriceJson });
        }
        /// <summary>
        /// 自动登录
        /// </summary>
        /// <param name="doc"></param>
        private void AutoLogin(HtmlDocument doc)
        {
            var script = @" function zyLogin(name,pass){
                                setTimeout(function(){
                                     document.getElementsByName('j_username')[0].value=name;
                                     document.getElementsByName('j_password')[0].value=pass;
                                     document.getElementsByName('loginButton')[0].click();
                                 },100);
                               }
";
            InstallScript(script);
            var r = this.wb.Document.InvokeScript("zyLogin", new object[] { userName, password });
            //登陆成功后打开门诊医生开方界面
            this.wb.Navigate(FeePriceUrl);
        }
        //添加脚本
        private void InstallScript(string code)
        {

            if (null == this.wb.Document || ( string.IsNullOrEmpty(code)))
                return;
            HtmlElement scriptElement = null;
            if (null == scriptElement)
            {
                scriptElement = this.wb.Document.CreateElement("script");

                HtmlElementCollection elements = this.wb.Document.GetElementsByTagName("head");

                if (elements.Count > 0)
                    this.wb.Document.GetElementsByTagName("head")[0].AppendChild(scriptElement);

            }

            //scriptElement.SetAttribute("id", id);
            scriptElement.SetAttribute("type", "text/javascript");
            scriptElement.SetAttribute("language", "javascript");
            scriptElement.SetAttribute("text", code);
          

        }
    }
}
