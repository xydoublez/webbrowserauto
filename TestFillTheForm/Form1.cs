using FillTheForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestFillTheForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillFormDemo ffd = new FillFormDemo();
            ffd.Show();
            //webBrowser1.Navigate("http://oa.msunsoft.com:8088/quexian/web/login.aspx");
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.webBrowser1.Document.GetElementById("username").InnerText = "测试";
            this.webBrowser1.Document.GetElementById("password").SetAttribute("value", "password");
        }
    }
}
