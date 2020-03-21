using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DotPOS
{
    public partial class WebBrowserPrint : Form
    {
        public WebBrowserPrint( string htmlCode)
        {
            InitializeComponent();
            webBrowser1.DocumentText = htmlCode;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }
    }
}
