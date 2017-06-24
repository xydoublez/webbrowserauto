using FillTheForm.disease;
using FillTheForm.drug;
using FillTheForm.undrug;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace FillTheForm
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
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
            //SetWebBrowserIE8Mode();
            this.wb.Navigate(LoginUrl);
            //js调用C#用
            this.wb.ObjectForScripting = this;
            this.button1.Enabled = false;
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("DocumentCompleted：" + e.Url);
            //登陆界面处理　
            if (e.Url.ToString().IndexOf("login.do") > -1)
            {
                AutoLogin(this.wb.Document);
            }
            //验证页处理　
            if (e.Url.ToString().IndexOf("j_unieap_security_check.do") > -1)
            {
                AutoCheckDo(this.wb.Document);
            }
            //首页界面处理　
            if (e.Url.ToString().IndexOf("index.jsp") > -1)
            {
                btnGetData.Enabled = true;
                AutoIndex(this.wb.Document);
            }
            //门诊医生开方界面
            if (e.Url.ToString().IndexOf(FeePriceUrl) > -1)
            {
                AutoFeePrice(this.wb.Document);
            }
            ////药品目录管理获取数据
            //if (e.Url.ToString().IndexOf("si_druginfo.jsp") > -1)
            //{
            //    AutoGetDrugInfo(this.wb.Document);
            //}



        }
        private HtmlDocument frameDrugInfo;
        ///// <summary>
        ///// 获取药品目录数据，导入sql脚本到drug.txt
        ///// </summary>
        ///// <param name="doc"></param>
        //private void AutoGetDrugInfo(HtmlDocument doc)
        //{
        //    var script = File.ReadAllText("script\\druginfo.js");
        //    frameDrugInfo = this.wb.Document.Window.Frames["mianFrame"].Document.Window.Frames["middern"].Frames["frmMid"].Frames["page_1280910172796"].Document;
        //    InstallScript(script, frameDrugInfo);

        //}
        public void OnWriteDrugInfoSucess()
        {
            MessageBox.Show("导出药品成功");
        }
        public void Sleep(int millseconds)
        {
            System.Threading.Thread.Sleep(millseconds);
        }
        /// <summary>
        /// 写入药品目录数据
        /// </summary>
        /// <param name="result"></param>
        public void WriteDrugInfoFile(string result)
        {
            if (result == "") return;
            string[] list = result.Split('$');
            StringBuilder sb = new StringBuilder();
            foreach (var record in list)
            {
                if (record.Length > 5)
                {
                    sb.Append("insert into druginfo values(");
                    string[] items = record.Split(',');
                    foreach (string item in items)
                    {
                        sb.Append("'").Append(item).Append("',");
                    }
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append(");\r\n");
                }
            }
            System.Diagnostics.Trace.WriteLine(sb.ToString());
            File.AppendAllText("result\\druginfo.txt", sb.ToString());
        }
        /// <summary>
        /// 验证页处理　登陆失败用，根据测试，进此方法，则登陆失败
        /// </summary>
        /// <param name="doc"></param>
        private void AutoCheckDo(HtmlDocument doc)
        {
            AfterLoginError();

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
                            window.alert=function(){};

";
            InstallScript(script);
            //var r = this.wb.Document.InvokeScript("goToUrl", new object[] { FeePriceUrl });
        }
        //自动处理门诊医生开方界面
        HtmlDocument frameFeePrice = null;
        private void AutoFeePrice(HtmlDocument doc)
        {
            var script = @" function zyAutoFeePrice(jsonInfo){
　　　　　　　　　　　　　　　　var feeChargePriceJson = eval('('+jsonInfo+')');
                                //alert(document.location.href);
                                setTimeout(function(){
                                   //1基本信息赋值
                                    unieap.byId('queryCodeTxt').setValue(feeChargePriceJson.queryCodeTxt);
                                    //回车方法加载基本信息
                                     changeCodeTxt();
                                    //unieap.byId('patientNameTxt').setValue(feeChargePriceJson.patientNameTxt);
                                    //unieap.byId('sexcmb').setValue(feeChargePriceJson.sexcmb);
                                    //unieap.byId('ageTxt').setValue(feeChargePriceJson.ageTxt);
                                    //unieap.byId('freeCost').setValue(feeChargePriceJson.freeCost);
                                    //unieap.byId('cmbPayKind').setValue(feeChargePriceJson.cmbPayKind);
                                    //unieap.byId('mcardNoTxt').setValue(feeChargePriceJson.mcardNoTxt);
                                    //unieap.byId('medicalTypeCmb').setValue(feeChargePriceJson.medicalTypeCmb);
                                    unieap.byId('diagnoseCmb').setValue(feeChargePriceJson.diagnoseCmb);
                                    unieap.byId('deptCmb').setValue(feeChargePriceJson.deptCmb);
                                    unieap.byId('docCmb').setValue(feeChargePriceJson.docCmb);
                                  
                                     //2费用明细赋值
                                    var rowSet= dsPatientFeeItemlist.getRowSet();
                                    rowSet.deleteAllRows();
                                    var patientFeeItemlist =feeChargePriceJson.patientFeeItemlist;
                                    dsPatientFeeItemlist.rowSet.primary  = feeChargePriceJson.patientFeeItemlist.rowSet.primary;
                                    dsPatientFeeItemlist.addMetaData('meta',patientFeeItemlist.metaData);
                                    var rowCount=dsPatientFeeItemlist.getRowSet().getRowCount()
                                    //alert(rowCount);
                                    var repcipeId=dsPatientFeeItemlist.getRowSet().getRow(0).getItemValue('OPB_FEEDETAIL_RECIPEID');
                                    for (var i = 0; i < rowCount; i++)
                                    {
                                            var feeItemId = dsPatientFeeItemlist.getRowSet().getRow(i).getItemValue('OPB_FEEDETAIL_FEEITEMID');
                                            dsPatientFeeItemlist.getRowSet().getRow(i).setItemValue('OPB_FEEDETAIL_FEEITEMID', feeItemId + i);
                                            dsPatientFeeItemlist.getRowSet().getRow(i).setItemValue('OPB_FEEDETAIL_RECIPEID', repcipeId);
                                            dsPatientFeeItemlist.getRowSet().getRow(i).setRowStatus(1);
                                    }
                                    unieap.byId('patientFeeItemlistGrid').getBinding().setDataStore(dsPatientFeeItemlist);
                                    showGroupByInvoice();
                                  
                                   
                                },1000);
                              
                             }
　　　　　　　　　　　　　　function zyProcNext(idcard){
                                //调用C#的中方法获取信息，处理下一个
                                setTimeout(function(){
                                            var json = window.external.getFeePriceInfoJson(idcard);
                                            zyAutoFeePrice(json);
                                },1000);
                            }

";


            //获取门诊医生开方界面frame对象，注意page_1399430526848此值查看网页获得的，其他页面类推
            frameFeePrice = this.wb.Document.Window.Frames["mianFrame"].Document.Window.Frames["middern"].Frames["frmMid"].Frames["page_1399430526848"].Document;
            InstallScript(script, frameFeePrice);
            var feeChargePriceJson = getFeePriceInfoJson("372826193205043124");
            var r = frameFeePrice.InvokeScript("zyAutoFeePrice", new object[] { feeChargePriceJson });
        }
        public string getFeePriceInfoJson(string idcard)
        {
            //测试用
            //string feeChargePriceJson = System.IO.File.ReadAllText("data.json");

            ////正式查询数据库给feePriceInfo
            FeePriceInfo feePriceInfo = new FeePriceInfo();
            //基本信息
            feePriceInfo.queryCodeTxt = idcard;
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
            //根据模板生成费用明细对象
            dsFeeDetail patientFeeItemlist = Newtonsoft.Json.JsonConvert.DeserializeObject<dsFeeDetail>(System.IO.File.ReadAllText("data.json"));

            ////start 正式时从数据库取费用明细 for添加
            ////明细重新赋值
            //patientFeeItemlist.rowSet.primary = new List<Primary>();
            ////单条明细 for循环添加
            //Primary primary = new Primary();
            //primary.BATCHNO = "";
            ////
            //patientFeeItemlist.rowSet.primary.Add(primary);
            ////end 正式时从数据库取费用明细 for添加

            feePriceInfo.patientFeeItemlist = patientFeeItemlist;
            return Newtonsoft.Json.JsonConvert.SerializeObject(feePriceInfo);
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
            var r = this.wb.Document.InvokeScript("zyLogin", new object[] { this.txtUserName.Text.Trim(), this.txtPassWord.Text.Trim(), FeePriceUrl });


        }
        //添加脚本
        private void InstallScript(string code, HtmlDocument frameDoc = null)
        {

            if (null == this.wb.Document || (string.IsNullOrEmpty(code)))
                return;

            HtmlElement scriptElement = null;
            HtmlElementCollection elements = null;
            if (null == scriptElement)
            {
                if (frameDoc == null)
                {
                    scriptElement = this.wb.Document.CreateElement("script");
                    elements = this.wb.Document.GetElementsByTagName("head");

                }
                else
                {
                    scriptElement = frameDoc.CreateElement("script");
                    elements = frameDoc.GetElementsByTagName("head");

                }
                if (elements.Count > 0)
                    elements[0].AppendChild(scriptElement);




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
            //System.Diagnostics.Trace.WriteLine(url);

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

        private void wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //禁用alert
            //InstallScript("window.alert = function () { }");
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.button1.Enabled == false)
            {
                var r = frameFeePrice.InvokeScript("zyProcNext", new object[] { "372826196509271525" });
            }
        }
        /// <summary>
        /// 判定是否登陆失败并处理　
        /// </summary>
        public void AfterLoginError()
        {

            MessageBox.Show("用户名或密码不正确！请重新输入用户名与密码！");
            this.txtUserName.Focus();
            this.button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            GetDrug();
            GetUnDrug();
            GetDisease();
            sw.Stop();
            MessageBox.Show("耗时：" + sw.ElapsedMilliseconds+"毫秒");

        }
        #region 获取药品目录数据
        /// <summary>
        /// 获取药品目录
        /// </summary>
        private void GetDrug()
        {
            File.Delete("result//药品目录数据.txt");
            //var r = frameDrugInfo.InvokeScript("zyGetDrugData");

            List<string> areas = new List<string> { "371100", "371101", "371102", "371103", "371104", "371121", "371122", "371151" };
            foreach (var item in areas)
            {
                int pageNumber = 1;
                getDrugInfo(ref pageNumber, 300, 0, item);
            }

        }
        private void getDrugInfo(ref int pageNumber, int pageSize, int recordCount, string areaCode)
        {
            HttpHelper http = new HttpHelper();

            string data = "{ header:{ \"code\":0,\"message\":{ \"title\":\"\",\"detail\":\"\"}" +
            " },body: { dataStores: { \"druginfo\":{ rowSet: { \"primary\":[],\"filter\":[],\"delete\":[] " +
            " },name:\"druginfo\",pageNumber: " + pageNumber + ", pageSize: " + pageSize + ",recordCount: " + recordCount + ",rowSetName:\"ncm.si.SI_DRUGINFO\"," +
            " conditionValues:[[\"03\",12],[\"" + areaCode + "\",12]],parameters:[[\"03\",12],[\"" + areaCode + "\",12]]," +
            " condition:\" PAYKINDCODE = ?  and AREACODE = ? \"}," +
            "\"invosubject\":{rowSet:{\"primary\":[],\"filter\":[],\"delete\":[]},name:\"invosubject\"," +
            "pageNumber:1,pageSize:2147483647,recordCount:0,rowSetName:\"ncm.si.SI_INVOSUBJECT\"," +
            "conditionValues:[[\"03\",12],[\"" + areaCode + "\",12]],parameters:[[\"03\",12],[\"" + areaCode + "\",12]],"
            + "condition:\" PAYKINDCODE = ?  and AREACODE = ? \"}},parameters:{}}}";
            HttpItem item = new HttpItem();
            item.URL = "http://10.66.1.6:8088/EAPDomain/SiBusinessDelegateAction.do?method=submit&BUSINESS_REQUEST_ID=REQ-ZA-M-001-00&MENUID=1280910172796&BUSINESS_ID=";
            item.Method = "post";
            item.Postdata = data;
            item.Encoding = Encoding.GetEncoding("UTF-8");
            item.Cookie = this.wb.Document.Cookie;
            item.ContentType = "multipart/form-data";
            item.Header.Add("x-requested-with", "XMLHttpRequest");
            item.Header.Add("ajaxrequest", "true");
            item.Header.Add("Pragma", "no-cache");
            item.Referer = "http://10.66.1.6:8088/EAPDomain/si/pages/ncm/druginfo/si_druginfo.jsp?menuid=1280910172796";
            var html = http.GetHtml(item);
            System.Diagnostics.Trace.WriteLine(html.Html);
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<DrugInfoResult>(html.Html);
            var primary = result.body.dataStores.druginfo.rowSet.primary;
            WriteDrugInfoFile2(primary);
            recordCount = result.body.dataStores.druginfo.recordCount;
            int pageCount = recordCount / pageSize;
            if (recordCount % pageSize != 0)
            {
                pageCount += 1;
            }
            pageNumber = result.body.dataStores.druginfo.pageNumber + 1;

            while (pageNumber <= pageCount)
            {
                System.Diagnostics.Trace.WriteLine("number:" + pageNumber + " count:" + recordCount);
                getDrugInfo(ref pageNumber, pageSize, recordCount, areaCode);

            }

        }
        /// <summary>
        /// 写druginfo
        /// </summary>
        private void WriteDrugInfoFile2(drug.Primary[] primary)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var record in primary)
            {

                sb.Append("insert into druginfo values(");
                sb.Append("'").Append(record.SI_DRUGINFO_AREACODE).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_DRUGCODE).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_REGULARNAME).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_SPECS).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_DOSEMODELCODE).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_FEEGRADE).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_TOPSALEPRICE).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_INVOCODE).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_PAYRATE).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_PACKUNIT).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_APPROVENO).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_LIMITDAYS).Append("',");
                sb.Append("'").Append(GetTime(record.SI_DRUGINFO_STARTDATE).ToString("yyyy-MM-dd")).Append("',");
                sb.Append("'").Append(GetTime(record.SI_DRUGINFO_ENDDATE).ToString("yyyy-MM-dd")).Append("',");
                sb.Append("'").Append(record.SI_DRUGINFO_REMARK).Append("'");
                sb.Append(");\r\n");
            }
            System.Diagnostics.Trace.WriteLine(sb.ToString());
            File.AppendAllText("result\\药品目录数据.txt", sb.ToString());
        }
        #endregion 获取药品目录数据
        #region 获取诊疗目录数据
        /// <summary>
        /// 获取诊疗目录数据
        /// </summary>
        private void GetUnDrug()
        {
            File.Delete("result//疹疗目录数据.txt");
            //var r = frameDrugInfo.InvokeScript("zyGetDrugData");

            List<string> areas = new List<string> { "371100", "371101", "371102", "371103", "371104", "371121", "371122", "371151" };
            foreach (var item in areas)
            {
                int pageNumber = 1;
                GetUnDrugInfo(ref pageNumber, 300, 0, item);
            }

        }
        private void GetUnDrugInfo(ref int pageNumber, int pageSize, int recordCount, string areaCode)
        {
            HttpHelper http = new HttpHelper();

            string data = "{ header:{ \"code\":0,\"message\":{ \"title\":\"\",\"detail\":\"\"}" +
            " },body: { dataStores: { \"undruginfo\":{ rowSet: { \"primary\":[],\"filter\":[],\"delete\":[] " +
            " },name:\"undruginfo\",pageNumber: " + pageNumber + ", pageSize: " + pageSize + ",recordCount: " + recordCount + ",rowSetName:\"ncm.si.SI_UNDRUGINFO\"," +
            " conditionValues:[[\"03\",12],[\"" + areaCode + "\",12]],parameters:[[\"03\",12],[\"" + areaCode + "\",12]]," +
            " condition:\" PAYKINDCODE = ?  and AREACODE = ? \"}," +
            "\"invosubject\":{rowSet:{\"primary\":[],\"filter\":[],\"delete\":[]},name:\"invosubject\"," +
            "pageNumber:1,pageSize:2147483647,recordCount:0,rowSetName:\"ncm.si.SI_INVOSUBJECT\"," +
            "conditionValues:[[\"03\",12],[\"" + areaCode + "\",12]],parameters:[[\"03\",12],[\"" + areaCode + "\",12]],"
            + "condition:\" PAYKINDCODE = ?  and AREACODE = ? \"}},parameters:{}}}";
            HttpItem item = new HttpItem();
            item.URL = "http://10.66.1.6:8088/EAPDomain/SiBusinessDelegateAction.do?method=submit&BUSINESS_REQUEST_ID=REQ-ZA-M-001-00&MENUID=1280910172796&BUSINESS_ID=";
            item.Method = "post";
            item.Postdata = data;
            item.Encoding = Encoding.GetEncoding("UTF-8");
            item.Cookie = this.wb.Document.Cookie;
            item.ContentType = "multipart/form-data";
            item.Header.Add("x-requested-with", "XMLHttpRequest");
            item.Header.Add("ajaxrequest", "true");
            item.Header.Add("Pragma", "no-cache");
            item.Referer = "http://10.66.1.6:8088/EAPDomain/si/pages/ncm/druginfo/si_druginfo.jsp?menuid=1280910172796";
            var html = http.GetHtml(item);
            System.Diagnostics.Trace.WriteLine(html.Html);
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<UnDrugInfo>(html.Html);
            var primary = result.body.dataStores.undruginfo.rowSet.primary;
            WriteUnDrugInfo(primary);
            recordCount = result.body.dataStores.undruginfo.recordCount;
            int pageCount = recordCount / pageSize;
            if (recordCount % pageSize != 0)
            {
                pageCount += 1;
            }
            pageNumber = result.body.dataStores.undruginfo.pageNumber + 1;

            while (pageNumber <= pageCount)
            {
                System.Diagnostics.Trace.WriteLine("number:" + pageNumber + " count:" + recordCount);
                GetUnDrugInfo(ref pageNumber, pageSize, recordCount, areaCode);

            }

        }
        /// <summary>
        /// 写诊疗目录数据
        /// </summary>
        private void WriteUnDrugInfo(undrug.Primary[] primary)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var record in primary)
            {

                sb.Append("insert into undruginfo values(");
                sb.Append("'").Append(record.SI_UNDRUGINFO_AREACODE).Append("',");
                sb.Append("'").Append(record.SI_UNDRUGINFO_ITEMCODE).Append("',");
                sb.Append("'").Append(record.SI_UNDRUGINFO_ITEMNAME).Append("',");
                sb.Append("'").Append(record.SI_UNDRUGINFO_FEEGRADE).Append("',");
                sb.Append("'").Append(record.SI_UNDRUGINFO_TOPSALEPRICE).Append("',");
                sb.Append("'").Append(record.SI_UNDRUGINFO_INVOCODE).Append("',");
                sb.Append("'").Append(record.SI_UNDRUGINFO_PAYRATE).Append("',");
                sb.Append("'").Append(GetTime(record.SI_UNDRUGINFO_STARTDATE).ToString("yyyy-MM-dd")).Append("',");
                sb.Append("'").Append(GetTime(record.SI_UNDRUGINFO_ENDDATE).ToString("yyyy-MM-dd")).Append("',");
                sb.Append("'").Append(record.SI_UNDRUGINFO_HOSGRADE).Append("',");
                sb.Append("'").Append(record.SI_UNDRUGINFO_REMARK).Append("'");
                sb.Append(");\r\n");
            }
            System.Diagnostics.Trace.WriteLine(sb.ToString());
            File.AppendAllText("result\\疹疗目录数据.txt", sb.ToString());
        }
        #endregion 获取诊疗目录数据
        #region 获取病种目录数据
        /// <summary>
        /// 获取病种目录数据
        /// </summary>
        private void GetDisease()
        {
            File.Delete("result//病种目录数据.txt");
            //var r = frameDrugInfo.InvokeScript("zyGetDrugData");

            List<string> areas = new List<string> { "371100", "371101", "371102", "371103", "371104", "371121", "371122", "371151" };
            foreach (var item in areas)
            {
                int pageNumber = 1;
                GetDiseaseInfo(ref pageNumber, 300, 0, item);
            }

        }
        private void GetDiseaseInfo(ref int pageNumber, int pageSize, int recordCount, string areaCode)
        {
            HttpHelper http = new HttpHelper();

            string data = "{ header:{ \"code\":0,\"message\":{ \"title\":\"\",\"detail\":\"\"}" +
            " },body: { dataStores: { \"si_disease\":{ rowSet: { \"primary\":[],\"filter\":[],\"delete\":[] " +
            " },name:\"si_disease\",pageNumber: " + pageNumber + ", pageSize: " + pageSize + ",recordCount: " + recordCount + ",rowSetName:\"ncm.si.SI_DISEASE\"," +
            " conditionValues:[[\"03\",12],[\"" + areaCode + "\",12]],parameters:[[\"03\",12],[\"" + areaCode + "\",12]]," +
            " condition:\" PAYKINDCODE = ?  and AREACODE = ? \"}," +
            "\"invosubject\":{rowSet:{\"primary\":[],\"filter\":[],\"delete\":[]},name:\"invosubject\"," +
            "pageNumber:1,pageSize:2147483647,recordCount:0,rowSetName:\"ncm.si.SI_INVOSUBJECT\"," +
            "conditionValues:[[\"03\",12],[\"" + areaCode + "\",12]],parameters:[[\"03\",12],[\"" + areaCode + "\",12]],"
            + "condition:\" PAYKINDCODE = ?  and AREACODE = ? \"}},parameters:{}}}";
            HttpItem item = new HttpItem();
            item.URL = "http://10.66.1.6:8088/EAPDomain/SiBusinessDelegateAction.do?method=submit&BUSINESS_REQUEST_ID=REQ-ZA-M-001-00&MENUID=1280910172796&BUSINESS_ID=";
            item.Method = "post";
            item.Postdata = data;
            item.Encoding = Encoding.GetEncoding("UTF-8");
            item.Cookie = this.wb.Document.Cookie;
            item.ContentType = "multipart/form-data";
            item.Header.Add("x-requested-with", "XMLHttpRequest");
            item.Header.Add("ajaxrequest", "true");
            item.Header.Add("Pragma", "no-cache");
            item.Referer = "http://10.66.1.6:8088/EAPDomain/si/pages/ncm/druginfo/si_druginfo.jsp?menuid=1280910172796";
            var html = http.GetHtml(item);
            System.Diagnostics.Trace.WriteLine(html.Html);
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<diseaseInfo>(html.Html);
            var primary = result.body.dataStores.si_disease.rowSet.primary;
            WriteDiseaseInfo(primary);
            recordCount = result.body.dataStores.si_disease.recordCount;
            int pageCount = recordCount / pageSize;
            if (recordCount % pageSize != 0)
            {
                pageCount += 1;
            }
            pageNumber = result.body.dataStores.si_disease.pageNumber + 1;

            while (pageNumber <= pageCount)
            {
                System.Diagnostics.Trace.WriteLine("number:" + pageNumber + " count:" + recordCount);
                GetDiseaseInfo(ref pageNumber, pageSize, recordCount, areaCode);

            }

        }
        /// <summary>
        /// 写获病种目录数据
        /// </summary>
        private void WriteDiseaseInfo(disease.Primary[] primary)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var record in primary)
            {

                sb.Append("insert into disease values(");
                sb.Append("'").Append(record.AREACODE).Append("',");
                sb.Append("'").Append(record.ICDCODE).Append("',");
                sb.Append("'").Append(record.ICDNAME).Append("',");
                sb.Append("'").Append(record.DISEASETYPE).Append("',");
                sb.Append("'").Append(record.DISEASESORT).Append("',");
                sb.Append("'").Append(record.VALIDATEFLAG).Append("',");
                sb.Append("'").Append(record.REMARK).Append("'");
             
                sb.Append(");\r\n");
            }
            System.Diagnostics.Trace.WriteLine(sb.ToString());
            File.AppendAllText("result\\病种目录数据.txt", sb.ToString());
        }
        #endregion 获取病种目录数据


        private void button4_Click(object sender, EventArgs e)
        {
            //frameDrugInfo.GetElementById("unieap_grid_view_toolbar_0").Children[0].Children[0].Children[0].Children[0].GetElementsByTagName("td")[4].FirstChild.InvokeMember("click");

            //var r = frameDrugInfo.InvokeScript("zyWriteDrugData");

            //getDrugInfo();
        }
        public static DateTime GetTime(string timeStamp)
        {
            return TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)).AddMilliseconds(long.Parse(timeStamp));
        }
      
       
    }
}

