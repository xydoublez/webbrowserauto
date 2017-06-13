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

            }
           


        }
        //自动处理门诊医生开方界面
        private void AutoFeePrice(HtmlDocument doc)
        {
            //unieap.byId("queryCodeTxt").setValue("test")
            var script = @" function zyAutoFeePrice(jsonInfo){
　　　　　　　　　　　　　　　　var feeChargePriceJson = eval('('+jsonInfo+')');
                                setTimeout(function(){
                                   unieap.byId('queryCodeTxt').setValue(feeChargePriceJson.queryCodeTxt);
                                   unieap.byId('queryCodeTxt').setValue(feeChargePriceJson.queryCodeTxt);
                                 },100);
                               }
";
            InstallScript(script);

            ////正式查询数据库给feePriceInfo
            //FeePriceInfo feePriceInfo = new FeePriceInfo();
            ////身份证号
            //feePriceInfo.queryCodeTxt = "37148290000000";
            ////其他字段．．．．
            //string feeChargePriceJson = Newtonsoft.Json.JsonConvert.SerializeObject(feePriceInfo);
            //测试用
            string feeChargePriceJson = System.IO.File.ReadAllText("data.json");
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
