using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLBL.Text = DateTime.Now.ToString("h:m:s tt");
            dateLBL.Text = DateTime.Now.ToString("MMMM d, yyyy");
            dayLBL.Text = DateTime.Now.ToString("dddd");
         }

        private void dayLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
