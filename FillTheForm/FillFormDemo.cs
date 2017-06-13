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
        public FillFormDemo()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.wb.Navigate("http://oa.msunsoft.com:8088/quexian/web/login.aspx");
            count = 1;
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //判定页面，并处理自动化
            if(this.wb.Document.Url.LocalPath == "/quexian/web/login.aspx")
            {
                AutoLogin(this.wb.Document);
            }
            //判定基他页面，并处理自动化
           //添加其他业务逻辑


        }
        /// <summary>
        /// 自动登录
        /// </summary>
        /// <param name="doc"></param>
        private void AutoLogin(HtmlDocument doc)
        {
            var script = @" function myFunc(name,pass){
                                setTimeout(function(){
       	                         username.value = name;
                                 password.value = pass;
                                 //alert(name);
                                 $('#password').parent().parent().next().find('a')[0].click();
                                 // alert($('#password').val());
                                 // loginCheck();
                                 },100);
                               }
";
            InstallScript(script);
            var r = this.wb.Document.InvokeScript("myFunc", new object[] { this.v1.Text, this.v2.Text });
        }
        static int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (count == 1) {
            //    //this.wb.Document.GetElementById("username").SetAttribute("value", this.v1.Text);
            //    this.wb.Document.GetElementById("password").SetAttribute("value", this.v2.Text);
            //    //点击登录按扭
            //    //this.wb.Document.GetElementById("password").Parent.Parent.NextSibling.Children[0].Children[0].InvokeMember("click");
                
            //    count += 1;
            //}
        
            //if (count > 3)
            //{
            //    this.timer1.Stop();
            //}
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
