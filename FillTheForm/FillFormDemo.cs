﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
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
        //[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //public static extern bool InternetSetCookie(string lpszUrlName, string lbszCookieName, string lpszCookieData);
        //private void SetCookie(string cookie,string url)
        //{
        //    foreach (string c in cookie.Split(';'))
        //    {
        //        string[] item = c.Split('=');
        //        if (item.Length == 2)
        //        {
        //            InternetSetCookie(url, null, new Cookie(HttpUtility.UrlEncode(item[0]).Replace("+", ""), HttpUtility.UrlEncode(item[1]), "; expires = Session GMT", "/").ToString());
        //        }
        //    }
        //    this.wb.Navigate(url);
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            SetWebBrowserIE8Mode();
            this.wb.Navigate(LoginUrl);
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine(e.Url);
            //登陆界面处理　
            if(this.wb.Document.Url.ToString().IndexOf("login.do")>-1)
            {
                AutoLogin(this.wb.Document);
            }
            //首页界面处理　
            if (this.wb.Document.Url.ToString().IndexOf("index.jsp") > -1)
            {
                AutoIndex(this.wb.Document);
            }
            //门诊医生开方界面
            if (this.wb.Document.Url.ToString().IndexOf("feeprice.jsp") > -1)
            {
                AutoFeePrice(this.wb.Document);
            }

            

        }
        /// <summary>
        /// 首页界面处理
        /// </summary>
        /// <param name="doc"></param>
        private void AutoIndex(HtmlDocument doc)
        {
            var script = @" function goToUrl(url){
                                setTimeout(function(){
                                     document.location.href = url;
                                 },2000);
 
                               }

";
            InstallScript(script);
            var r = this.wb.Document.InvokeScript("goToUrl", new object[] { FeePriceUrl });
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
                                    var feePriceList = feeChargePriceJson.feePriceList;
                                    var rowSet=dsPatientFeeItemlist.getRowSet();
                                    rowSet.deleteAllRows();
                                    //unieap.byId('patientFeeItemlistGrid').getBinding().setDataStore(feePriceList); 
                                   //添加表格
                                    for (var i= 0;i< feePriceList.length ; i++){
                                       //alert(feePriceList[i].pinMing);
                                       rowSet.addRow(feePriceList[i]);
                                      
                                    }
                                    //遍历赋值
                                    for (var i= 0;i<feePriceList.length ; i++){
                                         var feePrice = feePriceList[i];
                                         var table = dojo.query('#patientFeeItemlistGrid .u-grid-row-table').at(i+1);
                                         table.query('.u-grid-text2').at(0)[0].innerText=feePrice.pinMing;
                                         table.query('.u-grid-text2').at(1)[0].innerText=feePrice.guiGe;
                                         table.query('.u-grid-text2').at(2)[0].innerText=feePrice.piCi;
                                         table.query('.u-grid-text2').at(3)[0].innerText=feePrice.lingShouJia;
                                         table.query('.u-grid-text2').at(4)[0].innerText=feePrice.baoZhuangDanWei;
                                         table.query('.u-grid-text2').at(5)[0].innerText=feePrice.shuLiang;
                                         table.query('.u-grid-text2').at(6)[0].innerText=feePrice.jiJiaDanWei;
                                         table.query('.u-grid-text2').at(7)[0].innerText=feePrice.jinE;
                                         table.query('.u-grid-text2').at(8)[0].innerText=feePrice.jiBenYongLiang ;
                                         table.query('.u-grid-text2').at(9)[0].innerText=feePrice.jiLiangDanWei;
                                         table.query('.u-grid-text2').at(10)[0].innerText=feePrice.yongFa;
                                         table.query('.u-grid-text2').at(11)[0].innerText=feePrice.pinCi;
                                         table.query('.u-grid-text2').at(12)[0].innerText=feePrice.fuShu;
                                         table.query('.u-grid-text2').at(13)[0].innerText=feePrice.xiangMuDengJi;
                                         table.query('.u-grid-text2').at(14)[0].innerText=feePrice.zhiXingKeShi;

                                    }
　　　　　　　　　　　　　　　　　　//3预约结算
                                    //btnsave.click();
    },500);
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
            feePriceInfo.medicalTypeCmb = "11";//普通门诊11;
            feePriceInfo.diagnoseCmb = "感冒";
            feePriceInfo.deptCmb = "006";//外科门诊006
            feePriceInfo.docCmb = "008";//门诊医师008
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

            feePriceInfo.feePriceList = FeePriceList;

            string feeChargePriceJson = Newtonsoft.Json.JsonConvert.SerializeObject(feePriceInfo);
            var r = this.wb.Document.InvokeScript("zyAutoFeePrice", new object[] { feeChargePriceJson });
        }
        /// <summary>
        /// 自动登录
        /// </summary>
        /// <param name="doc"></param>
        private void AutoLogin(HtmlDocument doc)
        {
            var script = @" function zyLogin(name,pass,FeePriceUrl){
                                setTimeout(function(){
                                     window.close=null;
                                     document.getElementsByName('j_username')[0].value=name;
                                     document.getElementsByName('j_password')[0].value=pass;
                                     document.getElementsByName('loginButton')[0].click();
                                    
                                 },100);
 
                               }
              //这此函数替换定义，防止跳出界面，此处很重要
              submit_form = function(){
        　　　　　　　　　　document.all('logonform').submit();
        　　　}
";
            InstallScript(script);
            var r = this.wb.Document.InvokeScript("zyLogin", new object[] { userName, password,FeePriceUrl });
            

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.wb.Navigate(FeePriceUrl);
            this.timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.wb.Navigate(FeePriceUrl);
        }
        private void SetAllWebItemSelf(HtmlElementCollection items)
        {
            try
            {
                foreach (HtmlElement item in items)
                {
                    if (item.TagName.ToLower().Equals("iframe", StringComparison.OrdinalIgnoreCase) == false)
                    {
                        try
                        {
                            item.SetAttribute("target", "_self");
                        }
                        catch
                        { }
                    }
                    else
                    {
                        try
                        {
                            HtmlElementCollection fitems = item.Document.Window.Frames[item.Name].Document.All;

                            this.SetAllWebItemSelf(fitems);
                        }
                        catch
                        { }
                    }
                }
            }
            catch
            {
            }
        }
        private void wb_NewWindow(object sender, CancelEventArgs e)
        {
            //e.Cancel = false;
            //WebBrowser wb = (WebBrowser)sender;//把sender给拿下，是一个WebBrowser对象
            //wb.Navigate(FeePriceUrl);
            

        }

        private void wb_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            string url = e.Url.ToString();
            System.Diagnostics.Trace.WriteLine(url);
            e.Cancel = false;
        }

        private void FillFormDemo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Width = Screen.PrimaryScreen.Bounds.Width - 50;
            this.Height = Screen.PrimaryScreen.Bounds.Height - 50;
        }
        private bool SetWebBrowserIE8Mode()
        {
            RegistryKey key = Registry.LocalMachine;
            RegistryKey software = key.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
            software.SetValue(Process.GetCurrentProcess().ProcessName, "8000", RegistryValueKind.DWord);
            software.Close();
            return true;
        }
    }
}
