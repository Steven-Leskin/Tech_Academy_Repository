using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchBX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(searchBX.Text);
            }

        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardBTN_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void goBTN_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(searchBX.Text);
        }

         private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "Custom Web Brower- " + webBrowser1.Document.Title;
        }
    }
}
