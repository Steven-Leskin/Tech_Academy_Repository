using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClockII
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();


        public Form1()
        {
            InitializeComponent();
  

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_tick);
            t.Start();

        }

        private void t_tick(object sender, EventArgs e)
        {
            timeLBL.Text = DateTime.Now.ToString("HH:mm:ss");
        }


    }
}
