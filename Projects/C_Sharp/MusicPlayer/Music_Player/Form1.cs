using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            Player.URL = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
       {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();           
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}
